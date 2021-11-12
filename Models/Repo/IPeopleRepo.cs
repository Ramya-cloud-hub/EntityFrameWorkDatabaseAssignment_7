using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppAssignmentDATABASE_5.Controllers;

namespace WebAppAssignmentDATABASE_5.Models
{
   public interface IPeopleRepo
    {
        Person Create(string name, int cityId, List<int> languageId, int phoneNumber);//, Language language);
        List<Person> Read();
        Person Read(int id);
        Person Update(Person person);
        bool Delete(Person person);
    }
}