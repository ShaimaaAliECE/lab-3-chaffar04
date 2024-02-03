using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    internal class Diamond : Treasure
    {
        public Diamond(string des, int score) : base(des, score)
        {
        }

        public override void Display()
        {
            Console.Write("Diamond");
            base.Display();
        }
    }
}