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
        public List<Country> GetAllCountries()
        {
            PapersDataSet = provider.GetAllData(TargetData, DataType);
            DataRowCollection searchedRow = PapersDataSet.Countries.Rows;
            List<Country> countries = new List<Country>();

            foreach (BasePapersDataSet.CountriesRow countryRow in searchedRow)
            {
                Country country = new Country();
                country.Name = countryRow.country_name;
                country.ID = countryRow.country_id;
                countries.Add(country);
            }

            return countries;
        }
        public bool addCountry(Country country)
        {
            if (!isCountryInDB(country.Name))
            {
                PapersDataSet.Countries.AddCountriesRow(country.Name);
                provider.UpdateAllData();
                return true;
            };
            return false;
        }
        public bool deleteCountry(int ID)
        {
            if (isCountryInDB(ID)) 
            {
                DataRow[] countryRow = PapersDataSet.Countries.Select("[country_id] = '" + ID.ToString() + "'");
                countryRow[0].Delete();
                provider.UpdateAllData();
                return true;
            };
            return false;
        }
        public bool modifyCountry(Country country)
        {
            if (isCountryInDB(country.ID))
            {
                BasePapersDataSet.CountriesRow[] countryRow = (BasePapersDataSet.CountriesRow[])
                    PapersDataSet.Countries.Select("[country_id] = '" + country.ID.ToString() + "'");
                countryRow[0].country_name = country.Name;
                provider.UpdateAllData();
                return true;
            };
            return false;
        }
        bool isCountryInDB(string name)
        {
            DataRow[] countryRow = PapersDataSet.Countries.Select("[country_name] = '" + name.ToString() + "'");
            return countryRow != null && countryRow.Length > 0;
        }
        bool isCountryInDB(int ID)
        {
            DataRow[] countryRow = PapersDataSet.Countries.Select("[country_id] = '" + ID.ToString() + "'");
            return countryRow != null && countryRow.Length > 0;
        }
    }
}
