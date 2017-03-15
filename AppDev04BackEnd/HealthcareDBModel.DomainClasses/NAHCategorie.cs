namespace HealthcareDBModel.DomainClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NAHCategorie")]
    public partial class NAHCategorie
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string naam { get; set; }
    }
}
