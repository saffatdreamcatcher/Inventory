using Inventory.DLL.Entities;
using Inventory.DLL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.BLL.BusinessLogic
{
    public class CategoriesBLL
    {
        public int Save(Categories categories) 
        {
            try
            {
                CategoriesDLL categoriesDLL = new CategoriesDLL();
                return categoriesDLL.Save(categories);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Categories> GetAll()
        {
            try
            {
                CategoriesDLL categoriesDLL = new CategoriesDLL();
                return categoriesDLL.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Categories GetById()
        {
            try
            {
                CategoriesDLL categoriesDLL = new CategoriesDLL();
                return categoriesDLL.GetById(0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int GetCount(Categories categories)
        {
            try
            {
                var categoriesDLL = new CategoriesDLL();
                return categoriesDLL.GetCount();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public int Delete(int id)
        {
            try
            {
                var categoriesDLL = new CategoriesDLL();
                //int d = categoriesDLL.Delete(id);
                //return d;
                return categoriesDLL.Delete(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
