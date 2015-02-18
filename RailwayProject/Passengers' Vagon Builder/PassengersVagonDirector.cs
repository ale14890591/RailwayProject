using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayProject
{
    public class PassengersVagonDirector
    {
        public void CreateVagon(PassengersVagonBuilder builder)
        {
            builder.BuildPassengersSpace();
            builder.BuildLuggageSpace();
        }
    }
}
