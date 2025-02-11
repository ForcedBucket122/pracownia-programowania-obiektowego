using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trojkat_w_ukladzie_wspolrzednych
{
    internal class Punkt
    {
        private double x,y;
        
        public double getX()
        {
            return x;
        }
        public double getY()
        {
            return y;
        }
        public void setX(double x)
        {
            this.x = x;
        }
        public void setY(double y)
        {
            this.y = y;
        }
    }
}
