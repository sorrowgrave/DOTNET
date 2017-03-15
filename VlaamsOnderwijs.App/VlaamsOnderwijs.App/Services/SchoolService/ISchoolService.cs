using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VlaamsOnderwijs.ef;

namespace VlaamsOnderwijs.App.Services.SchoolService
{
    public interface ISchoolService
    {
        Task<ObservableCollection<School>> GetSchools(int start, int end);
    }
}
