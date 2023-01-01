using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.DLL.Entities
{
    public class Shipper : Entity
    {
        public Shipper()
        {

        }
        public Shipper(int id, DateTime createTime) : base(id, createTime)
        {

        }

        private string companyname;
        public string CompanyName { get => companyname; set => companyname = value; }

        private string phone;
        public string Phone { get => phone; set => phone = value; }
    }
}
