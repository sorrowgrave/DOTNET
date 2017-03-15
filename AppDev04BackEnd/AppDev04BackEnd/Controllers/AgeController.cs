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
    public class AgeController : ApiController
    {

        private HealthcareDB _db;

        public AgeController()
        {
            _db = new HealthcareDB();
        }

        //GET: api/Age
        public IEnumerable<Leeftijd> Get()
        {
            return _db.Leeftijd;
        }

        [Route("api/Leeftijd/{id}")]
        public IHttpActionResult GetAgeById(int id)
        {
            var leeftijd = (_db.Leeftijd.Where(c => c.id == id));
            if (leeftijd == null)
            {
                return NotFound();
            }
            return Ok(leeftijd);
        }


        // POST: api/Age
        public void Post([FromBody]JObject value)
        {
            Leeftijd Age = value.ToObject<Leeftijd>();
            _db.Leeftijd.Add(Age);
            _db.SaveChanges();
        }

        // PUT: api/Age/5
        public void Put([FromBody]JObject value)
        {
        }

        // DELETE: api/Age/5
        public void Delete(int id)
        {
        }
    }
}
