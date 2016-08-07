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
            AbstractEmployer ae = ep.CreateEmployer(EmployerType.Manager);

        }
    }
}
