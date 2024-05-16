
using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class MenuEvaluateBand : Menu
{
    public override void Execute(Dictionary<string, Group> registeredBands)
    {
        base.Execute(registeredBands);

        ShowMessageInConsole("Avaliar banda");

        Console.Write("Digite o nome da banda que deseja avaliar: ");
        string bandName = Console.ReadLine()!;

        if (registeredBands.ContainsKey(bandName))
        {
            Group group = registeredBands[bandName];

            Console.Write($"\nQual nota a banda {bandName} merece: ");
            Average average = Average.Parse(Console.ReadLine()!);

            group.AddGrade(average);

            Console.Write($"\n Nota {average.Grade} registrada com sucesso para a banda {bandName}.");

            Thread.Sleep(2000);
            Console.Clear();

            return;
        }

        Console.WriteLine($"\nBanda {bandName} não encontrada.");
        Console.WriteLine("Aperte qualquer tecla para retornar ao menu");
        Console.ReadKey();
        Console.Clear();
    }
}