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

namespace AppDev04BackEnd.Controllers
{
    public class RapportController : ApiController
    {

        private HealthcareDB _db;

        public RapportController()
        {
            _db = new HealthcareDB();
        }

        //GET: api/Rapport
        public IEnumerable<Rapport> Get()
        {
            return _db.Rapport;
        }

        [Route("api/Rapport/{id}")]
        public IHttpActionResult GetRapportById(int id)
        {
            var Rapport = (_db.Rapport.Where(c => c.RapportId == id));
            if (Rapport == null)
            {
                return NotFound();
            }
            return Ok(Rapport);
        }


        // POST: api/Rapport
        public void Post([FromBody]JObject value)
        {
            Rapport Rapport = value.ToObject<Rapport>();
            _db.Rapport.Add(Rapport);
            _db.SaveChanges();
        }

        // PUT: api/Rapport/5
        public void Put([FromBody]JObject value)
        {
        }

        // DELETE: api/Rapport/5
        public void Delete(int id)
        {
        }
    }
}
