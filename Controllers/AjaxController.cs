using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppAssignmentDATABASE_5.Models;
using WebAppAssignmentDATABASE_5.Models.ViewModel;

namespace WebAppAssignmentDATABASE_5.Controllers
{
    public class AjaxController : Controller
    {
        IPeopleService _peopleService;
        public AjaxController(IPeopleService peopleService)
        {
            _peopleService = peopleService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            PeopleViewModel peopleViewModel = _peopleService.All();

            return View(peopleViewModel);
        }

        [HttpGet]
        public IActionResult PeoplePartial(int id)
        {
            return PartialView("PeoplePartial", _peopleService.All().PersonList);
        }

        [HttpPost]
        public IActionResult PersonPartial(int id)
        {
            Person p = _peopleService.Findby(id);

            return PartialView("PersonPartial", p);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            bool deleted = _peopleService.Remove(id);
            string result = "";

            if (deleted)
                result = "Successfully deleted!";
            else
                result = "Was not deleted!";

            return Content(result);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreatePersonViewModel createPersonViewModel)
        {
            if (ModelState.IsValid)
            {
                _peopleService.Add(createPersonViewModel);

                return RedirectToAction(nameof(PeoplePartial));
            }

            return View(createPersonViewModel);
        }
    }
}