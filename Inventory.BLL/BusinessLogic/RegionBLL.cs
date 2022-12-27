using Inventory.DLL.Entities;
using Inventory.DLL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.BLL.BusinessLogic
{
    public class RegionBLL
    {
        public int Save(Region region)
        {
            try
            {
                var regionDLL = new RegionDLL();
                return regionDLL.Save(region);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Region> GetAll(string where = "")
        {
            try
            {
                var regionDLL = new RegionDLL();
                return regionDLL.GetAll(where);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Region GetById(int id)
        {
            try
            {
                var regionDLL = new RegionDLL();
                return regionDLL.GetById(id);
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
                var regionDLL = new RegionDLL();
                return regionDLL.GetCount(whereClause);
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
                var regionDLL = new RegionDLL();
                //int d = regionDLL.Delete(id);
                //return d;
                return regionDLL.Delete(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
