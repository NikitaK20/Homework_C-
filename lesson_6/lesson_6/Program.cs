using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Калугин
//Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double). Продемонстрировать работу на функции с функцией a* x^2 и функцией a* sin(x).

//Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
//Сделать меню с различными функциями и представить пользователю выбор, для какой функции и на каком отрезке находить минимум.Использовать массив(или список) делегатов, в котором хранятся различные функции.

namespace lesson_6
{
    public delegate double Fun(double x,double a);
    class Program
    {
        //Задание №1
        #region
        //public static void Table(Fun F, double x, double a, double b)
        //{
        //    Console.WriteLine("----- X ----- A ----- Y -----");
        //    while (x <= b)
        //    {
        //        Console.WriteLine($"| {x:0.000} | {a:0.000} | {F(x,a):0.000} |");
        //        x += 1;
        //        a += 1;
        //    }
        //    Console.WriteLine("---------------------");
        //}
        //public static double MyFunc(double x, double a)
        //{
        //    return a * (x * x);
        //}
        //public static double Sinus(double x, double a)
        //{
        //    return a * Math.Sin(x);
        //}
        #endregion
        //Задание №2
        #region
        public delegate double function(double x);
        public static double Fun1(double x)
        {
            return x * x - 50 * x + 10;
        }

        public static double Fun2(double x)
        {
            return x * x - 10 * x + 50;
        }
        public static void SaveFunc(string fileName, double a, double b, double h, function F)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(F(x));
                x += h;
            }
            bw.Close();
            fs.Close();
        }
        public static double Load(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                d = bw.ReadDouble();
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return min;
        }
        #endregion
        static void Main()
        {
            //Задание №1
            #region
            //Console.WriteLine("Таблица функции y=a*x^2 :");
            //Table(new Fun(MyFunc), -2, -1, 2);
            //Console.WriteLine("Таблица функции y=a*sin(x):");
            //Table(new Fun(Sinus), -2,-1, 2);
            //Console.ReadLine();
            #endregion
            //Задание №2
            #region
            function[] F = { Fun1, Fun2 };
            Console.WriteLine("Для какой функции найти минимум: 1 / 2 ?");
            int index = int.Parse(Console.ReadLine());
            SaveFunc("data.bin", -100, 100, 0.5, F[index - 1]);
            Console.WriteLine(Load("data.bin"));
            Console.ReadKey();
            #endregion
        }

    }
}
