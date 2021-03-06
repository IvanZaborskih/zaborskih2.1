﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLib._2._1._12;

namespace _1._2._12_console_
{
    class DiamondConsole
    {
        static double Input()
        {
            double a;
            while (!double.TryParse(Console.ReadLine().Replace('.', ','), out a) || a <= 0)
            {
                Console.WriteLine("Введите число больше нуля!");
            }
            return a;
        }

        static int InputColor()
        {
            Console.Write("Ваш цвет: ");
            int a;
            while (!int.TryParse(Console.ReadLine(), out a) || a > 4 || a < 1)
            {
                Console.WriteLine("Выберите цвет из списка!");
            }
            return a;
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

                Console.WriteLine("Выберите цвет алмаза из списка - \n1) Голубой \n2) Желтый \n3) Красный \n4) Белый");
                int colorNumber = InputColor();
                ColorNum color = new ColorNum();
                if (colorNumber == 1)
                {
                    color = ColorNum.Blue;
                }
                else if (colorNumber == 2)
                {
                    color = ColorNum.Yellow;
                }
                else
                {
                    color = ColorNum.None;
                }
                diamond = new KindOfDiamond(diamond.Name, diamond.Weight, diamond.CutQuality, diamond.Cost(), color);
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
