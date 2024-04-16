using System;
using System.Text;

namespace CarpetAndFloor
{
    class Customer
    {
        private string name;
        private string addr;
        private string addr2;
        private string city;
        private string state;
        private string zip;

        public Customer()
        {

        }
        public Customer(string name, string addr, string addr2, string city, string state, string zip)
        {
            this.name = name;
            this.addr = addr;
            this.addr2 = addr2;
            this.city = city;
            this.state = state;
            this.zip = zip;
        }

        public string Name { get => name; set => name = value; }
        public string Addr { get => addr; set => addr = value; }
        public string Addr2 { get => addr2; set => addr2 = value; }
        public string City { get => city; set => city = value; }
        public string State { get => state; set => state = value; }
        public string Zip { get => zip; set => zip = value; }

        public override string ToString()
        {
            return Name + " " + Addr + " " + Addr2 + " " + City + " " + State + " " + Zip;
        }

        public string ToStringFormatted()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name + Environment.NewLine);
            sb.Append(Addr + Environment.NewLine);
            sb.Append(Addr2 + Environment.NewLine);
            sb.Append(City + " " + State + " " + Zip);
            return sb.ToString();

        }
    }
}
