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
    public class ClientController : ApiController
    {

        private HealthcareDB _db;

        public ClientController()
        {
            _db = new HealthcareDB();
        }

        //GET: api/Client
        public IEnumerable<Client> Get()
        {
            return _db.Client;
        }

        [Route("api/Client/{id}")]
        public IHttpActionResult GetClientById(int id)
        {
            var client = (_db.Client.Where(c => c.ClientId == id));
            if (client == null)
            {
                return NotFound();
            }
            return Ok(client);
        }


        // POST: api/Client
        public void Post([FromBody]JObject value)
        {
            Client client = value.ToObject<Client>();
            _db.Client.Add(client);
            _db.SaveChanges();
        }

        // PUT: api/Client/5
        public void Put([FromBody]JObject value)
        {
        }

        // DELETE: api/Client/5
        public void Delete(int id)
        {
        }
    }
}
