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
using System.Web.Script.Serialization;
using System.Web.Http.Cors;

namespace AppDev04BackEnd.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class VraagController : ApiController
    {
        private HealthcareDB _db;

        public VraagController()
        {
            _db = new HealthcareDB();
        }

        //GET: api/Vraag
        public IEnumerable<Vraag> Get()
        {
            return _db.Vraag;
        }

        [Route("api/Vraag/{id}")]
        [AcceptVerbs("OPTIONS")]
        [HttpGet]
        public IHttpActionResult GetVraagById(int id)
        {
            var vraag = (_db.Vraag.Where(c => c.VraagNr == id));
            if (vraag == null)
            {
                return NotFound();
            }
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            return Ok(serializer.Serialize(vraag));
        }

        [Route("api/Vraag/Vragenlijst/{id}")]
        public IHttpActionResult GetVraagByVragenlijstId(int id)
        {
            var vraag = (_db.Vraag.Where(c => c.VragenlijstId == id).ToList());
            if (vraag == null)
            {
                return NotFound();
            }
            return Ok(vraag);
        }

        [Route("api/Vraag/{vragenlijstid}/{id}")]
        public IHttpActionResult GetVraag(int id, int vragenlijstid)
        {

            var vraag = (_db.Vraag.Where(c => c.VragenlijstId == vragenlijstid).Where(v => v.VraagNr == id).Single<Vraag>());

            //var result = _db.Vraag.AsEnumerable().Join(_db.Vragenlijst.AsEnumerable(),
            //    v => v.VraagNr, vl => vl.VragenlijstId,
            //    (v, vl) => new {vraag = v});
            if (vraag == null)
            {
                return NotFound();
            }
            return Ok(vraag);
        }


        // POST: api/Vraag

        public void Post(Parameter p)
        {
            JArray array = JArray.Parse(p.Value.ToString());

            Vraag[] vragen = array.ToObject<Vraag[]>();
            //if (_db.Vragenlijst.Count() == 0)
            //{
            //    foreach (Vraag vraag in vragen)
            //    {
            //        vraag.VragenlijstId = 1;
            //    }
            //}
            //else
            //{
            //    foreach (Vraag vraag in vragen)
            //    {
            //        vraag.VragenlijstId = (from i in _db.Vragenlijst select i.VragenlijstId).Max();
            //    }
            //}
            int teller = 1;
            foreach (Vraag vraag in vragen)
            {
                vraag.VraagNr = teller++;
            }

            Migrations.Configuration config = new Migrations.Configuration();
            config.Seed(vragen);
        }

        [Route("api/Vraag/enkel/{vragenlijstid}")]
        public void Post(Parameter p, int vragenlijstId)
        {
            JObject obj = JObject.Parse(p.Value.ToString());

            Vraag vraag = obj.ToObject<Vraag>();

           vraag.VragenlijstId = vragenlijstId;

            Migrations.Configuration config = new Migrations.Configuration();
            config.Seed(vraag);
        }

        // PUT: api/Vraag
        public void Put(Parameter p)
        {
            Migrations.Configuration config = new Migrations.Configuration();

            JArray array = JArray.Parse(p.Value.ToString());

            Vraag[] vraag = array.ToObject<Vraag[]>();
            config.Seed(vraag);

        }

        [Route("api/Vraag/{vragenlijstid}")]
        public void Put(Parameter p, int vragenlijstId)
        {
            Migrations.Configuration config = new Migrations.Configuration();

            JArray array = JArray.Parse(p.Value.ToString());

            Vraag[] vragen = array.ToObject<Vraag[]>();

            int teller = 1;
            foreach (Vraag vraag in vragen)
            {
                vraag.VragenlijstId = vragenlijstId;
                vraag.VraagNr = teller++;
            }

            config.Seed(vragen);
        }

        // DELETE: api/Vraag/5
        [Route("api/Vraag/{vragenlijstId}/{id}")]
        public void Delete(int id, int vragenlijstId)
        {
            HealthcareDB context = new HealthcareDB();
            Migrations.Configuration config = new Migrations.Configuration();
            context.Database.ExecuteSqlCommand("DELETE FROM Vraag WHERE VraagNr=" + id + " AND VragenlijstId=" + vragenlijstId);
            Vraag[] vragen = (_db.Vraag.Where(c => c.VragenlijstId == vragenlijstId).ToArray<Vraag>());

            int teller = 1;
            foreach (Vraag vraag in vragen)
            {
                vraag.VragenlijstId = vragenlijstId;
                vraag.VraagNr = teller++;
            }

            config.Seed(vragen);
            context.Database.ExecuteSqlCommand("DELETE FROM Vraag WHERE VraagNr>" + vragen.Length + " AND VragenlijstId=" + vragenlijstId);
            context.SaveChanges();
        }
    }
}
