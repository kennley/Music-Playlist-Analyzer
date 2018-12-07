using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicAnalyzer
{
    class Program
    {
        // Constant for the file name
        private const String FILE_NAME = "SampleMusicPlaylist.txt";

        static void Main(string[] args)
        {
            // Create Play List
            PlayList list = new PlayList();

            // Load songs from the file. 
            list.LoadList(FILE_NAME);

            List<Song> songList = list.GetSongList();

            // Create Report
            Console.WriteLine("Music Playlist Report\n");

            //------------------------ Linq Queries --------------------------//
            
            // 1. How many songs received 200 or more plays?
            var query1 = from song in songList
                          where song.Plays >= 200
                          select song;

            Console.WriteLine("Songs that received 200 or more plays: ");
            foreach (var song in query1)
            {
                Console.WriteLine(song.ToString());
            }

            // 2.How many songs are in the playlist with the Genre of “Alternative”?
            int query2Count = (from song in songList
                              where song.Genre == "Alternative"
                              select song).Count();
            Console.WriteLine("\nNumber of Alternative songs: {0}", query2Count);

            // 3.How many songs are in the playlist with the Genre of “Hip - Hop / Rap”?
            int query3Count = (from song in songList
                               where song.Genre == "Hip-Hop/Rap"
                               select song).Count();
            Console.WriteLine("\nNumber of Hip-Hop/Rap songs: {0}", query3Count);


            // 4.What songs are in the playlist from the album “Welcome to the Fishbowl?”
            var query4 = from song in songList
                         where song.Album == "Welcome to the Fishbowl"
                         select song;

            Console.WriteLine("\nSongs from the album Welcome to the Fishbowl:");

            foreach (var song in query4)
            {
                Console.WriteLine(song.ToString());
            }

            // 5.What are the songs in the playlist from before 1970 ?
            var query5 = from song in songList
                         where song.Year < 1970
                         select song;

            Console.WriteLine("\nSongs from before 1970:");

            foreach (var song in query5)
            {
                Console.WriteLine(song.ToString());
            }
            // 6.What are the song names that are more than 85 characters long?
            var query6 = from song in songList
                         where song.Name.Length > 85
                         select song;

            Console.WriteLine("\nSong names longer than 85 characters:");

            foreach (var song in query6)
            {
                Console.WriteLine(song.Name);
            }

            // 7.What is the longest song ? (longest in Time)
            var query7 = songList.OrderByDescending(song => song.Time).First();

            Console.WriteLine();

            //foreach (var song in query7)
            //{
                Console.WriteLine("Longest Song: {0}", query7.ToString());
            //}

            Console.ReadKey();
        }
    }
}
