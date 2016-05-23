using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RhythmKat.Model;

namespace RhythmKat.Repository.SqlRepository
{
    public class SqlArtistRepository : IArtistRepository
    {
        private string _connectionString { get; set; }

        /// <summary>
        /// Uses a SQL database as the data source for the Artist objects.
        /// </summary>
        /// <param name="p_connectionString"></param>
        public SqlArtistRepository(string p_connectionString)
        {
            _connectionString = p_connectionString;
        }

        public List<Artist> GetAllArtists()
        {
            throw new NotImplementedException();
        }

        public List<Artist> GetArtistsByName(string p_searchName)
        {
            throw new NotImplementedException();
        }

        public Artist GetArtistBySongId(int p_songId)
        {
            throw new NotImplementedException();
        }
    }
}
