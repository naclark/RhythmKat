using RhythmKat.Model;
using RhythmKat.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhythmKat.Service
{
    public class SongService
    {
        private ISongRepository _repository;

        public SongService(ISongRepository p_repository)
        {
            this._repository = p_repository;
        }

        public List<Song> GetAllSongs()
        {
            return _repository.GetAllSongs();
        }

        public List<Song> GetSongsByArtist(Artist p_artist)
        {
            return _repository.GetSongsByArtist(p_artist);
        }

        public List<Song> GetSongsByTitle(string p_searchTitle)
        {
            return _repository.GetSongsByTitle(p_searchTitle);
        }

        public List<Song> GetSongsByLanguage(LanguageEnum p_language)
        {
            return _repository.GetSongsByLanguage(p_language);
        }

        public List<Song> GetSongsByGame(Game p_game)
        {
            return _repository.GetSongsByGame(p_game);
        }
    }
}
