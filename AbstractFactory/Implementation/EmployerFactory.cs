using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    public class EmployerFactory
    {
        public AbstractEmployer CreateEmployer(EmployerType et)
        {
           
            switch (et)
            {
                case EmployerType.BusinessAnalyst:
                return new BuisineesAnalyst();
                case EmployerType.Developer:
                return new Developer();
                case EmployerType.Manager:
                return new Manager();
                // If no case label contains a matching value, control is transferred to the default section
                default:
                return new Manager();
            }

        }
    }
}