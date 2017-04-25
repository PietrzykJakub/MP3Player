using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using NAudio;
using NAudio.Wave;
using System.Windows.Threading;
using System.IO;

namespace MP3Player
{
    public partial class MainWindow : Window
    {
        IWavePlayer waveOutDevice;
        AudioFileReader audioFileReader;
        float previousValue;
        bool mute = false;
        bool paused = false;
        String[] paths;
        int currentId;
        String directory;
        int numberOfSongs;
        public MainWindow()
        {
            waveOutDevice = new WaveOut();
            paths = new String[100];

            InitializeComponent();
            currentId = 0;
            

        }

        public void update()
        {
            if (audioFileReader.Position != null)
                while (true)
                {                
                    progressBar.Dispatcher.Invoke(() => progressBar.Value = audioFileReader.Position, DispatcherPriority.Background);
                    progresLabel.Dispatcher.Invoke(() => progresLabel.Content = audioFileReader.CurrentTime.Minutes + " : " + audioFileReader.CurrentTime.Seconds, DispatcherPriority.Background);
                    volumeLabel.Content = (int)(waveOutDevice.Volume * 100);
                    if (currentId == 0)
                        previousButton.IsEnabled = false;
                    else
                        previousButton.IsEnabled = true;

                    if(currentId == numberOfSongs-1)
                        nextButton.IsEnabled = false;
                    else
                        nextButton.IsEnabled = true;
                }                 
        }
        private void play_Click(object sender, RoutedEventArgs e)
        {
            play(paths[0]);
        }

        private void load_Click(object sender, RoutedEventArgs e)
        {
            directory = destinationText.Text;
            DirectoryInfo dirInfo = new DirectoryInfo(directory);
            FileInfo[] files = dirInfo.GetFiles("*.*", SearchOption.AllDirectories);
            foreach (FileInfo f in files)
            {
                if (f.Extension == ".mp3")
                {
                    paths[numberOfSongs++] = f.FullName;
                }
            }
        }

        private void stop_Click(object sender, RoutedEventArgs e)
        {
            stop();       
        }

        public void stop()
        {
            stopButton.IsEnabled = false;
            playButton.IsEnabled = true;
            waveOutDevice.Stop();
            audioFileReader.Dispose();
            audioFileReader = null;
            muteButton.IsEnabled = false;
        }
        private void volume_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            waveOutDevice.Volume = (float)(volume.Value / 10);
            mute = false;
        }

        private void mute_Click(object sender, RoutedEventArgs e)
        {
            if (!mute)
            {
                previousValue = (float)volume.Value;
                volume.Value = 0;
                mute = true;
                muteButton.Content = "Unmute";
            }
            else
            {
                volume.Value = previousValue;
                mute = false;
                muteButton.Content = "Mute";
            }
        }

        private void pause_Click(object sender, RoutedEventArgs e)
        {
            if (!paused)
            {
                waveOutDevice.Pause();
                paused = true;
                pauseButton.Content = "Resume";
            }                
            else{
                waveOutDevice.Play();
                paused = false;
                pauseButton.Content = "Pause";
            }
                
        }

        private void progressBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            audioFileReader.Position = (long)progressBar.Value;            
        }


        private void next_Click(object sender, RoutedEventArgs e)
        {
            stop();
            play(paths[++currentId]);
        }

        public void play(String path)
        {
            stopButton.IsEnabled = true;
            playButton.IsEnabled = false;
            waveOutDevice.Volume = (float)(volume.Value / 10);
            audioFileReader = new AudioFileReader(path);
            waveOutDevice.Init(audioFileReader);
            waveOutDevice.Play();
            pauseButton.IsEnabled = true;
            progressBar.Maximum = audioFileReader.Length;
            //label1.Content = audioFileReader.TotalTime;
            update();
        }

        private void previous_Click(object sender, RoutedEventArgs e)
        {            
            if(currentId > 0)
            {                
                stop();
                play(paths[--currentId]);
            }                
        }

        private void progressBar_ValueChanged_1(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }
    }
}
