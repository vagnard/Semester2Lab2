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
            PapersDataSet = provider.GetAllData(TargetData, DataType);
            DataRowCollection searchedRow = PapersDataSet.Languages.Rows;
            List<Language> languages = new List<Language>();

            foreach (BasePapersDataSet.LanguagesRow LanguageRow in searchedRow)
            {
                Language Language = new Language();
                Language.Name = LanguageRow.language_name;
                Language.ID = LanguageRow.language_id;
                languages.Add(Language);
            }

            return languages;
        }
        public bool addLanguage(Language Language)
        {
            if (!isLanguageInDB(Language.Name))
            {
                PapersDataSet.Languages.AddLanguagesRow(Language.Name);
                provider.UpdateAllData();
                return true;
            };
            return false;
        }
        public bool deleteLanguage(int ID)
        {
            if (isLanguageInDB(ID))
            {
                DataRow[] LanguageRow = PapersDataSet.Languages.Select("[language_id] = '" + ID.ToString() + "'");
                LanguageRow[0].Delete();
                provider.UpdateAllData();
                return true;
            };
            return false;
        }
        public bool modifyLanguage(Language Language)
        {
            if (isLanguageInDB(Language.ID))
            {
                BasePapersDataSet.LanguagesRow[] LanguageRow = (BasePapersDataSet.LanguagesRow[])
                    PapersDataSet.Languages.Select("[language_id] = '" + Language.ID.ToString() + "'");
                LanguageRow[0].language_name = Language.Name;
                provider.UpdateAllData();
                return true;
            };
            return false;
        }
        bool isLanguageInDB(string name)
        {
            DataRow[] LanguageRow = PapersDataSet.Languages.Select("[language_name] = '" + name.ToString() + "'");
            return LanguageRow != null && LanguageRow.Length > 0;
        }
        bool isLanguageInDB(int ID)
        {
            DataRow[] LanguageRow = PapersDataSet.Languages.Select("[language_id] = '" + ID.ToString() + "'");
            return LanguageRow != null && LanguageRow.Length > 0;
        }
    }
}
