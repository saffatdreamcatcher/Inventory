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

        public List<Supplier> GetAll()
        {
            try
            {
                var supplierDLL = new SupplierDLL();
                return supplierDLL.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Supplier GetById()
        {
            try
            {
                var supplierDLL = new SupplierDLL();
                return supplierDLL.GetById(0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int GetCount(Supplier supplier)
        {
            try
            {
                var supplierDLL = new SupplierDLL();
                return supplierDLL.GetCount();
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
