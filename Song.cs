using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicAnalyzer
{
    class Song
    {
        /** Public Properties **/
        public String Name { set; get; }
        public String Artist { set; get; }
        public String Album { set; get; }
        public String Genre { set; get; }
        public int Size { set; get; }
        public int Time { set; get; }
        public int Year { set; get; }
        public int Plays { set; get; }

        /// <summary>
        /// Convert Song to its equivalent String representation
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("Name: {0}, Artist: {1}, Album: {2}, Genre: {3},  " + 
                 "Size: {4}, Time: {5}, Year: {6}, Plays: {7}", Name, Artist, Album, 
                 Genre, Size, Time, Year, Plays);
        }
    }
}
