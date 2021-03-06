using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppAssignmentDATABASE_5.Data;

namespace WebAppAssignmentDATABASE_5.Models.Repo
{
    public class DatabasePeopleRepo : IPeopleRepo
    {
        private static List<Person> _personList = new List<Person>();
        private readonly PeopleDbContext _context;

        public DatabasePeopleRepo(PeopleDbContext context)
        {
            _context = context;
            if (_personList.Count == 0)
                _personList = _context.People.ToList();
        }

        public Person Create(string name, int cityId, List<int> languageIds, int phoneNumber)
        {
            City city = _context.Cities.Find(cityId);

            Person person = new Person(name, phoneNumber);
            person.City = city;

            List<KnownLanguage> knownLanguages = new List<KnownLanguage>();
            Language language;
            foreach (int item in languageIds)
            {
                language = null;
                language = _context.Languages.Find(item);

                KnownLanguage knownLanguage = new KnownLanguage();
                knownLanguage.Person = person;
                knownLanguage.PersonId = person.Id;
                knownLanguage.Language = language;
                knownLanguage.LanguageId = language.LanguageId;

                knownLanguages.Add(knownLanguage);
                _context.KnownLanguages.Add(knownLanguage);
            }
            person.KnownLanguageList = knownLanguages;

            _personList.Add(person);

            _context.People.Add(person);
            _context.SaveChanges();

            return person;
        }

        public bool Delete(Person person)
        {
            bool deleted = _personList.Remove(person);
            if (deleted)
            {
                _context.People.Remove(person);
                _context.SaveChanges();
            }

            return deleted;
        }

        public List<Person> Read()
        {
            return _personList;
        }

        public Person Read(int id)
        {
            //LINQ expression
            // Define the query expression
            IEnumerable<Person> personQuery =
                from person in _personList
                where person.Id == id
                select person;

            return personQuery.First();
        }

        public Person Update(Person person)
        {
            foreach (Person item in _personList)
            {
                if (item.Id == person.Id)
                {
                    item.Name = person.Name;
                    item.Phone = person.Phone;
                    item.City = person.City;

                    _context.People.Update(item);
                    _context.SaveChanges();

                    _personList = _context.People.ToList();
                }
            }

            return person;
        }
    }
}
