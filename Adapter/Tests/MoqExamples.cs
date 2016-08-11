using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public interface IPerson
    {
         string FirstName { get; set; }
         string LastName { get; set; }        
         string FullName();
         string GetPersonInfo(string id);
    }

    public interface IRepository
    {
         Person GetPerson(string personId);
    }

    public class Repository:IRepository
    {
        public Person GetPerson(string personId)
        {
            // Access to production Database which is not accessible at testing time
            return new Person() { FirstName = "Pippo", LastName = "Pluto" };
        }
    }

    public class Order
    {       
        public Person Buyer { get; set; }
        public Order(IRepository repo,string personID)
        {
            Buyer = repo.GetPerson(personID);
        }


        public string Info()
        {
            return Buyer.FullName() + " Has Bought 100 Computers";
        }

    }









    public class Person : IPerson
    {
        public string FirstName { get; set; }      
        public string LastName { get; set; }
        public Person() { }       
      
        public string FullName()
        {
            return FirstName + " " + LastName;
        }

        public string GetPersonInfo(string id)
        {
            return ("Hello");
        }
    }



}
