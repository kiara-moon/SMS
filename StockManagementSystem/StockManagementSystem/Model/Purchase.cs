using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Model
{
    class Purchase
    {
        public int ID { set; get; }
        public string Date { set; get; }
        public string BillNo { set; get; }
        public int CateogoryID { set; get; }
        public int SupplierID { set; get; }
        public int ProductID { set; get; }
        public int PurchaseQuantity { set; get; }
        public int AvailableQuantity { set; get; }
        public int ExpiredDate { set; get; }
        public string ManuDate { set; get; }
        public int UnitPrice { set; get; }
        public double MRP { set; get; }
        public string Remarks { set; get; } 


    }
}
