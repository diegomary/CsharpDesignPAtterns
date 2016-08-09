using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SingletonDp;

namespace PilotApp
{
    class Program
    {
        static void Main(string[] args)
        {

       
            for (int i = 0; i < 100; i++)
            {
                Task.Factory.StartNew(() =>
                {

                    SingletonStaticInitialization sio = SingletonStaticInitialization.Instance;
                    sio.CalculateLatency();

                });

            }

            System.Threading.Thread.Sleep(4000);          

            var all = SingletonStaticInitialization.allResponseTimes;

            Console.ReadLine();

        }
    }
}
