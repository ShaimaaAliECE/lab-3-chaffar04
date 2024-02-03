using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    internal class MagicWand : Tool
    {
        public MagicWand(string des) : base(des)
        {
        }

        public override void Display()
        {
            Console.Write("MagicWand ");
            base.Display();
        }

        public override void DoAction()
        {
            Console.WriteLine("MagicWand is used");
        }
    }
}