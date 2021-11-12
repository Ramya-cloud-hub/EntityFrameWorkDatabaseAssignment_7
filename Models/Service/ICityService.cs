using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppAssignmentDATABASE_5.Models.ViewModels;

namespace WebAppAssignmentDATABASE_5.Models.Service
{
    public interface ICityService
    {
        City Add(CreateCityViewModel city);
        CitiesViewModel All();
        CitiesViewModel FindBy(CitiesViewModel search);
        City Findby(int id);
        City Edit(int id, City city);
        bool Remove(int id);
    }
}
