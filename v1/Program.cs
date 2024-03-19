using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.CodeDom;
using System.Runtime.InteropServices;

namespace v1
{


    class Program
    {

        delegate void MyDelegate();
        static void Main(string[] args)
        {
            Random random = new Random();

            MyDelegate[] delegates = new MyDelegate[]
            {
                method1,
                method2,
                method3,
            };


            Timer timer = new Timer(() =>
            {
                int index = random.Next(delegates.Length);
                delegates[index]();
            }, 2);

            timer.Start();

            Console.WriteLine("press any key to stop");
            Console.ReadKey();

            timer.Stop();

        }

        public static void method1() {
            Console.WriteLine("called method1");
        }
        public static void method2()
        {
            Console.WriteLine("called method2");
        }
        public static void method3()
        {
            Console.WriteLine("called method3");
        }
    }
}
