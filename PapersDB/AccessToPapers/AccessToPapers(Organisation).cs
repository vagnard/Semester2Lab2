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
    public class ProjectedOrganization
    {
        public int org_id { get; set; }
        public string org_name { get; set; }
        public string org_country { get; set; }
        public string org_website { get; set; }
    }

    public partial class AccessToPapers
    {
        public List<ProjectedOrganization> GetAllOrganisations(string name, string country)
        {
            return (from org in basePapers.Organisations
                    where org.org_name.Contains(name) && (org.Country.country_name == country || country == "")
                    join cntry in basePapers.Countries
                    on org.org_country
                    equals cntry.country_id
                    select new ProjectedOrganization {
                        org_id = org.org_id,
                        org_name = org.org_name,
                        org_country = cntry.country_name,
                        org_website = org.org_website
                    }).ToList();
        }

        public bool addOrganisation(Organisation organisation)
        {
            if (!isOrganisationInDB(organisation))
            {
                basePapers.Organisations.Add(organisation);
                basePapers.SaveChanges();
                return true;
            };
            return false;
        }

        public void modifyOrganisation(Organisation organisation)
        {
           
                Organisation org_mod = basePapers.Organisations.First(i => i.org_id == organisation.org_id);
                if (organisation.Country.country_name != "")
                {
                    org_mod.org_country = basePapers.Countries.First(i => i.country_name == organisation.Country.country_name).country_id;
                }
                if (organisation.org_name != "")
                    org_mod.org_name = organisation.org_name;

                if (organisation.org_website != "")
                    org_mod.org_website = organisation.org_website;

                basePapers.SaveChanges();
                
        }

        public bool deleteOrganisation(Organisation organisation)
        {
            if (isOrganisationLinked(organisation)) return false;

            basePapers.Organisations.Remove(basePapers.Organisations.Find(organisation.org_id));
            basePapers.SaveChanges();

            return true;
        }
        bool isOrganisationLinked(Organisation organisation)
        {
            return (from sci in basePapers.Scientists
                    where
                        sci.org_id == organisation.org_id
                    select
                        sci).Any();
        }


        bool isOrganisationInDB(Organisation organisation)
        {
            return (from org in basePapers.Organisations
                             where org.org_name == organisation.org_name ||
                                   org.org_id == organisation.org_id
                             select org).Any();
        }
        
    }
}
