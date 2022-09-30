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
            const string CommandXToY = "Обмен валюты X на Y";
            const string CommandXToZ = "Обмен валюты X на Z";
            const string CommandYToX = "Обмен валюты Y на X";
            const string CommandYToZ = "Обмен валюты Y на Z";
            const string CommandZToX = "Обмен валюты Z на X";
            const string CommandZToY = "Обмен валюты Z на Y";
            const string CommandExit = "Выход из системы";
            const string CommandNoMoney = "Недостаточно средств";

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
                Console.Write("Конвертер валют\n\n1." + CommandXToY + "\n2." + CommandXToZ + "\n3." + CommandYToX + "\n4." + CommandYToZ + "\n5." + CommandZToX + "\n6." + CommandZToY + "\n7." + CommandExit + "\n\nВведите номер команды: ");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        Console.WriteLine(CommandXToY);
                        Console.WriteLine("сколько валюты Y вам нужно?");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                        if(currencyX >= currencyCount * (currencyXrate / currencyYrate))
                        {
                            currencyX -= currencyCount * (currencyXrate / currencyYrate);
                            currencyY += currencyCount;
                        }
                        else
                        {
                            Console.WriteLine(CommandNoMoney);
                            Console.ReadKey();
                        }
                        break;
                    case 2:
                        Console.WriteLine(CommandXToZ);
                        Console.WriteLine("сколько валюты Z вам нужно?");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                        if(currencyX >= currencyCount * (currencyXrate / currencyZrate))
                        {
                            currencyX -= currencyCount * (currencyXrate / currencyZrate);
                            currencyZ += currencyCount;
                        }
                        else
                        {
                            Console.WriteLine(CommandNoMoney);
                            Console.ReadKey();
                        }
                        break;
                    case 3:
                        Console.WriteLine(CommandYToX);
                        Console.WriteLine("сколько валюты X вам нужно?");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                        if(currencyY >= currencyCount * (currencyYrate / currencyXrate))
                        {
                            currencyY -= currencyCount * (currencyYrate / currencyXrate);
                            currencyX += currencyCount;
                        }
                        else
                        {
                            Console.WriteLine(CommandNoMoney);
                            Console.ReadKey();
                        }
                        break;
                    case 4:
                        Console.WriteLine(CommandYToZ);
                        Console.WriteLine("сколько валюты Z вам нужно?");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                        if(currencyY >= currencyCount * (currencyYrate / currencyZrate))
                        {
                            currencyY -= currencyCount * (currencyYrate / currencyZrate);
                            currencyZ += currencyCount;
                        }
                        else
                        {
                            Console.WriteLine(CommandNoMoney);
                            Console.ReadKey();
                        }
                        break;
                    case 5:
                        Console.WriteLine(CommandZToX);
                        Console.WriteLine("сколько валюты X вам нужно?");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                        if(currencyZ >= currencyCount * (currencyZrate / currencyXrate))
                        {
                            currencyZ -= currencyCount * (currencyZrate / currencyXrate);
                            currencyX += currencyCount;
                        }
                        else
                        {
                            Console.WriteLine(CommandNoMoney);
                            Console.ReadKey();
                        }
                        break;
                    case 6:
                        Console.WriteLine(CommandZToY);
                        Console.WriteLine("сколько валюты Y вам нужно?");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                        if(currencyZ >= currencyCount * (currencyZrate / currencyYrate))
                        {
                            currencyZ -= currencyCount * (currencyZrate / currencyYrate);
                            currencyY += currencyCount;
                        }
                        else
                        {
                            Console.WriteLine(CommandNoMoney);
                            Console.ReadKey();
                        }
                        break;
                    case 7:
                        Console.WriteLine(CommandExit);
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
