using System.Diagnostics;

public class LeagueBlocker
{
    public static void Main(string[] args)
    {
        while (true)
        {
            var process = Process.GetProcessesByName("RiotClientUx");

            if (process.Length > 0)
            {
                process[0].Kill();
                Console.WriteLine("Destroyed Riot Client");
            }
            Console.WriteLine("Searching For Riot Client");
            Thread.Sleep(15000); // Check every 15second
        }
    }
}