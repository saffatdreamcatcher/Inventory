using Inventory.DLL.Entities;
using Inventory.DLL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.BLL.BusinessLogic
{
    public class ShipperBLL
    {
        public int Save(Shipper shipper)
        {
            try
            {
                var shipperDLL = new ShipperDLL();
                return shipperDLL.Save(shipper);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Shipper> GetAll(string where = "")
        {
            try
            {
                var shipperDLL = new ShipperDLL();
                return shipperDLL.GetAll(where);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Shipper GetById(int id)
        {
            try
            {
                var shipperDLL = new ShipperDLL();
                return shipperDLL.GetById(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int GetCount(string whereClause = "")
        {
            try
            {
                var shipperDLL = new ShipperDLL();
                return shipperDLL.GetCount(whereClause);
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
                var shipperDLL = new ShipperDLL();
                return shipperDLL.Delete(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
