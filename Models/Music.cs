namespace ScreenSound.Models;

internal class Music : IRateable
{
    private readonly List<Average> grades = new();

    public Music(Group artist, string name)
    {
        Artist = artist;
        Name = name;
    }

    public string Name { get; }
    public Group Artist { get; }
    public int Duration { get; set; }
    public bool Available { get; set; }
    public Gender Gender { get; set; }
    public string ResumeDescription => $"A musica pertence {Name} pertence a {Artist}";

    public double Average
    {
        get
        {
            if (grades.Count == 0) return 0;
            else return grades.Average(grade => grade.Grade);
        }
    }

    public void AddGrade(Average grade)
    {
        grades.Add(grade);
    }

    public void ShowMusic()
    {
        Console.WriteLine($"Nome: {Name}");
        Console.WriteLine($"Artista: {Artist.Name}");
        Console.WriteLine($"Duração: {Duration}");

        if (Available) Console.WriteLine("Disponivel no plano.");
        else Console.WriteLine("Adquira o plano Plus+.");
    }
}