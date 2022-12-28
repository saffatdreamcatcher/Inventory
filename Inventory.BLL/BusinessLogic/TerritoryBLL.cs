using Inventory.DLL.Entities;
using Inventory.DLL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.BLL.BusinessLogic
{
    public class TerritoryBLL
    {
       

        public int Save(Territory territory)
        {
            try
            {
                var territoryDLL = new TerritoryDLL();
                return territoryDLL.Save(territory);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Territory> GetAll()
        {
            try
            {
                var territoryDLL = new TerritoryDLL();
                return territoryDLL.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Territory GetById()
        {
            try
            {
                var territoryDLL = new TerritoryDLL();
                return territoryDLL.GetById(0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int GetCount(Territory territory)
        {
            try
            {
                var territoryDLL = new TerritoryDLL();
                return territoryDLL.GetCount();
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
                var territoryDLL = new TerritoryDLL();
                
                return territoryDLL.Delete(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        }
}
