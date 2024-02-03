using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    internal abstract class Treasure : Collectable
    {
        public Treasure(string des, int score) : base(des)
        {
            Score = score;
        }

        public int Score { get; set; }

        public override void AddMe(List<Collectable> item)
        {
            base.AddMe(item);

            UpdateTotalScore();
            Console.WriteLine($"Total score is updated to: {Board.TotalScore}");
        }
        public void UpdateTotalScore()
        {
            Board.TotalScore += Score;
        }
    }
}