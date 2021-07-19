using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    class PointFactory 
    {
        public static Point NewCartesianPoint(float x, float y)
        {
            return new Point(x, y); // needs to be public
        }
        // same for NewPolarPoint
    }
}
