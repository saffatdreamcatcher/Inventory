using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.DLL.Entities
{
    public class Categories : Entity
    {
        public Categories()
        {

        }
        public Categories(int id, DateTime createTime) : base(id, createTime)
        {

        }

        private string name;
        public string Name { get => name; set => name = value; }

        private string description;
        public string Description { get => description; set => description = value; }

        private byte[] picture ;
        public byte[] Picture { get => picture; set => picture = value; }

    }
}
