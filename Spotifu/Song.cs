using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotifu
{
    internal class Song
    {

        public string Title { get; set; }
        public List<Artist> Artists { get; set; }

        public Song(string title, List<Artist> artists)
        {
            Title = title;
            Artists = artists;
        }







    }
}
