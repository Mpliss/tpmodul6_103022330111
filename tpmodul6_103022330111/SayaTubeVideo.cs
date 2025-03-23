using System.Diagnostics;

class SayaTubeVideo
{
    private int id;
    private string title;
    private int playcount;

    public SayaTubeVideo(string title)
    {
        Debug.Assert(title.Length <= 100);
        Debug.Assert(title != null);

        Random random = new Random();
        this.id = random.Next(10000, 99999);
        this.title = title;
        this.playcount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        try
        {
            if(count <= 0 || count > 10000000)
            {
                throw new ArgumentException("Error: Inputan play count harus 1 sampai 10.000.000");
            }
            checked
            {
                this.playcount += count;
            }
        }
        catch(ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine("ID: " + this.id);
        Console.WriteLine("Title: " + this.title);
        Console.WriteLine("PlayCount: " + this.playcount);
    }
}

class program
{
    static void Main()
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design by Contract - [Pieter Immanuel Sinaga]");
        video.IncreasePlayCount(10000000);
        video.IncreasePlayCount(-1);
        video.IncreasePlayCount(15000000);
        video.PrintVideoDetails();
    }
}