using Inventory.DLL.Entities;
using Inventory.DLL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.BLL.BusinessLogic
{
    public class CustomerBLL
    {

        public int Save(Customer customer)
        {
            try
            {
                var customerDLL = new CustomerDLL();
                return customerDLL.Save(customer);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Customer> GetAll(string whereclause = "")
        {
            try
            {
                var customerDLL = new CustomerDLL();
                return customerDLL.GetAll(whereclause);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Customer GetById(int id)
        {
            try
            {
                var customerDLL = new CustomerDLL();
                return customerDLL.GetById(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int GetCount(Customer customer)
        {
            try
            {
                var customerDLL = new CustomerDLL();
                return customerDLL.GetCount();
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
                var customerDLL = new CustomerDLL();
                //int d = customerDLL.Delete(id);
                //return d;
                return customerDLL.Delete(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}