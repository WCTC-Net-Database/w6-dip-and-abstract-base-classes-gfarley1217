using W6_assignment_template.Interfaces;

namespace W6_assignment_template.Models
{
    public class Player : CharacterBase
    {
        public Player(string name, int hitPoints, int level, IRoom startingRoom, int gold)
            : base(name, hitPoints, level, startingRoom, gold)
        {
        }

        public override void UniqueBehavior()
        {
            throw new NotImplementedException();
        }
    }
}
