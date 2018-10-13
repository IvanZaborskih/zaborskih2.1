using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLib;

namespace _1._1._12
{
    class CulcConsole
    {
        static int Input()
        {
            bool b;
            int value = 0;
            do
            {
                try
                {
                    value = Convert.ToInt32(Console.ReadLine());
                    if (value == 0)
                    {
                        Console.WriteLine("Введите число отличное от нуля");
                        b = false;
                    }
                    else
                        b = true;
                }
                catch
                {
                    Console.WriteLine("Введите число");
                    b = false;
                }
            } while (b == false);
            return value;
        }

        static char InputSign()
        {
            bool b;
            char sign = ' ';
            do
            {
                try
                {
                    sign = Convert.ToChar(Console.ReadLine());
                    if (sign == '*' || sign == '+' || sign == '-' || sign == '/')
                    {
                        b = true;
                    }
                    else
                    {
                        Console.WriteLine("Введите правильный знак операции!");
                        b = false;
                    }
                }
                catch
                {
                    Console.Write("Введите операцию(+,-,*,/): ");
                    b = false;
                }
            } while (b == false);
            return sign;
        }

        static void Sum(Fraction fract1, Fraction fract2)
        {
            Operation operation = new Operation();
            Fraction result = operation.Sum(fract1, fract2);
            Console.WriteLine("Результат: ");
            Console.WriteLine(Convert.ToString(result.Numerator.Value));
            Console.WriteLine("--");
            Console.WriteLine(Convert.ToString(result.Denomerator.Value));
        }

        static void Sub(Fraction fract1, Fraction fract2)
        {
            Operation operation = new Operation();
            Fraction result = operation.Sub(fract1, fract2);
            Console.WriteLine("Результат: ");
            Console.WriteLine(Convert.ToString(result.Numerator.Value));
            Console.WriteLine("--");
            Console.WriteLine(Convert.ToString(result.Denomerator.Value));
        }

        static void Mult(Fraction fract1, Fraction fract2)
        {
            Operation operation = new Operation();
            Fraction result = operation.Mult(fract1, fract2);
            Console.WriteLine("Результат: ");
            Console.WriteLine(Convert.ToString(result.Numerator.Value));
            Console.WriteLine("--");
            Console.WriteLine(Convert.ToString(result.Denomerator.Value));
        }

        static void Div(Fraction fract1, Fraction fract2)
        {
            Operation operation = new Operation();
            Fraction result = operation.Div(fract1, fract2);
            Console.WriteLine("Результат: ");
            Console.WriteLine(Convert.ToString(result.Numerator.Value));
            Console.WriteLine("--");
            Console.WriteLine(Convert.ToString(result.Denomerator.Value));
        }
        
        static void Main(string[] args)
        {
            string check = "";
            do
            {
                Console.WriteLine("Введите первую дробь:");
                int Num1 = Input();
                Console.WriteLine("--");
                int Den1 = Input();
                Console.WriteLine("Введите вторую дробь:");
                int Num2 = Input();
                Console.WriteLine("--");
                int Den2 = Input();
                Number num1 = new Number(Num1);
                Number den1 = new Number(Den1);
                Number num2 = new Number(Num2);
                Number den2 = new Number(Den2);
                Fraction frac1 = new Fraction(num1, den1);
                Fraction frac2 = new Fraction(num2, den2);
                
                Console.Write("Введите операцию(+,-,*,/): ");
                char znak = InputSign();
                if (znak == '+')
                    Sum(frac1, frac2);
                if (znak == '-')
                    Sub(frac1, frac2);
                if (znak == '*')
                    Mult(frac1, frac2);
                if (znak == '/')
                    Div(frac1, frac2);
                Console.WriteLine();
                Console.WriteLine("Если хотите продолжить, введите 0, если хотите завершить работу, нажмите любую кнопку");
                check = Convert.ToString(Console.ReadLine());
            }
            while (check == "0");
            Console.ReadKey();
        }
    }
}