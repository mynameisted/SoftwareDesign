using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composites
{
    class Program
    {
        static void Main(string[] args)
        {
            SongComponent industrialMusic = new SongGroup("Industrial", "");
            SongComponent heavyMetalMusic = new SongGroup("Heavy Metal", "");
            SongComponent dubstepMusic = new SongGroup("Industrial", "");

            SongComponent everySong = new SongGroup("Song List", "Every Available");


            everySong.add(industrialMusic);

            // Adding individual song in industrial music
            industrialMusic.add(new Song("Head Like a hole", "NIN", 1990));
            industrialMusic.add(new Song("Head Like a hole", "NIN", 1990));
            industrialMusic.add(dubstepMusic);


            dubstepMusic.add(new Song("Centipede", "Knife Party", 2012));
            dubstepMusic.add(new Song("Tetris", "Doctor P", 2011));


            everySong.add(heavyMetalMusic);


            heavyMetalMusic.add(new Song("War pigs", "Black Sabath", 1970));
            heavyMetalMusic.add(new Song("Ace of Spades", "Motorhead", 1980));

            DiskJockey crazyLarry = new DiskJockey(everySong);

            crazyLarry.getSongList();

        }
    }
}
