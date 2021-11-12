using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppAssignmentDATABASE_5.Models.ViewModels
{
    public class CreateCountryViewModel
    {
        [Required]
        [StringLength(15, MinimumLength = 1)]
        public string Name { get; set; }

        [Key]
        public int CountryId { get; set; }

        public CreateCountryViewModel()
        {

        }
    }
}
