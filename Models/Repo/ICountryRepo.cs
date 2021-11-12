using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppAssignmentDATABASE_5.Models.Repo
{
    public interface ICountryRepo
    {
        City AddCityToCountry(int id, City city);
        Country Create(string name);
        List<Country> Read();
        Country Read(int id);
        Country Update(Country country);
        bool Delete(Country country);


    }
}
