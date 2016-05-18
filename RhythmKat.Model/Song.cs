using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhythmKat.Model
{
    /// <summary>
    /// Found in the Songs table in the database:
    /// Songs.SongId, .ArtistId, .Title, .Length, .YearRecorded, .Language.
    /// </summary>
    public class Song
    {
        public Song()
        {
            //preventative measure against null references to Artist
            Artist = new Artist();
        }

        public int SongId { get; set; }

        /// <summary>
        /// Artist who performed the song.
        /// </summary>
        public Artist Artist { get; set; }

        /// <summary>
        /// Title of the song.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Length of the song in seconds.
        /// </summary>
        public int Length { get; set; }

        /// <summary>
        /// Year recorded.
        /// </summary>
        public int YearRecorded { get; set; }

        /// <summary>
        /// Language of the lyrics (where applicable).
        /// </summary>
        public LanguageEnum Language { get; set; }
    }
}
