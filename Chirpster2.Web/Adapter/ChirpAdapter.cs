using Chirpster2.Data;
using Chirpster2.Models;
using Chirpster2.Web.Adapter.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chirpster2.Web.Adapter
{
    public class ChirpAdapter : IChirp
    {
        public Chirps GetChirp(int id) 
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            Chirps Cheeps = Db.Cheeps.Where(c => c.Id == id).FirstOrDefault();
            return Cheeps;
        }
        public List<Chirps> GetChirps() 
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            List<Chirps> Cheeps = Db.Cheeps.ToList();
            return Cheeps;
        }
        public void CreateChirp(Chirps Cheep) 
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            Db.Cheeps.Add(Cheep);
            Db.SaveChanges();
        }
        public void UpdateChirp(int id, Chirps Cheep) 
        {
            ApplicationDbContext Db = new ApplicationDbContext();

            Db.SaveChanges();
        }
        public void Delete(int id) 
        {
            ApplicationDbContext Db = new ApplicationDbContext();

            Db.SaveChanges();
        }


    }
}