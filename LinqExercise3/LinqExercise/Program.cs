using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            //TODO: Print the Sum of numbers
            //TODO: Print the Average of numbers
            Console.WriteLine(numbers.Sum());
            Console.WriteLine();
            Console.WriteLine("-------------");
            Console.WriteLine();
            Console.WriteLine(numbers.Average());
            Console.WriteLine();
            //TODO: Order numbers in ascending order and print to the console
            Console.WriteLine("-------------");
            Console.WriteLine();
            var aOrder = numbers.OrderBy(num => num);
            foreach (var number in aOrder)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();
            //TODO: Order numbers in decsending order adn print to the console
            Console.WriteLine("-------------");
            Console.WriteLine();
            var dOrder = numbers.OrderByDescending(num => num);

            Console.WriteLine();
            foreach (var number in dOrder)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();

            //TODO: Print to the console only the numbers greater than 6
            Console.WriteLine("-------------");
            Console.WriteLine();
            var biggerSix = numbers.Where(num1 => num1 > 6);

            foreach (var number in biggerSix)
            {

                Console.WriteLine(number);
            }
            Console.WriteLine();
            //TODO: Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**
            Console.WriteLine("------------");
            Console.WriteLine();

            foreach (var num in aOrder.Take(4))
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();
            //TODO: Change the value at index 4 to your age, then print the numbers in decsending order
            Console.WriteLine("------------");
            Console.WriteLine();
            numbers[4] = 32;
            numbers.SetValue(32, 4);

            var dAge = numbers.OrderByDescending(num => num);

            foreach (var number in dAge)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();
            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in acesnding order by FirstName.
            var filtered = employees.Where(person => person.FirstName.ToLower().StartsWith('c') || person.FirstName.ToLower()[0] == 's')
                            .OrderBy(person => person.FirstName);

            var otherFiltered = employees.FindAll(name => name.FirstName.ToLower()[0] == 'c' || name.FirstName.ToLower()[0] == 's')
                                .OrderBy(name => name.FirstName);

            Console.WriteLine("------------");
            Console.WriteLine();
            foreach (var person in filtered)
            {
                Console.WriteLine(person.FullName);
            }
            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            var allemployees = employees.Where(emp => emp.Age > 26).OrderByDescending(emp => emp.Age).ThenBy(emp => emp.FirstName);

            Console.WriteLine("------------");
            Console.WriteLine();
            foreach (var emp in allemployees)
            {
                Console.WriteLine($"Name: {emp.FullName}, Age: {emp.Age}");
            }
            //TODO: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35
            var sumAndYOE = employees.Where(e => e.YearsOfExperience <= 10 && e.Age > 35);

            Console.WriteLine("------------");
            Console.WriteLine();
            Console.WriteLine($"Total Years of Experience:{sumAndYOE.Sum(e => e.YearsOfExperience)}");
            Console.WriteLine($"Average Years of Experience:{sumAndYOE.Average(e => e.YearsOfExperience)}");
            //TODO: Add an employee to the end of the list without using employees.Add()
            employees = employees.Append(new Employee("Joseph", "Poole", 32, 1)).ToList();


            Console.WriteLine("------------");
            Console.WriteLine();
            foreach (var item in employees)
            {
                Console.WriteLine(item.FullName);
                Console.WriteLine();

            }

            #region CreateEmployeesMethod
            static List<Employee> CreateEmployees()
            {
                List<Employee> employees = new List<Employee>();
                employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
                employees.Add(new Employee("Steven", "Bustamento", 56, 5));
                employees.Add(new Employee("Micheal", "Doyle", 36, 8));
                employees.Add(new Employee("Daniel", "Walsh", 72, 22));
                employees.Add(new Employee("Jill", "Valentine", 32, 43));
                employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
                employees.Add(new Employee("Big", "Boss", 23, 14));
                employees.Add(new Employee("Solid", "Snake", 18, 3));
                employees.Add(new Employee("Chris", "Redfield", 44, 7));
                employees.Add(new Employee("Faye", "Valentine", 32, 10));

                return employees;
            }
            #endregion
        }
    }
}
