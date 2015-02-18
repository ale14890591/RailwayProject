using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayProject
{
    public class PassengersSpace
    {
        private List<PassengersPlace> _places = new List<PassengersPlace>();
        public List<PassengersPlace> Places
        {
            get { return _places; }
        }
        public int StoreyArea { get; set; }
        public int NumberOfSroreys { get; set; }

        public PassengersSpace(int numberOfStoreys, int storeyArea)
        {
            this.NumberOfSroreys = numberOfStoreys;
            this.StoreyArea = storeyArea;
        }

        public bool AddPlace(PassengersPlace place)
        {
            if (_places.Sum(x => x.Space) + place.Space <= this.StoreyArea * this.NumberOfSroreys)
            {
                this._places.Add(place);
                return true;
            }
            return false;
        }
    }
}

