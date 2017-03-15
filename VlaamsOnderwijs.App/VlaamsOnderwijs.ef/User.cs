using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VlaamsOnderwijs.ef
{
    public class User
    {
        public int Id { get; set; }
        public int SchoolId { get; set; }
        public string Password { get; set; }
        public School School { get; set; }
    }
}
