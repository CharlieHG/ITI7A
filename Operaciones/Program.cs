using Operaciones.operacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Suma s = new Suma();
            Restar r = new Restar();

            int num1,num2,res;
            
            Console.WriteLine("1.Sumar");
            Console.WriteLine("2.Restar");
            Console.WriteLine("Seleccione la operación:");
            res = Convert.ToInt32(Console.ReadLine());

            Console.Write("Numero1: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Numero2: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            switch (res)
            {
                case 1:
                    s.sumar(num1,num2);
                    break;
                case 2:
                    r.restar(num1, num2);
                    break;
                default:
                    break;
            }
            Console.ReadLine();
        }
    }
}
