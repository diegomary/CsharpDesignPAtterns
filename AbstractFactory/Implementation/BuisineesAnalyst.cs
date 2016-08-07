using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    public class BuisineesAnalyst : IEmployer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public string BusineessTitle { get; set; }
        public string FullName()
        {
            return string.Concat(this.BusineessTitle, " ", this.FirstName, " ", this.LastName);
        }

    }
}