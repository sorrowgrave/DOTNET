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
using System.Configuration;
using System.Web.Services;
using RestSharp;
using System.Text.RegularExpressions;

namespace AppDev04BackEnd.Controllers
{
    public class HulpverlenerController : ApiController
    {

        private HealthcareDB _db;
     
        public HulpverlenerController()
        {
            _db = new HealthcareDB();
        }


         //GET: api/Hulpverlener
        public IEnumerable<Hulpverlener> Get()
        {
            return _db.Hulpverlener;
        }

        [WebMethod]
        [Route("api/Hulpverlener/{email}")]
        public IHttpActionResult GetHulpverlenerByEmail(string email)
        {
            var hulpverlener = _db.Hulpverlener;
            foreach(var hulp in hulpverlener){
                string emaildb = Regex.Replace(hulp.Email , "[.,]", "");
                if(emaildb.Equals(email)){
                    return Ok(hulp);
                }
            }
            return NotFound();
        }


        // POST: api/Hulpverlener
        public void Post([FromBody]JObject value)
        {
            Hulpverlener hulpverlener = value.ToObject<Hulpverlener>();
            _db.Hulpverlener.Add(hulpverlener);
            _db.SaveChanges();
        }

        // PUT: api/Hulpverlener/5
        public void Put(Parameter p)
        {
            Migrations.Configuration config = new Migrations.Configuration();
            
            JToken token = JObject.Parse(p.Value.ToString());
            
            Hulpverlener hulpverlener = token.ToObject<Hulpverlener>();
            config.Seed(hulpverlener);

            //HealthcareDB context = new HealthcareDB();
            //SqlParameter pic = new SqlParameter("@p0", SqlDbType.VarBinary, 800000);
            //pic.Value = hulpverlener.Picture;
            
            //context.Database.ExecuteSqlCommand("UPDATE Hulpverleners " +
            //    "SET Picture = @p0 " +
            //    "WHERE HulpverlenerId = @p1", pic, new SqlParameter("@p1", hulpverlener.HulpverlenerId));
            //_db.SaveChanges();
        }

        // DELETE: api/Hulpverlener/5
        public void Delete(int id)
        {
        }
    }
}
