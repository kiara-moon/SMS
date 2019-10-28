using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Model
{
    class NewPurchase
    {
        public int ID { set; get; }
        public string Date { set; get; }
        public string BillNo { set; get; }
        public int SupplierID { get; set; }
        public int ProductID { get; set; }
       
        public string ManuDate { set; get; }
        public string ExpiredDate { set; get; }
     
        public int PurchaseQuantity { get; set; }
        public double UnitPrice { get; set; }
        public double MRP { get; set; } 
    }
}
