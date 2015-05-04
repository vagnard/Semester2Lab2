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
        public class ProjectedPaper
        {
            public int p_id { get; set; }
            public string p_title { get; set; }
            public string language_id { get; set; }
            public string subj_id { get; set; }
        }
        public List<ProjectedPaper> GetAllPapers(string title, string subject, string language)
        {
            return (from paper in basePapers.Papers
                    where paper.p_title.Contains(title) &&
                    (paper.Subject.subj_name == subject || subject == "") &&
                    (paper.Language.language_name == language || language == "")
                    join lang in basePapers.Languages
                    on paper.language_id
                    equals lang.language_id
                    join subj in basePapers.Subjects
                    on paper.subj_id
                    equals subj.subj_id
                    select new ProjectedPaper
                    {
                        p_id = paper.p_id,
                        p_title = paper.p_title,
                        language_id = lang.language_name,
                        subj_id = subj.subj_name
                    }).ToList();
        }
        
        public bool addPaper(Paper paper)
        {
            if (!isPaperInDB(paper))
            {
                basePapers.Papers.Add(paper);
                basePapers.SaveChanges();
                return true;
            };
            return false;
        }

        public void modifyPaper(Paper paper)
        {
            Paper paper_mod = basePapers.Papers.First(i => i.p_id == paper.p_id);
            if (paper.Language.language_name != "")
                paper_mod.language_id = basePapers.Languages.First(i => i.language_name == paper.Language.language_name).language_id;

            if (paper.Subject.subj_name != "")
                paper_mod.subj_id = basePapers.Subjects.First(i => i.subj_name == paper.Subject.subj_name).subj_id;

            if (paper.p_title != "")
                paper_mod.p_title = paper.p_title;

            basePapers.SaveChanges();
        }

        public bool deletePaper(Paper paper)
        {
            if (isPaperLinked(paper)) return false;

            basePapers.Papers.Remove(basePapers.Papers.Find(paper.p_id));
            basePapers.SaveChanges();

            return true;
        }
        bool isPaperLinked(Paper paper)
        {
            return (from sci in basePapers.Auths_papers
                    where
                        sci.p_id == paper.p_id
                    select
                        sci).Any();
        }


        bool isPaperInDB(Paper paper)
        {
            return (from p in basePapers.Papers
                    where paper.p_id == p.p_id ||
                          paper.p_title == p.p_title
                    select p).Any();
        }
        public class ProjectedAuths
        {
            public int author_paper_id { get; set; }
            public string p_id { get; set; }
            public string s_id { get; set; }
        }
        public List<ProjectedAuths> getAllAuthors(int paperID, string Name)
        {
            return (from auths in basePapers.Auths_papers
                    where auths.Scientist.s_name.Contains(Name) && (auths.p_id == paperID)
                    join sci in basePapers.Scientists
                    on auths.s_id
                    equals sci.s_id
                    select new ProjectedAuths
                    {
                       author_paper_id = auths.author_paper_id,
                       p_id = auths.Paper.p_title,
                       s_id = auths.Scientist.s_name
                    }).ToList();
        }
        public bool addAuthor(Auths_papers author)
        {
            if (!isAuthorInDB(author))
            {
                basePapers.Auths_papers.Add(author);
                basePapers.SaveChanges();
                return true;
            };
            return false;
        }
        public void deleteAuthor(Auths_papers author)
        {
            basePapers.Auths_papers.Remove(basePapers.Auths_papers.Find(author.author_paper_id));
            basePapers.SaveChanges();
        }
        
  
        bool isAuthorInDB(Auths_papers author)
        {
            return (from auth in basePapers.Auths_papers
                    where
                     auth.p_id == author.p_id && auth.Scientist.s_name == author.Scientist.s_name
                    select
                     auth).Any();
        }
       
    }
}
