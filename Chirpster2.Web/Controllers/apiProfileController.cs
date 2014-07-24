using Chirpster2.Models;
using Chirpster2.Web.Adapter;
using Chirpster2.Web.Adapter.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Chirpster2.Web.Controllers
{
    public class apiProfileController : ApiController
    {
        private IChirp _adapter;
        public apiProfileController() 
        {
            _adapter = new ChirpAdapter();
        }
        [HttpGet]
        public IHttpActionResult Get(int id = -1) 
        {
            if (id == -1)
            {
                return Ok(_adapter.GetChirps());
            }
            else 
            {
                return Ok(_adapter.GetChirp(id));
            }
        }
        [HttpPost]
        public IHttpActionResult Post(Chirps cheeps) 
        {
            _adapter.CreateChirp(cheeps);
            return Ok();
        }
        [HttpPut]
        public IHttpActionResult Put(int id, Chirps cheep) 
        {
            _adapter.UpdateChirp(id, cheep);
            return Ok();
        }
        [HttpDelete]
        public IHttpActionResult Delete() 
        {
            return Ok();
        }
    }
}
