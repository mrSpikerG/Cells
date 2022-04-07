using System;
using ConsoleApp1.Interface;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.IRealization.Segmentation
{
    class FamilyLover : ISegmentation
    {
        public Cell segmentation(Cell cell)
        {
            Console.WriteLine($"{cell.Name} have kid");
            return new Cell(cell.Strength * 2, cell.Name + "_yonger");
        }
    }
}
