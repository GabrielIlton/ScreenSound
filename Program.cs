using ScreenSound.Menus;
using ScreenSound.Models;

Group group = new("Faces");
Group group1 = new("Vocal");

Average grade = new(10);

group.AddGrade(grade);

Dictionary<string, Group> registeredBands = new();
registeredBands.Add(group.Name, group);
registeredBands.Add(group1.Name, group1);

Dictionary<int, Menu> options = new();
options.Add(1, new MenuInsertBand());
options.Add(2, new MenuInsertAlbum());
options.Add(3, new MenuListBands());
options.Add(4, new MenuEvaluateBand());
options.Add(5, new MenuEvaluateAlbum());
options.Add(6, new MenuShowDetails());
options.Add(0, new MenuExit());

ShowMenu();

void ShowMenu()
{
    Console.WriteLine("Digite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para registrar um album de uma banda");
    Console.WriteLine("Digite 3 para listar bandas");
    Console.WriteLine("Digite 4 para avaliar uma banda");
    Console.WriteLine("Digite 5 para avaliar um album");
    Console.WriteLine("Digite 6 para exibir detalhes de uma banda");
    Console.WriteLine("Digite 0 para sair");

    Console.Write("\nDigite a sua opção: ");
    string chosenOption = Console.ReadLine()!;
    int chosenOptionInt = int.Parse(chosenOption);

    if(options.ContainsKey(chosenOptionInt)) 
    {
        Menu menu = options[chosenOptionInt];
        menu.Execute(registeredBands);

        if(chosenOptionInt > 0) ShowMenu();
    }
    else 
    {
        Console.WriteLine("Opção inválida");
    }
}
