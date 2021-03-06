using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppAssignmentDATABASE_5.Models.ViewModels;

namespace WebAppAssignmentDATABASE_5.Models.Service
{
    public interface ICountryService
    {
        Country Add(CreateCountryViewModel country);
        City AddCityToCountry(int id, City city);
        CountriesViewModel All();
        CountriesViewModel FindBy(CountriesViewModel search);
        Country Findby(int id);
        Country Edit(int id, Country country);
        bool Remove(int id);
    }
}