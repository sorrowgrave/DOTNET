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
using RestSharp;

namespace AppDev04BackEnd.Controllers
{
    public class UitslagController : ApiController
    {

        private HealthcareDB _db;

        public UitslagController()
        {
            _db = new HealthcareDB();
        }

        //GET: api/Uitslag
        public IEnumerable<Uitslag> Get()
        {
            return _db.Uitslag;
        }

        [Route("api/Uitslag/{id}")]
        public IHttpActionResult GetUitslagById(int id)
        {
            var uitslag = (_db.Uitslag.Where(c => c.Id == id));
            if (uitslag == null)
            {
                return NotFound();
            }
            return Ok(uitslag);
        }


        // POST: api/Uitslag
        public void Post(Parameter p)
        {
            JToken token = JObject.Parse(p.Value.ToString());

            Uitslag uitslag = token.ToObject<Uitslag>();
            Migrations.Configuration config = new Migrations.Configuration();
            config.Seed(uitslag);
        }

        // PUT: api/Uitslag/5
        public void Put(Parameter p)
        {
            Migrations.Configuration config = new Migrations.Configuration();

            JToken token = JObject.Parse(p.Value.ToString());

            Uitslag uitslag = token.ToObject<Uitslag>();
            config.Seed(uitslag);
        }

        // PUT: api/uitslag/5/Client
        [Route("api/Uitslag/{id}/{type}")]
        public void Put(int id, string type)
        {
            HealthcareDB context = new HealthcareDB();
            Migrations.Configuration config = new Migrations.Configuration();
            if (type.Equals("Zorger"))
            {
                var zorger = (_db.Uitslag.First(c => c.Id == id));
                if (zorger.ClientIngevuld)
                {
                    context.Database.ExecuteSqlCommand("UPDATE Rapport SET AntwLijstMantelzorger =" + zorger.ZorgerUrl + " WHERE RapportId = "+id);
                    context.Database.ExecuteSqlCommand("UPDATE Uitslag SET Availability = 1, ZorgerIngevuld = 1, ZorgerUrl = null WHERE Id = " + id);
                }
                else
                {
                    context.Database.ExecuteSqlCommand("INSERT INTO Rapport (RapportId, AntwLijstMantelzorger) VALUES ("+id+", "+zorger.ZorgerUrl+")");
                    context.Database.ExecuteSqlCommand("UPDATE Uitslag SET ZorgerIngevuld = 1, ZorgerUrl = null WHERE Id = " + id);
                }
            }
            else
            {
                if (type.Equals("Client"))
                {
                   var client = (_db.Uitslag.First(c => c.Id == id));
                   if (client.ZorgerIngevuld)
                   {
                       context.Database.ExecuteSqlCommand("UPDATE Rapport SET AntwLijstClient =" + client.ClientUrl + " WHERE RapportId = "+id);
                       context.Database.ExecuteSqlCommand("UPDATE Uitslag SET Availability = 1, ClientIngevuld = 1, ClientUrl = null WHERE Id = " + id);
                   }
                   else
                   {
                       context.Database.ExecuteSqlCommand("INSERT INTO Rapport (RapportId, AntwLijstClient) VALUES (" + id + ", " + client.ClientUrl + ")");
                       context.Database.ExecuteSqlCommand("UPDATE Uitslag SET ClientIngevuld = 1, ClientUrl = null WHERE Id = " + id);
                   }
                }
            }
            context.SaveChanges();
        }

        // DELETE: api/Uitslag/5
        [Route("api/Uitslag/{id}")]
        public void Delete(int id)
        {
            HealthcareDB context = new HealthcareDB();
            context.Database.ExecuteSqlCommand("DELETE FROM Uitslag WHERE Id=" + id);
            context.SaveChanges();
        }
    }
}
