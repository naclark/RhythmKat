using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RhythmKat.Model;

namespace RhythmKat.Repository.TestRepository
{
	public class TestGameRepository : IGameRepository
	{

        #region Test Data

		private static List<GameSystem> TestSystems = new List<GameSystem>()
		{
			new GameSystem()
			{
				SystemId=1,
				SystemMaker="Gloopy Toys",
				SystemName="GloopyCon 3000"
			},
			new GameSystem()
			{
				SystemId=2,
				SystemMaker="Videlectrix",
				SystemName = "Remote Controller Video Game System"
			}
		};

		private static GameSeries[] TestSeries = {
			new GameSeries()
			{
				SeriesId = 1,
				SeriesDeveloper = "Capcpom",
				SeriesName = "Tuba Hero"
			},
			new GameSeries()
			{
				SeriesId = 2,
				SeriesDeveloper = "Bluth Company",
				SeriesName = "Banana Jamz"
			}
		};



		private static List<Game> TestGames = new List<Game>()
		{
			new Game()
			{
				GameId=1,
				GameName="Tuba Hero II",
				ReleaseYear=1776,
				Systems=TestSystems,
				Series=TestSeries[0]
			},
			new Game()
			{
				GameId=2,
				GameName="Banana Jamz World Tour",
				ReleaseYear=2112,
				Systems=TestSystems,
				Series=TestSeries[1]
			}
		};

        #endregion

		public List<Game> GetAllGames()
		{
			return TestGames;
		}

		public List<Game> GetGamesByMaker(string p_maker)
		{
			return TestGames.Where(a => a.Series.SeriesDeveloper.Contains(p_maker)).ToList();
		}

		public List<Game> GetGamesBySeries(GameSeries p_series)
		{
			return TestGames.Where(a => a.Series.SeriesId == p_series.SeriesId).ToList();
		}

		public List<Game> GetGamesBySystem(GameSystem p_system)
		{
			return TestGames.Where(a => a.Systems.Any(b => b.SystemId == p_system.SystemId)).ToList();
		}
	}
}
