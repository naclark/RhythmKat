using RhythmKat.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhythmKat.Repository
{
    public interface IArtistRepository
    {
        #region Create

        #endregion

        #region Retrieve

        List<Artist> GetAllArtists();

        List<Artist> GetArtistsByName(string p_searchName);

        //This assumes one artist per song. Collaborations count as their own "artist."
        Artist GetArtistBySongId(int p_songId);

        #endregion

        #region Update

        #endregion
        
        #region Delete
        
        #endregion
    }
}
