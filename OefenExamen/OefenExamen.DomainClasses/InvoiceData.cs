namespace OefenExamen.DomainClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InvoiceData")]
    public partial class InvoiceData
    {
        [Key]
        [Column(TypeName = "money")]
        public decimal SalesTax { get; set; }
    }
}
