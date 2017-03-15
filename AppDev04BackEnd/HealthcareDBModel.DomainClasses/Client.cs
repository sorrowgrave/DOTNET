namespace HealthcareDBModel.DomainClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Client")]
    public partial class Client
    {
        public int ClientId { get; set; }

        [StringLength(3)]
        public string LeeftijdsCategorie { get; set; }

        [StringLength(30)]
        public string RelatieMantelzorger { get; set; }
    }
}
