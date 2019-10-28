using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.BLL;
using StockManagementSystem.Model;
using StockManagementSystem.Repository;
namespace StockManagementSystem.BLL
{
    class NewPurchaseManager
    {
        public List<Supplier> SupplierComboItem()

        {
            NewPurchaseRepository _newPurchaseRepository = new NewPurchaseRepository();
            return _newPurchaseRepository.SupplierComboItem();
        }

        public List<Category> CategoryComboItem()

        {
            NewPurchaseRepository _newPurchaseRepository = new NewPurchaseRepository();
            return _newPurchaseRepository.CategoryComboItem();
        }

        public List<Product> GetProductFromCategory(int categoryId)
        {
            NewPurchaseRepository _newPurchaseRepository = new NewPurchaseRepository();
            return _newPurchaseRepository.GetProductFromCategory(categoryId);
        }

        public Product SearchProductById(int id)
        {
            NewPurchaseRepository _newPurchaseRepository = new NewPurchaseRepository();
            return _newPurchaseRepository.SearchProductById(id);
        }

        public NewPurchase LastPurchaseInfo(int productId)
        {
            NewPurchaseRepository _newPurchaseRepository = new NewPurchaseRepository();
            return _newPurchaseRepository.LastPurchaseInfo(productId);
        }

        public int AvailableQuantity(int productId)
        {
            NewPurchaseRepository _newPurchaseRepository = new NewPurchaseRepository();
            return _newPurchaseRepository.AvailableQuantity(productId);
        }

        public bool AddPurchase(List<NewPurchase> purchases)
        {
            bool isAdded = false;
            NewPurchaseRepository _newPurchaseRepository = new NewPurchaseRepository();
            foreach (NewPurchase newPurchase in purchases)
            {
                isAdded = _newPurchaseRepository.AddPurchase(newPurchase);
            }

            return isAdded;
        }


    }

}
