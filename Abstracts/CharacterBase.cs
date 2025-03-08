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
        public int Level { get; set; }
        public IRoom StartingRoom { get; set; }
        public int Gold { get; set; }

        protected CharacterBase(string name, int hitPoints, int level, IRoom startingRoom, int gold)
        {
            Name = name;
            HitPoints = hitPoints;
            Level = level;
            StartingRoom = startingRoom;
            Gold = gold;
        }

        public abstract void UniqueBehavior();

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






