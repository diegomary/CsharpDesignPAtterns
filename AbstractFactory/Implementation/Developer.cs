using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    public class Developer : AbstractEmployer
    {
        public string ItDeportmentCode { get; set; }
        public override string FullName()
        {
            return string.Concat(this.ItDeportmentCode, " ", this.FirstName, " ", this.LastName);
        }      
       
    }
}