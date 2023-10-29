using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal interface IEngine
    {
        int HorsePower { get; set; }
        int TankSize { get; set; }
        int CurrentOil { get; set; }
        string FuelType { get; set; }
    }
}
