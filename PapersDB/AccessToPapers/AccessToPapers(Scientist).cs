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
        public List<Scientist> GetAllScientists(string name, string organisation)
        {
            PapersDataSet = provider.GetAllData(TargetData, DataType);
            BasePapersDataSet.ScientistsRow[] searchedRow = null;
                
                if (name != "" && organisation != "")
                {
                    BasePapersDataSet.OrganisationsRow[] organisationRow = (BasePapersDataSet.OrganisationsRow[])
                         PapersDataSet.Organisations.Select("[org_name] = '" + organisation + "'");
                    searchedRow = (BasePapersDataSet.ScientistsRow[])
                        PapersDataSet.Scientists.Select("[s_name] = '" + name + "' AND " +
                                                           "[org_id] = '" + organisationRow[0].org_id.ToString() + "'");
                }
                else
                    if (name != "")
                    {
                        searchedRow = (BasePapersDataSet.ScientistsRow[])
                       PapersDataSet.Scientists.Select("[s_name] = '" + name + "'");
                    }
                    else
                        if (organisation != "")
                        {
                            BasePapersDataSet.OrganisationsRow[] organisationRow = (BasePapersDataSet.OrganisationsRow[])
                         PapersDataSet.Organisations.Select("[org_name] = '" + organisation + "'");
                            searchedRow = (BasePapersDataSet.ScientistsRow[])
                                PapersDataSet.Scientists.Select("[org_id] = '" + organisationRow[0].org_id.ToString() + "'");
                        }
                        else {
                            
                            searchedRow = (BasePapersDataSet.ScientistsRow[])PapersDataSet.Scientists.Select("");
                        }
                 
            List <Scientist> scientists = new List<Scientist>();

            foreach (BasePapersDataSet.ScientistsRow scientistRow in searchedRow)
            {
                Scientist scientist = new Scientist();
                scientist.Email = scientistRow.s_email;
                scientist.hindex = (float)scientistRow.s_hindex;
                scientist.ID = scientistRow.s_id;
                scientist.Name = scientistRow.s_name;
                scientist.organisationID = scientistRow.OrganisationsRow.org_id;
                scientist.organisationName = scientistRow.OrganisationsRow.org_name;

               scientists.Add(scientist);
            }

            return scientists;
        }
        public bool addScientist(Scientist scientist)
        {
            if (!isScientistInDB(scientist))
            {
                BasePapersDataSet.OrganisationsRow[] organisationRow = (BasePapersDataSet.OrganisationsRow[])
                 PapersDataSet.Organisations.Select("[org_name] = '" + scientist.organisationName.ToString() + "'");
                PapersDataSet.Scientists.AddScientistsRow(scientist.hindex, organisationRow[0], scientist.Name, scientist.Email);
                provider.UpdateAllData();
                return true;
            };
            return false;
        }
        
        public bool modifyScientist(Scientist scientist)
        {
            if (isScientistInDB(scientist.ID))
            {
                BasePapersDataSet.ScientistsRow[] scientistRow = (BasePapersDataSet.ScientistsRow[])
                    PapersDataSet.Scientists.Select("[s_id] = '" + scientist.ID.ToString() + "'");
                if (scientist.organisationName != "")
                {
                    BasePapersDataSet.OrganisationsRow[] organisationRow = (BasePapersDataSet.OrganisationsRow[])
                        PapersDataSet.Countries.Select("[org_name] = '" + scientist.organisationName.ToString() + "'");
                    scientistRow[0].org_id = organisationRow[0].org_id;
                }
                if (scientist.Name != "")
                    scientistRow[0].s_name = scientist.Name;

                if (scientist.Email != "")
                    scientistRow[0].s_email = scientist.Email;
                if (scientist.hindex != 0)
                    scientistRow[0].s_hindex = scientist.hindex;

                provider.UpdateAllData();
                return true;
            };
            return false;
        }
        
        public bool deleteScientist(int ID)
        {
            if (isScientistInDB(ID))
            {
                DataRow[] ScientistRow = PapersDataSet.Scientists.Select("[s_id] = '" + ID.ToString() + "'");
                ScientistRow[0].Delete();
                provider.UpdateAllData();
                return true;
            };
            return false;
        }
        bool isScientistInDB(int ID)
        {
            DataRow[] ScientistRow = PapersDataSet.Scientists.Select("[s_id] = '" + ID.ToString() + "'");
            return ScientistRow != null && ScientistRow.Length > 0;
        }


        bool isScientistInDB(Scientist scientist)
        {
            var scies = from sci in PapersDataSet.Scientists.AsEnumerable()
                       where sci.s_name == scientist.Name
                       select sci;
            return scies.Count() > 0;

            /*
            
            DataRow[] OrganisationRow = PapersDataSet.Organisations.Select("[org_name] = '" + organisation.Name.ToString() + "'");
            return OrganisationRow != null && OrganisationRow.Length > 0;*/
        }

    }
}
