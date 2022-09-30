using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_currency_converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float currencyX;
            float currencyY;
            float currencyZ;
            bool isOpen = true;
            float currencyXrate = 16.32f;
            float currencyYrate = 1.2f;
            float currencyZrate = 134.52f;
            float currencyCount;

            Console.WriteLine("Приветствуем в конвертере валют!");
            Console.WriteLine("Какое количество валюты 'X' у вас есть?");
            currencyX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Какое количество валюты 'Y' у вас есть?");
            currencyY = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Какое количество валюты 'Z' у вас есть?");
            currencyZ = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            
            while(isOpen == true)
            {
                Console.SetCursorPosition(0, 20);
                Console.WriteLine("Ваш баланс\n\nВалюта X: " + currencyX + "\nВалюта Y: " + currencyY + "\nВалюта Z: " + currencyZ);
                Console.WriteLine("\nКурс конвертера\n\n" + currencyXrate + " валюта X = " + currencyYrate + " валюта Y = " + currencyZrate + " валюта Z");
                Console.SetCursorPosition(0, 0);
                Console.Write("Конвертер валют\n\n1.Обменять валюту X на Y\n2.Обменять валюту X на Z\n3.Обменять валюту Y на X\n4.Обменять валюту Y на Z\n5.Обменять валюту Z на X\n6.Обменять валюту Z на Y\n7.Закончить\n\nВведите номер команды: ");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        Console.WriteLine("сколько валюты Y вам нужно?");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                        currencyX -= currencyCount * (currencyXrate / currencyYrate);
                        currencyY += currencyCount;
                        break;
                    case 2:
                        Console.WriteLine("сколько валюты Z вам нужно?");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                        currencyX -= currencyCount * (currencyXrate / currencyZrate);
                        currencyZ += currencyCount;
                        break;
                    case 3:
                        Console.WriteLine("сколько валюты X вам нужно?");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                        currencyY -= currencyCount * (currencyYrate / currencyXrate);
                        currencyX += currencyCount;
                        break;
                    case 4:
                        Console.WriteLine("сколько валюты Z вам нужно?");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                        currencyY -= currencyCount * (currencyYrate / currencyZrate);
                        currencyZ += currencyCount;
                        break;
                    case 5:
                        Console.WriteLine("сколько валюты X вам нужно?");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                        currencyZ -= currencyCount * (currencyZrate / currencyXrate);
                        currencyX += currencyCount;
                        break;
                    case 6:
                        Console.WriteLine("сколько валюты Y вам нужно?");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                        currencyZ -= currencyCount * (currencyZrate / currencyYrate);
                        currencyY += currencyCount;
                        break;
                    case 7:
                        isOpen = false;
                        break;
                    default:
                        Console.WriteLine("Такой команды нет");
                        Console.ReadKey();
                        break;
                }

                Console.Clear();
            }
        }
    }
}
