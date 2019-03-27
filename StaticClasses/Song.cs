using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassesAttributes
{
    class Song
    {
        public string title;
        public string artist;
        public int duration;
        public static int songCount;


        public Song(string title, string artist, int duration)
        {
            this.title = title;
            this.artist = artist;
            this.duration = duration;
            //Every time the song object get created, the songCount will be icremented.
            songCount++;
        }
        public int getSongCount()
        {
            //This method returns the songCount attribute
            return songCount;
        }
    }
}
