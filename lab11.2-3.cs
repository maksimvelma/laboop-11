using System;
using System.Collections.Generic;

namespace LB11_2_3
{
    class RandomDateTime
    {
        DateTime start;
        Random gen;
        int range;

        public RandomDateTime()
        {
            start = new DateTime(2015, 1, 1);
            gen = new Random();
            range = (DateTime.Today - start).Days;
        }

        public DateTime Next()
        {

            return start.AddDays(gen.Next(range));
        }
    }


    class Date
    {


        static void Main(string[] args)
        {
            RandomDateTime date = new RandomDateTime();
            Console.WriteLine("Дати : \n");

            List<int> termsList = new List<int>();
            List<DateTime> list = new List<DateTime>();

            for (int i = 0; i < 3; i++)
            {


                DateTime dt = date.Next();

                termsList.Add(dt.Year);


                list.Add(new DateTime(dt.Year, dt.Month, dt.Day));

                Console.WriteLine(dt);

                Console.WriteLine("Рiк : " + dt.Year);
                Console.WriteLine("Мiсяць : " + dt.Month);
                Console.WriteLine("День : " + dt.Day);
                Console.WriteLine("----------------------------");



            }
            List<DateTime> SpringDates = new List<DateTime>();
            string sdate = "";
            for (int i = 0; i < 3; i++)
            {
                if (list[i].Month == 3 || list[i].Month == 4 || list[i].Month == 5)
                {
                    SpringDates.Add(list[i]);
                }

            }
            var len = SpringDates.Count();
            if (len == 0) { sdate = "Немає у списку"; }
            else
            {
                sdate = SpringDates[0].ToString();
            }
            int[] terms = termsList.ToArray();
            DateTime biggestDate = list.Max(p => p);

            Console.WriteLine("Рiк з найменшим номером : " + terms.Min());
            Console.WriteLine("Сама пiздня дата : " + biggestDate);
            Console.WriteLine("Весняна дата : " + sdate);
            Console.WriteLine("______________________________________________");
            Console.WriteLine("Нажмiть клавiшу ENTER щоб перейти на наступний етап. \n");

            Console.ReadLine();
            Console.WriteLine("Взнати рiзницю =>");

            Console.WriteLine("Сьогоднi : " + DateTime.Now);
            Console.WriteLine("Укажіть дату в такому вигляді : dd-MM-yyyy");
            string udate = Console.ReadLine();
            string[] input = udate.Split("-");

            int year = Int32.Parse(input[2]);
            int month = Int32.Parse(input[1]);
            int day = Int32.Parse(input[0]);

            Console.WriteLine("Ви вказали : " + udate);
            DateTime x = new(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            DateTime y = new(year, month, day);

            TimeSpan ts = y - x;
            Console.WriteLine("Рiзниця мiж датами : " + ts.Days + " дня.");

            Console.WriteLine("Вказаний рiк : " + year + "\n" + "Вказаний мiсяць : " + month + "\n" + "Вказаний день : " + day);
            Console.ReadLine();

        }
    }
}