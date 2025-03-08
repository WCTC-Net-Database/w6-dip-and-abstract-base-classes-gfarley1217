using W6_assignment_template.Interfaces;

namespace W6_assignment_template.Models
{
    public class Goblin : CharacterBase, ILootable
    {
        public string Treasure { get; set; }

        public Goblin(string name, int hitPoints, int level, IRoom startingRoom, int gold, string treasure)
            : base(name, hitPoints, level, startingRoom, gold)
        {
            Treasure = treasure;
        }

        public override void UniqueBehavior()
        {
            throw new NotImplementedException();
        }
    }

    public interface ILootable
    {
        string Treasure { get; set; }
    }
}
