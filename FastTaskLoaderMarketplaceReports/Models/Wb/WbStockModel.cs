using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastTaskLoaderMarketplaceReports.Models.Wb
{
    internal class WbStockModel
    {
        public DateTime LastChangeDate { get; set; }
        public string SupplierArticle { get; set; } = "-";
        public string TechSize { get; set; } = "-";
        public string Barcode { get; set; } = "-";
        public int Quantity { get; set; }
        public bool IsSupply { get; set; }
        public bool IsRealization { get; set; }
        public int QuantityFull { get; set; }
        public string WarehouseName { get; set; } = "-";
        public int NmId { get; set; }
        public string Subject { get; set; } = "-";
        public string Category { get; set; } = "-";
        public int DaysOnSite { get; set; }
        public string Brand { get; set; } = "-";
        public string SCCode { get; set; } = "-";
        public int Price { get; set; }
        public int Discount { get; set; }
    }
}
