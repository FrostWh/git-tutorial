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
            
            Person person2 = new Person();
            person2.m_name = "frostwang";
            person2.m_age = 21;
            Console.WriteLine(person2);
        }
        
    }
}