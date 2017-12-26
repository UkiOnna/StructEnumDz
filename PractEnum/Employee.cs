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
        private DateTime _dataEnter;

        public Employee (string name,Vacancies vacancy,int salary,DateTime dataEnter)
        {
            _name = name;
            _vacancy = vacancy;
            _salary = salary;
            _dataEnter = dataEnter;
        }

       public string Show()
        {
            
            string show =String.Format( "Имя - {0}\n Зарплата -{1}\n Вакансия - {2}\n Дата поступления - {3}",_name,_salary,_vacancy,_dataEnter);
            return show;
        }

        public Vacancies GetVacancy()
        {
            return _vacancy;
        }

        public int GetSalary()
        {
            return _salary;
        }

        public DateTime GetDate()
        {
            return _dataEnter;
        }
    }
}
