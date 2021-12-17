using System;

namespace ConsoleApp2
{
    class program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Сьогоднi : " + DateTime.Now);
            Console.WriteLine("Вкажiть дату в такому форматi : dd-MM-yyyy");
            string udate = Console.ReadLine();
            string[] input = udate.Split("-");

            int year = Int32.Parse(input[2]);
            int month = Int32.Parse(input[1]);
            int day = Int32.Parse(input[0]);

            Console.WriteLine("Ви вказали : " + udate);
            DateTime x = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            DateTime y = new DateTime(year, month, day);

            TimeSpan ts = y - x;
            Console.WriteLine("Рiзниця мiж датами : " + ts.Days + " дня.");
            Console.ReadLine();
        }
    }
}