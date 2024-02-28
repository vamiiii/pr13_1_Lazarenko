using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace pr13
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                ArrayList list = new ArrayList();
                list.Add(4.5);
                list.Add(18);
                list.AddRange(new string[] { "Студент", "петров" });
                foreach (object e in list)
                {
                    Console.WriteLine(e);

                }
                list.RemoveAt(0);
                list.Reverse();
                Console.WriteLine(list[1]);
                Console.WriteLine("-----------------");
                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine(list[i]);
                }
                Console.WriteLine("-----------------");
                Console.WriteLine("-----------------");

                ArrayList list1 = new ArrayList();
                list1.Add("*");
                list1.Add("**");
                list1.Add("***");
                int n1;
                while (true)
                {
                    Console.WriteLine("введите n1");
                    n1 = int.Parse(Console.ReadLine());
                    if (n1 < 0 || n1 > list.Count)
                    {
                        Console.WriteLine("неверные данные");
                    }
                    else { break; }
                }

                n1--;
                foreach (object e in list1)
                {
                    list.Insert(n1, e);

                }
                int k;
                while (true)
                {
                    Console.WriteLine("введите k");
                    k = int.Parse(Console.ReadLine());
                    if (k < 0 || k > list.Count)
                    {
                        Console.WriteLine("неверные данные");
                    }
                    else break;
                }
                list.RemoveRange(n1/2,k);
               

                Console.WriteLine("изменённая коллекция:");
                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine(list[i]);
                }
                Console.ReadLine();
            }
        }
    }
}
