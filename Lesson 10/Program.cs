using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите двузначное число:");

            int number = Convert.ToInt32(Console.ReadLine());

            if (number < 10 || number > 100)
            {
                Console.WriteLine("Введите двузначное число.");                
            }

            else
            {
                int a = (number / 10) * 10;
                int b = number % 10;

                if (number > 10 && number < 20)
                {
                    switch (number)
                    {
                        case 11:
                            Console.Write("Одиннадцать.");
                            break;

                        case 12:
                            Console.Write("Двенадцать.");
                            break;

                        case 13:
                            Console.Write("Тринадцать.");
                            break;

                        case 14:
                            Console.Write("Четырнадцать.");
                            break;

                        case 15:
                            Console.Write("Пятнадцать.");
                            break;

                        case 16:
                            Console.Write("Шестнадцать.");
                            break;

                        case 17:
                            Console.Write("Семнадцать.");
                            break;

                        case 18:
                            Console.Write("Восемнадцать.");
                            break;

                        case 19:
                            Console.Write("Девятнадцать.");
                            break;
                    }
                }

                else
                {
                    switch (a)
                    {
                        case 10:
                            Console.Write("Десять" + " ");
                            break;

                        case 20:
                            Console.Write("Двадцать" + " ");
                            break;

                        case 30:
                            Console.Write("Тридцать" + " ");
                            break;

                        case 40:
                            Console.Write("Сорок" + " ");
                            break;

                        case 50:
                            Console.Write("Пятьдесят" + " ");
                            break;

                        case 60:
                            Console.Write("Шестьдесят" + " ");
                            break;

                        case 70:
                            Console.Write("Семьдесят" + " ");
                            break;

                        case 80:
                            Console.Write("Восемьдесят" + " ");
                            break;

                        case 90:
                            Console.Write("Девяносто" + " ");
                            break;
                    }

                    switch (b)
                    {
                        case 1:
                            Console.Write("один.");
                            break;

                        case 2:
                            Console.Write("два.");
                            break;

                        case 3:
                            Console.Write("три.");
                            break;

                        case 4:
                            Console.Write("четыре.");
                            break;

                        case 5:
                            Console.Write("пять.");
                            break;

                        case 6:
                            Console.Write("шесть.");
                            break;

                        case 7:
                            Console.Write("семь.");
                            break;

                        case 8:
                            Console.Write("восемь.");
                            break;

                        case 9:
                            Console.Write("девять.");
                            break;
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
