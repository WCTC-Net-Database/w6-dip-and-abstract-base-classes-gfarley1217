using W6_assignment_template.Data;
using W6_assignment_template.Interfaces;
using W6_assignment_template.Models;

namespace W6_assignment_template.Services
{
    public class GameEngine
    {
        private readonly IContext _context;
        private readonly ICharacter? _player;
        private readonly ICharacter? _goblin;

        public GameEngine(IContext context)
        {
            _context = context;
            _player = (ICharacter?)context.Characters.OfType<Warrior>().FirstOrDefault(); // Copilot changes made here
            _goblin = (ICharacter?)context.Characters.OfType<Goblin>().FirstOrDefault(); // Copilot changes made here
        }

        public void Run()
        {
            if (_player == null || _goblin == null)
            {
                Console.WriteLine("Failed to initialize game characters.");
                return;
            }

            Console.WriteLine($"Player Gold: {_player.Gold}");

            _goblin.Move();
            _goblin.Attack(_player);

            _player.Move();
            _player.Attack(_goblin);

            Console.WriteLine($"Player Gold: {_player.Gold}");
        }
    }

}
