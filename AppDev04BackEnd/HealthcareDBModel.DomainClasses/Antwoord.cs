namespace HealthcareDBModel.DomainClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Antwoord")]
    public partial class Antwoord
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int VraagNr { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AntwoordenlijstId { get; set; }

        [Required]
        [StringLength(45)]
        public string AntwoordCode { get; set; }

        public byte HulpNodig { get; set; }
    }
}
