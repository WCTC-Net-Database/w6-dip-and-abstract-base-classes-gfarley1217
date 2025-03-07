using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W6_assignment_template.Interfaces;

namespace W6_assignment_template.Abstracts
{
    public abstract class CharacterBase : ICharacter
    {
        public string Name { get; set; }
        public int HitPoints { get; set; }
        public string Class { get; set; }
        public int Level { get; set; }
        public int Gold { get; set; } // Implementing Gold property
        protected IRoom CurrentRoom { get; set; }

        protected CharacterBase(string name, int hitPoints, string characterClass, int level, IRoom startingRoom)
        {
            Name = name;
            HitPoints = hitPoints;
            Class = characterClass;
            Level = level;
            CurrentRoom = startingRoom;
            CurrentRoom.Enter();
        }

        public void MoveToRoom(IRoom room)
        {
            CurrentRoom = room;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{Name} has entered {CurrentRoom.Name}. {CurrentRoom.Description}");
            Console.ResetColor();
        }

        public abstract void PerformSpecialAction();

        // Implementing ICharacter methods
        public void Attack(ICharacter target)
        {
            // Implementation of Attack method
        }

        public void Move()
        {
            // Implementation of Move method
        }
    }


}




