using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    delegate void mydelegate(int number);

    class Program
    {
        static void Main(string[] args)
        {
            mydelegate call = SayHellow;

            executeTheDelegate(2 , call);
            Console.ReadLine();
            
        }

        public static void SayHellow(int number)
        {
            Console.WriteLine("{0} " ,number);
        }

        static void executeTheDelegate(int num , mydelegate calldelegate)
        {
            calldelegate(num);
        }
    }
}
