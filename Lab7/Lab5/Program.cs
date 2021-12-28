﻿using Lab5.Ex;
using System;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {

        

            try
            {
                
                
                
                Collection<Product> products = new Collection<Product>();
                products.Add(new Flowers());
                products.Add(new Clocks());
                products.Show();
                Console.WriteLine($"Current size: {products.GetSize()}\n");
            
                products.Delete(1);
                products.Show();
                Console.WriteLine($"Current size: {products.GetSize()}");
                Console.WriteLine();

                
                Clocks clocks = new Clocks();
                Flowers flowers = new Flowers();
                Console.WriteLine("----------------Clocks--------------------");
                clocks.ShowMoney();
                clocks.Buy();
                clocks.TopUp(100);
                //clocks.TopUp(-1); /////////////////////////////////////////////////////////////////
                //clocks.TopUp(-1); /////////////////////////////////////////////////////////////////
                //clocks.TopUp(1000000); /////////////////////////////////////////////////////////////////
                Console.WriteLine("----------------Flowers--------------------");
                flowers.ShowMoney();
                flowers.Buy(10);
                //clocks.Buy(); /////////////////////////////////////////////////////////////////

                Console.WriteLine();

              
                Cake cake = new Cake();
                IPastry cakeInterface = new Cake();
                Sweets sweets = new Sweets();
                IPastry sweetsInterface = new Sweets();
                cake.Print();
                cakeInterface.Print();
                sweets.Print();
                sweetsInterface.Print();
                Console.WriteLine();

                Printer printer = new Printer();
                
                printer.IAmPrinting(sweets);
                printer.IAmPrinting(cake);
                Console.WriteLine();



               
                Sweets candies = new Sweets();
                foreach (var elem in candies.companies)
                {
                    Console.WriteLine($"{$"Company: {elem.Type},"}\nPrice: {elem.Price}");
                }
                Console.WriteLine();


               
                
                Console.WriteLine("\nПодарок:\n");
                Present<Goods> present = new Present<Goods>();
                present.Add(flowers, 4);
                present.Add(clocks);
                present.Add(flowers, 3);
                present.Show();
                present.ShowPrice();

                
                Console.WriteLine("\nСортируем по весу:");
                present.Sort();
                present.Show();
                Console.WriteLine();


                
                Console.WriteLine("Клонируем подарок:");
                var clone = (Present<Goods>)present.Clone();
                clone.Show();
                clone.ShowPrice();
                Console.WriteLine();

                
            }
            catch (ExForTop ex)
            {
                LOG.WriteLog(ex);
                throw;
            }
            catch (ExForBy ex)
            {
                LOG.WriteLog(ex);
            }
            finally
            {
                Console.WriteLine("\nEND");
            }






        }

    }
}
