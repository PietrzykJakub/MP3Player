using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP3Player
{
    class SongInfo
    {
        public string title { get; set; }

        public string album { get; set; }

        public string artist { get; set; }

        public string year { get; set; }

        public string time { get; set; }

        public SongInfo(String title, String album, String artist, String year, String time)
        {
            this.title = title;
            this.album = album;
            this.artist = artist;
            this.year = year;
            this.time = time;

        }

    }
}
