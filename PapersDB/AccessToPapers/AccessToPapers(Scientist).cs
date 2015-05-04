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
        public class ProjectedScientist
        {
            public int s_id { get; set; }
            public Nullable<double> s_hindex { get; set; }
            public string org_id { get; set; }
            public string s_name { get; set; }
            public string s_email { get; set; }
        }

        public List<ProjectedScientist> GetAllScientists(string name, string organisation)
        {
            return (from sci in basePapers.Scientists
                    where sci.s_name.Contains(name) && (sci.Organisation.org_name == organisation || organisation == "")
                    join org in basePapers.Organisations
                    on sci.org_id
                    equals org.org_id
                    select new ProjectedScientist
                    {
                        s_id = sci.s_id,
                        s_hindex = sci.s_hindex,
                        org_id = org.org_name,
                        s_name = sci.s_name,
                        s_email = sci.s_email
                    }).ToList();
            
        }

        public bool addScientist(Scientist scientist)
        {
            if (!isScientistInDB(scientist))
            { 
            
                scientist.Organisation = basePapers.Organisations.First(i => i.org_name == scientist.Organisation.org_name);
                
                basePapers.Scientists.Add(scientist);

                basePapers.SaveChanges();
                return true;
            };
            return false;
        }

        public void modifyScientist(Scientist scientist)
        {
          
                Scientist sci_mod = basePapers.Scientists.First(i => i.s_id == scientist.s_id);
                if (scientist.Organisation.org_name != "")
                {
                    sci_mod.org_id = basePapers.Organisations.First(i => i.org_name == scientist.Organisation.org_name).org_id;
                }
                if (scientist.s_name != "")
                    sci_mod.s_name = scientist.s_name;

                if (scientist.s_email != "")
                    sci_mod.s_email = scientist.s_email;

                if (scientist.s_hindex != 0)
                    sci_mod.s_hindex = scientist.s_hindex;

                basePapers.SaveChanges();
                
        }

        public bool deleteScientist(Scientist scientist)
        {
            if (isScientistLinked(scientist)) return false;

            basePapers.Scientists.Remove(basePapers.Scientists.Find(scientist.s_id));
            basePapers.SaveChanges();

            return true;
        }
        bool isScientistLinked(Scientist scientist)
        {
            return (from paper in basePapers.Auths_papers
                    where
                        paper.s_id == scientist.s_id
                    select
                        paper).Any();
        }


        bool isScientistInDB(Scientist scientist)
        {
            return (from sci in basePapers.Scientists
                    where sci.s_name == scientist.s_name ||
                          sci.s_id == scientist.s_id
                    select sci).Any();
        }

    }
}
