using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio;
using NAudio.Wave;
using System.Windows.Threading;
using System.IO;
using System.Reflection;
using System.Threading;
using System.ComponentModel;

namespace MP3Player
{
    public class Player
    {
        private IWavePlayer waveOutDevice;
        public volatile AudioFileReader audioFileReader;
        private bool muted;
        private bool paused;
        private bool isFirstPlayed;
        float previousValue;
        public Thread guiThread;
        BackgroundWorker bw;



        public Player()
        {
            waveOutDevice = new WaveOut();
            paused = false;
            muted = false;
            isFirstPlayed = false;

        }

        public AudioFileReader getAudioFileReader()
        {
            return audioFileReader;
        }
        public void play(Library library, MainWindow mainWindow)
        {

            mainWindow.stopButton.IsEnabled = true;
            mainWindow.playButton.IsEnabled = false;
            waveOutDevice.Volume = (float)(mainWindow.volume.Value / 10);

            try
            {

                audioFileReader = new AudioFileReader(library.getSongs()[library.getCurrentId()].getPath());
                waveOutDevice.Init(audioFileReader);
                waveOutDevice.Play();
                mainWindow.pauseButton.IsEnabled = true;
                mainWindow.pauseButton.Content = "Pause";
                mainWindow.progressBar.Maximum = audioFileReader.Length;
                mainWindow.muteButton.IsEnabled = true;
                isFirstPlayed = true;


               update(library, mainWindow);

            }
            catch (System.ArgumentOutOfRangeException err)
            {

            }


        }
        public void stop(MainWindow mainWindow)
        {

            mainWindow.stopButton.IsEnabled = false;
            mainWindow.playButton.IsEnabled = true;
            waveOutDevice.Stop();
            try
            {
                audioFileReader.Dispose();
            }
            catch (System.NullReferenceException err)
            {

            }
            audioFileReader = null;
            mainWindow.muteButton.IsEnabled = false;

        }

        public void update(Library library, MainWindow mainWindow)
        {

            while (true)
            {
                try
                {
                    if(audioFileReader!=null && mainWindow!=null && library!= null)
                    if (audioFileReader.TotalTime.TotalSeconds <= audioFileReader.CurrentTime.TotalSeconds)
                    {
                        Console.WriteLine(audioFileReader.TotalTime.TotalSeconds);
                        mainWindow.progressBar.Value = 1;
                        library.setCurrentId(library.getCurrentId() + 1);
                        stop(mainWindow);
                        break;
                    }
                }
                catch (Exception err)
                {

                }


                String time;
                if (audioFileReader.CurrentTime.Seconds < 10)
                    time = audioFileReader.CurrentTime.Minutes + " : 0" + audioFileReader.CurrentTime.Seconds;
                else
                    time = audioFileReader.CurrentTime.Minutes + " : " + audioFileReader.CurrentTime.Seconds;


               mainWindow.progresLabel.Dispatcher.Invoke(() => mainWindow.progresLabel.Content = time, DispatcherPriority.Background);
               mainWindow.progressBar.Dispatcher.Invoke(() => mainWindow.progressBar.Value = audioFileReader.Position, DispatcherPriority.Background);


                mainWindow.volumeLabel.Content = (int)(waveOutDevice.Volume * 100);
                if (library.getCurrentId() == 0)
                    mainWindow.previousButton.IsEnabled = false;
                else
                    mainWindow.previousButton.IsEnabled = true;

                if (library.getCurrentId() == library.getAmountOfItems() - 1)
                    mainWindow.nextButton.IsEnabled = false;
                else
                    mainWindow.nextButton.IsEnabled = true;
            }
        }


        public void setVolume(float volume)
        {
            waveOutDevice.Volume = volume;
        }
        public void pause(MainWindow mainWindow)
        {

           
            if (!paused)
            {
                waveOutDevice.Pause();
                paused = true;
                mainWindow.pauseButton.Content = "Resume";
            }
            else
            {
                waveOutDevice.Play();
                paused = false;
                mainWindow.pauseButton.Content = "Pause";
            }
        }
        public void mute(MainWindow mainWindow)
        {
            if (!muted)
            {
                previousValue = (float)mainWindow.volume.Value;
                mainWindow.volume.Value = 0;
                muted = true;
                mainWindow.muteButton.Content = "Unmute";
            }
            else
            {
                mainWindow.volume.Value = previousValue;
                muted = false;
                mainWindow.muteButton.Content = "Mute";
            }

        }
        public void volumeChange(MainWindow mainWindow)
        {
            setVolume((float)(mainWindow.volume.Value / 10));
            muted = false;
            mainWindow.muteButton.Content = "Mute";
        }
        public void progressBarChange(MainWindow mainWindow, Library library)
        {
            if(paused)
            {
                pause(mainWindow);
            }
            if(!isFirstPlayed)
            {
                play(library, mainWindow);
            }
            audioFileReader.Position = (long) mainWindow.progressBar.Value;
        }
    }
}
