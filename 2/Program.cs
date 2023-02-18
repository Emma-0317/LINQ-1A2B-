using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("歡迎來到1A2B猜數字遊戲~");

            while (true)//迴圈
            {
                var number = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
                char temp;
                Random answer = new Random();

                for (int i = 0; i < number.Length; i++)//**還是會有重複數字出現
                {
                    int x = answer.Next(number.Length);
                    temp = number[i] = number[x];
                }
                //答案
                //Console.WriteLine($"{number[0]}{number[1]}{number[2]}{number[3]}");

                while (true)
                {
                    Console.WriteLine("請輸入要猜測的數字");
                    string input = Console.ReadLine();

                    int a = 0;
                    for (int i = 0; i < input.Length; i++)
                    {
                        if (input[i] == number[i])
                        {
                            a++;
                        }
                    }

                    int b = number.Take(input.Length).Intersect(input).Count() - a;

                    Console.WriteLine($"結果是{a}A{b}B");
                    if (a == 4)
                    {
                        Console.WriteLine("正確答案");
                        break;
                    }
                }

                Console.WriteLine("是否再次進行遊戲(繼續玩請按y/結束請按n)");
                if (Console.ReadLine() == "y")
                {
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}
