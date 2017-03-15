using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;
using Newtonsoft.Json.Linq;
using AppDev04BackEnd.Models;
using HealthcareDBModel.DomainClasses;
using System.Web.Script.Serialization;

namespace AppDev04BackEnd.Controllers
{
    public class AntwoordController : ApiController
    {

        private HealthcareDB _db;

        public AntwoordController()
        {
            _db = new HealthcareDB();
        }

        //GET: api/Antwoord
        public IEnumerable<Antwoord> Get()
        {
            return _db.Antwoord;
        }

        [Route("api/Antwoord/{id}")]
        public IHttpActionResult GetAntwoordById(int id)
        {
            var Antwoord = (_db.Antwoord.Where(c => c.AntwoordenlijstId == id));
            if (Antwoord == null)
            {
                return NotFound();
            }
            return Ok(Antwoord);
        }
        
        // POST: api/Antwoord
        public void Post([FromBody]JObject value)
        {
            Migrations.Configuration config = new Migrations.Configuration();
            string test = value.First.Path;
            JavaScriptSerializer testing = new JavaScriptSerializer();
            Antwoord antwoord = testing.Deserialize<Antwoord>(test);
            //Antwoord antwoord = tokens.ToObject<Antwoord>();
            config.Seed(antwoord);
        }

        // PUT: api/Antwoord/5
        public void Put([FromBody]JObject value)
        {
            Migrations.Configuration config = new Migrations.Configuration();

            Antwoord antwoord = value.ToObject<Antwoord>();
            config.Seed(antwoord);
        }

        // DELETE: api/Antwoord/5
        public void Delete(int id)
        {
        }
    }
}
