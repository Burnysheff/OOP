using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp9
{
    public class Time
    {
        static public int count = 0;
        public int hours;
        public int Hours
        {
            get { return hours; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Время не может быть отрицательным!");
                    hours = 0;
                }
                else hours = value;
            }
        }
        public int minutes;
        public int Minutes
        {
            get { return minutes; }
            set
            {
                if (value > 59)
                {
                    Hours = Hours + value / 60;
                    minutes = value % 60;
                    Console.WriteLine($"\n{value} минут конвертировалось в {value / 60} часов {value % 60} минут");
                }
                else
                {
                    if (value < 0)
                    {
                        if (Math.Abs(value) > minutes)
                        {
                            if (Hours > 0)
                            {
                                Hours = Hours - 1;
                                minutes = 60 + minutes + value;
                            }
                            else
                            {
                                Console.WriteLine("Время не может быть отрицательным!");
                                minutes = 0;
                            }
                        }
                    }
                    else minutes = value;
                }
            }
        }
        public Time()
        {
            Hours = 0;
            Minutes = 0;
            count = count + 1;
        }
        public Time(int a, int b)
        {
            Hours = a;
            Minutes = b;
            count = count + 1;
        }
        public void PrintMas()
        {
            Console.WriteLine($"\n{Hours} часов {Minutes} минут");
        }
        public void Print()
        {
            Console.WriteLine($"\n{count} элемент класса: {Hours} часов {Minutes} минут");
        }
        public Time AddTime1(int minutes)
        {
            this.Hours = this.Hours;
            this.Minutes = this.Minutes + minutes;
            return this;
        }
        public static Time operator ++(Time t)
        {
            Time a = new Time();
            a.Hours = t.Hours;
            a.Minutes = t.Minutes + 1;
            return a;
        }
        public static Time operator --(Time t)
        {
            if (t.Minutes == 0)
            {
                if (t.Hours == 0)
                {
                    Console.WriteLine("\nВычесть невозможно - получается отрицательное время!");
                    return t;
                }
            }
            Time a = new Time();
            a.Hours = t.Hours;
            a.Minutes = t.Minutes - 1;
            return a;
        }
        public static Time operator +(Time a, Time b)
        {
            Time q = new Time();
            q.Hours = a.Hours + b.Hours;
            q.Minutes = a.Minutes + b.Minutes;
            return q;
        }
        public static Time operator -(Time a, Time b)
        {
            Time q = new Time();
            if (a.Hours < b.Hours)
            {
                Console.WriteLine("Получается отрицательное время!");
                q.Hours = 0;
                q.Minutes = 0;
                return q;
            }
            q.Hours = a.Hours - b.Hours;
            q.Minutes = a.Minutes - b.Minutes;
            return q;
        }
        public static explicit operator int(Time t)
        {
            return t.Hours;
        }
        public static implicit operator bool(Time t)
        {
            if (t.Hours == 0 && t.Minutes == 0) return false;
            else return true;
        }
        public override bool Equals(object obj)
        {
            if (obj is Time)
            {
                Time t = (Time)obj;
                return this.Hours == t.Hours && this.Minutes == t.Minutes;
            }
            else return false;
        }
    }
}
