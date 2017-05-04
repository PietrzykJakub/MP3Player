using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MP3Player
{
    public class Library
    {
        private String[] paths;
        private String directory;
        private int currentId;
        private int amountOfItems;

        public Library(String directory)
        {
            paths = new String[100];
            currentId = 0;
            amountOfItems = 0;
            this.directory = directory;
            load();
        }
        public String[] getPaths()
        {
            return paths;
        }
        private void load()
        {
            DirectoryInfo dirInfo = new DirectoryInfo(directory);
            FileInfo[] files = dirInfo.GetFiles("*.*", SearchOption.AllDirectories);
            foreach (FileInfo f in files)
            {
                if (f.Extension == ".mp3")
                {
                    paths[amountOfItems++] = f.FullName;
                }
            }
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
            this.currentId = currentId;
        }

        public String getPath()
        {
            return paths[currentId];
        }
    }
}
