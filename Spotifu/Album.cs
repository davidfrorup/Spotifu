using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotifu
{
    internal class Album
    {

        public string Title { get; set; }
        public List<Song> Songs { get; set; }

        public Album(string title, List<Song> songs)
        {
            Title = title;
            Songs = songs;
        }




    }
}
