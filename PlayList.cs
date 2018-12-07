using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MusicAnalyzer
{
    class PlayList
    {
        private List<Song> songList;

        /// <summary>
        /// Create Empty Song List.
        /// </summary>
        public PlayList()
        {
            this.songList = new List<Song>();
        }

        /// <summary>
        /// Function to load the Song List from the Tab Delimited File into Objects of
        /// songs into the List of songs.
        /// </summary>
        /// <param name="fileName"></param>
        public void LoadList(String fileName)
        {
            try
            {
                String [] lines = File.ReadAllLines(fileName);

                int counter = 0;

                foreach (String line in lines)
                {
                    if(counter == 0)
                    {
                        counter++;
                        continue;
                    }
                    // Break the line by tab into tokens

                    String[] tokens = line.Split(new char[] { '\t' });
                    //Console.WriteLine("{0} {1}", tokens[0], tokens[1]);

                    // Create song from tokens
                    Song song = new Song();
                    song.Name = tokens[0].Trim();
                    song.Artist = tokens[1].Trim();
                    song.Album = tokens[2].Trim();
                    song.Genre = tokens[3].Trim();
                    song.Size = int.Parse(tokens[4].Trim());
                    song.Time = int.Parse(tokens[5].Trim());
                    song.Year = int.Parse(tokens[6].Trim());
                    song.Plays = int.Parse(tokens[7].Trim());

                    // Add to list
                    this.songList.Add(song);
                }

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message + "\n" + e.ToString());
            }
        }

        /// <summary>
        /// Function to get the Song List.
        /// </summary>
        /// <returns></returns>
        public List<Song> GetSongList()
        {
            return this.songList;
        }
    }
}
