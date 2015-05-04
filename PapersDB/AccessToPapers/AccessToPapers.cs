using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using System.Data.Entity;

namespace AccessToPapers
{
    public partial class AccessToPapers
    {
        BasePapersEntities basePapers;

        public AccessToPapers()
        {
            basePapers = new BasePapersEntities();
            basePapers.Auths_papers.Load();
            basePapers.Languages.Load();
            basePapers.Subjects.Load();
            basePapers.Countries.Load();
            basePapers.Organisations.Load();
            basePapers.Papers.Load();
            basePapers.Scientists.Load(); 
            
        }
    }
}
