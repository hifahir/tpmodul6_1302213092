// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

public class SayaTubeVideo{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        Debug.Assert(title.Length <= 100 && title != null, "Batas judul maksimal 100 karakter dan tidak berupa null");
        this.id = new Random().Next(1000,99999);
        this.title = title;
        this.playCount = 0;
    }

    public void IncrasePlayCount(int Count)
    {
        Debug.Assert(Count <= 10000000, "Input playCount maksimal 10 juta per panggilan method-nya");
        try
        {
            checked {this.playCount += Count;}
        }
        catch(OverflowException err)
        {
            Console.WriteLine(err.Message);
        }
    }
    
    public void printVideoDetail()
    {
        Console.WriteLine("<==========================================>");
        Console.WriteLine("Detail Video: ");
        Console.WriteLine("ID Video: " + this.id);
        Console.WriteLine("Judul: " + this.title);
        Console.WriteLine("Viewer: " + this.playCount);//.ToString("NO")//);
        Console.WriteLine("<==========================================>");
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - HilmanFarizHirzi_praktikan");
            for(int i = 0; i < 1000; i++)
            {
                video.IncrasePlayCount(10000000);
            }
            video.printVideoDetail();
        }
    }
}
