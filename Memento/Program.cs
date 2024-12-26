using Memento.classes;

namespace Memento;

class Program
{
    static void Main(string[] args)
    {
        Game game = new Game(40, 10);
        game.Start();
    }
}