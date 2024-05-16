
using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class MenuShowDetails : Menu
{
    public override void Execute(Dictionary<string, Group> registeredBands)
    {
        base.Execute(registeredBands);

        ShowMessageInConsole("Exibir detalhes da banda");

        Console.WriteLine("Digite o nome da banda que deseja conhecer melhor: ");
        string bandName = Console.ReadLine()!;

        if(registeredBands.ContainsKey(bandName))
        {
            Group group = registeredBands[bandName];
            
            Console.WriteLine(group.Resume);
            Console.WriteLine($"A media da banda {group.Name} é {group.Average}");

            Console.WriteLine("Discografia: ");
            foreach (Album album in group.albums)
            {
                Console.WriteLine($"{album.Name} -> {album.Average}");
            }

            Console.WriteLine("Aperte qualquer tecla para retornar ao menu");
            Console.ReadKey();
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