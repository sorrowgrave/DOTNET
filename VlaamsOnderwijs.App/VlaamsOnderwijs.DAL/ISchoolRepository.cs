using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using VlaamsOnderwijs.ef;

namespace VlaamsOnderwijs.DAL
{
    public interface ISchoolRepository
    {
        void DeleteSchool(School school);
        School GetSchoolById(int id);
        Task<List<School>> GetSchools(int start, int end);
        void UpdateSchool(School school);
    }
}
