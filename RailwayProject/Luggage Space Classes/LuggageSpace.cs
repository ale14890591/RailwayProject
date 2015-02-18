using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayProject
{
    public class LuggageSpace
    {
        private List<LuggageItem> _luggageItems = new List<LuggageItem>();
        public List<LuggageItem> LuggageItems
        {
            get { return _luggageItems; }
        }
        public int Area { get; set; }
        public int Height { get; set; }

        public LuggageSpace(int area, int height)
        {
            this.Area = area;
            this.Height = height;
        }

        public bool AddItem(LuggageItem item)
        {
            if (_luggageItems.Sum(x => x.Volume) + item.Volume <= this.Area * this.Height)
            {
                this._luggageItems.Add(item);
                return true;
            }
            return false;
        }
    }
}
