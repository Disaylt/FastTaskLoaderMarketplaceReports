using ClosedXML.Excel;
using FastTaskLoaderMarketplaceReports.Models.Wb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastTaskLoaderMarketplaceReports
{
    internal class WbExcelReport
    {
        private readonly List<WbStockModel> _wbStocks;

        public WbExcelReport(List<WbStockModel> wbStocks)
        {
            _wbStocks = wbStocks;
        }

        public void CreateExcel(string fileName)
        {
            IXLWorkbook xLWorkbook = new XLWorkbook();
            IXLWorksheet workSheet = xLWorkbook.Worksheet("Stats");
            foreach(WbStockModel wbStock in _wbStocks)
            {
                
            }

        }
    }
}
