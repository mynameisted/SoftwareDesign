using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composites
{
    class Song : SongComponent
    {
        string songName { get; }
        string bandName { get; }
        int releaseYear { get; }

        public Song(string newSongName, string newBandName, int newYearReleased)
        {
            songName = newSongName;
            bandName = newBandName;
            releaseYear = newYearReleased;
        }

        public override void add(SongComponent newSongComponent)
        {
            throw new NotImplementedException();
        }

        public override void remove(SongComponent newSongComponent)
        {
            throw new NotImplementedException();
        }

        public override void displaySongInfo()
        {
            Console.WriteLine(songName + " was recorded by " + bandName + "in" + releaseYear);
        }
    }
}
