using Spotifu;

Artist artist1 = new Artist("Artist1");
Artist artist2 = new Artist("Artist2");

Song song1 = new Song("Song1", new List<Artist> { artist1 });
Song song2 = new Song("Song2", new List<Artist> { artist1, artist2 });

Album album = new Album("Album1", new List<Song> { song1, song2 });

MusicPlayer musicPlayer = new MusicPlayer();
Console.WriteLine("Welcome to the Music Player!");
Console.WriteLine("Press 'P' to start playing the album, 'Q' to quit.");
var key = Console.ReadKey().Key;
if (key == ConsoleKey.P)
{
    Console.WriteLine("\n");
    musicPlayer.PlayAlbum(album);
}
else if (key == ConsoleKey.Q)
{
    Console.WriteLine("\nQuitting.");
}