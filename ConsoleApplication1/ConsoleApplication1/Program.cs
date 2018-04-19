using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            for (int i = 1; i <= 42; i++)
            {
                numbers.Add(i);

            }

            //将号码放入序列中
            Random rand = new Random();
            for (int i = 0; i < 6; i++)
            {

                 int r = rand.Next(1, numbers.Count);
                Console.Write(numbers[r] + " ");                                 
                numbers.RemoveAt(r);

            }

              //随机选出一个号码並从List中刪除      
               Console.ReadLine();
        }
    }
}
