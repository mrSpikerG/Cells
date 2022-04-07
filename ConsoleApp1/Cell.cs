using ConsoleApp1.Interface;
using ConsoleApp1.IRealization;
using ConsoleApp1.IRealization.Segmentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Cell
    {
        public string Name { get; set; }
        public int Strength { get; set; }


        private IAtack attack;
        private IMove move;
        private IFood food;
        private ISegmentation segmentation;
        public Cell(int strength = 10, string name = "Billy")
        {
            Strength = strength;
            Name = name;
            move = new  Run();
            food = new Gluttony();
            segmentation = new FamilyLover();
            attack = new Attack();
        }

        public Cell(IMove _move, int strength = 10, string name = "Billy")
        {
            Strength = strength;
            Name = name;
            move = _move;
            food = new Gluttony();
            segmentation = new FamilyLover();
            attack = new Attack();
        }

        public Cell(IMove _move,IFood _food,ISegmentation _segmentation, int strength = 10, string name = "Billy")
        {
            Strength = strength;
            Name = name;
            move = _move;
            food = _food;
            segmentation = _segmentation;
            attack = new Attack();
        }
    /*    public Cell(IMove _move, IFood _food, ISegmentation _segmentation,IAtack _attack, int strength = 10, string name = "Billy")
        {
            Strength = strength;
            Name = name;
            move = _move;
            food = _food;
            segmentation = _segmentation;
            attack = _attack;
        }*/

        

        //choose direction (T - top, D - down, R - right, L - left)
        public void moveTo(string chose)
        {
            chose = chose.ToLower();
            switch (chose)
            {
                case "T":
                    move.moveUp();
                    break;
                case "D":
                    move.moveDown();
                    break;
                case "R":
                    move.moveRight();
                    break;
                case "L":
                    move.moveLeft();
                    break;
            }
        }
        public void haveBreakfast()
        {
            food.eat(this);
        }
        public Cell divide()
        {
            return segmentation.segmentation(this);
        }
        public void Attack(Cell victim)
        {
            if (victim.Strength > this.Strength)
            {
                attack = new RunAway();
                victim.attack = new Attack();
            }
            else
            {
                victim.attack = new RunAway();
                attack = new Attack();
            }
            attack.attack(this,victim);
            victim.attack.attack(victim, this);
        }
        

    }
}
