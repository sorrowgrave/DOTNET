namespace OefenExamen.DomainClasses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Categories
    {
        private ICollection<Products> products;
        public Categories()
        {
            products = new HashSet<Products>();
        }

        [Key]
        [StringLength(10)]
        public string CategoryID { get; set; }

        [Required]
        [StringLength(15)]
        public string ShortName { get; set; }

        [Required]
        [StringLength(50)]
        public string LongName { get; set; }

        public virtual ICollection<Products> Products { get { return products; } set { products = value; } }
    }
}
