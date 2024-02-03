using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    internal class Coin : Treasure
    {


        public Coin(string des, int score, int value) : base(des, score)
        {
            Value = value;
        }


        private int Value { get; set; }

        public override void Display()
        {
            Console.Write("Coin ");
            base.Display();
        }

        public override void AddMe(List<Collectable> item)
        {
            base.AddMe(item);
            UpdateTotalValue();
            Console.WriteLine($"Total value is updated to: {Board.TotalValue}");
        }

        public void UpdateTotalValue()
        {
            Board.TotalValue += Value;
        }
    }
}