using System;
using static Three_Tasks__MS_course_.Tasks;

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

        

    }


}
