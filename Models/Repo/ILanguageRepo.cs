using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppAssignmentDATABASE_5.Models.Repo
{
    public interface ILanguageRepo
    {
        Language Create(string name);
        List<Language> Read();
        Language Read(int id);
        Language Update(Language language);
        bool Delete(Language language);
    }
}
