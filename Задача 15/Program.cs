﻿namespace ConsoleApp3 
{ 
    internal class Program 
    { 
        static void Main(string[] args) 
        { 
            Console.Write(" Нужно узнать, является ли этот день выходным или нет?  "); 
            while (true) 
            { 
                Console.Write("\n Введите номер дня недели  "); 
                int num = int.Parse(Console.ReadLine()); 
                if (num >= 1 && num <= 5) 
                { 
                    Console.Write(" Нет, это не выходной"); 
                } 
 
                else if (num >= 6 && num <= 7) 
                { 
                    Console.Write(" Да, это выходной"); 
                } 
                else Console.Write(" Не существует такого дня недели"); 
            } 
        } 
    } 
}