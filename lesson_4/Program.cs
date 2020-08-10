using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Для работы с текстовым файлом
using System.IO;
using lesson_4;
//Калугин
//1. Дан  целочисленный  массив  из 20 элементов.  Элементы  массива  могут принимать  целые  значения  от –10 000 до 10 000 включительно. 
//Заполнить случайными числами.  Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3.
//В данной задаче под парой подразумевается два подряд идущих элемента массива. Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2. 

//2. Реализуйте задачу 1 в виде статического класса StaticClass;
//а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
//б) * Добавьте статический метод для считывания массива из текстового файла. Метод должен возвращать массив целых чисел;
//в)** Добавьте обработку ситуации отсутствия файла на диске.

//3. а) Дописать класс для работы с одномерным массивом. Реализовать конструктор, создающий массив определенного размера и заполняющий массив числами от начального значения с заданным шагом.
//Создать свойство Sum, которое возвращает сумму элементов массива, метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива (старый массив, остается без изменений),
// метод Multi, умножающий каждый элемент массива на определённое число, свойство MaxCount, возвращающее количество максимальных элементов. 
//б)** Создать библиотеку содержащую класс для работы с массивом.Продемонстрировать работу библиотеки
//е) *** Подсчитать частоту вхождения каждого элемента в массив(коллекция Dictionary<int, int>)

//4.Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив. Создайте структуру Account, содержащую Login и Password.

namespace lesson_4
{
    //Задание №3 начало
    #region
    class MyArray
        {
            //Задание №3 (e) начало
            public Dictionary<int, int> Counter()
            {
                Dictionary<int, int> dic = new Dictionary<int, int>();
                foreach (var i in a)
                {
                    if (!dic.ContainsKey(i)) dic.Add(i, 0);
                    dic[i]++;
                }
                return dic;
            }
            //Задание №3 (e) конец
            int[] a;
            public MyArray(int n, int el)
            {
                a = new int[n];
                for (int i = 0; i < n; i++)
                    a[i] = el;
            }
            public MyArray(int n,int MinValue,int MaxValue, bool flag)
            {
                a = new int[n];
                Random r = new Random();
                for(int i=0;i<a.Length; i++)
                {
                    a[i] = r.Next(MinValue, MaxValue+1);
                }

            }
            public MyArray(int n, int start, int step)
            {
                a = new int[n];
                a[0] = start;
                for (int i = 1; i < a.Length; i++)
                {
                    a[i] = a[i - 1] + step;
                }
            }
            public int Sum
            {
                get
                {
                    int s = 0;
                    foreach (var i in a)
                    {
                        s += i;
                    }
                    return s;
                }
            }
            public int[] Inverse()
            {
                int[] t = new int[a.Length];
                for (int i = 0; i < a.Length; i++)
                {
                    t[i] = -a[i];
                }
                return t;
            }
            public void Multi(int m)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    a[i] = a[i] * m;
                }
            }
            public int MaxCount
            {
                get
                {
                    int max = a[0];
                    int CountMax = 0;
                    for (int i = 1; i < a.Length; i++) if (a[i] > max) max = a[i];
                    foreach (var i in a) if (i == max) CountMax++;
                    return CountMax;
                }
            }
            public int Max
            {
                get
                {
                    int max = a[0];
                    for (int i = 1; i < a.Length; i++)
                        if (a[i] > max) max = a[i];
                    return max;
                }
            }
            public int Min
            {
                get
                {
                    int min = a[0];
                    for (int i = 1; i < a.Length; i++)
                        if (a[i] < min) min = a[i];
                    return min;
                }
            }
            public int CountPositiv
            {
                get
                {
                    int count = 0;
                    for (int i = 0; i < a.Length; i++)
                        if (a[i] > 0) count++;
                    return count;
                }
            }
            public override string ToString()
            {
                string s = "";
                foreach (int v in a)
                    s = s + v + " ";
                return s;
            }
        }
    }
    #endregion
    //Задание №3 конец


    //Задание №2 начало
    #region
    static class StaticClass
        {
            public static int[] array_from_file(string path)
            {
                string[] strArr = File.ReadAllLines(path);
                int[] temp = new int[strArr.Length];
                for (int i=0;i<temp.Length;i++)
                {
                    temp[i] = Convert.ToInt32(strArr[i]);
                }
                return temp;
            }
            public static int matchCouple(params int[]arr)
            {
                int sum = 0;
                int i;
                int j;
                for (i = 0, j = 1; j < arr.Length; i++, j++)
                {
                    if (arr[i] % 3 == 0 ^ arr[j] % 3 == 0)
                    {
                        sum++;

                    }
                }
                return sum;
            }
        }
        #endregion
    //Задание №2 конец
    class Program
    {
        //Задание №1 начало
        #region
        static void fillarray(ref int[] arr, Random random)
        {
            for(int i=0; i< arr.Length;  i++)
            {
                arr[i] = random.Next(-10000,10001);
            }
        }
        static void Print(ref int[]arr)
        {
            for (int i=0;i<arr.Length;i++)
            {
                Console.Write($" {arr[i]} ");
            }
        }
        static void match_couple(int[] arr)
        {
            int sum = 0;
            int i;
            int j;
            for (i = 0, j = 1 ; j < arr.Length; i++, j++)
            {
               if (arr[i] % 3 == 0 ^ arr[j] % 3 == 0)
               {
                    sum++;
                
               }
            }
            Console.WriteLine($"\nКоличество пар элементов массива, в которых только одно число делится на 3 равно {sum} .");
        }
        #endregion
        //Задание №1 конец
        static void Main(string[] args)
        {
        //Задание №1 начало
        #region
        //int[] array = new int[20];
        //Random r = new Random();
        //fillarray(ref array, r);
        //Print(ref array);
        //match_couple(array);
        //Console.ReadKey();
        #endregion
        //Задание №1 конец


        //Задание №2 начало
        #region
        //try
        //{
        //    int[] array = StaticClass.array_from_file("lesson_4.txt");
        //    foreach (var i in array)
        //    {
        //        Console.Write($"{i} ");
        //    }
        //    Console.WriteLine("\nКоличество пар элементов массива, в которых только одно число делится на 3 равно " + StaticClass.matchCouple(array));
        //}
        //catch (Exception)
        //{
        //    Console.Write("Файл не найден");
        //}
        //Console.ReadKey();
        #endregion
        //Задание №2 конец


        //Задание №3 начало
        #region
        MyArray array = new MyArray(20, -3, 3, true);
        Console.WriteLine(array.ToString());
        foreach (var i in array.Counter())
        {
            Console.WriteLine($"{i.Key,4} - {i.Value,4}");
        }
        Console.ReadKey();
        #endregion
        //Задание №3 конец
    }
}
