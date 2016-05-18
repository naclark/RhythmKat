using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhythmKat.Model
{
    /// <summary>
    /// Found in the Artists table in the database:
    /// Artists.ArtistId, .ArtistName. More to come?
    /// </summary>
    public class Artist
    {
        public int ArtistId { get; set; }

        public string ArtistName { get; set; }
    }
}
