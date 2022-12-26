using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.DLL.Entities
{
    public class Region: Entity
    { 
    public  Region()
    {
     
    }
    public Region(int id, DateTime createTime) : base(id, createTime)
    {

    }

    private string description;
    public string Description { get => description; set => description = value; }
}
}
