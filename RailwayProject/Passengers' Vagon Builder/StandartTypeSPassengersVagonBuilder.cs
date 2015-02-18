using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayProject
{
    public class StandartTypeSPassengersVagonBuilder : PassengersVagonBuilder
    {
        PassengersVagon _vagon = new PassengersVagon(25, 5, 4);

        public override void BuildPassengersSpace()
        {
            PassengersSpace space = new PassengersSpace(1, 80);

            for (int i = 1; i <= 60; i++)
            {
                space.AddPlace(new PassengersPlace(Type.S, i, 1));
            }

            _vagon.PassengersSpace = space;
        }

        public override void BuildLuggageSpace()
        {
            LuggageSpace space = new LuggageSpace(45, _vagon.Height);

            _vagon.LuggageSpace = space;
        }

        public override PassengersVagon GetResult()
        {
            return _vagon;
        }
    }
}
