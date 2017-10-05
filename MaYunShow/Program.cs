using System;
using System.Collections.Generic;

namespace MaYunShow
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World");
            
            Person person = new Person();
            person.m_name = "wanghong";
            person.m_age = 28;
            Console.WriteLine(person);

            Person person3 = new Person();
            person3.m_name = "mengmeng";
            person3.m_age = 23;
            Console.WriteLine(person3);
        }
        
    }
}