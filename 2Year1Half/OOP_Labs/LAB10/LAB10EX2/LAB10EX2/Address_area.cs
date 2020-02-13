using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB10EX2
{
    interface Address_area : Name_population
    {
        string address { get; set; }
        string Get_Area();
    }
}
