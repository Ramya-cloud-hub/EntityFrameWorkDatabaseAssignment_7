using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppAssignmentDATABASE_5.Models;
using WebAppAssignmentDATABASE_5.Controllers;
using WebAppAssignmentDATABASE_5.Models.ViewModel;

namespace WebAppAssignmentDATABASE_5
{
    public class PeopleViewModel : CreatePersonViewModel
    {
        public string FilterText { get; set; }

        public List<Person> PersonList { get; set; }

    }
}
