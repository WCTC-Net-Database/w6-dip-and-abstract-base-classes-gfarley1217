using W6_assignment_template.Interfaces;

namespace W6_assignment_template.Models
{
    public class Ghost : CharacterBase, IFlyable
    {
        public string Treasure { get; set; }

        public Ghost(string name, int hitPoints, int level, IRoom startingRoom, int gold, string treasure)
            : base(name, hitPoints, level, startingRoom, gold)
        {
            Treasure = treasure;
        }

        public void Fly()
        {
            Console.WriteLine($"{Name} flies rapidly through the air.");
        }

        public override void UniqueBehavior()
        {
            throw new NotImplementedException();
        }
    }
}
