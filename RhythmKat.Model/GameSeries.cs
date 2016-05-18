using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhythmKat.Model
{
    /// <summary>
    /// Found in the GameSeries table in the database:
    /// GameSeries.SeriesId, .SeriesName, .SeriesDeveloper.
    /// </summary>
    public class GameSeries
    {
        public int SeriesId { get; set; }

        /// <summary>
        /// Name of the series (e.g. "Pop'n Music").
        /// </summary>
        public string SeriesName { get; set; }

        /// <summary>
        /// Developer of the series (e.g. "Konami").
        /// </summary>
        public string SeriesDeveloper { get; set; }
    }
}
