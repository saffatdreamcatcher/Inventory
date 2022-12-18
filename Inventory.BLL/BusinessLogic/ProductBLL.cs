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
    public List<Product> GetAll()
    {
      try
      {
        var productDLL = new ProductDLL();
        return productDLL.GetAll();
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

        public Product GetById()
        { 
        try
            {
                var productDLL = new ProductDLL();    
                return productDLL.GetById(0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int GetCount(Product product)
        {
            try
            {
                var productDLL = new ProductDLL();
                return productDLL.GetCount ();
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
