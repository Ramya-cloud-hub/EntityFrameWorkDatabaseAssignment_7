using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppAssignmentDATABASE_5.Data;
using WebAppAssignmentDATABASE_5.Models.Service;

namespace WebAppAssignmentDATABASE_5.Controllers
{
    public class CityController : Controller
    {
        ICityService _citiesService;
        PeopleDbContext _context;

        public CityController(ICityService citiesService, PeopleDbContext context)
        {
            _citiesService = citiesService;
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
