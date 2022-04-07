using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.IRealization
{
    class Walk : IMove
    {
        public void moveDown()
        {
            Console.WriteLine("Walk down");
        }

        public void moveLeft()
        {
            Console.WriteLine("Walk left");
        }

        public void moveRight()
        {
            Console.WriteLine("Walk right");
        }

        public void moveUp()
        {
            Console.WriteLine("Walk up");
        }
    }
}
