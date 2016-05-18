using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhythmKat.Model
{
    /// <summary>
    /// Found in the GameSystems table in the database:
    /// GameSystems.SystemId, .SystemName, .SystemMaker.
    /// </summary>
    public class GameSystem
    {
        public int SystemId { get; set; }

        /// <summary>
        /// Name of the console (e.g. "PlayStation 2"), or "Arcade."
        /// </summary>
        public string SystemName { get; set; }

        /// <summary>
        /// Name of the game system's maker (e.g. "Sony"), or "Arcade."
        /// </summary>
        public string SystemMaker { get; set; }
    }
}
