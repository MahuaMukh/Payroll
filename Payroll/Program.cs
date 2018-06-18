using System;


namespace Payroll
{
    class Program
    {

        enum Payroll
        {
            Hourly,
            Salaried
        };
        static void Main(string[] args)
        {
            //Payroll value = Payroll.Salaried;
            Payroll value = Payroll.Hourly;
            Employee employee = new Employee();
            Employee employee1 = new Employee();
            employee.Name = "Minty";
            employee1.Name = "Molly";
            employee.Hours = 10;
            employee.HourlyPay = 25;

            if (value == Payroll.Hourly)
            {
          
                Console.WriteLine("Information: {0} worked {1} hours at an hourly rate of ${2}", employee.Name, employee.Hours, employee.HourlyPay);
                CalcPay(employee.Hours, employee.HourlyPay);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Information: {0} worked as salaried and earned a total of ${1}", employee1.Name, employee.PaySalary);
                Console.ReadLine();
            }
        }

        public static int CalcPay(int hours, int hourlyPay)
        {
            int totalEarned = (hours * hourlyPay);
            Console.WriteLine("This employee earned a total of ${0}", totalEarned);
            return totalEarned;
        }






    }

}
