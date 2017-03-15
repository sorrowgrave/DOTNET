namespace HealthcareDBModel.DomainClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Uitslag")]
    public partial class Uitslag
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Date { get; set; }

        public TimeSpan Hour { get; set; }

        public bool Availability { get; set; }

        public bool ClientIngevuld { get; set; }

        public bool ZorgerIngevuld { get; set; }

        [StringLength(10)]
        public string ClientLeeftijd { get; set; }

        [StringLength(10)]
        public string ZorgerLeeftijd { get; set; }

        [StringLength(50)]
        public string Relatie { get; set; }

        [Required]
        [StringLength(150)]
        public string Informatie { get; set; }

        public bool Geldig { get; set; }

        public int? ClientUrl { get; set; }

        public int? ZorgerUrl { get; set; }

        public int VragenlijstId { get; set; }
    }
}
