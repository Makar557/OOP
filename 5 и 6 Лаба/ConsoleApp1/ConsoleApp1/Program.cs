using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cartoon cart1 = new Cartoon();
            cart1.Print();
            IProducer cart2 = new Cartoon();
            cart2.Print();

            News news = new News();
             Film[] film = new Film[3];
             film[0] = new Film("ХУИ ГАЛАКТИКИ",2015);
             film[1] = new Film("La_KOLGOTi",2017);
             film[2] = new Film("ХУИ ГАЛАКТИКИ 2",2017);

            Add add = new Add();
            news.ShowDuration();
            news.ShowSubscribers();

            Console.WriteLine();
            film[0].ShowDuration();
            film[0].ShowSubscribers();
            film[1].ShowDuration();
            film[1].ShowSubscribers();
            film[2].ShowDuration();
            film[2].ShowSubscribers();

            Console.WriteLine("Введите год:");
            int x = int.Parse(Console.ReadLine());
            Console.Write($"Фильмы, выпущенные в {x}:");
            foreach(var elem in film)
            {
                if (elem._year == x) Console.Write($"'{elem.name}';");
                
            }
            ////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine();
            ArtissticFilm artFilm = new ArtissticFilm();
            foreach(var elem in artFilm.infos)
            {
                Console.Write($"Genre:{elem.SV}--------\nRecomendation:{elem.SV2[0]}, {elem.SV2[1]}\n----------------------\n");
            }
            ////////////////////////////////////////////////////////////////////////////////////////////////////
            ///




            ProgramSchedules<TVProgramm> schedules = new ProgramSchedules<TVProgramm>();
            schedules.Add(film[0]);
            schedules.Add(add, 2);
            schedules.Add(film[2]);
            schedules.Add(add,2);
            schedules.Add(news);
            schedules.Show();
            schedules.ShowCountAdd();
            schedules.ShowDurOfPrSche();


        }
    }
}
