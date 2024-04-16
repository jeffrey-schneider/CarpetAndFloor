using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpetAndFloor
{
    /***
     * Floor type - identifies the type of floor by material and price
     * material is: 
     *   Hardwood, Engineered Wood, Laminate, etc.
     *   Price is square foot based
     */
    class FloorType
    {
        private String name;               
        private String ctgry;
        private decimal price;
        private double length;
        private double width;
        private bool installed;        
        private decimal labor;


        public FloorType()
        {

        }
        public FloorType(string name,  string ctgry, decimal price)
        {
            this.Name = name;
            this.Ctgry = ctgry;
            this.Price = price;
            this.Installed = false;
        }

        public string Name { get => name; set => name = value; }
        public string Ctgry { get => ctgry; set => ctgry = value; }
        public decimal Price { get => price; set => price = value; }
        public double Length { get => length; set => length = value; }
        public double Width { get => width; set => width = value; }
        
        public decimal Cost
        {
            get
            {
                return ((decimal)(Length * Width) * Price);

            }
        }

        public double Area { 
            get
            {
                return Length * Width;
            } 
        }

        public double AreaSqYards
        {
            get
            {
                return Area * 0.111;
            }
        }

        public bool Installed {  set => installed = value; }
        public decimal Labor { get => labor; set => labor = value; }
        

        public decimal TotalCost
        {
            get
            {
                return Cost + Labor;
            }
        }

        public override string ToString()
        {
            return Name + " " + Ctgry + " " + Price;
        }

        public string ToStringDetail()
        {
            return "Flooring Name:    " + Name + Environment.NewLine + 
                "Desc:                " + Ctgry + Environment.NewLine + 
                "Price:               " + Price + Environment.NewLine +
                "Area (Ft):           " + Area + Environment.NewLine +
                "Area (Yd):           " + AreaSqYards + Environment.NewLine +
                "Cost (Materials):    " + Cost + Environment.NewLine +
                "Installation(Labor): " + Labor + Environment.NewLine + 
                "Total:               " + TotalCost;
        }
    }


}
