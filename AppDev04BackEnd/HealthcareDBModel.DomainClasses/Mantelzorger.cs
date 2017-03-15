namespace HealthcareDBModel.DomainClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Mantelzorger")]
    public partial class Mantelzorger
    {
        public int MantelzorgerId { get; set; }

        [Required]
        [StringLength(3)]
        public string LeeftijdsCategorie { get; set; }
    }
}
