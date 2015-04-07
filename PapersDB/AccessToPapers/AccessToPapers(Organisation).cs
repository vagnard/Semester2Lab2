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
        public List<Organisation> GetAllOrganisations(string name, string country)
        {
            PapersDataSet = provider.GetAllData(TargetData, DataType);
            BasePapersDataSet.OrganisationsRow[] searchedRow = null;

            if (name != "" && country != "")
            {
                BasePapersDataSet.CountriesRow[] countryRow = (BasePapersDataSet.CountriesRow[])
                     PapersDataSet.Countries.Select("[country_name] = '" + country + "'");
                searchedRow = (BasePapersDataSet.OrganisationsRow[])
                    PapersDataSet.Organisations.Select("[org_name] = '" + name + "' AND " +
                                                       "[org_country] = '" + countryRow[0].country_id.ToString() + "'");
            }
            else
                if (name != "")
                {
                    searchedRow = (BasePapersDataSet.OrganisationsRow[])
                   PapersDataSet.Organisations.Select("[org_name] = '" + name + "'");
                }
                else
                    if (country != "")
                    {
                        BasePapersDataSet.CountriesRow[] countryRow = (BasePapersDataSet.CountriesRow[])
                            PapersDataSet.Countries.Select("[country_name] = '" + country + "'");
                        searchedRow = (BasePapersDataSet.OrganisationsRow[])
                          PapersDataSet.Organisations.Select("[org_country] = '" + countryRow[0].country_id.ToString() + "'");
                    }
                    else
                        searchedRow = (BasePapersDataSet.OrganisationsRow[])PapersDataSet.Organisations.Select("");
            List<Organisation> organisations = new List<Organisation>();

            foreach (BasePapersDataSet.OrganisationsRow organisationRow in searchedRow)
            {
                Organisation organisation = new Organisation();
                organisation.Country = organisationRow.CountriesRow.country_name;
                organisation.CountryID = organisationRow.CountriesRow.country_id;
                organisation.ID = organisationRow.org_id;
                organisation.Name = organisationRow.org_name;
                organisation.Website = organisationRow.org_website;

                organisations.Add(organisation);
            }

            return organisations;
        }
        public bool addOrganisation(Organisation organisation)
        {
            if (!isOrganisationInDB(organisation))
            {
                BasePapersDataSet.CountriesRow[] countryRow = (BasePapersDataSet.CountriesRow[])
                 PapersDataSet.Countries.Select("[country_name] = '" + organisation.Country.ToString() + "'");
                PapersDataSet.Organisations.AddOrganisationsRow(organisation.Name, countryRow[0], organisation.Website);
                provider.UpdateAllData();
                return true;
            };
            return false;
        }

        public bool modifyOrganisation(Organisation organisation)
        {
            if (isOrganisationInDB(organisation.ID))
            {
                BasePapersDataSet.OrganisationsRow[] organisationRow = (BasePapersDataSet.OrganisationsRow[])
                    PapersDataSet.Organisations.Select("[org_id] = '" + organisation.ID.ToString() + "'");
                if (organisation.Country != "")
                {
                    BasePapersDataSet.CountriesRow[] countryRow = (BasePapersDataSet.CountriesRow[])
                        PapersDataSet.Countries.Select("[country_name] = '" + organisation.Country.ToString() + "'");
                    organisationRow[0].org_country = countryRow[0].country_id;
                }
                if (organisation.Name != "")
                    organisationRow[0].org_name = organisation.Name;

                if (organisation.Website != "")
                    organisationRow[0].org_website = organisation.Website;
                provider.UpdateAllData();
                return true;
            };
            return false;
        }

        public bool deleteOrganisation(int ID)
        {
            if (isOrganisationInDB(ID))
            {
                DataRow[] countryRow = PapersDataSet.Organisations.Select("[org_id] = '" + ID.ToString() + "'");
                countryRow[0].Delete();
                provider.UpdateAllData();
                return true;
            };
            return false;
        }
        bool isOrganisationInDB(int ID)
        {
            DataRow[] OrganisationRow = PapersDataSet.Organisations.Select("[org_id] = '" + ID.ToString() + "'");
            return OrganisationRow != null && OrganisationRow.Length > 0;
        }


        bool isOrganisationInDB(Organisation organisation)
        {
            var orgs = from org in PapersDataSet.Organisations.AsEnumerable()
                             where org.org_name == organisation.Name
                             select org;
            return orgs.Count() > 0;

            /*
            
            DataRow[] OrganisationRow = PapersDataSet.Organisations.Select("[org_name] = '" + organisation.Name.ToString() + "'");
            return OrganisationRow != null && OrganisationRow.Length > 0;*/
        }
        
    }
}
