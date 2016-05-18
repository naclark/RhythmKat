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
    }
}
