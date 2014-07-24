using Chirpster2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chirpster2.Web.Adapter.Interface
{
   public interface IChirp
    {
        Chirps GetChirp(int id);
        List<Chirps> GetChirps();
        void CreateChirp(Chirps Cheeps);
        void UpdateChirp(int id, Chirps Cheeps);
        void Delete(int id);
    }
}
