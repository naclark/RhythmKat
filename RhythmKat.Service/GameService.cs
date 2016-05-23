using RhythmKat.Model;
using RhythmKat.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhythmKat.Service
{
    public class GameService
    {
        private IGameRepository _repository;

        public GameService(IGameRepository p_repository)
        {
            this._repository = p_repository;
        }

        public List<Game> GetAllGames()
        {
            return _repository.GetAllGames();
        }

        public List<Game> GetGamesByMaker(string p_maker)
        {
            return _repository.GetGamesByMaker(p_maker);
        }

        public List<Game> GetGamesBySystem(GameSystem p_system)
        {
            return _repository.GetGamesBySystem(p_system);
        }

        public List<Game> GetGamesBySeries(GameSeries p_series)
        {
            return _repository.GetGamesBySeries(p_series);
        }

        public List<GameSeries> GetAllSeries()
        {
            return _repository.GetAllSeries();
        }

        public List<GameSystem> GetAllSystems()
        {
            return _repository.GetAllSystems();
        }
    }
}
