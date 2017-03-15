using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VlaamsOnderwijs.ef
{
    public class Rating
    {
        [Key]
        public int SchoolId { get; set; }
        public int Accessibility { get; set; }
        public int Facilities { get; set; }
        public int LevelOfClasses { get; set; }
        public School School { get; set; }
    }
}
