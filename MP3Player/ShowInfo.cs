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


        public ShowInfo(Library[] library, MainWindow main)
        {
            songsInfo = new List<SongInfo>();

        }
        public void setActualSongInfo(Library library, MainWindow main)
        {
            TagLib.File info = TagLib.File.Create(library.getPaths()[library.getCurrentId()]);
            main.song.Content = info.Tag.Title + "\t" + info.Tag.Album + "\t" + info.Tag.FirstAlbumArtist + "\t" + info.Tag.Year;
            TagLib.IPicture pic = info.Tag.Pictures[0];
            MemoryStream ms = new MemoryStream(pic.Data.Data);
            ms.Seek(0, SeekOrigin.Begin);
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.StreamSource = ms;
            bitmap.EndInit();
            main.cover.Source = bitmap;

        }
        public void setSongsInfo(Library library, MainWindow main)
        {
            for (int i = 0; i < library.getPaths().Length; i++)
            {
                if (library.getPaths()[i] != null)
                {
                    TagLib.File info = TagLib.File.Create(library.getPaths()[i]);
                    songsInfo.Add(new SongInfo(info.Tag.Title, info.Tag.Album ,info.Tag.FirstAlbumArtist,info.Tag.Year.ToString()));
                }
            }
            main.songs.ItemsSource = null;
            main.songs.ItemsSource = songsInfo;
        }
    }
}
