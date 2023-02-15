using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRMEmployeeApp
{
    public class Employee
    {
        private string firstName;
        private string lastName;


        private int numberOfHoursWorked;
        private double wage;
        private double hourlyRate;

        public string FirstName { get{ return FirstName; } set{ firstName = value; } }
        public string LastName { get { return LastName; } set { lastName = value; } }
        public int NumberOfHoursWorked { get { return numberOfHoursWorked; } set { numberOfHoursWorked = value; } }
        public double Wage { get { return wage; } set { wage = value; } }
        public double HourlyRate { get { return hourlyRate; } set { hourlyRate = value; } }

        public Employee(string firstName, string lastName, double rate)
        {
            FirstName = firstName;
            LastName = lastName;
            hourlyRate= rate;
        }
        public int PerformWork(int hour)
        {
            NumberOfHoursWorked += hour;
            return NumberOfHoursWorked;
        }

        public double ReceiveWage(out int hoursWorked)
        {
            Wage = NumberOfHoursWorked * HourlyRate;

            Console.WriteLine($"The wage for {NumberOfHoursWorked} hours of work is {Wage}.");

            NumberOfHoursWorked = 0;
            hoursWorked = NumberOfHoursWorked;

            return Wage;
        }
    }
}
