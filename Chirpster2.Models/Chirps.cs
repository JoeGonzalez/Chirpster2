using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chirpster2.Models
{
   public class Chirps
    {
        public int Id { get; set; }

        public string Cheeps { get; set; }
        public string UserId { get; set; }
        public Chirps() { }
        public Chirps(string cheeps, string userid) 
        {
            Cheeps = cheeps;
            UserId = userid;
        }
    }
}
