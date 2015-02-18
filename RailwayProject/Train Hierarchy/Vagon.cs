using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayProject
{
    public abstract class Vagon : RailwayItem
    {
        protected Vagon()
        {
            _numberOfJoints = 2;
        }

        public int Length { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }
}
