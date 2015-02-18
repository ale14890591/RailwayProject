using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayProject
{
    public class PassengersPlace
    {
        public Type Type { get; set; }
        public int Number { get; set; }
        public int Space { get; set; }
        public bool Engaged { get; set; }

        public PassengersPlace(Type type, int number, int space)
        {
            this.Type = type;
            this.Number = number;
            this.Space = space;
            this.Engaged = false;
        }

        public bool Engage()
        {
            if (this.Engaged)
                return false;

            this.Engaged = true;
            return true;
        }

        public bool SetFree()
        {
            if (!this.Engaged)
                return false;

            this.Engaged = false;
            return true;
        }
    }
}
