using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayProject
{
    class Program
    {
        static void Main(string[] args)
        {
            PassengersVagonDirector director = new PassengersVagonDirector();
            StandartTypeKPassengersVagonBuilder builderK = new StandartTypeKPassengersVagonBuilder();
            StandartTypePLPassangersVagonBuilder builderPL = new StandartTypePLPassangersVagonBuilder();
            StandartTypeSPassengersVagonBuilder builderS = new StandartTypeSPassengersVagonBuilder();

            director.CreateVagon(builderK);
            Vagon vK = builderK.GetResult();
            director.CreateVagon(builderPL);
            Vagon vPL = builderPL.GetResult();
            director.CreateVagon(builderS);
            Vagon vS = builderS.GetResult();
            Locomotive l = new Locomotive();

            Train t = new Train();
            t.AddToHead(l);
            t.AddToEnd(vK as PassengersVagon, 1);
            t.AddToEnd(vS as PassengersVagon, 2);
            t.AddToEnd(vPL as PassengersVagon, 3);
            t.Info();

            Console.ReadKey();
        }
    }
}
