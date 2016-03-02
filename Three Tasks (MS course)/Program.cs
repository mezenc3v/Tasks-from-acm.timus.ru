using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Three_Tasks__MS_course_
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите номер нужной задачи:");
            Console.WriteLine("1. \"Куча камней\"");
            Console.WriteLine("2. \"1, 10, 100, 1000...\"");
            Console.WriteLine("3. \"Демократия в опасности\"");

            //Выбор задачи
            int number = 0;
            while (number < 1 || number > 3)
            {
                number = Convert.ToInt32(Console.ReadLine());
            }

            switch (number)
            {
                case 1:
                    Console.Clear();
                    DoTask1();
                    break;
                case 2:
                    Console.Clear();
                    DoTask2();
                    break;
                case 3:
                    Console.Clear();
                    DoTask3();
                    break;
            }
            Console.Clear();
        }

        /*
            У вас есть несколько камней известного веса w1, …, wn. 
            Напишите программу, которая распределит камни в две кучи так, 
            что разность весов этих двух куч будет минимальной.
        */
        private static void DoTask1()
        {
            int n = 0;
            Console.WriteLine("Введите количество камней:");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите вес каждого камня:");
            int[] stones = new int[n];
            for (int i = 0; i < n; i++)
            {
                stones[i] = Convert.ToInt32(Console.ReadLine());
            }

            int result = 0;
            Array.Sort(stones);
            for (int i = n - 1; i >= 0; i--)
            {
                if (result >= 0)
                {
                    result -= stones[i];
                }
                else
                {
                    result += stones[i];
                }
            }
            Console.WriteLine("Минимальная разность весов двух куч: " + Math.Abs(result));
            Console.WriteLine("Для продолжения нажмите Enter..");
            Console.Read();

        }

        /*
           Представим себе бесконечную последовательность цифр, 
           составленную из записанных друг за другом возрастающих степеней десятки. 
           Вот начало этой последовательности: 110100100010000… 
           Всё, что надо — определить, 
           какая цифра находится в такой последовательности на определённом месте.
        */
        private static void DoTask2()
        {
            Console.WriteLine("Введите количество строк:");
            int n = Convert.ToInt32(Console.ReadLine());

            // Запись проверяемых позиций в массив
            var positions = new double[n];
            for (int i = 0; i < n; i++)
            {
                positions[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Результат:");
            for (int i = 0; i < n; i++)
            {
                double result = Math.Sqrt(8.0 * positions[i] - 7.0);

                if (Math.Abs(result - Math.Round(result)) < 0.0001)
                {
                    Console.WriteLine(1);
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
            Console.WriteLine("Для продолжения нажмите Enter..");
            Console.Read();
        }

        /*
           Вам надо написать программу, 
           которая определяет по заданному разбиению избирателей на группы 
           минимальное количество сторонников партии, 
           достаточное, при некотором распределении их по группам, 
           для принятия любого решения.
       */
        private static void DoTask3()
        {
            int n = 0;
            Console.WriteLine("Введите количество групп (нечетное число):");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите численность каждой группы (нечетное число):");
            int[] people = new int[n];
            for (int i = 0; i < n; i++)
            {
                people[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(people);
            int result = 0;
            for (int i = 0; i < (n - (n / 2)); i++)
            {
                result = result + (people[i] / 2) + 1;
            }
            Console.WriteLine("Минимальное количество сторонников партии,\n" +
                "способное решить исход голосования: " + result);
            Console.WriteLine("Для продолжения нажмите Enter..");
            Console.Read();
        }
    }


}
