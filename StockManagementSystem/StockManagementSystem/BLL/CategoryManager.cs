using StockManagementSystem.Model;
using StockManagementSystem.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.BLL
{
  
        public class CategoryManager
        {
            CategoryRepository _categoryRepository = new CategoryRepository();

            public List<Category> GetAllCategory()
            {

                return _categoryRepository.GetAllCategory();
            }
        }

    
}
