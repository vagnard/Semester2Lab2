using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Common;

namespace AccessToPapers
{
    public partial class AccessToPapers
    {
        public List<Language> GetAllLanguages()
        {
            return basePapers.Languages.Local.ToList();
        }
        public bool addLanguage(Language language)
        {
            if (!isLanguageInDB(language))
            {
                basePapers.Languages.Add(language);
                basePapers.SaveChanges();
                return true;
            };
            return false;
        }
        public bool deleteLanguage(Language language)
        {
            if (languageLinked(language)) return true;

            basePapers.Languages.Remove(basePapers.Languages.Find(language.language_id));
            basePapers.SaveChanges();

            return false;
        }
        public void modifyLanguage(Language language)
        {
                Language language_mod = basePapers.Languages.First(i => i.language_id == language.language_id);

                language_mod.language_name = language.language_name;

                basePapers.SaveChanges();
        }
        bool isLanguageInDB(Language language)
        {
            return (from language_f in basePapers.Languages
                    where
                     language_f.language_name == language.language_name ||
                     language_f.language_id == language.language_id
                    select
                     language_f.language_id).Any();
        }
        bool languageLinked(Language language)
        {
            return (from paper in basePapers.Papers
                    where
                        paper.language_id == language.language_id
                    select
                        paper).Any();
        }
    }
}
