using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Lexa";
           
            int salary = 5;
            int[] dataEntered = new int[3];
            for(int i = 0; i < dataEntered.Length; i++)
            {
                dataEntered[i] = i + 10;
            }
            Employee employee=new Employee (name,Vacancies.Boss,salary,dataEntered);
            Console.WriteLine("Имя - {0}, Должность - {1}, Зарплата - {2}, Дата Создания {3}.{4}.{5}",name,Vacancies.Boss,salary,dataEntered[0],dataEntered[1],dataEntered[2]);
            Console.ReadLine();
        }
    }
}
