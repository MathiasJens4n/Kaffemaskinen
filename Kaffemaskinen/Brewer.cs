using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskinen
{
    internal class Brewer: IFIlter, IPowder, IPower, IWater, ICofee, IEspresso
    {
        public string Cups { get; set; }
        public string Process { get; set; }
        public string AddWater(int cups)
        {
            return ($"Pouring water for {cups} cups");
        }
        public string InsertFilter()
        {
            return ("Inserting filter");
        }
        public string AddPowder()
        {
            return ("Adding powder");
        }
        public string TurnOn()
        {
            return ("Turning on machine");
        }

        public string MakeCoffee(int cups)
        {
            Process += $"{AddWater(cups)}\n";
            Process += $"{InsertFilter()}\n";
            Process += $"{AddPowder()}\n";
            Process += $"{TurnOn()}\n";
            Process += $"Making coffee\n";
            return Process;
        }
        public string MakeTea(int cups)
        {
            Process += $"{AddWater(cups)}\n";
            Process += $"{InsertFilter()}\n";
            Process += $"{AddPowder()}\n";
            Process += $"{TurnOn()}\n";
            Process += $"Making Tea\n";
            return Process;
        }

        public string MakeEspresso()
        {
            Process += $"{AddWater(1)}\n";
            Process += $"{InsertFilter()}\n";
            Process += $"{AddPowder()}\n";
            Process += $"{TurnOn()}\n";
            Process += $"Making Espresso\n";
            return Process;

        }
    }
}
