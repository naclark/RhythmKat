using RhythmKat.Model;
using RhythmKat.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhythmKat.Service
{
    public class ArtistService
    {
        private IArtistRepository _repository;

        public ArtistService(IArtistRepository p_repository)
        {
            this._repository = p_repository;
        }

        public List<Artist> GetAllArtists()
        {
            return _repository.GetAllArtists();
        }

        public List<Artist> GetArtistsByName(string p_searchName)
        {
            return _repository.GetArtistsByName(p_searchName);
        }

        public Artist GetArtistBySongId(int p_songId)
        {
            return _repository.GetArtistBySongId(p_songId);
        }
    }
}
