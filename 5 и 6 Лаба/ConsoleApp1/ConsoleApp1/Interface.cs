using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    interface Generic<T>
    {
        void Add(T item);
        void Delete(int index);
        void Show();
    }

   public interface IProducer
    {
        void Print();
    }

}
