﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppAssignmentDATABASE_5.Models
{
    public class KnownLanguage
    {
        public int PersonId { get; set; }
        public Person Person { get; set; }

        public int LanguageId { get; set; }
        public Language Language { get; set; }
    }
}
