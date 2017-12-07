using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractEnum
{
    public struct Employee
    {
        private string _name;
        private Vacancies _vacancy;
        private int _salary;
        private int[] _dataEnter;

        public Employee (string name,Vacancies vacancy,int salary,int[] dataEnter)
        {
            _name = name;
            _vacancy = vacancy;
            _salary = salary;
            _dataEnter = new int[3];
            for(int i = 0; i < _dataEnter.Length; i++)
            {
                _dataEnter[i] = dataEnter[i];
            }
        }

       
    }
}
