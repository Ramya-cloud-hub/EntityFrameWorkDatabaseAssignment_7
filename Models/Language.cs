using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppAssignmentDATABASE_5.Models
{
    public class Language
    {

        [Key]
        public int LanguageId { get; set; }

        [Required]
        [MaxLength(20)]
        [MinLength(1)]
        public string Name { get; set; }

        [Required]
        public List<KnownLanguage> KnownLanguageList { get; set; }

        public Language(string Name)
        {
            this.Name = Name;
            KnownLanguageList = new List<KnownLanguage>();
        }
    }
}
