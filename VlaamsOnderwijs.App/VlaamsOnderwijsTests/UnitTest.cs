
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VlaamsOnderwijs.DAL;
using VlaamsOnderwijs.ef;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace VlaamsOnderwijsTests
{
    [TestClass]
    public class UnitTest1
    {
        private ISchoolRepository schoolRep;
        private School school;
        private List<School> schools;

        [TestInitialize]
        public void Initialize()
        {
            schoolRep = new SchoolRepository();
            school = new School();
            schools = new List<School>();
            //Assert.IsInstanceOfType(schoolRep, SchoolRepository);
            //Assert.A
        }


        [TestMethod]
        public void TestIfGetSchoolReturnsSchoolById()
        {
            school = schoolRep.GetSchoolById(0);
            Assert.AreEqual(0, school.Id);
        }

        [TestMethod]
        public async Task TestIfGetSchoolReturnsSchools()
        {
            schools = await schoolRep.GetSchools(0, 2);
            school = schoolRep.GetSchoolById(0);
            CollectionAssert.Contains(schools, school);
            //CollectionAssert.AllItemsAreInstancesOfType(schools, School);
        }
    }



}

