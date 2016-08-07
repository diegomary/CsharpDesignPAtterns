using AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilotApp
{
    class Program
    {
        static void Main(string[] args)
        {

            EmployerFactory ep = new EmployerFactory();
            Manager mg = (Manager)ep.CreateEmployer(EmployerType.Manager);

            mg.ManagerialStatus = "CTO";

            var f = mg.ManagerialStatus;


            var t = 0;
          

        }
    }
}
