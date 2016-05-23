using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RhythmKat.Model;

namespace RhythmKat.Repository.SqlRepository
{
    public class SqlSongRepository : ISongRepository
    {
        private string _connectionString { get; set; }

        /// <summary>
        /// Uses a SQL database as the data source for the Song objects.
        /// </summary>
        /// <param name="p_connectionString"></param>
        public SqlSongRepository(string p_connectionString)
        {
            _connectionString = p_connectionString;
        }

        public List<Song> GetAllSongs()
        {
            throw new NotImplementedException();
        }

        public List<Song> GetSongsByArtist(Artist p_artist)
        {
            throw new NotImplementedException();
        }

        public List<Song> GetSongsByTitle(string p_searchTitle)
        {
            throw new NotImplementedException();
        }

        public List<Song> GetSongsByLanguage(LanguageEnum p_language)
        {
            throw new NotImplementedException();
        }

        public List<Song> GetSongsByGame(Game p_game)
        {
            throw new NotImplementedException();
        }
    }
}
