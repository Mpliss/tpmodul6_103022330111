class SayaTubeVideo
{
    private int id;
    private string title;
    private int playcount;

    public SayaTubeVideo(string title)
    {
        Random random = new Random();
        this.id = random.Next(10000, 99999);
        this.title = title;
        this.playcount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        if(count < 0)
        {
            Console.WriteLine("Jumlah tidak boleh negatif");
        }
        this.playcount += count;
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
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design by Contract - [Pieter Immanuel Sina]");
        video.IncreasePlayCount(10);
        video.PrintVideoDetails();
    }
}