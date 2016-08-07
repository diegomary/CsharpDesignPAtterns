using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    public class BuisineesAnalyst : AbstractEmployer
    {

        public string BusineessTitle { get; set; }
        public override string FullName()
        {
            return string.Concat(this.BusineessTitle, " ", this.FirstName, " ", this.LastName);
        }
      
    }
}