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
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AppDev04BackEnd.Controllers
{
    public class UitslagenController : ApiController
    {

        private HealthcareDB _db;
     
        // GET: api/Uitslagen
        public UitslagenController()
        {
            _db = new HealthcareDB();
        }

        // GET: api/Uitslagen/
        public IEnumerable<Uitslag> Get()
        {
            return _db.Uitslag;
        }

        // POST: api/Uitslagen
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Uitslagen/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Uitslagen/5
        public void Delete(int id)
        {
        }
    }
}
