using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Konstryktor
{
    class MyClass
    {
        public string Name;
        public byte Age;
        // Создаем параметрический конструктор
        public MyClass(string s, byte b)
        {
            Name = s;
            Age = b;
        }
        public void reWrite()
        {
            Console.WriteLine("Имя: {0}\nВозраст: {1}", Name, Age);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass ex = new MyClass("Alexandr", 26);
            ex.reWrite();
            Console.ReadLine();
        }
    }
}
