using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuzikMashLib
{
    public class Artist
    {
        private string artistName;
        private int artistId;
        private string song;
        private string genre;
        /// <summary>
        /// Artist Constructor
        /// </summary>
        /// <param name="artistName">Artist Name</param>
        /// <param name="artistId">Artist ID</param>
        /// <param name="song">List of songs</param>
        /// <param name="genre">Genres</param>
        public Artist(string artistName, int artistId, string song, string genre)
        {
            this.ArtistName = artistName;
            this.ArtistId = artistId;
            this.Song = song;
            this.Genre = genre;
        }

        public string ArtistName { get => artistName; set => artistName = value; }
        public int ArtistId { get => artistId; set => artistId = value; }
        public string Song { get => song; set => song = value; }
        public string Genre { get => genre; set => genre = value; }

        /// <summary>
        /// Populates a list with artist data.
        /// </summary>
        /// <param name="List">List to populate</param>
        public static void CreateArtistList(List<Artist> List)
        {
            //Aerosmith, Queen , Stormzy , Calvin, Twenty , Don , Eminem, Muse, Cole, Slipknot, Coldplay , Post , Black , Billie
            //List.add(new Artist(params));
            List.Add(new Artist("Aerosmith", 1, "Dream On", "rock"));
            List.Add(new Artist("Queen", 2, "Another One Bites the Dust", "rock"));
            List.Add(new Artist("Stormzy", 3, "Vossi bop", "rap"));
            List.Add(new Artist("Calvin Harris", 4, "Summer", "pop"));
            List.Add(new Artist("Twenty One Pilots", 5, "Heathens", "alternative"));
            List.Add(new Artist("Don McLean", 6, "American Pie", "rock"));
            List.Add(new Artist("Eminem", 7, "Without Me", "rap"));
            List.Add(new Artist("Muse", 8, "Time is Running Out", "alternative"));
            List.Add(new Artist("J.Cole", 9, "Can't Get Enough", "rap"));
            List.Add(new Artist("Slipknot", 10, "Before I Forget", "metal"));
            List.Add(new Artist("Coldplay", 11, "Paradise", "pop"));
            List.Add(new Artist("Post Malone", 12, "Congratulations", "rap"));
            List.Add(new Artist("Black Sabbath", 13, "paranoid", "metal"));
            List.Add(new Artist("Billie Eilish ", 14, "bury a friend", "pop"));
            List.Add(new Artist("Seether", 15, "Fake it", "rock"));
        }
    }
}

