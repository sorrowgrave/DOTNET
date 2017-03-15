using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using VlaamsOnderwijs.ef;
using Windows.Data.Json;

namespace VlaamsOnderwijs.DAL
{
    public class SchoolRepository : ISchoolRepository
    {
        private static List<School> schools;
        APIRequest apiRequest;

        public SchoolRepository()
        {
            apiRequest = new APIRequest();
            //LoadSchools();
        }

        public async Task<List<School>> GetSchools(int start, int end)
        {
            if (schools == null)
            {
                //string jsonString = await apiRequest.getResponse("school?zitCode=3500");
                string jsonString = await apiRequest.getResponse("school?min=" + start + "&max=" + end);
                schools = JsonConvert.DeserializeObject<List<School>>(jsonString);
            }

            return schools;
        }

        public School GetSchoolById(int id)
        {
            if (schools == null)
                LoadSchools();
            return schools.Where(c => c.Id == id).FirstOrDefault();
        }

        public void DeleteSchool(School school)
        {
            schools.Remove(school);
        }

        public void UpdateSchool(School school)
        {
            School schoolToUpdate = schools.Where(c => c.Id == school.Id).FirstOrDefault();
            schoolToUpdate = school;
        }

        private void LoadSchools()
        {

            schools = new List<School>()
        {
            new School()
            {
                Id = 0,
                Image = "../assets/index.jpg",
                Name = "handelsschool hasselt",
                Description = "een school voor handel gerelateerde vakken in hasselt.",
                Email = "phhasselt@limburg.be",
                Street = "gouverneur verwilghensingel",
                Number = "1",
                //Zipcode = "3500",
                Phone = "011 26 72 11",
                Principle = "annaert peter",
                Website = "http://www.handelsschoolhasselt.be/"
            },
            new School()
            {
                Id = 1,
                Image = "../assets/sint-franciscuscollege.jpg",
                Name = "sint - franciscuscollege",
                Description = "katolieke school te heusden.",
                Email = "info@sfc.be",
                Street = "minderbroedersstraat",
                Number = "11",
                //zipcode = "3550",
                Phone = "011 52 07 20",
                Principle = "eddy willems",
                Website = "http://www.sfc.be/"
            },
            //new School()
            //{
            //    id = 2,
            //    image = "../assets/bobross.jpg",
            //    name = "painting happy trees",
            //    description = "the joy of painting.",
            //    email = "bobross@gmail.com",
            //    street = "somewhere in orlando, florida",
            //    number = "0",
            //    zipcode = "9999",
            //    phone = "999 99 99 99",
            //    principle = "bob ross",
            //    website = "https://en.wikipedia.org/wiki/the_joy_of_painting"
            //},
            //new School()
            //{
            //    image = "../assets/index.jpg",
            //    name = "handelsschool hasselt",
            //    description = "een school voor handel gerelateerde vakken in hasselt.",
            //    email = "phhasselt@limburg.be",
            //    street = "gouverneur verwilghensingel",
            //    number = "1",
            //    zipcode = "3500",
            //    phone = "011267211",
            //    principle = "annaert peter",
            //    website = "http://www.sfc.be/"
            //}


            };

        }

    }
}