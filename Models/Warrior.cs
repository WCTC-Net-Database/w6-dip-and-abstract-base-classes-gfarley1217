using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using W6_assignment_template.Interfaces;

namespace W6_assignment_template.Models
{
    public class Warrior : CharacterBase
    {
        public Warrior(string name, int hitPoints, int level, IRoom startingRoom, int gold)
            : base(name, hitPoints, level, startingRoom, gold)
        {
        }

        public override void PerformSpecialAction()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{Name} performs a powerful attack!");
            Console.ResetColor();
        }

        
        public override void UniqueBehavior()
        {
            
        }
    }
}

