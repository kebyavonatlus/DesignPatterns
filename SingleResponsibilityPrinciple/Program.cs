using System.Diagnostics;
using static System.Console;

namespace SingleResponsibilityPrinciple
{

    class Program
    {
        static void Main(string[] args)
        {
            var j = new Journal();
            j.Add("I cried tpday");
            j.Add("I ate a bug");

            WriteLine(j);

            var p = new Persistence();
            var fileName = @"c:\temp\journal.txt";

            p.SaveToFile(j, fileName, true);
            var process = new Process
            {
                StartInfo = new ProcessStartInfo(fileName)
                {
                    UseShellExecute = true
                }
            };

            process.Start();
        }
    }
}
