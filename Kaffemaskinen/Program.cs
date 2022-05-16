using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskinen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Brewer brewer = new Brewer();
            Console.WriteLine(brewer.MakeEspresso());
        }
    }
}
