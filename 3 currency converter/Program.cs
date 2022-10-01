﻿using System;
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
            const string CommandXToY = "1";
            const string CommandXToZ = "2";
            const string CommandYToX = "3";
            const string CommandYToZ = "4";
            const string CommandZToX = "5";
            const string CommandZToY = "6";
            const string CommandExit = "7";
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
                Console.Write("Конвертер валют\n\n1.Обмен валюты X на Y\n2.Обмен валюты X на Z\n3.Обмен валюты Y на X\n4.Обмен валюты Y на Z\n5.Обмен валюты Z на X\n6.Обмен валюты Z на Y\n7.Выход из системы\n\nВведите номер команды: ");
                switch (Console.ReadLine())
                {
                    case CommandXToY:
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
                    case CommandXToZ:
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
                    case CommandYToX:
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
                    case CommandYToZ:
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
                    case CommandZToX:
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
                    case CommandZToY:
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
                    case CommandExit:
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
