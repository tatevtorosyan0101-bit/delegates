using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate_call
{
    internal class Program
    {
        delegate int Op(int n);
        static int Double(int n) => n * 2;
        static int PlusTen(int n) => n + 10;
        static int Apply(int number,Op op)
        {
            return op(number);
        }
        static int Pick(int number)
        {
            Op op;
            if (number%2==0)
            {
             op= Double;    
            }
            else {               
                op= PlusTen; }
            return op(number);
        }
        static void Main(string[] args)
        {
            Op op= Double;
            Console.WriteLine(op(4));
            op = PlusTen;
            Console.WriteLine(op(4));
            op= Double;
            Console.WriteLine(op(7));
            op= PlusTen;
            Console.WriteLine(op(7));
            Console.WriteLine(Apply(5, Double));   
            Console.WriteLine(Apply(5, PlusTen));   
            Console.WriteLine(Apply(0, Double));    
            Console.WriteLine(Apply(0, PlusTen)); 
            Console.WriteLine(Pick(4)); 
            Console.WriteLine(Pick(5));   
            Console.WriteLine(Pick(0));   
            Console.WriteLine(Pick(7));    
        }
    }
}
