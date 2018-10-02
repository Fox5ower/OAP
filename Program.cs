using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        // Данный метод возвращает кортеж с 4-мя
        // разными значениями
        static Tuple<int, string, char, ulong> Corteg(int a, string name)
        {
            int sqr = a * a;
            ulong sqrt = (ulong)(Math.Sqrt(a));
            string s = "Привет, " + name;
            char ch = (char)(name[0]);

            return Tuple.Create<int, string, char, ulong>(sqr, s, ch, sqrt);
        }

        static void Main(string[] args)
        {
            var myTuple = Corteg(25, "Alexandr");
            Console.WriteLine("{0}\n25 в квадрате: {1}\nКвадратный корень из 25: "
                + "{2}\nПервый символ в имени: {3}\n", myTuple.Item3, myTuple.Item1, myTuple.Item2, myTuple.Item4);

            // Создаем кортеж произвольной размерности
            var myTuple2 = Tuple.Create<int, char, string, decimal, float, byte, short, Tuple<int, string, char, ulong>>(12, 'C', "Name", 12.3892m, 0.5f, 120, 4501, myTuple);
            Console.ReadLine();
        }

    }

    public class Tuple<T1, T2, T3, T4, T5, T6, T7, TRest>
    {
    }
}