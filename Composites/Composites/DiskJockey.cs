using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composites
{
    class DiskJockey
    {
        SongComponent songList;

        public DiskJockey(SongComponent newSongList)
        {
            songList = newSongList;
        }
        public void getSongList()
        {
            songList.displaySongInfo();
        }
    }
}
