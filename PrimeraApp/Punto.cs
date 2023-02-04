using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraApp
{
    internal class Punto
    {
        private int x, y;
        public Punto(int x, int y) 
        {   
            this.x = x;
            this.y = y;
        }

        public double DistanciaHasta(Punto punto)
        {
            int xdiff = this.x - punto.x;
            int ydiff = this.y - punto.y;
            return Math.Sqrt(Math.Pow(xdiff, 2) + Math.Pow(ydiff, 2));
        }

    }
}
