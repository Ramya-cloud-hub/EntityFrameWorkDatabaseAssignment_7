using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppAssignmentDATABASE_5.Data;
using WebAppAssignmentDATABASE_5.Models.Service;

namespace WebAppAssignmentDATABASE_5.Controllers
{
    public class CountryController : Controller
    {

        ICountryService _countriesService;
        PeopleDbContext _context;

        public CountryController(ICountryService countriesService, PeopleDbContext context)
        {
            _countriesService = countriesService;
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
