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
using System.Threading;

namespace MP3Player
{
    public partial class MainWindow : Window
    {

        private List<Library> library;
        public Player player;
        private ShowInfo showInfo;
        int chosenLibrary;

        public MainWindow()
        {
            chosenLibrary = 0;
            library = new List<Library>();
            library.Add(new Library("New Lib"));
            player = new Player();
            InitializeComponent();
            showInfo = new ShowInfo();

        }

        private void play_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                player.play(library[chosenLibrary], this);
            }
            catch(Exception err)
            {

            }
        }

        private void load_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                library[chosenLibrary].load(destinationText.Text);
            }
            catch (System.ArgumentOutOfRangeException err)
            {
                library.Add(new Library("New Lib"));
                Console.WriteLine(chosenLibrary);
                library[chosenLibrary].load(destinationText.Text);
            }
            showInfo.updateAll(library,chosenLibrary,this);


        }
        
        private void stop_Click(object sender, RoutedEventArgs e)
        {
            stopButton.IsEnabled = false;
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
            try
            {
                player.progressBarChange(this, library[chosenLibrary]);
                showInfo.setActualSongInfo(library[chosenLibrary], this);
            }
            catch(Exception)
            {

            }

        }



        private void next_Click(object sender, RoutedEventArgs e)
        {
            player.stop(this);
            try
            {
                library[chosenLibrary].setCurrentId(library[chosenLibrary].getCurrentId() + 1);
                player.play(library[chosenLibrary], this);
            }
            catch(Exception err)
            {

            }



        }

        private void previous_Click(object sender, RoutedEventArgs e)
        {            
            if(library[chosenLibrary].getCurrentId() > 0)
            {                
                player.stop(this);
                library[chosenLibrary].setCurrentId(library[chosenLibrary].getCurrentId() - 1);
                player.play(library[chosenLibrary],this);
            }

        }
        private void destinationText_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void songs_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            player.stop(this);
            library[chosenLibrary].setCurrentId(songs.SelectedIndex);
            player.play(library[chosenLibrary], this);
            
        }

        public ShowInfo getShowInfo()
        {
            return showInfo;
        }

        private void librarys_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if(librarys.SelectedIndex >= 0)
            chosenLibrary = librarys.SelectedIndex;
            Console.WriteLine(chosenLibrary);
            
            showInfo.updateAll(library, chosenLibrary, this);
        }

        private void addLibrary_Click(object sender, RoutedEventArgs e)
        {
            library.Add(new Library("New Lib " + library.Count));
            chosenLibrary = library.Count-1;
            Console.WriteLine(library.Count);
            showInfo.updateAll(library, chosenLibrary, this);
            player.stop(this);
 
            try
            {
                player.play(library[chosenLibrary], this);
            }
            catch (Exception err)
            {
            }
        }

    }

}
