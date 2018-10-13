using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLib._2._1._12;

namespace _1._2._12_console_
{
    class Program
    {
        static double Input()
        {
            bool b;
            double value = 0;
            do
            {
                try
                {
                    value = Convert.ToDouble(Console.ReadLine());
                    b = true;
                }
                catch
                {
                    Console.WriteLine("Введите число!");
                    b = false;
                }
            } while (b == false);
            return value;
        }

        static string InputColor()
        {
            bool b;
            string color = "";
            do
            {
                try
                {
                    color = Convert.ToString(Console.ReadLine());
                    if (color == "Голубой" || color == "Желтый" || color == "Красный" || color == "Белый")
                    {
                        b = true;
                    }
                    else
                    {
                        Console.WriteLine("Введите цвет из списка!");
                        b = false;
                    }
                }
                catch
                {
                    Console.WriteLine("Введите правильный цвет");
                    b = false;
                }
            } while (b == false);
            return color;
        }

        static void Main(string[] args)
        {
            string check = "";
            do
            {
                Diamond diamond = new Diamond();
                Console.WriteLine("Введите название алмаза:");
                diamond.Name = Console.ReadLine();
                Console.WriteLine("Введите вес(в каратах):");
                diamond.Weight = Input();
                Console.WriteLine("Введите качество огранки в баллах:");
                diamond.CutQuality = Input();

                Console.WriteLine("Введите конкретный цвет алмаза из списка - \n- Голубой \n- Желтый \n- Красный \n- Белый");
                Console.Write("Ваш цвет: ");
                string colorName = InputColor();

                KindOfDiamond kindOfDiamond = new KindOfDiamond(diamond.Name, diamond.Weight, diamond.CutQuality, diamond.Cost(), colorName);
                diamond = kindOfDiamond;

                Console.WriteLine("Цена = " + diamond.Cost());

                Console.WriteLine();
                Console.WriteLine("Если хотите продолжить, введите 0, если хотите завершить работу, нажмите любую кнопку");
                check = Convert.ToString(Console.ReadLine());
            }
            while (check == "0");
            Console.ReadKey();
        }
    }
}
