using Inventory.DLL.Entities;
using Inventory.DLL.Repositories;
using System;
using System.Collections.Generic;

namespace Inventory.BLL.BusinessLogic
{
  public class ProductBLL
  {
    public int Save(Product product)
    {
      try
      {
        var productDLL = new ProductDLL();
        return productDLL.Save(product);
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }
    public List<Product> GetAll(string whereclause = "")
    {
      try
      {
        var productDLL = new ProductDLL();
        return productDLL.GetAll(whereclause);
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

        public Product GetById(int id)
        { 
        try
            {
                var productDLL = new ProductDLL();    
                return productDLL.GetById(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int GetCount(string whereclause = "")
        {
            try
            {
                var productDLL = new ProductDLL();
                return productDLL.GetCount (whereclause);
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
        var productDLL = new ProductDLL();
        return productDLL.Delete(id);
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

  }
}
