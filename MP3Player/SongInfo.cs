using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP3Player
{
    public class SongInfo
    {
        public string title { get; set; }

        public string album { get; set; }

        public string artist { get; set; }

        public string year { get; set; }

        public string time { get; set; }

        public TagLib.IPicture picture { get; set; }

        private string path;

        TagLib.File info;

        public SongInfo(String path)
        {
            this.path = path;

            info = TagLib.File.Create(path);

            if (info.Properties.Duration.Seconds < 10)
                time = (info.Properties.Duration.Minutes.ToString() + ":0" + info.Properties.Duration.Seconds.ToString());
            else
                time = (info.Properties.Duration.Minutes.ToString() + ":" + info.Properties.Duration.Seconds.ToString());

            this.title = info.Tag.Title;
            this.album = info.Tag.Album;
            this.artist = info.Tag.FirstAlbumArtist;
            this.year = info.Tag.Year.ToString();
            this.time = time;
            try
            {
                this.picture = info.Tag.Pictures[0];
            }
            catch (Exception err) { }
        }
        public String getPath()
        {
            return path;
        }
        public string getTitle()
        {
            return title;
        }
        

    }
}
