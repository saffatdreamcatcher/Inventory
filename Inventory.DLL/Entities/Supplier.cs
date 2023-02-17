using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.DLL.Entities
{
    public class Supplier : Entity
    {

        public Supplier()
        {

        }
        public Supplier(int id, DateTime createTime) : base(id, createTime)
        {

        }

        private string name;
        public string Name { get => name; set => name = value; }


        private string contact;
        public string Contact { get => contact; set => contact = value; }

        private string contacttitle;
        public string ContactTitle { get => contacttitle; set => contacttitle = value; }

        private string address;
        public string Address { get => address; set => address = value; }

        private string city;
        public string City { get => city; set => city = value; }

        private string postalcode;
        public string PostalCode { get => postalcode; set => postalcode = value; }

        private string region;
        public string Region { get => region; set => region = value; }

        private string country;
        public string Country { get => country; set => country = value; }

        private string phone;
        public string Phone { get => phone; set => phone = value; }

        private string fax;
        public string Fax { get => fax; set => fax = value; }

        private string homepage;
        public string HomePage { get => homepage; set => homepage = value; }

       

    }
}

