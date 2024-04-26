using System.IO;

namespace jatekok
{
    internal class Program
    {
        static List<jatek> jatekok = new List<jatek>();
        static void Main(string[] args)
        {
            var sr = new StreamReader("bestgames.csv");
            while (!sr.EndOfStream) 
            {
                jatekok.Add(new jatek(sr.ReadLine()));
            }
            sr.Close();
            Console.WriteLine($"f1: összesen {jatekok.Count} játék szerepel a listában!");
            Console.WriteLine($"f2: ezekben az években került több mint 10 cím a listára:");
            Dictionary<int,int> evek = new Dictionary<int,int>();
            foreach (var item in jatekok)
            {
                if (evek.ContainsKey(item.megjelenes))
                {
                    evek[item.megjelenes]++;
                }
                else
                {
                    evek.Add(item.megjelenes, 1);
                }
            }
            evek = evek.OrderByDescending(x => x.Value).ToDictionary(x=>x.Key,x=>x.Value);
            foreach (var item in evek)
            {
                if (item.Value>10)
                {
                    Console.WriteLine($"\t{item.Key}: {item.Value}db");
                }
            }
            List<string> fps = new List<string>();
            foreach (var item in jatekok) 
            {
                if (item.mufaj=="First-person shooter")
                {
                    fps.Add(item.cim);
                }
            }
            Random rnd = new Random();
            Console.WriteLine($"f3: összesen {fps.Count} FPS került fel a listára.\n\tpéldául a(z): {fps[rnd.Next(0,fps.Count)]}");

        }
    }
}
