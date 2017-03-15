namespace HealthcareDBModel.DomainClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Antwoordenlijst")]
    public partial class Antwoordenlijst
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Antwoordenlijst()
        {
            Antwoord = new HashSet<Antwoord>();
        }

        public int AntwoordenlijstId { get; set; }

        public int VragenlijstId { get; set; }

        [Required]
        [StringLength(15)]
        public string BetrokkenPersoon { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Antwoord> Antwoord { get; set; }

        public virtual Vragenlijst Vragenlijst { get; set; }
    }
}
