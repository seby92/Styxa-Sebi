using System;
using System.Collections.Generic;
using System.Text;

namespace Tanulas_nappal_06_09
{
    internal class Song
    {
        public string title;
        public string artist;
        public int duration;

        public Song(string aTitle, string aArtist, int aDuration)
        {
            title = aTitle;
            artist = aArtist;
            duration = aDuration;
        }
    }
}
