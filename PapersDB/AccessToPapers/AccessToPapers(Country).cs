using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Common;
using System.Data.Entity;
using System.ComponentModel;

namespace AccessToPapers
{
    public partial class AccessToPapers
    {
        public List<Country> GetAllCountries()
        {
            return basePapers.Countries.Local.ToList();
        }
        public bool addCountry(Country country)
        {
            if (!isCountryInDB(country))
            {
                basePapers.Countries.Add(country);
                basePapers.SaveChanges();
                return true;
            };
            return false;
        }
        public bool deleteCountry(Country country)
        {
            if (countryLinked(country)) return false;
            
            basePapers.Countries.Remove(basePapers.Countries.Find(country.country_id));
            basePapers.SaveChanges();

            return true;
        }
        public void modifyCountry(Country country)
        {
           Country country_mod = basePapers.Countries.First(i => i.country_id == country.country_id);
                
           country_mod.country_name = country.country_name;
                
           basePapers.SaveChanges();
             

        }
        bool isCountryInDB(Country country)
        {
            return (from country_f in basePapers.Countries 
                    where 
                     country_f.country_name == country.country_name ||
                     country_f.country_id == country.country_id 
                    select 
                     country.country_id).Any();

        }

        bool countryLinked(Country country)
        {
            return (from org in basePapers.Organisations
                    where
                        org.Country.country_id == country.country_id
                    select
                        org).Any();
        }
    }
}
