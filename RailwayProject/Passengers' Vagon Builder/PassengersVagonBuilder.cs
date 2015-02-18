using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayProject
{
    public abstract class PassengersVagonBuilder
    {
        public abstract void BuildPassengersSpace();
        public abstract void BuildLuggageSpace();
        public abstract PassengersVagon GetResult();
    }
}
