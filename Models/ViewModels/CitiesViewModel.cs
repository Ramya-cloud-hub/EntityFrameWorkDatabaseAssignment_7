using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppAssignmentDATABASE_5.Models.ViewModels
{
    public class CitiesViewModel
    {
        public string FilterText { get; set; }

        public List<City> CityList { get; set; }
    }
}
