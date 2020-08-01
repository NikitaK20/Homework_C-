using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Калугин
// 1. Написать метод, возвращающий минимальное из трёх чисел.
// 2. Написать метод подсчета количества цифр числа.
// 3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.

// 4. Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль.
//На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
//Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
//С помощью цикла do while ограничить ввод пароля тремя попытками.

// 5.а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
//   б) * Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.

namespace Homework_2_Kalugin
{
    class Program
    {
        static void body_mass_index()
        {
            Console.WriteLine("Введите ваш вес в киллограммах:");
            double mass = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введите ваш рост в метрах:");
            double hight = Double.Parse(Console.ReadLine());
            double bmindex = (mass/(hight*hight));
            Console.WriteLine("Ваш индекс массы тела= " + bmindex.ToString("0.00"));
            if (bmindex<=18.5)
            {
                Console.WriteLine("Недостаточная (дефицит) масса тела, вам нужно набрать {0:F2} килограмм", ((20 - bmindex) * (hight * hight)));
            }else if(bmindex>18.5 && bmindex<25)
            {
                Console.WriteLine("Ваш вес в норме");
            }else if(bmindex>=25)
            {
                Console.WriteLine("Избыточная масса тела, вам нужно сбросить {0:F2} килограмм", ((bmindex-20) * (hight * hight)));
            }
            Console.ReadLine();
        }
        static void login()
        {
            int trycount = 1;
            string user_log= "root";
            string user_password = "GeekBrains";
            do
            {
                Console.WriteLine("Введите ваш логин: ");
                var log = Console.ReadLine();
                Console.WriteLine("Введите ваш пароль: ");
                var password = Console.ReadLine();
                if (user_log==log && user_password==password)
                {
                    Console.WriteLine("Вход выполнен");
                    break;
                }else{
                    Console.WriteLine("Попробуйте ещё раз. Количество попыток: {0}", 3-trycount);
                }
                trycount++;
            }
            while (trycount <= 3);
            Console.ReadLine();
        }
        static void numbers_sum()
        {
            Console.WriteLine("Вводите целые числа по одному, чтобы узнать сумму всех нечетных положительных чисел. Для окончания введите '0'.");
            int sum = 0;
            while (true)
            {
                int i = Int32.Parse(Console.ReadLine());
                if(i!=0 && i >= 0 && i % 2 == 1)
                {
                   sum += i;
                }else if (i==0)
                { 
                   break;
                }
            }
            Console.WriteLine("Сумма чисел равна: " + sum);
            Console.ReadLine();
        }
        static void numbers_amount()
        {
            Console.WriteLine("Введите число, чтобы узнать кол-во цифр в нём: ");
            var i = Console.ReadLine();
            Console.WriteLine(i.Length);
            Console.ReadLine();
        }
        static void min()
        {
            Console.WriteLine("Введите 3 целых числа, чтобы выбрать самое маленькое");
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            int c = Int32.Parse(Console.ReadLine());
            if (a <= b && a<=c)
            {
                Console.WriteLine("Самое маленькое число: "+a);
            }
            else if (b <= a && b <= c)
            {
                Console.WriteLine("Самое маленькое число: " + b);
            }
            else if (c <= a && c <= b)
            {
                Console.WriteLine("Самое маленькое число: " + c);
            }
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            min();
            numbers_amount();
            numbers_sum();
            login();
            body_mass_index();

        }
    }
}
