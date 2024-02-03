using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    internal abstract class Collectable : CollectionBoard, Displayable
    {
        public String Description { get; set; }

        public CollectionBoard Board { get; set; }

        public Collectable(String des) { Description = des; }

        public virtual void AddMe(List<Collectable> item)
        {
            item.Add(this);
            Console.WriteLine($"{Description} Collected, Congrats!!!!");
        }

        public virtual void Display()
        {
            Console.WriteLine($"{Description} is displayed.");
        }
    }
}