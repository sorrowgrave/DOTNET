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
    public class NAHCategorieController : ApiController
    {

        private HealthcareDB _db;

        public NAHCategorieController()
        {
            _db = new HealthcareDB();
        }

        //GET: api/NAHCategorie
        public IEnumerable<NAHCategorie> Get()
        {
            return _db.NAHCategorie;
        }

        [Route("api/NAHCategorie/{id}")]
        public IHttpActionResult GetNAHCategorieById(int id)
        {
            var NAHcategorie = (_db.NAHCategorie.Where(c => c.id == id));
            if (NAHcategorie == null)
            {
                return NotFound();
            }
            return Ok(NAHcategorie);
        }


        // POST: api/NAHCategorie
        public void Post([FromBody]JObject value)
        {
            NAHCategorie NAHcategorie = value.ToObject<NAHCategorie>();
            _db.NAHCategorie.Add(NAHcategorie);
            _db.SaveChanges();
        }

        // PUT: api/NAHCategorie/5
        public void Put([FromBody]JObject value)
        {
        }

        // DELETE: api/NAHCategorie/5
        public void Delete(int id)
        {
        }
    }
}
