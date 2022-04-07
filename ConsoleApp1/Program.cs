using ConsoleApp1.IRealization;
using ConsoleApp1.IRealization.Segmentation;
using System;

namespace ConsoleApp1
{
    class Program
    {
        //Molecula 
        static void Main(string[] args)
        {
            Cell cell1 = new Cell();
            Cell cell2 = new Cell(new Walk(), new Diet(), new ForeverAlone(), 15, "vasya");
            Cell cell3 = new Cell(new Run(), new Gluttony(), new FamilyLover(), 5, "Petya");


            cell2.Attack(cell3);

            Cell cell4 = cell3.divide();
            Cell cell5 = cell4.divide();
            Cell cell6 = cell5.divide();

            cell2.Attack(cell6);
            //Правнук отомстил за прадеда )))

            Console.WriteLine();
            cell2.divide();
            cell2.haveBreakfast();
            Console.WriteLine();
            cell3.haveBreakfast();

            // cell1.
        }
    }
}
