using System;

namespace PayslipKata
{
    class Program
    {
        public static void Main(string[] args){
           string first_name;
           string last_name;
           int salary;
           double super_rate;
           string start;
           string end;
           Console.WriteLine("Welcome to the payslip generator!");
           Console.ReadLine();

           Console.Write("Please input your name: ");
           first_name = Console.ReadLine();

           Console.Write("Please input your surname: ");
           last_name = Console.ReadLine();

           Console.Write("Please enter your annual salary: ");
           salary = Int32.Parse(Console.ReadLine());


           Console.Write("Please enter your super rate: ");
           super_rate = Convert.ToDouble(Console.ReadLine());


           Console.Write("Please enter your start date: ");
           start = Console.ReadLine();

           Console.Write("Please enter your end date: ");
           end = Console.ReadLine();

           double g_income = GIncome(salary);
           double tax = Tax(salary);
           double net_income = g_income - tax;
           double super = Math.Round(g_income*(super_rate/100));

           Console.WriteLine("\r\nYour payslip has been generated:\r\n");
           Console.WriteLine("Name: " + first_name + " " + last_name);
           Console.WriteLine("Pay Period: " + start + " - " + end);
           Console.WriteLine("Gross Income: " + g_income);
           Console.WriteLine("Income Tax: " + Math.Round(tax) );
           Console.WriteLine("Net Income: " + Math.Round(net_income));
           Console.WriteLine("Super: " + super + "\r\n");
           Console.WriteLine("Thank you for using MYOB!");    
           }

        static double GIncome(double s){
            double gross_income = Math.Round(s/12);
            return gross_income;
        }
        static double Tax(double x){
            double r = 0.0;
            if (x <= 18200){ return r;}

            else if (18201 < x && x < 37000) { 
                double a = x - 18200;
                a = (0.19*a)/12;
                return a;
            }

            else if(37001 < x && x < 87000){
                double b = x-37000;
                b = (3572+(b*0.325))/12;
                return b;
            }

            else if(87001 < x && x < 180000){
                double c = x-87000;
                c = (19822+(c*0.37))/12;
                return c;
            }

            else if(x>= 180001){
                double d = x-180000;
                d = (54232+(d*0.45))/12;
                return d;
            }
            else { return 0.0;}
        }
    }
}