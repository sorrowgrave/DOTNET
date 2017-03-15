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
    public class MantelzorgerController : ApiController
    {

        private HealthcareDB _db;

        public MantelzorgerController()
        {
            _db = new HealthcareDB();
        }

        //GET: api/Mantelzorger
        public IEnumerable<Mantelzorger> Get()
        {
            return _db.Mantelzorger;
        }

        [Route("api/Mantelzorger/{id}")]
        public IHttpActionResult GetMantelzorgerById(int id)
        {
            var mantelzorger = (_db.Mantelzorger.Where(c => c.MantelzorgerId == id));
            if (mantelzorger == null)
            {
                return NotFound();
            }
            return Ok(mantelzorger);
        }


        // POST: api/Mantelzorger
        public void Post([FromBody]JObject value)
        {
            Mantelzorger Mantelzorger = value.ToObject<Mantelzorger>();
            _db.Mantelzorger.Add(Mantelzorger);
            _db.SaveChanges();
        }

        // PUT: api/Mantelzorger/5
        public void Put([FromBody]JObject value)
        {
        }

        // DELETE: api/Mantelzorger/5
        public void Delete(int id)
        {
        }
    }
}
