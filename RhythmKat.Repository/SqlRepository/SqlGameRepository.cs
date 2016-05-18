using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RhythmKat.Model;

namespace RhythmKat.Repository.SqlRepository
{
    public class SqlGameRepository : IGameRepository
    {
        private string _connectionString { get; set; }

        public SqlGameRepository(string p_connectionString)
        {
            _connectionString = p_connectionString;
        }

        public List<Game> GetAllGames()
        {
            throw new NotImplementedException();
        }

        public List<Game> GetGamesByMaker(string p_maker)
        {
            throw new NotImplementedException();
        }

        public List<Game> GetGamesBySeries(GameSeries p_series)
        {
            throw new NotImplementedException();
        }

        public List<Game> GetGamesBySystem(GameSystem p_system)
        {
            throw new NotImplementedException();
        }
    }
}
