using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayProject
{
    public class StandartTypeKPassengersVagonBuilder : PassengersVagonBuilder
    {
        private PassengersVagon _vagon = new PassengersVagon(25, 5, 4);

        public override void BuildPassengersSpace()
        {
            PassengersSpace space = new PassengersSpace(2, 54);

            for (int i = 1; i <= 36; i++)
            {
                space.AddPlace(new PassengersPlace(Type.K, i, 3));
            }

            _vagon.PassengersSpace = space;
        }

        public override void BuildLuggageSpace()
        {
            LuggageSpace space = new LuggageSpace(50, _vagon.Height);

            _vagon.LuggageSpace = space;
        }

        public override PassengersVagon GetResult()
        {
            return _vagon;
        }
    }
}
