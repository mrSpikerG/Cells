using ConsoleApp1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.IRealization
{
    class Diet : IFood
    {
        public void eat(Cell cell)
        {
            Console.WriteLine($"{cell.Name} can't eat");
        }

      
    }
}
