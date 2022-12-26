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

        public List<Region> GetAll()
        {
            try
            {
                var regionDLL = new RegionDLL();
                return regionDLL.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Region GetById()
        {
            try
            {
                var regionDLL = new RegionDLL();
                return regionDLL.GetById(0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int GetCount(Region region)
        {
            try
            {
                var regionDLL = new RegionDLL();
                return regionDLL.GetCount();
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
