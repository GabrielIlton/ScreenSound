namespace ScreenSound.Models;

internal class Album : IRateable
{
    private readonly List<Music> musics = new List<Music>();
    private readonly List<Average> grades = new();

    public Album(string name)
    {
        Name = name;
    }

    public string Name { get; }
    public int TotalDuration => musics.Sum(music => music.Duration);

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

    public void AddMusic(Music music) 
    {
        if (!musics.Contains(music)) musics.Add(music);
    }

    public void ListMusics()
    {
        Console.WriteLine($"Lista de musicas do album {Name}\n");

        foreach (var music in musics)
        {
            Console.WriteLine($"Musica: {music.Name}");
        }

        Console.WriteLine($"\nPara ouvir esse álbum você precisa de {TotalDuration} minutos");
    }
}