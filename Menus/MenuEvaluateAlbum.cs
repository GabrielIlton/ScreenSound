
using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class MenuEvaluateAlbum : Menu
{
    public override void Execute(Dictionary<string, Group> registeredBands)
    {
        base.Execute(registeredBands);

        ShowMessageInConsole("Avaliar album");

        Console.Write("Digite o nome da banda do album que deseja avaliar: ");
        string bandName = Console.ReadLine()!;

        if (registeredBands.ContainsKey(bandName))
        {
            Group group = registeredBands[bandName];

            Console.Write("Digite o titulo do album: ");
            string albumTitle = Console.ReadLine()!;

            if (group.albums.Any(album => album.Name.Equals(albumTitle)))
            {
                Album album = group.albums.First(album => album.Name == albumTitle);

                Console.Write($"\nQual nota o album {albumTitle} merece: ");
                Average average = Average.Parse(Console.ReadLine()!);

                album.AddGrade(average);

                Console.Write($"\n Nota {average.Grade} registrada com sucesso para o album {albumTitle}.");

                Thread.Sleep(2000);
                Console.Clear();
            }
            else
            {
                Console.WriteLine($"\nAlbum {albumTitle} não encontrado.");
                Console.WriteLine("Aperte qualquer tecla para retornar ao menu");
                Console.ReadKey();
                Console.Clear();
            }
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