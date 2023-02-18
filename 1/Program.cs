using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var filename = new StreamReader(File.OpenRead(@".//..//..//../product.csv"));
            var list = new List<Product>();
            var file = filename.ReadLine();
            while (filename.EndOfStream)
            {
                var line = filename.ReadLine();
                var values = line.Split(',');

                var product = new Product();
                list.Add(product);
            }

            //**數字出不來

            while (true)
            {
                Console.WriteLine("題數1~16：");
                int QN = int.Parse(Console.ReadLine());


                if (QN == 1)// 1. 計算所有商品的總價格
                {
                    Console.WriteLine($"1.商品的總價格: {list.Sum(x => x.Price)} 元");
                }
                else if (QN == 2)//2. 計算所有商品的平均價格
                {
                    Console.WriteLine($"2.商品的平均價格: {list.Average(x => x.Price)} 元");
                }
                else if (QN == 3)//3. 計算商品的總數量
                {
                    Console.WriteLine($"3.商品的總數量: {list.Sum(x => x.Quantity)} 個");
                }
                else if (QN == 4)//4. 計算商品的平均數量
                {
                    Console.WriteLine($"4.商品的平均數量: {list.Average(x => x.Quantity)} 個");
                }
                else if (QN == 5)//5. 找出哪一項商品最貴
                {
                    Console.WriteLine($"5.最貴的商品: {list.OrderByDescending(x => x.Price).First().Name}");
                }
                else if (QN == 6)//6. 找出哪一項商品最便宜
                {
                    Console.WriteLine($"6.最便宜的商品: {list.OrderBy(x => x.Price).First().Name}");
                }
                else if (QN == 7)//7. 計算產品類別為 3C 的商品總價格
                {
                    Console.WriteLine($"7.3C類商品的總價格: {list.Where(x => x.Category == "3C").Sum(x => x.Price)} 元");
                }
                else if (QN == 8)//8. 計算產品類別為飲料及食品的商品價格
                {
                    Console.WriteLine($"8.食品及飲料類商品的總價格: {list.Where(x => x.Category == "食品" || x.Category == "飲料").Sum(x => x.Price)} 元");
                }
                else if (QN == 9)//9. 找出所有商品類別為食品，而且商品數量大於 100 的商品
                {
                    Console.WriteLine("商品類別為食品，且數量大於100:");
                    foreach (var i in list.Where(x => x.Category == "食品" && x.Quantity > 100))
                    {
                        Console.WriteLine(i.Name);
                    }
                }
                else if (QN == 10) { }//10. 找出各個商品類別底下有哪些商品的價格是大於 1000 的商品


                else if (QN == 11) { }//11. 呈上題，請計算該類別底下所有商品的平均價格


                else if (QN == 12) //12. 依照商品價格由高到低排序
                {
                    Console.WriteLine("所有商品由價格從高到低排序:");
                    foreach (var item in list.OrderByDescending(x => x.Price))
                    {
                        Console.WriteLine($"{item.Name}，{item.Price} 元");
                    }
                }
                else if (QN == 13)//13. 依照商品數量由低到高排序
                {
                    Console.WriteLine("所有商品由數量從低到高排序:");
                    foreach (var item in list.OrderBy(x => x.Quantity))
                    {
                        Console.WriteLine($"{item.Name}，{item.Quantity} 個");
                    }
                }
                else if (QN == 14) { }//14. 找出各商品類別底下，最貴的商品

                else if (QN == 15) { }//15. 找出各商品類別底下，最貴的商品

                else if (QN == 16) //16. 找出價格小於等於 10000 的商品
                {
                    foreach (var item in list.Where(x => x.Price <= 10000))
                    {
                        Console.WriteLine("16.商品中價格小於或等於1000:");
                        Console.WriteLine(item.Name);
                    }
                }
                else
                {
                    Console.WriteLine("無此題");
                }

                Console.WriteLine();
            }
        }
    }
}
