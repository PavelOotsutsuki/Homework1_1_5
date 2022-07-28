using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Homework1_1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string name="Иванов"; 
            string secondName="Иван"; 
            string temporarilyVariable; 

            Console.WriteLine("Значение переменной name до перестановки: " + name);
            Console.WriteLine("Значение переменной secondName до перестановки: " + secondName);
            temporarilyVariable = name;
            name = secondName;
            secondName = temporarilyVariable;
            Console.WriteLine("Значение переменной name после перестановки: " + name);
            Console.WriteLine("Значение переменной secondName после перестановки: " + secondName);
        }
    }
}