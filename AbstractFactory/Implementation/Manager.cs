using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    public class Manager : AbstractEmployer
    {    

        public string ManagerialStatus {get; set; }
        public override string FullName()
        {
            return string.Concat(this.ManagerialStatus, " ", this.FirstName, " ", this.LastName);
        }

    }
}