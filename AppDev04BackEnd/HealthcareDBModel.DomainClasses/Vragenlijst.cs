namespace HealthcareDBModel.DomainClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Vragenlijst")]
    public partial class Vragenlijst
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int VragenlijstId { get; set; }

        [StringLength(60)]
        public string Categorie { get; set; }
    }
}
