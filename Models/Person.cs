using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebAppAssignmentDATABASE_5.Models
{
    public class Person
    {

        [Required]
        [MaxLength(20)]
        [MinLength(1)]
        public string Name { get; set; }

        [Required]
        [Range(9, 16)]
        public int Phone { get; set; }

        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(15)]
        [MinLength(1)]
        public City City { get; set; }

        [Required]
        public List<KnownLanguage> KnownLanguageList { get; set; }

        public Person(string Name, int Phone)
        {
            this.Name = Name;
            this.Phone = Phone;
            KnownLanguageList = new List<KnownLanguage>();
        }
        public Person(string Name, int Phone, int Id)
        {
            this.Name = Name;
            this.Phone = Phone;
            this.Id = Id;
            KnownLanguageList = new List<KnownLanguage>();
        }
    }
}
