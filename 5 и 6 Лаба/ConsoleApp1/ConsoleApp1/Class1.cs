using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    abstract class Producer
    {
        public override string ToString() => GetType().Name;
        public abstract void Print();
    }
    sealed class Cartoon : Producer, IProducer
    {
        public override void Print()
        {
            Console.WriteLine($"Абстрактный класс :{ToString()} ");
        }
         void IProducer.Print()
        {
            Console.WriteLine($"Интерфейс класс :{ToString()} ");
        }
    }
    ///<summary>
    //////////////////////////////////////////////////////////////////////////////////
    ///</summary>
    sealed class ArtissticFilm : Producer, IProducer
    {
        public enum film
        {
            comedy,
            thriller
        }
        public INFO[] infos;
        public struct INFO
        {
            private string[] name;
            private film FILM;
            public film SV
            {
                get
                {
                    return FILM;
                }
                set
                {
                    FILM = value;
                }
            }
            public string[] SV2
            {
                get
                {
                    return name;
                }
                set
                {
                    name = value;
                }
            }
        }


        public ArtissticFilm()
        {
            infos = new INFO[2];
            infos[0].SV = film.comedy;
            infos[0].SV2 = new string[2];
            infos[0].SV2[0] = "Любовь и голуби";
            infos[0].SV2[1] = "Счастливы вместе";
            infos[1].SV = film.thriller;
            infos[1].SV2 = new string[2];
            infos[1].SV2[0] = "Не дыши";
            infos[1].SV2[1] = "Тихое место";

        }
        ///<summary>
        ///////////////////////////////////////////////////////////////////////////////////////////////
        ///</summary>
        public override void Print()
        {
            Console.WriteLine($"Абстрактный класс :{ToString()} ");
        }
        void IProducer.Print()
        {
            Console.WriteLine($"Интерфейс класс :{ToString()} ");
        }
    }


    abstract class TVProgramm
    {
        Random rnd = new Random();
        public override string ToString()
        {
            return GetType().Name;
        }
        public abstract void ShowDuration();
        public  void ShowSubscribers()
        {
            Console.WriteLine($"{ToString()} сейчас смотрят {rnd.Next(1000,100000)} зрителей ");
        }
        public abstract int Duration();
    }
    class Film:TVProgramm
    {
        public int _year;
        public string name;
        private int _duration = 90;

        public override int Duration() => _duration;
        public  string Name() => name;
        public Film(string s,int year)
        {
            _year = year;
            name = s;
        }
        public override void ShowDuration()
        {
            Console.WriteLine($"Продолжительность фильма '{this.name}' {_duration} минут----Год выпуска:{this._year}");
        }
       
    }
    class Add : TVProgramm
    {
        
        private int _duration = 5;
        public override int Duration() => _duration;
        public override void ShowDuration()
        {
            Console.WriteLine($"Продолжительность {ToString()} {_duration} минут");
        }
    }
    class News : TVProgramm
    {
        
        private int _duration = 20;
        public override int Duration() => _duration;
        public override void ShowDuration()
        {
            Console.WriteLine($"Продолжительность {ToString()} {_duration} минут");
        }

    }
  

    
}
