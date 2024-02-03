using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab3App
{
    internal abstract class Tool : Collectable
    {
        public Tool(string des) : base(des)
        {
        }

        public abstract void DoAction();

        public override void AddMe(List<Collectable> item)
        {
            base.AddMe(item);
            DoAction();
        }
    }
}