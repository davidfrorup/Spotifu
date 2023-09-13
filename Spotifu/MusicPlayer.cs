using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotifu
{
    internal class MusicPlayer
    {

        private bool isPlaying = false;

        public void PlayAlbum(Album album)
        {
            Console.WriteLine("Now playing album: " + album.Title);
            foreach (var song in album.Songs)
            {
                if (!isPlaying)
                {
                    Console.WriteLine("Paused. Press 'P' to play.");
                    while (Console.ReadKey().Key != ConsoleKey.P) { }
                    Console.WriteLine("\nResumed.");
                }

                Console.WriteLine("Playing song: " + song.Title);
                Console.WriteLine("Artists:");
                foreach (var artist in song.Artists)
                {
                    Console.WriteLine("  - " + artist.Name);
                }

                Console.WriteLine("Press 'S' to skip to the next song, 'P' to pause, or 'Q' to quit.");
                var key = Console.ReadKey().Key;
                if (key == ConsoleKey.S)
                {
                    Console.WriteLine("\nSkipping to the next song.");
                }
                else if (key == ConsoleKey.P)
                {
                    isPlaying = !isPlaying;
                    Console.WriteLine("\nPaused. Press 'P' to resume.");
                    while (Console.ReadKey().Key != ConsoleKey.P) { }
                    Console.WriteLine("\nResumed.");
                }
                else if (key == ConsoleKey.Q)
                {
                    Console.WriteLine("\nQuitting.");
                    break;
                }

                Console.WriteLine();
            }
        }




    }
}
