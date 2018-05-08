using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildSchoolBizApp.ViewModels
{
    public class SellingViewModel
    {
        public int SellingId { get; set; }
        public int SalesJobNumber { get; set; }
        public string PartNo { get; set; }
        public DateTime SellingDay { get; set; }
        public int Quantity { get; set; }
        public int UnitPrice { get; set; }
    }
}
