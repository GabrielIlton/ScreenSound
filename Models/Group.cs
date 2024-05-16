namespace ScreenSound.Models;

internal class Group : IRateable
{
    public List<Album> albums = new List<Album>();
    private readonly List<Average> grades = new();

    public Group(string name)
    {
        Name = name;
    }

    public string Name { get; }
    public double Average {
        get
        {
            if(grades.Count == 0) return 0;
            else return grades.Average(grade => grade.Grade);
        }
    }

    public string? Resume { get; set; }
    
    public void AddAlbum(Album album)
    {
        albums.Add(album);
    }
    
    public void ShowGroup()
    {
        Console.WriteLine($"Discografia da banda {Name}");
        
        foreach (var album in albums)
        {
            Console.WriteLine($"Álbum: {album.Name} ({album.TotalDuration}) min");
        }
    }

    public void AddGrade(Average grade)
    {
        grades.Add(grade);
    }
}