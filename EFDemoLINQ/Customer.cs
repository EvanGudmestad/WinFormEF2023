using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemoLINQ
{
    public class Customer
    {
        //Coding by Convention
        //EF automatically makes this a PK in the Customer table
        //Auto incrementing
        public int CustomerId { get; set; }

        public string CustomerName { get; set; } = string.Empty;
        public double Budget { get; set; } = 0;

        public override string ToString()
        {
            return $"{CustomerName} has a budget of {Budget:C}\n";
        }


    }
}
