using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dz_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Employee[] employeers;
            Console.WriteLine("Введите размер массива");
            int a = int.Parse(Console.ReadLine());
            int n = Convert.ToInt32(a);
            employeers = new Employee[n];
            for (int i = 0; i < n; i++)

            {
                employeers[n] = new Employee();
                Console.WriteLine("Введите имя");
                employeers[n].name = Console.ReadLine();

                Console.WriteLine("Введите зарплату");
                employeers[n].Salary = Console.ReadLine();
                Console.WriteLine("Введите вакансию");
                employeers[n].vacancy = Console.ReadLine();
                Console.WriteLine("Введите дату");
                employeers[n].DateOfStartWork = Console.ReadLine();
                //2
                int minIncome = 100000;
                List<Student> students = new List<Student>();
                students.Add(new Student("Кан", "15", 73000, 7));
                students.Add(new Student("Скидан", "15", 25000, 3));
                students.Add(new Student("Бухврев", "19", 15000, 5));
                Console.WriteLine("Очередь на получение студентами общежития:");
                int count = 1;
                foreach (Student s in students)
                {
                    Console.WriteLine($"{count} {s.name}, группа {s.group}");
                    count++;
                }
                Console.ReadLine();
            }
        }

    }
}
struct Student
{
    public string name;
    public string group;
    public int income;
    public int averageScore;
    public Student(string name, string group, int income, int averageScore)
    {
        this.name = name;
        this.group = group;
        this.income = income;
        this.averageScore = averageScore;
    }
}
    struct Employee 
{
    public enum Vacancies 
    {
        Manager, Boss, Clerk, Salesman
    }

    public string name;
    public int Salary;
    public int[] DateOfStartWork;
    public Vacancies vacancy;
}
    

