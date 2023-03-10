using Inventory.DLL.Entities;
using Inventory.DLL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.BLL.BusinessLogic
{
    public class SupplierBLL
    {

        public int Save(Supplier supplier)
        {
            try
            {
                var supplierDLL = new SupplierDLL();
                return supplierDLL.Save(supplier);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Supplier> GetAll(string whereclause= "")
        {
            try
            {
                var supplierDLL = new SupplierDLL();
                return supplierDLL.GetAll(whereclause);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Supplier GetById(int id)
        {
            try
            {
                var supplierDLL = new SupplierDLL();
                return supplierDLL.GetById(id);
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
                var supplierDLL = new SupplierDLL();
                return supplierDLL.GetCount(whereclause);
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
                var supplierDLL = new SupplierDLL();
                //int d = supplierDLL.Delete(id);
                //return d;
                return supplierDLL.Delete(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
