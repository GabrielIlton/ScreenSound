class Podcast
{
    private List<Episode> episodes = new();

    public Podcast(string name, string host)
    {
        Name = name;
        Host = host;
    }

    public string Name { get; }
    public string Host { get; }
    public int TotalEpisodes => episodes.Count;

    public void addEpisode(Episode episode) 
    {
        episodes.Add(episode);
    }

    public void showPodcast() 
    {
        Console.WriteLine($"Podcast {Name} apresentado por {Host}\n");

        foreach (Episode episode in episodes.OrderBy(ep => ep.Order))
        {
            Console.WriteLine(episode.Resume);
        }

        Console.WriteLine($"Esse Podcast possui {TotalEpisodes} episodio(s)");
    }
}