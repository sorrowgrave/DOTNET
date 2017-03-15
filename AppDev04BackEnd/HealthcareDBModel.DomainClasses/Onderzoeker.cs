namespace HealthcareDBModel.DomainClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Onderzoeker")]
    public partial class Onderzoeker
    {
        public int OnderzoekerId { get; set; }

        [Required]
        [StringLength(30)]
        public string Naam { get; set; }

        [Required]
        [StringLength(30)]
        public string Voornaam { get; set; }

        [Required]
        [StringLength(60)]
        public string Email { get; set; }

        [Required]
        [StringLength(16)]
        public string Password { get; set; }
    }
}
