using Memento.classes;

namespace Memento;

internal class Program
{
    private static void Main(string[] args)
    {
        var game = new Game(40, 10);
        game.Start();
    }
}