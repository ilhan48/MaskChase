using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class PTTManager : ISupplierService
    {
        private IApplicantService _applicantService;
        

        public PTTManager(IApplicantService applicantService)
        {
            _applicantService = applicantService;

        }
        public void GiveMask(Person person)
        {
            if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " gived mask.");
            }
            else
            {
                Console.WriteLine(person.FirstName + " not gived mask.");
            }

        }
    }

}
