using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_3_10_2_ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте. \nВведите количество карт  : ");
            int i;
            int sum;
            sum=0;
            i = int.Parse( Console.ReadLine());
            string card;
            for (int j = 1; j <= i; j++)

            {
                Console.WriteLine("Введите карту  №{0}", j);
                card = Console.ReadLine();
                switch (card)
                {
                    case "2":
                        sum = sum + 2;
                        break;
                    case "3":
                        sum = sum + 3;
                        break;
                    case "4":
                        sum = sum + 4;
                        break;
                    case "5":
                        sum = sum + 5;
                        break;
                    case "6":
                        sum = sum + 6;
                        break;
                    case "7":
                        sum = sum + 7;
                        break;
                    case "8":
                        sum = sum + 8;
                        break;
                    case "9":
                        sum = sum + 9;
                        break;
                    case "10":
                        sum = sum + 10;
                        break;
                    case "j":
                        sum = sum + 10;
                        break;
                    case "q":
                        sum = sum + 10;
                        break;
                    case "k":
                        sum = sum + 10;
                        break;
                    case "t":
                        sum = sum + 10;
                        break;
                }


            }

                   if (sum <=21)
            {
                Console.WriteLine(" Ваши очки {0}", sum);
            }
                   else
            {
                Console.WriteLine(" Перебор", sum);
            }


        }
    }
}
