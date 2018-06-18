using System;


namespace Payroll
{
    class Employee
    {
        private string name;
        private int hours;
        private int hourlyPay;
        private const int SALARY = 1500;



        public Employee()
        {

        }

        public string Name
        {
            get
            {
                return name;

            }
            set
            {
                if (value.Length >= 1 && value.Length <= 10)
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Invalid Input!");
                    Console.ReadLine();
                }
            }
        }

        public int Hours
        {
            get
            {
                return hours;

            }
            set
            {
                if (value >= 1 && value <= 20)
                {
                    hours = value;
                }
                else
                {
                    Console.WriteLine("Invalid Input!");
                }
            }
        }

        public int HourlyPay
        {
            get
            {
                return hourlyPay;
            }
            set
            {
                if (value >= 1 && value <= 40)
                {
                    hourlyPay = value;
                }
                else
                {
                    Console.WriteLine("Invalid Input!");
                }
            }
        }

        public int PaySalary
        {
            get
            {
                return SALARY;
            }
        }
    }

 }

