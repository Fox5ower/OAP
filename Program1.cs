using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    internal class Program
    {
        private static string hey;
        private static bool i16;
        private static char sixteen;

        private static void Main(string[] args)
        {
            //1)
            //a)

            sbyte first = 8;
            short second = 16;
            int third = 32;
            long fourth = 64;
            byte fifth = 8;
            ushort six = 16;
            uint seven = 32;
            ulong eighth = 64;
            char nine = sixteen;
            bool ten = true;
            float eleven = 32;
            double twelve = 64;
            decimal thirteen = 128;
            string fourteen = hey;
            object fifteen = hey;

            //b)

            Int32 i32 = 5;
            Int64 i64 = i32;


            Byte l = (Byte) i32;
            var v = (object) l;
            Single g = (Int64) i64;
            Int64 d1 = 5;
            long w = (long) d1;
            Double d = (int) 13;
            Int64 e = (Int32) i32;

            //c)

            int a = 1; //а - значимый тип
            object o = a; // упаковка
            //o - ссылочный тип. можно передавать в параметры функции,как аргумент ссылочного типа

            int b = (int) o; //явная распаковка
            //b - значимый тип

            Int32 m = 5;
            object r = m;
            Console.WriteLine(m + ", " + r);
            // упаковка происходит дважды, первый раз во второй строке, второй раз неявно
            // в 3 строке, когда int и object объединяются компилятором чтобы получился string

            //d)

            var date = 15;
            Type dateType = date.GetType();
            Console.WriteLine("Тип date {0}", dateType);

            //e)

            int? x = null;
            if (x.HasValue)
                Console.WriteLine(x.Value);
            else
                Console.WriteLine("x is equal to null");
            //2)
            //a)

            string str = "str";
            object obj = "str";
            bool result = str.Equals(obj);
            Console.WriteLine(result);

            //b)


            string str1 = "first string";
            string str2 = "second string";
            string str3 = "third string";
            string.Concat(str1, str2);
            string[] words = str1.Split(new char[] {' '});
            str2 = str2.Trim(new char[] {'s', 'g'});
            str1 = str1.Insert(12, " " + str2);
            // .Replace - замена, (то, что нужно заменить , то, чем заменяем)

            //c)

            string strNull = null;
            string strFull = "full";
            strNull = strFull;
            string newStr = String.Format("{0} + {1} = {2}", strNull, strFull, strNull + strFull);
            Console.WriteLine(strNull);
            Console.WriteLine(newStr);

            //d)

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 10; i++) sb.Append(i + ",");
            Console.WriteLine(sb.ToString());
            sb.Append("summ ");
            sb.AppendFormat("summ in the end");
            sb.Insert(0, "beginning ");
            Console.WriteLine(sb);

            //3)
            //a)

            int[,] mas = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } };

            int rows = mas.GetUpperBound(0) + 1;
            int columns = mas.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mas[i, j]} \t");
                }
                Console.WriteLine();

                //b)

                Console.WriteLine("Введите размер массива");
                int n = int.Parse(Console.ReadLine());
                string[] arr = new string[n];
                Console.WriteLine("Вводите элементы массива массива нажимая Enter");
                for (int t = 0; t < n; t++)
                {
                    arr[t] = Console.ReadLine(); // заполнение массива
                }
                Console.WriteLine("Массив: ");
                foreach (string s in arr) Console.Write(s + " "); // вывод массива 
                int length = arr.Length;
                Console.WriteLine(length);
                Console.ReadLine();
            }


            }
        }
        }
    
