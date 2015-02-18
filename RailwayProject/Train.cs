using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayProject
{
    public class Train
    {      
        private LinkedList<RailwayItem> _train = new LinkedList<RailwayItem>();

        public bool AddToEnd(RailwayItem item)
        {
            if (_train.Count == 0)
            {
                _train.AddFirst(item);
                return true;
            }
            else
            {
                if (_train.Last.Value.HasNonEngagedJoints())
                {
                    _train.Last.Value.Join(item);
                    _train.AddLast(item);
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool AddToEnd(PassengersVagon vagon, int numberOfVagon)
        {
            if (_train.Count == 0)
            {
                vagon.Number = numberOfVagon;
                _train.AddFirst(vagon);
                return true;
            }
            else
            {
                if (_train.Last.Value.HasNonEngagedJoints())
                {
                    vagon.Number = numberOfVagon;
                    _train.Last.Value.Join(vagon);
                    _train.AddLast(vagon);
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool AddToHead(RailwayItem item)
        {
            if (_train.Count == 0)
            {
                _train.AddFirst(item);
                return true;
            }
            else
            {
                if (_train.First.Value.HasNonEngagedJoints())
                {
                    _train.First.Value.Join(item);
                    _train.AddFirst(item);
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool AddToHead(PassengersVagon vagon, int numberOfVagon)
        {
            if (_train.Count == 0)
            {
                vagon.Number = numberOfVagon;
                _train.AddFirst(vagon);
                return true;
            }
            else
            {
                if (_train.First.Value.HasNonEngagedJoints())
                {
                    vagon.Number = numberOfVagon;
                    _train.First.Value.Join(vagon);
                    _train.AddFirst(vagon);
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public RailwayItem this[int index]
        {
            get
            {
                LinkedListNode<RailwayItem> item = _train.First;
                for (int i = 0; i < index; i++) 
                {
                    item = item.Next;
                }
                return item.Value;
            }
        }

        public void Info()
        {
            foreach (RailwayItem item in _train)
            {
                PassengersVagon vagon = item as PassengersVagon;

                if (vagon != null)
                {
                    Console.WriteLine("****Vagon {0}****", vagon.Number);
                    Console.WriteLine("Length: {0} m, Width: {1} m, Height: {2} m, Total area: {3} sq.m.", vagon.Length, vagon.Width, vagon.Height, vagon.Length * vagon.Width);
                    if (vagon.PassengersSpace != null)
                    {
                        Console.Write("Area for passengers: {0} sq.m.", vagon.PassengersSpace.StoreyArea);
                        if (vagon.PassengersSpace.NumberOfSroreys > 1)
                        {
                            Console.Write(", {0} storeys", vagon.PassengersSpace.NumberOfSroreys);
                        }
                        Console.WriteLine();
                        Console.WriteLine("Total number of places:{0}", vagon.PassengersSpace.Places.Count);
                        
                        IEnumerable<IGrouping<Type,PassengersPlace>> sequence = vagon.PassengersSpace.Places.GroupBy(x => x.Type);
                        foreach (IGrouping<Type, PassengersPlace> group in sequence)
                        {
                            Console.WriteLine("***\nType {0}: {1} places", group.Key.ToString(), group.Count());
                            Console.Write("Numbers:");
                            foreach (PassengersPlace p in group)
                            {
                                Console.Write("{0} ", p.Number);
                            }
                            Console.WriteLine("\n***");
                        }
                    }

                    if (vagon.LuggageSpace != null)
                    {
                        Console.WriteLine("Area for luggage: {0} sq.m., total luggage room capacity: {1} cb.m.", vagon.LuggageSpace.Area, vagon.LuggageSpace.Area * vagon.LuggageSpace.Height);
                    }
                }
            }
        }
    }
}
