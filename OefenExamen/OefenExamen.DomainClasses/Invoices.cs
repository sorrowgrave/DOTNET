namespace OefenExamen.DomainClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Invoices
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Invoices()
        {
            LineItems = new HashSet<LineItems>();
        }

        [Key]
        public int InvoiceNumber { get; set; }

        [Required]
        [StringLength(25)]
        public string CustEmail { get; set; }

        public DateTime OrderDate { get; set; }

        [Column(TypeName = "money")]
        public decimal Subtotal { get; set; }

        [Required]
        [StringLength(50)]
        public string ShipMethod { get; set; }

        [Column(TypeName = "money")]
        public decimal Shipping { get; set; }

        [Column(TypeName = "money")]
        public decimal SalesTax { get; set; }

        [Column(TypeName = "money")]
        public decimal Total { get; set; }

        [Required]
        [StringLength(10)]
        public string CreditCardType { get; set; }

        [Required]
        [StringLength(20)]
        public string CardNumber { get; set; }

        public short ExpirationMonth { get; set; }

        public short ExpirationYear { get; set; }

        public virtual Customers Customers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LineItems> LineItems { get; set; }
    }
}
