using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyCustomClass myClass = new MyCustomClass();
    
            myClass.Number = 27;
            int result = myClass.Multiply(4);
            myClass.SetAge(50);
            myClass.Name = "Fulano de tal";

            Console.WriteLine("O resultado da multiplicação é: " + result);
            Console.WriteLine("A idade é: " + myClass.GetAge());
            Console.WriteLine("O nome é: " + myClass.Name);
            Console.ReadKey();
        }
    }
}
