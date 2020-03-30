using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composites
{
    class SongGroup : SongComponent
    {

        List<SongComponent> songComponents = new List<SongComponent>();
        string groupName { get;}
        string groupDescription {get;}


        public SongGroup(String newGroupName, string newGroupDescription)
        {
            groupName = newGroupName;
            groupDescription = newGroupDescription;
        }


        // Whats added into this is an interface SongComponent
        // Since Song and SongGroup implements SongComponents, 
        // we can add both types of objects into this class.
        // Only song group can have the add feature as it is not necessarily a leaf node.
        public override void add(SongComponent newSongComponent)
        {
            songComponents.Add(newSongComponent);
        }

        public override void remove(SongComponent newSongComponent)
        {
            songComponents.Remove(newSongComponent);
        }

        public SongComponent getComponent(int componentIndex)
        {
            return (SongComponent)songComponents[componentIndex];
        }


        public override void displaySongInfo()
        {
            Console.WriteLine(groupName + " " + groupDescription);
            foreach (var songInfo in songComponents){
                songInfo.displaySongInfo();
            }
        }
    
    }
}
