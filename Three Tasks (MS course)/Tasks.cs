using System;

namespace Three_Tasks__MS_course_
{
    public class Tasks
    {
        // У вас есть несколько камней известного веса w1, …, wn. 
        // Напишите программу, которая распределит камни в две кучи так, 
        // что разность весов этих двух куч будет минимальной.

        internal static void DoTask1()
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


        // Представим себе бесконечную последовательность цифр, 
        // составленную из записанных друг за другом возрастающих степеней десятки. 
        // Вот начало этой последовательности: 110100100010000… 
        // Всё, что надо — определить, 
        // какая цифра находится в такой последовательности на определённом месте.

        internal static void DoTask2()
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


        // Вам надо написать программу,
        // которая определяет по заданному разбиению избирателей на группы
        // минимальное количество сторонников партии, 
        // достаточное, при некотором распределении их по группам, 
        // для принятия любого решения.

        internal static void DoTask3()
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