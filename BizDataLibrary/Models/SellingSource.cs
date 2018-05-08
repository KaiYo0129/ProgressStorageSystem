namespace BizDataLibrary.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SellingSource")]
    public partial class SellingSource
    {
        public int Id { get; set; }

        public int SellingId { get; set; }

        public int ProcurementId { get; set; }

        public int Quantity { get; set; }
    }
}
