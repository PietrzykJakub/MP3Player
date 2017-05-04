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

        Library[] library;
        Player player;
        ShowInfo showInfo;
        public MainWindow()
        {
       

            library = new Library[100];
            player = new Player();
            InitializeComponent();
            showInfo = new ShowInfo(library,this);

        }

        private void play_Click(object sender, RoutedEventArgs e)
        {
            player.play(library[0],this);
        }

        private void load_Click(object sender, RoutedEventArgs e)
        {

            library[0] = new Library(destinationText.Text);
            showInfo.setActualSongInfo(library[0], this);
            showInfo.setSongsInfo(library[0], this);
        }
        
        private void stop_Click(object sender, RoutedEventArgs e)
        {
            player.stop(this);       
        }

        private void volume_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            player.volumeChange(this);
        }

        private void mute_Click(object sender, RoutedEventArgs e)
        {
            player.mute(this);
        }

        private void pause_Click(object sender, RoutedEventArgs e)
        {
            player.pause(this);
                
        }

        private void progressBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            player.progressBarChange(this, library[0]);
            showInfo.setActualSongInfo(library[0], this);
        }



        private void next_Click(object sender, RoutedEventArgs e)
        {
            player.stop(this);
            library[0].setCurrentId(library[0].getCurrentId() + 1);
            player.play(library[0],this);


        }

        private void previous_Click(object sender, RoutedEventArgs e)
        {            
            if(library[0].getCurrentId() > 0)
            {                
                player.stop(this);
                library[0].setCurrentId(library[0].getCurrentId() - 1);
                player.play(library[0],this);
            }

        }
        private void destinationText_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void songs_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            player.stop(this);
            library[0].setCurrentId(songs.SelectedIndex);
            player.play(library[0], this);
            
        }

    }
}
