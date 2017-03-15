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
    public class VragenlijstController : ApiController
    {

        private HealthcareDB _db;

        public VragenlijstController()
        {
            _db = new HealthcareDB();
        }

        //GET: api/Vragenlijst
        public IEnumerable<Vragenlijst> Get()
        {
            return _db.Vragenlijst;
        }

        [Route("api/Vragenlijst/{id}")]
        public IHttpActionResult GetVragenlijstById(int id)
        {
            var Vragenlijst = (_db.Vragenlijst.Where(c => c.VragenlijstId == id));
            if (Vragenlijst == null)
            {
                return NotFound();
            }
            return Ok(Vragenlijst);
        }

        [Route("api/Vragenlijst/laatste")]
        public IHttpActionResult GetLastVragenlijst()
        {
            try
            {
                var Vragenlijst = _db.Vragenlijst.SqlQuery("SELECT * FROM Vragenlijst ORDER BY VragenlijstId DESC").First();
                if (Vragenlijst == null)
                {
                    return (NotFound());
                }
                return Ok(Vragenlijst);
            }
            catch (InvalidOperationException ex)
            {
                Vragenlijst lijst = new Vragenlijst();
                lijst.VragenlijstId = 0;
                lijst.Categorie = "NotFound";
                return Ok(lijst);
            }
            
            
            
        }

        // POST: api/Vragenlijst
        public void Post(Parameter p)
        {
            JToken token = JObject.Parse(p.Value.ToString());

            Vragenlijst lijst = token.ToObject<Vragenlijst>();

            Migrations.Configuration config = new Migrations.Configuration();
            config.Seed(lijst);
        }

        [Route("api/Vragenlijst/{id}")]
        public void Post(Parameter p, int id)
        {
            JToken token = JObject.Parse(p.Value.ToString());

            Vragenlijst lijst = token.ToObject<Vragenlijst>();
            lijst.VragenlijstId = id;
            Migrations.Configuration config = new Migrations.Configuration();
            config.Seed(lijst);
        }

        // PUT: api/Vragenlijst/5
        public void Put(Parameter p)
        {
            Migrations.Configuration config = new Migrations.Configuration();

            JToken token = JObject.Parse(p.Value.ToString());

            Vragenlijst lijst = token.ToObject<Vragenlijst>();
            config.Seed(lijst);
        }

        // DELETE: api/Vragenlijst/5
        [Route("api/Vragenlijst/{id}")]
        public void Delete(int id)
        {
            HealthcareDB context = new HealthcareDB();
            context.Database.ExecuteSqlCommand("DELETE FROM Vragenlijst WHERE VragenlijstId="+id);
            context.Database.ExecuteSqlCommand("DELETE FROM Vraag WHERE VragenlijstId=" + id);
            context.SaveChanges();
        }
    }
}
