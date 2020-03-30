using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composites
{
    public abstract class SongComponent
    {
        abstract public void add(SongComponent newSongComponent);


        abstract public void remove(SongComponent newSongComponent);


        abstract public void displaySongInfo();
    }
}
