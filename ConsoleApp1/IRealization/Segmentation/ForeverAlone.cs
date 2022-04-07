using ConsoleApp1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.IRealization.Segmentation
{
    class ForeverAlone : ISegmentation
    {
        public Cell segmentation(Cell cell)
        {
            Console.WriteLine($"{cell.Name} don't wanna kids ");
            return null;
        }
    }
}
