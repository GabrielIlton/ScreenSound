
using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class MenuExit : Menu
{
    public override void Execute(Dictionary<string, Group> registeredBands)
    {
        Console.WriteLine("Você saiu do programa!");

    }
}