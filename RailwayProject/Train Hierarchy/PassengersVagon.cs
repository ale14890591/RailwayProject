using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayProject
{
    public class PassengersVagon : Vagon
    {
        public int Number { get; set; }
        private int _freeSpace;
        private PassengersSpace _passengersSpace;
        public PassengersSpace PassengersSpace 
        {
            get
            {
                return _passengersSpace;
            }
            set
            {
                if (value.StoreyArea <= this._freeSpace)
                {
                    _passengersSpace = value;
                    _freeSpace -= value.StoreyArea;
                }
                else
                {
                    throw new Exception("Exception in \"PassengersVagon.PassengersSpace\" property, the area of the passenger's space is too large for the vagon");
                }
            }
        }
        private LuggageSpace _luggageSpace;
        public LuggageSpace LuggageSpace 
        {
            get
            {
                return _luggageSpace;
            }
            set
            {
                if (value.Area <= this._freeSpace)
                {
                    _luggageSpace = value;
                    _freeSpace -= value.Area;
                }
                else
                {
                    throw new Exception("Exception in \"PassengersVagon.LuggageSpace\" property, the area of the luggage space is too large for the vagon");
                }
            }
        }

        public PassengersVagon(int lenght, int width, int height)
        {
            this.Length = lenght;
            this.Width = width;
            this.Height = height;
            this._freeSpace = this.Length * this.Width;
        }
    }
}
