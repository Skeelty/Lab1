using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        private static int i;

        static void Main(string[] args)
        {
            int j, k = 0;
            var fileText = File.ReadAllText("Input.txt");
            var splitText = fileText.Split(new string[] { "\r\n", " " }, StringSplitOptions.None);
            
            int[,] table = new int[splitText.Length / 3,3];
            int counter = 0;
            for (int i=0; i<splitText.Length/3;i++)
            {
                for(int p=0;p<3;p++)
                {
                    table[i, p] = Convert.ToInt32(splitText[counter]);
                    counter++;
                }
            }

            if (table.Length/3>100)
            {
                Console.WriteLine("Количество жителей больше 100");
                Console.ReadLine();
                return;
            }
                
                

            for (int i = 0; i < splitText.Length / 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write(table[i, j] + " ");
                }

                Console.WriteLine();



            }
            Console.WriteLine();
            int z = 0;
            for (int i = 0; i < splitText.Length/3; i++)
            {
                if (table[i, 2] == 1 && table[i, 1] > k)
                {
                    k = table[i, 1];                    
                    z = table[i, 0];
                }

            }

            if (z == 0)
                z = -1;

            File.WriteAllText("Output.txt", z.ToString());
           
           Console.WriteLine(z);
           Console.ReadKey();

        }
       
    }
}
