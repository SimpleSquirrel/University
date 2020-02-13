using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB10EX1
{
    public interface Get_Info
    {
        string name { get; set; }
        string address { get; set; }
        int Get_Population();
        string Get_Area();
    }
}
