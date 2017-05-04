using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP3Player
{
    class SongInfo
    {
        public string Title { get; set; }

        public string Album { get; set; }

        public string Artist { get; set; }

        public string Year { get; set; }

        public SongInfo(String Title, String Album, String Artist, String Year)
        {
            this.Title = Title;
            this.Album = Album;
            this.Artist = Artist;
            this.Year = Year;

        }

    }
}
