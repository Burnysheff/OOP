using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp9
{
    public class TimeArray
    {
        static public int count = 0;
        public Time[] array;
        static Random rnd = new Random();
        public int Length
        {
            get { return array.Length; }
        }
        public TimeArray(int size)
        {
            count = count + 1;
            array = new Time[size];
            for (int i = 0; i < size; i++)
            {
                Time m = new Time();
                Time.count--;
                m.Hours = rnd.Next(0, 20);
                m.Minutes = rnd.Next(0, 20);
                array[i] = m;
            }
        }
        public TimeArray()
        {
            count = count + 1;
            array = new Time[1];
            Time a = new Time();
            Time.count--;
            a.Hours = 0;
            a.Minutes = 0;
            array[0] = a;
        }
        public TimeArray(params Time[] mass)
        {
            count = count + 1;
            array = new Time[mass.Length];
            for (int i = 0; i < mass.Length; i++)
            {
                array[i] = mass[i];
            }
        }
        public TimeArray(int a, params Time[] mass)
        {
            count = count + 1;
            array = new Time[a];
            for (int i = 0; i < a; i++)
            {
                array[i] = mass[i];
            }
        }
        public Time this[int index]
        {
            get
            {
                try
                {
                    return array[index];
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Элемента с таким номеом не существует!");
                    return array[0];
                }
            }
            set
            {
                try
                {
                    array[index] = value;
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Элемент с таким номером еще не создан!");
                }
            }
        }
        public void Show()
        {
            if (Length == 0)
            {
                Console.WriteLine("Маcсив пустой!");
            }
            for (int i = 0; i < Length; i++)
            {
                Console.WriteLine($"\n{i + 1} элемент: ");
                array[i].PrintMas();
            }
        }
    }
}
