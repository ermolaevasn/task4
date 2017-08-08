using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание4
{
    class Program
    {
        static void Main(string[] args)
        {
            double e, x;
            Console.WriteLine("Введите точность е");
            e = Convert.ToDouble(Console.ReadLine());
            x = deleniya(0, 1, e);   //Поиск корня на интервале (0;1) c заданной точностью
            Console.WriteLine("корень уравнения x^4+2x^3-x-1 = "+x);  //вывод результата
            Console.ReadLine();   
        }
        
        static double f(double x)
        {
            return x*x*x*x+2*x*x*x-x-1;
        }

        static double deleniya(double a, double b, double e)
        {
            double c;
            while ((b - a) > e) //поиск корня пока не достинута заданная точность
            {
                c = (a + b) / 2;//делим промежуток пополам
                if (f(c) >= 0)   
                    a = c;         
                else
                    b = c;           
            }
            return (a + b) / 2.0; //найденный корень уравнения
        }
    }
}
