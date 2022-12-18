using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.DLL.Entities
{
    public class Customer : Entity
    {
      public Customer ()
        {

        }
        public Customer(int id, DateTime createTime) : base(id, createTime)
        {

        }

        private string name;
        public string Name { get => name; set => name = value; }


        private string contact;
        public string Contact
        {
            get => contact; set => contact = value;
        }

        private string address;
        public string Address { get => address; set => address = value; }

        private string city;
        public string City { get => city; set => city = value; }

        private string postalcode;
        public string PostalCode { get => postalcode; set => postalcode = value; }

        private string country;
        public string Country { get => country; set => country = value; }
    }
}
