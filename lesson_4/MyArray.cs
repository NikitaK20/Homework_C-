//Калугин
//3. а) Дописать класс для работы с одномерным массивом. Реализовать конструктор, создающий массив определенного размера и заполняющий массив числами от начального значения с заданным шагом.
//Создать свойство Sum, которое возвращает сумму элементов массива, метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива (старый массив, остается без изменений),
// метод Multi, умножающий каждый элемент массива на определённое число, свойство MaxCount, возвращающее количество максимальных элементов. 
//б)** Создать библиотеку содержащую класс для работы с массивом.Продемонстрировать работу библиотеки
//е) *** Подсчитать частоту вхождения каждого элемента в массив(коллекция Dictionary<int, int>)


using System.Collections.Generic;

namespace lesson_4
{
    //Задание №3 (б) начало
    #region
    //    class MyArray
    //    {   
    //        //Задание №3 (e) начало
    //        public Dictionary<int, int> Counter()
    //        {
    //            Dictionary<int, int> dic = new Dictionary<int, int>();
    //            foreach(var i in a)
    //            {
    //                if (!dic.ContainsKey(i)) dic.Add(i, 0);
    //                dic[i]++;
    //            }
    //            return dic;
    //        }
    //        //Задание №3 (e) конец
    //        int[] a;
    //        public MyArray(int n, int el)
    //        {
    //            a = new int[n];
    //            for (int i = 0; i < n; i++)
    //                a[i] = el;
    //        }
    //        public MyArray(int n, int start, int step)
    //        {
    //            a = new int[n];
    //            a[0] = start;
    //            for (int i = 1; i < a.Length; i++)
    //            {
    //                a[i] = a[i - 1] + step;
    //            }
    //        }
    //        public int Sum
    //        {
    //            get
    //            {
    //                int s = 0;
    //                foreach(var i in a)
    //                {
    //                    s += i;
    //                }
    //                return s;
    //            }
    //        }
    //        public int[] Inverse()
    //        {
    //            int[] t = new int[a.Length];
    //            for(int i=0;i<a.Length;i++)
    //            {
    //                t[i] = -a[i];
    //            }
    //            return t;
    //        }
    //        public void Multi(int m)
    //        {
    //            for(int i=0 ; i<a.Length ; i++)
    //            {
    //                a[i]=a[i]*m;
    //            }
    //        }
    //        public int MaxCount
    //        {
    //            get 
    //            {
    //                int max = a[0];
    //                int CountMax = 0;
    //                for (int i = 1; i < a.Length; i++) if (a[i] > max) max = a[i];
    //                foreach(var i in a) if (i== max) CountMax++;
    //                return CountMax;
    //            }
    //        }
    //        public int Max
    //        {
    //            get
    //            {
    //                int max = a[0];
    //                for (int i = 1; i < a.Length; i++)
    //                    if (a[i] > max) max = a[i];
    //                return max;
    //            }
    //        }
    //        public int Min
    //        {
    //            get
    //            {
    //                int min = a[0];
    //                for (int i = 1; i < a.Length; i++)
    //                    if (a[i] < min) min = a[i];
    //                return min;
    //            }
    //        }
    //        public int CountPositiv
    //        {
    //            get
    //            {
    //                int count = 0;
    //                for (int i = 0; i < a.Length; i++)
    //                    if (a[i] > 0) count++;
    //                return count;
    //            }
    //        }
    //        public override string ToString()
    //        {
    //            string s = "";
    //            foreach (int v in a)
    //                s = s + v + " ";
    //            return s;
    //        }
    //    }
}
////Задание №3 (б) конец
#endregion