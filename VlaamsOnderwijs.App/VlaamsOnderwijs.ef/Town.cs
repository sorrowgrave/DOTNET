using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VlaamsOnderwijs.ef
{
    public class Town
    {
        [Key]
        public string ZipCode { get; set; }
        public string TownName { get; set; }
        public int ProvinceId { get; set; }
        public Province Province { get; set; }
    }
}
