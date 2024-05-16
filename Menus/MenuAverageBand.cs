
using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class MenuAverageBand : Menu
{
    public override void Execute(Dictionary<string, Group> registeredBands)
    {
        base.Execute(registeredBands);

        ShowMessageInConsole("Média banda");

        Console.Write("Digite o nome da banda que deseja ver a média: ");
        string bandName = Console.ReadLine()!;

        if (registeredBands.ContainsKey(bandName))
        {
            Group group = registeredBands[bandName];

            Console.Write($"\n A média da banda {bandName} é {group.Average}.");

            Thread.Sleep(1000);
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"\nBanda {bandName} não encontrada.");
            Console.WriteLine("Aperte qualquer tecla para retornar ao menu");
            Console.ReadKey();
            Console.Clear();
        }
    }
}