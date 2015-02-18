using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayProject
{
    public abstract class CargoVagon : Vagon
    {
        public CargoVagon(int length, int width, int height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }
    }
}
