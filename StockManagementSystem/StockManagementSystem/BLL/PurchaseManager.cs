using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.Model;
using StockManagementSystem.Repository;
using System.Data;

namespace StockManagementSystem.BLL
{
    class PurchaseManager
    {
        //public List<Category> GetAllCategoryFromComboBox()
        //{
        //    CategoryRepository _categoryRepository = new CategoryRepository();
        //    return _categoryRepository.GetAllCategoryFromComboBox();
        //}
        PurchaseRepository _purchaseRepository = new PurchaseRepository();

        public DataTable GetSupplierComboBox()
        {

            SupplierRepository _supplierRepository = new SupplierRepository();
            return _supplierRepository.Display();
        }

        public List<Category> GetAllCategory()
        {

            CategoryRepository _categoryRepository = new CategoryRepository();
            return _categoryRepository.GetAllCategory();
        }

        public DataTable ShowProduct()
        {
            PurchaseRepository _purchaseRepository = new PurchaseRepository();
            
            return _purchaseRepository.ShowProduct();

        }

        public DataTable GetProduct(Purchase purchase)

        {
            PurchaseRepository _purchaseRepository = new PurchaseRepository();

            return _purchaseRepository.GetProduct(purchase);

        }

        //public DataTable GetCategory(Purchase purchase)
        //{
        //    PurchaseRepository _purchaseRepository = new PurchaseRepository();
        //    return _purchaseRepository.GetCategory(purchase);
        //}

        public string GetProductCode(int productId)
        {
            PurchaseRepository _purchaseRepository = new PurchaseRepository();
            return _purchaseRepository.GetProductCode(productId);
        }






        //public List<Product> GetProductFromComboBox()
        //{

        //    CategoryRepository _categoryRepository = new CategoryRepository();

        //    return _categoryRepository.GetProductFromComboBox();

        //}



        //public bool ViewQuantity(string productCombo,int quantity,int prevMRP,int prevUnitPrice)
        //{
        //    return true;
        //}



    }
}
