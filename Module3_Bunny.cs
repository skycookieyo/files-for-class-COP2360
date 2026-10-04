using System;

class Bunny
{
    public string Name;
    public bool LikesCarrots;
    public bool LikesHumans;

    public Bunny() { }

    public Bunny(string n)
    {
        Name = n;
    }
}

class Program
{
    static void Main()
    {
        Bunny bunny = new Bunny
        {
            Name = "Bo",
            LikesCarrots = true,
            LikesHumans = false
        };

        Console.WriteLine("Bunny Name: " + bunny.Name);
        Console.WriteLine("Likes Carrots: " + bunny.LikesCarrots);
        Console.WriteLine("Likes Humans: " + bunny.LikesHumans);
    }
}
