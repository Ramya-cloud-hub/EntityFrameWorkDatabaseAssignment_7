using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppAssignmentDATABASE_5.Models.ViewModels
{
    public class CountriesViewModel
    {
        public string FilterText { get; set; }
        public List<Country> CountryList { get; set; }
    }
}
