using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Windows.Media.Imaging;
using System.Collections;

namespace MP3Player
{
    public class ShowInfo
    {
        List<SongInfo> songsInfo;


        public ShowInfo()
        {
            songsInfo = new List<SongInfo>();

        }
        public void updateAll(List<Library> library, int chosenLibrary,MainWindow mainWindow)
        {
            try
            {
                setActualSongInfo(library[chosenLibrary], mainWindow);
                setSongsInfo(library[chosenLibrary], mainWindow);
                setLibraryInfo(library, mainWindow);
            }
            catch(System.ArgumentOutOfRangeException err)
            {

            }

        }
        public void setActualSongInfo(Library library, MainWindow mainWindow)
        {

            try
            {
                mainWindow.song.Content = library.getSongs()[library.getCurrentId()].title +  " - " + library.getSongs()[library.getCurrentId()].artist;
            MemoryStream ms = new MemoryStream(library.getSongs()[library.getCurrentId()].picture.Data.Data);
            ms.Seek(0, SeekOrigin.Begin);
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.StreamSource = ms;
            bitmap.EndInit();
            mainWindow.cover.Source = bitmap;

            }
            catch(System.ArgumentOutOfRangeException err)
            {

            }

}
        public void setSongsInfo(Library library, MainWindow mainWindow)
        {

            mainWindow.songs.ItemsSource = null;
            mainWindow.songs.ItemsSource = library.getSongs();
        }
        public void setLibraryInfo( List<Library> library, MainWindow mainWindow)
        {

            mainWindow.librarys.ItemsSource = null;
            mainWindow.librarys.ItemsSource = library;
        }

    }
}
