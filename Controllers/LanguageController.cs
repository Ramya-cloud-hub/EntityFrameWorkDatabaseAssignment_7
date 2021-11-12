using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Host;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppAssignmentDATABASE_5.Data;

namespace WebAppAssignmentDATABASE_5.Controllers
{
    public class LanguageController : Controller
    {
            ILanguageService _languageService;
            PeopleDbContext _context;

            public LanguageController(ILanguageService languageService, PeopleDbContext context)
            {
                _languageService = languageService;
                _context = context;
            }


            public IActionResult Index()
            {
                return View();
            }
        }
    }