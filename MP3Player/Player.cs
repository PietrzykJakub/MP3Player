using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio;
using NAudio.Wave;
using System.Windows.Threading;
using System.IO;

namespace MP3Player
{
    public class Player 
    {
        private IWavePlayer waveOutDevice;
        private AudioFileReader audioFileReader;
        private bool muted;
        private bool paused;
        float previousValue;

        public Player()
        {
            waveOutDevice = new WaveOut();
            paused = false;
            muted = false;
        }
        public void play(Library library, MainWindow mainWindow)
        {
            mainWindow.stopButton.IsEnabled = true;
            mainWindow.playButton.IsEnabled = false;
            waveOutDevice.Volume = (float)(mainWindow.volume.Value / 10);
            audioFileReader = new AudioFileReader(library.getPath());
            waveOutDevice.Init(audioFileReader);
            waveOutDevice.Play();
            mainWindow.pauseButton.IsEnabled = true;
            mainWindow.pauseButton.Content = "Pause";
            mainWindow.progressBar.Maximum = audioFileReader.Length;
            mainWindow.muteButton.IsEnabled = true;
            update(library, mainWindow);

        }
        public void stop(MainWindow mainWindow)
        {
            mainWindow.stopButton.IsEnabled = false;
            mainWindow.playButton.IsEnabled = true;
            waveOutDevice.Stop();
            audioFileReader.Dispose();
            audioFileReader = null;
            mainWindow.muteButton.IsEnabled = false;
        }
        public void update(Library library, MainWindow mainWindow)
        {
            while (true)
            {
                try
                {
                    mainWindow.progressBar.Dispatcher.Invoke(() => mainWindow.progressBar.Value = audioFileReader.Position, DispatcherPriority.Background);
                    mainWindow.progresLabel.Dispatcher.Invoke(() => mainWindow.progresLabel.Content = audioFileReader.CurrentTime.Minutes + " : " + audioFileReader.CurrentTime.Seconds, DispatcherPriority.Background);
                }
                catch (NullReferenceException e)
                {
                    Console.WriteLine(e.Message);
                }
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
        public void progressBarChange(MainWindow mainWindow)
        {
            audioFileReader.Position = (long) mainWindow.progressBar.Value;
        }
    }
}
