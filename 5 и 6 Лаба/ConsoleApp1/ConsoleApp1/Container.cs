using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class ProgramSchedules<T>: Generic<T> where T : TVProgramm
    {
        private int duration_ = 0;
        private int countAdd = 0;
        public List<T> list;

        public ProgramSchedules()
        {
            list = new List<T>();
        }
      
        public void Find()
        {
            list = list.OrderByDescending(w => w).ToList();
        }
        public void Add(T item)
        {
            list.Add(item);
            duration_ += item.Duration();
            if (item.ToString() == "Add") countAdd++;
        }

        public void Add(T item, int count)
        {
            for (int i = 0; i < count ; i++)
            {
                list.Add(item);
                duration_ += item.Duration();
                if (item.ToString() == "Add") countAdd++;
            }
        }

        public void Delete(int index)
        {
            try
            {
                duration_ -= list[index].Duration();
                list.RemoveAt(index);
            }
            catch
            {
                Console.WriteLine("Incorrect index!");
            }
        }

        public void Show()
        {
            Console.WriteLine("\n\n------------Программа телеперадч--------------");
            foreach (T item in list)
            {
                Console.Write(item.ToString());
                if (item.ToString() == "Film") { Console.Write($"---'{(item as Film).Name() }'"); }
                Console.WriteLine();
            }
        }
        public void ShowDurOfPrSche()
        {
            int x=0, y=0;
            if (duration_ > 60)
            {
                
                x = duration_ / 60;
                y = duration_ % 60;
            }
            Console.WriteLine($"Current duration: {x} ч {y} мин");
        }
        public void ShowCountAdd()
        {
            Console.WriteLine($"Count of Add:{countAdd}");
        }
    }
}
