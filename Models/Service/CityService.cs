using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppAssignmentDATABASE_5.Models.Repo;
using WebAppAssignmentDATABASE_5.Models.ViewModels;

namespace WebAppAssignmentDATABASE_5.Models.Service
{
    public class CityService : ICityService
    {
        ICityRepo _citiesRepo;

        public CityService(ICityRepo citiesRepo)
        {
            _citiesRepo = citiesRepo;
        }

        public City Add(CreateCityViewModel city)
        {
            return _citiesRepo.Create(city.Name);
        }

        public CitiesViewModel All()
        {
            CitiesViewModel citiesViewModel = new CitiesViewModel();

            citiesViewModel.CityList = _citiesRepo.Read();

            return citiesViewModel;
        }

        public City Edit(int id, City city)
        {
            return _citiesRepo.Update(city);
        }

        public CitiesViewModel FindBy(CitiesViewModel search)
        {
            List<City> searchedCityList = new List<City>();

            foreach (City item in _citiesRepo.Read())
            {
                if (item.Name.Contains(search.FilterText, StringComparison.OrdinalIgnoreCase))
                {
                    searchedCityList.Add(item);
                }
            }
            search.CityList = searchedCityList;

            return search;
        }

        public City Findby(int id)
        {
            return _citiesRepo.Read(id);
        }

        public bool Remove(int id)
        {
            City city = _citiesRepo.Read(id);

            return _citiesRepo.Delete(city);
        }
    }
}