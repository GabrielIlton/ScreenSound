
using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class MenuInsertAlbum : Menu
{
    public override void Execute(Dictionary<string, Group> registeredBands)
    {
        base.Execute(registeredBands);

        ShowMessageInConsole("Registro de albuns");

        Console.Write("Digite o nome da banda cujo album deseja registrar: ");

        string bandName = Console.ReadLine()!;
        if (registeredBands.ContainsKey(bandName))
        {
            Group group = registeredBands[bandName];

            Console.Write("Digite o titulo do album: ");
            string albumTitle = Console.ReadLine()!;

            Album album = new(albumTitle);

            group.AddAlbum(album);

            Console.WriteLine($"\nO album {albumTitle} de {bandName} foi inserido com sucesso.");
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