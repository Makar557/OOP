using System;
using System.Collections.Generic;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassPr.Words Words;
           
            ClassPr programmer = new ClassPr();
            List<string> list = new List<string> { "Walther_P99", "FN_Five_Seven", "Smith&Wesson", "Beretta_92", "Glock_17", "TAR-21", "АК-12", "Винторез", "Barrett M82" };

            Console.Write("Начальный список: ");
            
            foreach (string item in list)
            {
                Console.Write(item + "   ");
            }
            Console.WriteLine();
            

            programmer.Removee += list =>
            {
                Console.Write("Меняй: ");
                
                foreach (string item in list)
                {
                    Console.Write(item + "   ");
                }
                Console.WriteLine();
                
            };

            programmer.Change += list =>
            {
                Console.Write("Меняй: ");
                
                foreach (string item in list)
                {
                    Console.Write(item + "   ");
                }
                Console.WriteLine();
                
            };

            Words = programmer.Remove;
            Words += programmer.Remove;
            Words += programmer.Mutate;
            Words += programmer.Mutate;
            Words(list);





            ClassPr.Words2 Words2;
            ClassPr programm = new ClassPr();
            List<string> list2 = new List<string>();
            Console.Write("Второй список: ");
            
            foreach (var elem in list)
            {
                list2.Add(elem);
                Console.Write(elem + "   ");
            }
            Console.WriteLine();
            

            programm.Addd += list2 =>
             {
                 Console.Write("Добавлено : ");
                 
                 foreach (string elem in list2)
                 {
                     Console.Write(elem + "   ");
                 }
                 Console.WriteLine();
                 
             };
            Words2 = programm.ADD;
            Words2 += programm.ADD;
            Words2(list2);




            Func<string, string> A;
            string str = "ADS,,, , ; . sdase";
            
            Console.WriteLine($"\n\n\nString: {str}");
            A = Str.RemovePunctuation;
            Console.WriteLine($"{A.Method.Name}: {A(str)}");
            A = Str.AddSymbol;
            Console.WriteLine($"{A.Method.Name}: {A(str)}");
            A = Str.ToUpper;
            Console.WriteLine($"{A.Method.Name}: {A(str)}");
            A = Str.ToLower;
            Console.WriteLine($"{A.Method.Name}: {A(str)}");
            A = Str.RemoveSpace;
            Console.WriteLine($"{A.Method.Name}: {A(str)}");
            
        }
    }
}
