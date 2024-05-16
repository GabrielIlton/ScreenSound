
using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class MenuListBands : Menu
{
    public override void Execute(Dictionary<string, Group> registeredBands)
    {
        base.Execute(registeredBands);

        ShowMessageInConsole("Exibindo todas as bandas");

        foreach (string band in registeredBands.Keys) Console.WriteLine($"Banda: {band}");

        Console.WriteLine("\nDigite algo para voltar ao menu");

        Console.ReadKey();

        Console.Clear();
    }
}