namespace OefenExamen.DomainClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LineItems
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int InvoiceNumber { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string ProductID { get; set; }

        [Column(TypeName = "money")]
        public decimal UnitPrice { get; set; }

        public int Quantity { get; set; }

        [Column(TypeName = "money")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? Extension { get; set; }

        public virtual Invoices Invoices { get; set; }

        public virtual Products Products { get; set; }
    }
}
