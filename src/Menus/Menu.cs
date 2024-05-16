using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class Menu
{
    public void ShowMessageInConsole(string message)
    {
        int messageLength = message.Length;
        string asterik = string.Empty.PadLeft(messageLength, '*');

        Console.WriteLine(asterik);
        Console.WriteLine(message);
        Console.WriteLine($"{asterik}\n");
    }


    public virtual void Execute(Dictionary<string, Group> registeredBands)
    {
        Console.Clear();
    }
}