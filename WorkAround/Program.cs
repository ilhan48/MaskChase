using Business.Concrete;
using Entities.Concrete;
using System;

namespace WorkAround
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.FirstName = "İLHAN";
            person1.LastName = "ÖDÜN";
            person1.DateofBirthYear = 1999;
            person1.NationalIdentity = 1234;



            PTTManager pTTManager = new PTTManager(new PersonManager());
            pTTManager.GiveMask(person1);
            Console.ReadLine();
        }

    }
}

//    public class Person
//    {
//        public string FirstName { get; set; }
//        public string LastName { get; set; }
//        public int DateofBorn { get; set; }
//        public long NationalId { get; set; }
//    }
//}
