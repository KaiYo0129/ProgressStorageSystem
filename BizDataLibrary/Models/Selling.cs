namespace BizDataLibrary.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Selling")]
    public partial class Selling
    {
        public int SellingId { get; set; }

        public int SalesJobNumber { get; set; }

        [Required]
        [StringLength(10)]
        public string PartNo { get; set; }

        public DateTime SellingDay { get; set; }

        public int Quantity { get; set; }

        public int UnitPrice { get; set; }
    }
}
