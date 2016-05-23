using RhythmKat.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhythmKat.Repository
{
    public interface IGameRepository
    {
        #region Create

        #endregion

        #region Retrieve

        List<Game> GetAllGames();

        List<Game> GetGamesByMaker(string p_maker);

        List<Game> GetGamesBySystem(GameSystem p_system);

        List<Game> GetGamesBySeries(GameSeries p_series);

        List<GameSeries> GetAllSeries();

        List<GameSystem> GetAllSystems();

        #endregion

        #region Update

        #endregion
        
        #region Delete
        
        #endregion
    }
}
