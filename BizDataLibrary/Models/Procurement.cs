namespace BizDataLibrary.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Procurement")]
    public partial class Procurement
    {
        public int ProcurementId { get; set; }

        [Required]
        [StringLength(10)]
        public string PartNo { get; set; }

        public DateTime PurchasingDay { get; set; }

        public int Quantity { get; set; }

        public int UintPrice { get; set; }

        public int InvetoryQuantity { get; set; }
    }
}
