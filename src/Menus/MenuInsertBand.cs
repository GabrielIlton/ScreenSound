
using OpenAI_API;
using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class MenuInsertBand : Menu
{
    public override void Execute(Dictionary<string, Group> registeredBands)
    {
        base.Execute(registeredBands);

        ShowMessageInConsole("Registro de bandas");

        Console.Write("Digite o nome da banda que deseja inserir: ");

        string bandName = Console.ReadLine()!;
        Group group = new(bandName);

        registeredBands.Add(group.Name, group);

        // var client = new OpenAIAPI("API_KEY_OPEN_AI");

        // var chat = client.Chat.CreateConversation();
        // chat.AppendSystemMessage($"Resuma a banda {bandName} em um paragrafo. Adote um estilo informal.");

        // string response = chat.GetResponseFromChatbotAsync().GetAwaiter().GetResult();
        // group.Resume = response;

        Console.WriteLine($"\nA banda {bandName} foi inserida com sucesso.");
        Console.WriteLine("Aperte qualquer tecla para retornar ao menu");
        Console.ReadKey();
        Console.Clear();
    }
}