using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.IRealization
{
    public class Run : IMove
    {
        public void moveDown()
        {
            Console.WriteLine("Run down");
        }

        public void moveLeft()
        {
            Console.WriteLine("Run left");
        }

        public void moveRight()
        {
            Console.WriteLine("Run right");
        }

        public void moveUp()
        {
            Console.WriteLine("Run up");
        }
    }
}
