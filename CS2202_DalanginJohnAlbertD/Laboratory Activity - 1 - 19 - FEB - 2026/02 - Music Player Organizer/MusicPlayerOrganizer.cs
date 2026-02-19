using System;

class Song
{
    public string Title { get; set; }
    public string Artist { get; set; }
    public double Duration { get; set; }

    public Song() : this("Unknown", "Unknown", 0) { }

    public Song(string title, string artist, double duration)
    {
        Title = string.IsNullOrWhiteSpace(title) ? "Unknown" : title;
        Artist = string.IsNullOrWhiteSpace(artist) ? "Unknown" : artist;
        Duration = duration;
    }

    public Song(string title, string artist) : this(title, artist, 0) { }

    public void DisplaySong(int index)
    {
        Console.WriteLine("#{0,-3}{1,-20}{2,-20}{3,7:F2}", index, Title, Artist, Duration);
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Songs to add: ");
        int n = int.Parse(Console.ReadLine());

        Song[] playlist = new Song[n];
        double totalDuration = 0;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nSong #{i+1}");

            Console.Write("Title: ");
            string title = Console.ReadLine();

            Console.Write("Artist: ");
            string artist = Console.ReadLine();

            Console.Write("Duration (minutes): ");
            string durationInput = Console.ReadLine();
            double duration = 0;

            if (!string.IsNullOrWhiteSpace(durationInput))
            {
                if (!double.TryParse(durationInput, out duration))
                {
                    duration = 0; 
                }
            }

            playlist[i] = new Song(title, artist, duration);
            totalDuration += duration;
        }

        
        Console.WriteLine("\n=== || MY PLAYLIST || ===");
        
        Console.WriteLine("{0,-5}{1,-20}{2,-20}{3,7}", "No.", "Title", "Artist", "Time");
        Console.WriteLine(new string('-', 55));

        for (int i = 0; i < n; i++)
        {
            playlist[i].DisplaySong(i + 1);
        }

        double avgDuration = totalDuration / n;
        Console.WriteLine("\nTotal Duration: {0:F2} mins", totalDuration);
        Console.WriteLine("Average Duration: {0:F2} mins", avgDuration);

    }
}