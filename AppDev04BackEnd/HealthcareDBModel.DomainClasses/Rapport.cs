namespace HealthcareDBModel.DomainClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Rapport")]
    public partial class Rapport
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RapportId { get; set; }

        public int? AntwLijstClient { get; set; }

        public int? AntwLijstMantelzorger { get; set; }
    }
}
