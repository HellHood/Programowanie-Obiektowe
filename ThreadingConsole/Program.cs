using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab6ThreadingConsole
{
    internal class Program
    {
        public static void Main()
        {
            ParameterizedThreadStart operation = new ParameterizedThreadStart(WorkWithParameter);

            Thread theThread = new Thread(operation);

            theThread.Start("DzienDobry");

            Thread newThread = new Thread(operation);

            newThread.Start("Dowidzenia");

            Thread.Sleep(10000);
        }

        private static void WorkWithParameter(object o)
        {
            string info = (string)o;
            for (int x = 0; x < 10; ++x)
            {
                Console.WriteLine("{0}: {1}", info, Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(10);
            }
        }
    }
}