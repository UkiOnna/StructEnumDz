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
            Console.WriteLine("Введите количество сотрудников");
            int countWorker;
            int.TryParse(Console.ReadLine(), out countWorker);

            Employee[] employee = new Employee[countWorker];
            int salary;
            string name;
            int choose;
            int day, month, year;
            Vacancies vacancy;

            for (int i = 1; i <= countWorker; i++)
            {
                Console.WriteLine("Введите имя {0} сотрудника", i);
                name = Console.ReadLine();

                Console.WriteLine("Выберяите вакансию: 1-Мэнэджэр, 2-Босс,3-Клерк,4-Продавец");
                int.TryParse(Console.ReadLine(), out choose);
                if (choose == 1)
                {
                    vacancy = Vacancies.Manager;
                }

                else if (choose == 2)
                {
                    vacancy = Vacancies.Boss;
                }

                else if (choose == 3)
                {
                    vacancy = Vacancies.Clerk;
                }

                else
                {
                    vacancy = Vacancies.Salesman;
                }

                Console.WriteLine("Введите зарплату {0} сотрудника", i);
                int.TryParse(Console.ReadLine(), out salary);

                Console.WriteLine("Введите день пострупления сотрудника");
                int.TryParse(Console.ReadLine(), out day);
                Console.WriteLine("Введите месяц пострупления сотрудника");
                int.TryParse(Console.ReadLine(), out month);
                Console.WriteLine("Введите год пострупления сотрудника");
                int.TryParse(Console.ReadLine(), out year);

                DateTime enterDate = new DateTime(year, month, day);
                employee[i - 1] = new Employee(name, vacancy, salary, enterDate);
            }

            FullInfo(employee);
            ManagerInfo(employee);
            LaterBoss(employee);

            Console.ReadLine();
        }

        private static void LaterBoss(Employee[] employee)
        {
            int compare;
            Employee boss = employee[0];
            string show;

            for (int i = 0; i < employee.Length; i++)
            {
                if (employee[i].GetVacancy() == Vacancies.Boss)
                {
                    boss = employee[i];
                }
            }

            Console.WriteLine("Сотрудники принятые позже босса :");
            for (int i = 0; i < employee.Length; i++)
            {
                compare = boss.GetDate().CompareTo(employee[i].GetDate());
                if (compare == -1)
                {
                    show = employee[i].Show();
                    Console.WriteLine(show);
                    Console.WriteLine("-----------------------------------");
                }
            }
        }

        private static void ManagerInfo(Employee[] employee)
        {
            
            int salaryClerk = 0;
            int countClerk = 0;
            string show;

            for (int i = 0; i < employee.Length; i++)
            {
                if (employee[i].GetVacancy() == Vacancies.Clerk)
                {
                    salaryClerk += employee[i].GetSalary();
                    countClerk++;
                }
            }

            salaryClerk = salaryClerk / countClerk;

            Console.WriteLine("Менеджеры :");
            for (int i = 0; i < employee.Length; i++)
            {
                if (employee[i].GetVacancy() == Vacancies.Manager)
                {
                    if (employee[i].GetSalary() > salaryClerk)
                    {
                        show = employee[i].Show();
                        Console.WriteLine(show);
                        Console.WriteLine("-----------------------------------");
                    }
                }
            }
        }

        private static void FullInfo(Employee[] employee)
        {
            string show;
            Console.WriteLine("Все сотрудники :");

            for (int i = 0; i < employee.Length; i++)
            {
                show = employee[i].Show();
                Console.WriteLine(show);
                Console.WriteLine("-----------------------------------");
            }
        }
    }
}
