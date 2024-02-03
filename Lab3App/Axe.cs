using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    internal class Axe : Tool
    {
        public Axe(string des) : base(des)
        {
        }

        public override void Display()
        {
            Console.Write("Axe ");
            base.Display();
        }

        public override void DoAction()
        {
            Console.WriteLine("Axe is Used");
        }
    }
}