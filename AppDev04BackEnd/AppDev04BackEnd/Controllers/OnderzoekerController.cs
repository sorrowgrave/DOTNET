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
    public class OnderzoekerController : ApiController
    {

        private HealthcareDB _db;

        public OnderzoekerController()
        {
            _db = new HealthcareDB();
        }

        //GET: api/Onderzoeker
        public IEnumerable<Onderzoeker> Get()
        {
            return _db.Onderzoeker;
        }

        [Route("api/Onderzoeker/{id}")]
        public IHttpActionResult GetOnderzoekerById(int id)
        {
            var onderzoeker = (_db.Onderzoeker.Where(c => c.OnderzoekerId == id));
            if (onderzoeker == null)
            {
                return NotFound();
            }
            return Ok(onderzoeker);
        }


        // POST: api/Onderzoeker
        public void Post([FromBody]JObject value)
        {
            Onderzoeker onderzoeker = value.ToObject<Onderzoeker>();
            _db.Onderzoeker.Add(onderzoeker);
            _db.SaveChanges();
        }

        // PUT: api/Onderzoeker/5
        public void Put([FromBody]JObject value)
        {
        }

        // DELETE: api/Onderzoeker/5
        public void Delete(int id)
        {
        }
    }
}
