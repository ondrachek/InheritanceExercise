using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animal
    
     public Bird()
    {
        IsAlive = true;
        LegCount = 2;
        Age = 0;
        LandSeaAir = "Air";
    }

    public string WingColor { get; set; }
    public bool CanFly { get; set; }
    public bool WillMigrate { get; set; }
    public double BeakLengthg { get; set; }
}
