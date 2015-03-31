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
        public List<Organisation> GetAllOrganisations()
        {
            DataRowCollection searchedRow = PapersDataSet.Organisations.Rows;
            List<Organisation> organisations = new List<Organisation>();

            foreach (BasePapersDataSet.OrganisationsRow orgRow in searchedRow)
            {
                Organisation organisation = new Organisation();
                organisation.ID = orgRow.org_id;
                organisation.Name = orgRow.org_name;
                organisation.Website = orgRow.org_website;
                organisation.Country = orgRow.CountriesRow.country_name;
                organisations.Add(organisation);
            }

            return organisations;
        }

        public void addOrganisation(Organisation organisation)
        {
            
            //PapersDataSet.Organisations.AddOrganisationsRow(organisation.Name, organisation.Country, organisation.Website);
            
        }
    }
}
