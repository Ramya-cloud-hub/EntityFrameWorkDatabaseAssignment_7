using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace WebAppAssignmentDATABASE_5.Models.ViewModel
{
    public class CreatePersonViewModel
    {
        [Required]
        [StringLength(15, MinimumLength = 1)]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public int Phone { get; set; }

        public string City { get; set; }
        public string Language { get; set; }

        [Required]
        public int CityId { get; set; }
        [Required]
        public List<int> LanguageId { get; set; }

        public SelectList selectList { get; set; }

        public SelectList selectLanguageList { get; set; }

        [Key]
        public int Id { get; set; }

        public CreatePersonViewModel()
        {

        }
    }

}
