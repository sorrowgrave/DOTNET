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
    public class RelatieController : ApiController
    {

        private HealthcareDB _db;

        public RelatieController()
        {
            _db = new HealthcareDB();
        }

        //GET: api/Relatie
        public IEnumerable<Relatie> Get()
        {
            return _db.Relatie;
        }

        [Route("api/Relatie/{id}")]
        public IHttpActionResult GetRelatieById(int id)
        {
            var relatie = (_db.Relatie.Where(c => c.id == id));
            if (relatie == null)
            {
                return NotFound();
            }
            return Ok(relatie);
        }


        // POST: api/Relatie
        public void Post([FromBody]JObject value)
        {
            Relatie relatie = value.ToObject<Relatie>();
            _db.Relatie.Add(relatie);
            _db.SaveChanges();
        }

        // PUT: api/Relatie/5
        public void Put([FromBody]JObject value)
        {
        }

        // DELETE: api/Relatie/5
        public void Delete(int id)
        {
        }
    }
}
