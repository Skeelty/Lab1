using System;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int id = -1;//
            int yearsOld = 0;
            var fileText = File.ReadAllLines("input.txt");

            if(fileText.Length <= 1)
            {
                File.WriteAllText("Output.txt", id.ToString());
            }

            int n = Convert.ToInt32(fileText[0]);

            if (n > 100)
            {
                File.WriteAllText("Output.txt", id.ToString());
            }

            int[,] table = new int[n, 3];

            for (int i = 1; i< n+1; i++)
            {
               var splitText = fileText[i].Split(' ');
               table[i-1, 0] = Convert.ToInt32(splitText[0]);
               table[i-1, 1] = Convert.ToInt32(splitText[1]);
               table[i-1, 2] = i;
            }

            for (int i = 0; i < table.Length/3; i++)
            {
                if (table[i, 1] == 1 && table[i, 0] <= 100 && table[i, 0] > 0 && table[i, 0] > yearsOld)
                {
                    yearsOld = table[i, 0];
                    id = table[i, 2];
                }

            }

            File.WriteAllText("output.txt", id.ToString());
        }

    }
}
