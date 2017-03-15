namespace HealthcareDBModel.DomainClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Relatie")]
    public partial class Relatie
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string naam { get; set; }
    }
}
