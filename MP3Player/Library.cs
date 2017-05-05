using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace MP3Player
{
    public class Library
    {
        public String name { get; set; }
        private List<SongInfo> songs;
        private String directory;
        private  int currentId;
        public int amountOfItems { get; set; }

        public Library(String  name)
        {
            this.name = name;
            songs = new List<SongInfo>();
            currentId = 0;
            amountOfItems = 0;
        }

        public List<SongInfo> getSongs()
        {
            return songs;
        }
        public void load(String directory)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(directory);
            FileInfo[] files = dirInfo.GetFiles("*.*", SearchOption.AllDirectories);
            foreach (FileInfo f in files)
            {
                if (f.Extension == ".mp3")
                {
                    songs.Add(new SongInfo(f.FullName));
                    amountOfItems++;
                }
            }
            currentId = 0;
        }
        public int getCurrentId()
        {
            return currentId;
        }

        public int getAmountOfItems()
        {
            return amountOfItems;
        }

        public void setCurrentId(int currentId)
        {
            Console.Write("set:" + currentId);
            this.currentId = currentId;
        }

    }
}
