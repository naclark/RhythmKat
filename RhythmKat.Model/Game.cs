using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhythmKat.Model
{
    /// <summary>
    /// Found in the Games table in the database:
    /// Games.GameId, .GameName, .SeriesId, .GameSystemId.
    /// </summary>
    public class Game
    {
        public Game()
        {
            //to avoid null references
            Songs = new List<Song>();
            Series = new GameSeries();
            Systems = new List<GameSystem>();
        }

        public int GameId { get; set; }

        /// <summary>
        /// Name of the game (e.g. "Guitar Hero 2").
        /// </summary>
        public string GameName { get; set; }

        /// <summary>
        /// List of songs in the game.
        /// </summary>
        public List<Song> Songs { get; set; }

        /// <summary>
        /// Series to which the game belongs.
        /// </summary>
        public GameSeries Series { get; set; }

        /// <summary>
        /// Systems on which the game was released.
        /// </summary>
        public List<GameSystem> Systems { get; set; }

        /// <summary>
        /// Year the game was released.
        /// </summary>
        public int ReleaseYear { get; set; }
    }
}
