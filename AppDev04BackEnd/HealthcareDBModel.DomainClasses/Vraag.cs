namespace HealthcareDBModel.DomainClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Vraag")]
    public partial class Vraag
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int VraagNr { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int VragenlijstId { get; set; }

        [StringLength(300)]
        public string VraagStr { get; set; }

        public byte[] VraagPicture { get; set; }
    }
}
