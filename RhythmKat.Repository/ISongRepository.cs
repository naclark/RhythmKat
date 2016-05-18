using RhythmKat.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhythmKat.Repository
{
    public interface ISongRepository
    {
        #region Create

        #endregion

        #region Retrieve

        List<Song> GetAllSongs();

        List<Song> GetSongsByArtist(Artist p_artist);

        List<Song> GetSongsByTitle(string p_searchTitle);

        List<Song> GetSongsByLanguage(LanguageEnum p_language);

        List<Song> GetSongsByGame(Game p_game);

        #endregion

        #region Update

        #endregion
        
        #region Delete
        
        #endregion
    }
}
