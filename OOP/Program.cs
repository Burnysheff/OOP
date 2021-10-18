using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp9
{
    public class Program
    {
        public static void Case1Time(ref Time[] mass)
        {
            int switchcase1 = 0;
            Console.WriteLine("\n1. Не указывая количество часов и минут");
            Console.WriteLine("2. Указать количество часов и минут");
            ProvMenu2(ref switchcase1);
            switch (switchcase1)
            {
                case 1:
                    mass[Time.count] = new Time();
                    mass[Time.count - 1].Print();
                    break;
                case 2:
                    int a = 0;
                    int b = 0;
                    Console.WriteLine("Введите количество часов:");
                    Provch(ref a);
                    Console.WriteLine("Введите количество минут:");
                    Provch(ref b);
                    mass[Time.count] = new Time(a, b);
                    mass[Time.count - 1].Print();
                    break;
            }
        }
        public static void Case2Time(ref int var, ref Time[] mass)
        {
            int minutes = 0;
            if (Time.count == 0)
            {
                Console.WriteLine("\nНи один объект еще не создан!");
                return;
            }
            uint number = Number(Time.count);
            Console.WriteLine("\nВведите, пожалуйста, количество прибавляемых минут: ");
            Console.WriteLine();
            Provch(ref minutes);
            if (var == 0)
            {
                mass[number - 1].AddTime1(minutes);
                mass[number - 1].Print();
                var = 1;
                Console.WriteLine("\nБыл использован метод класса Time");
                return;
            }
            if (var == 1)
            {
                mass[number - 1] = AddTime(ref mass[number - 1], minutes);
                mass[number - 1].Print();
                var = 0;
                Console.WriteLine("\nБыла использована статическая функция класса Program");
            }
        }
        public static void Case3Time(ref Time[] mass)
        {
            if (Time.count == 0)
            {
                Console.WriteLine("\nНи один объект еще не создан!");
                return;
            }
            uint number3 = Number(Time.count);
            mass[Time.count] = mass[number3 - 1];
            mass[Time.count]++;
            mass[Time.count - 1].Print();
        }
        public static void Case4Time(ref Time[] mass)
        {
            if (Time.count == 0)
            {
                Console.WriteLine("\nНи один объект еще не создан!");
                return;
            }
            uint number4 = Number(Time.count);
            mass[Time.count] = mass[number4 - 1];
            mass[Time.count]--;
            mass[Time.count - 1].Print();
        }
        public static void Case5Time(ref Time[] mass)
        {
            if (Time.count == 0 || Time.count == 1)
            {
                Console.WriteLine("\nСоздано недостаточно объектов для сложения!");
                return;
            }
            uint number51 = Number(Time.count);
            uint number52 = Number(Time.count);
            mass[Time.count] = mass[number51 - 1] + mass[number52 - 1];
            mass[Time.count - 1].Print();
        }
        public static void Case6Time(ref Time[] mass)
        {
            if (Time.count == 0 || Time.count == 1)
            {
                Console.WriteLine("\nСоздано недостаточно объектов для вычитания!");
                return;
            }
            uint number61 = Number(Time.count);
            uint number62 = Number(Time.count);
            mass[Time.count] = mass[number61 - 1] - mass[number62 - 1];
            mass[Time.count - 1].Print();
        }
        public static void Case7Time(ref Time[] mass)
        {
            if (Time.count == 0)
            {
                Console.WriteLine("\nНи один объект еще не создан!");
                return;
            }
            uint number7 = Number(Time.count);
            int res = (int)mass[number7 - 1];
            Console.WriteLine($"\nКоличество часов: {res}");
        }
        public static void Case8Time(ref Time[] mass)
        {
            if (Time.count == 0)
            {
                Console.WriteLine("\nНи один объект еще не создан!");
                return;
            }
            uint number8 = Number(Time.count);
            bool nul = mass[number8 - 1];
            Console.WriteLine($"\nРезультат: {nul}");
        }
        public static void Case1TimeArray(ref TimeArray[] massiv)
        {
            massiv[TimeArray.count] = new TimeArray();
            Console.WriteLine($"\nПолучившийся массив (№{TimeArray.count}): ");
            massiv[TimeArray.count - 1].Show();
        }
        public static void Case2TimeArray(ref TimeArray[] massiv)
        {
            int len = 0;
            Console.WriteLine("\nВведите, пожалуйста, длину массива: ");
            Provch(ref len);
            massiv[TimeArray.count] = new TimeArray(len);
            Console.WriteLine($"\nПолучившийся массив (№{TimeArray.count}): ");
            massiv[TimeArray.count - 1].Show();
        }
        public static void Case3TimeArray(ref TimeArray[] massiv)
        {
            Console.WriteLine("\nВведите, пожалуйста, длину массива: ");
            int leng = 0;
            Provch(ref leng);
            Time[] mas = new Time[leng];
            for (int i = 0; i < leng; i++)
            {
                Console.WriteLine($"\n{i + 1} элемент: ");
                int switchcase1 = 0;
                Console.WriteLine("\n1. Не указывая количество часов и минут");
                Console.WriteLine("2. Указать количество часов и минут");
                ProvMenu2(ref switchcase1);
                switch (switchcase1)
                {
                    case 1:
                        mas[i] = new Time();
                        break;
                    case 2:
                        int a = 0;
                        int b = 0;
                        Console.WriteLine("Введите количество часов:");
                        Provch(ref a);
                        Console.WriteLine("Введите количество минут:");
                        Provch(ref b);
                        mas[i] = new Time(a, b);
                        break;
                }
            }
            massiv[TimeArray.count] = new TimeArray(leng, mas);
            Console.WriteLine($"\nПолучившийся массив (№{TimeArray.count}): ");
            massiv[TimeArray.count - 1].Show();
        }
        public static void Case4TimeArray(ref TimeArray[] massiv, Time[] mass)
        {
            if (Time.count == 0)
            {
                Console.WriteLine("В Time нет ни одного объекта!");
                return;
            }
            massiv[TimeArray.count] = new TimeArray(mass);
            Console.WriteLine($"\nПолучившийся массив (№{TimeArray.count}): ");
            massiv[TimeArray.count - 1].Show();
        }
        public static void Case5TimeArray(ref TimeArray[] massiv)
        {
            if (TimeArray.count == 0)
            {
                Console.WriteLine("Ни один объект еще не создан!");
                return;
            }
            uint number25 = Number(TimeArray.count);
            if (massiv[number25 - 1].Length == 0)
            {
                Console.WriteLine("Массив пустой, вычислять нечего!");
                return;
            }
            int sumhours = 0;
            int summinutes = 0;
            for (int i = 0; i < massiv[number25 - 1].Length; i++)
            {
                sumhours = sumhours + massiv[number25 - 1][i].Hours;
                summinutes = summinutes + massiv[number25 - 1][i].Minutes;
            }
            int res = ((sumhours * 60 + summinutes) / massiv[number25 - 1].Length);
            int reshours = res / 60;
            int resmin = res % 60;
            Time result = new Time(reshours, resmin);
            result.PrintMas();
        }
        public static Time AddTime(ref Time a, int minutes)
        {
            a.Minutes = a.Minutes + minutes;
            return a;
        }
        static uint Number(int count)
        {
            uint n;
            bool ok = true;
            do
            {
                Console.WriteLine("Введите номер объекта:");
                string buf = Console.ReadLine();
                ok = uint.TryParse(buf, out n);
                if (!ok || n == 0)
                {
                    Console.WriteLine("Номер объекта должен быть положительным числом!");
                    ok = false;
                }
                else
                {
                    if (n > count)
                    {
                        Console.WriteLine("Такой объект еще не создан!");
                        ok = false;
                    }
                }
            } while (ok == false);
            return n;
        }
        static void Provch(ref int per)
        {
            int n;
            bool ok;
            do
            {
                string buf = Console.ReadLine();
                ok = int.TryParse(buf, out n);
                if (ok)
                {
                    if (n < 0) Console.WriteLine("\nЭто число должно быть неотрицательным!");
                    per = n;
                }
                else
                {
                    per = 0;
                    Console.WriteLine("Введите, пожалуйста, целое неотрицательное число!");
                }
            } while (!ok || n < 0);
        }
        static void ProvMenu4(ref int per)
        {
            int n;
            bool ok;
            do
            {
                Console.WriteLine("\nВаш выбор:");
                string buf = Console.ReadLine();
                ok = int.TryParse(buf, out n);
                if (ok)
                {
                    per = n;
                }
                else
                {
                    per = 0;
                    Console.WriteLine("Выберите, пожалуйста, один из вариантов!");
                }
            } while (!ok || n < 1 || n > 6);
        }
        static void ProvMenu3(ref int per)
        {
            int n;
            bool ok;
            do
            {
                Console.WriteLine("\nВаш выбор:");
                string buf = Console.ReadLine();
                ok = int.TryParse(buf, out n);
                if (ok)
                {
                    per = n;
                }
                if (!ok || n < 1 || n > 3)
                {
                    per = 0;
                    Console.WriteLine("Выберите, пожалуйста, один из вариантов!");
                }
            } while (!ok || n < 1 || n > 3);
        }
        static void ProvMenu2(ref int per)
        {
            int n;
            bool ok;
            do
            {
                Console.WriteLine("\nВаш выбор:");
                string buf = Console.ReadLine();
                ok = int.TryParse(buf, out n);
                if (ok)
                {
                    per = n;
                }
                if (!ok || n < 1 || n > 2)
                {
                    per = 0;
                    Console.WriteLine("Выберите, пожалуйста, один из вариантов!");
                }
            } while (!ok || n < 1 || n > 2);
        }
        static void ProvMenu(ref int per)
        {
            int n;
            bool ok;
            do
            {
                Console.WriteLine("\nВаш выбор:");
                string buf = Console.ReadLine();
                ok = int.TryParse(buf, out n);
                if (ok)
                {
                    per = n;
                }
                else
                {
                    per = 0;
                    Console.WriteLine("Выберите, пожалуйста, один из вариантов!");
                }
            } while (!ok || n < 1 || n > 9);
        }
        static void Main(string[] args)
        {
            int switchCase = 0;
            int var = 0;
            Time[] mass = new Time[50];
            Console.WriteLine("1. Работа с классом Time");
            Console.WriteLine("2. Работа с классом TimeArray");
            Console.WriteLine("3. Конец пограммы");
            do
            {
                ProvMenu3(ref switchCase);
                switch (switchCase)
                {
                    case 1:
                        Console.Clear();
                        int switchcase = 0;
                        Console.WriteLine("1. Создать и вывести элемент класса");
                        Console.WriteLine("2. Прибавить минуты к элементу класса");
                        Console.WriteLine("3. Прибавить минуту к объекту класса (перегрузка ++)");
                        Console.WriteLine("4. Вычесть минуту из объекту класса (перегрузка --)");
                        Console.WriteLine("5. Сложить два объекта (перегрузка +)");
                        Console.WriteLine("6. Вычесть один объект из другого (перегрузка -)");
                        Console.WriteLine("7. Получить количество часов элемента (минуты отбрасываются) - явное приведение типа");
                        Console.WriteLine("8. Часы и минуты равны нулю? true - нет; false - да. (Неявное приведение типа)");
                        Console.WriteLine("9. Выход");
                        do
                        {
                            ProvMenu(ref switchcase);
                            switch (switchcase)
                            {
                                case 1:
                                    Case1Time(ref mass);
                                    break;
                                case 2:
                                    Case2Time(ref var, ref mass);
                                    break;
                                case 3:
                                    Case3Time(ref mass);
                                    break;
                                case 4:
                                    Case4Time(ref mass);
                                    break;
                                case 5:
                                    Case5Time(ref mass);
                                    break;
                                case 6:
                                    Case6Time(ref mass);
                                    break;
                                case 7:
                                    Case7Time(ref mass);
                                    break;
                                case 8:
                                    Case8Time(ref mass);
                                    break;
                            }
                        } while (switchcase != 9);
                        Console.WriteLine($"\nКоличество созданных объектов: {Time.count}");
                        Console.WriteLine("\n\nЧто дальше?");
                        Console.WriteLine("1. Работа с классом Time");
                        Console.WriteLine("2. Работа с классом TimeArray");
                        Console.WriteLine("3. Конец пограммы");
                        break;
                    case 2:
                        TimeArray[] massiv = new TimeArray[25];
                        int switchcase2 = 0;
                        Console.Clear();
                        Console.WriteLine("Как вы хотите сформировать массив?");
                        Console.WriteLine("1. Один нулевой элемент (конструктор без параметров)");
                        Console.WriteLine("2. Заполнение случайными числами с указанием размера");
                        Console.WriteLine("3. Заполнение вручную с указанием размера");
                        Console.WriteLine("4. Перенос значений из работы с классом Time");
                        Console.WriteLine("5. Вычислить среднее арфиметическое.");
                        Console.WriteLine("6. Конец работы с TimeArray");
                        do
                        {
                            ProvMenu4(ref switchcase2);
                            switch (switchcase2)
                            {
                                case 1:
                                    Case1TimeArray(ref massiv);
                                    break;
                                case 2:
                                    Case2TimeArray(ref massiv);
                                    break;
                                case 3:
                                    Case3TimeArray(ref massiv);
                                    break;
                                case 4:
                                    Case4TimeArray(ref massiv, mass);
                                    break;
                                case 5:
                                    Case5TimeArray(ref massiv);
                                    break;
                            }
                        } while (switchcase2 != 6);
                        Console.WriteLine($"\nКоличество созданных объектов: {TimeArray.count}");
                        Console.WriteLine("\n\nЧто дальше?");
                        Console.WriteLine("1. Работа с классом Time");
                        Console.WriteLine("2. Работа с классом TimeArray");
                        Console.WriteLine("3. Конец программы");
                        break;
                    case 3:
                        Console.WriteLine("\nСпасибо за использование!");
                        break;
                }
            } while (switchCase != 3);
            Console.WriteLine($"\nВсего создано объектов: {Time.count + TimeArray.count}");
        }
    }
}
