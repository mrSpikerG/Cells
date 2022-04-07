using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.IRealization
{
    class Attack : IAtack
    {
        public void attack(Cell cell1,Cell cell2)
        {
            Console.WriteLine($"{cell1.Name} attack {cell2.Name}!");
            
        }

     
    }
}
