using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            byte students;            
            double all = 0;

            Console.WriteLine("Введите количество студентов: ");
            students = byte.Parse(Console.ReadLine());
            byte[] heightArr = new byte[students];

            Console.WriteLine("Поочередно вводите рост каждого студента: ");
            for (int i = 0; i < heightArr.Length; i++)
            {
                Console.Write($"{i+1}) ");
                heightArr[i] = byte.Parse(Console.ReadLine());
            }

            for (int i = 0; i < heightArr.Length; i++)                            
                all += heightArr[i];  
                      
            Console.WriteLine($"Средний рост в группе: {Math.Round(all/students, 2)}");
            
        }
    }
}
