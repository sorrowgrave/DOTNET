using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template10.Utils;
using VlaamsOnderwijs.DAL;
using VlaamsOnderwijs.ef;

namespace VlaamsOnderwijs.App.Services.SchoolService
{
    public partial class SchoolService : ISchoolService
    {
        private static ObservableCollection<School> _schools;
        ISchoolRepository schoolRep;

        public SchoolService (ISchoolRepository schoolRep)
        {
            this.schoolRep = schoolRep;
        }

        public async Task<ObservableCollection<School>> GetSchools(int start, int end)
        {
            if (_schools != null)
                return _schools;
            return _schools = _schools
                ?? (await schoolRep.GetSchools(start, end)).ToObservableCollection();
        }
    }
}
