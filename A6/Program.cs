using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] stuscore = new int[3][];
            stuscore[0] = new int[3] { 85, 92, 78 };
            stuscore[1]= new int[4] {90,87,93,89};
            stuscore[2] = new int[2] { 76, 88 };
            float avg = 0,sum=0,allavg=0,allsum=0;
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Score of student {i+1}");
               for(int j = 0; j < stuscore[i].Length; j++)
                {
                    sum += stuscore[i][j];
                    avg = sum / stuscore[i].Length;
                    Console.WriteLine(stuscore[i][j]);
                }
                Console.WriteLine("-----------------------");
                Console.WriteLine($"Average score of student {i+1} is "+avg);
                allsum += avg;
                avg = 0;
                sum = 0;
                Console.WriteLine("-----------------------");
                Console.WriteLine("\n");
                allavg = allsum / 3;
            }
           
            Console.WriteLine("Average score of all 3 students is :"+allavg);
            
            Console.ReadKey();
        }
    }
}
