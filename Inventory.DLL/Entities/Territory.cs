using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.DLL.Entities
{
    public class Territory : Entity
    {
        //below constructor without parameter
        public Territory()
        {

        }
        public Territory(int id, DateTime createTime) : base(id, createTime)   //constructor with parameter
        {

        }

        private string description;
        public string Description { get => description; set => description = value; }

        private int regionId;  //field
        public int RegionId { get => regionId; set => regionId = value; }   //propery= RegionId

        private string regionName;

        public string RegionName { get => regionName; set => regionName = value; }
    }
}
