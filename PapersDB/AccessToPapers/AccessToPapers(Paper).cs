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
        public List<Paper> GetAllPapers(string title, string subject, string language)
        {
            PapersDataSet = provider.GetAllData(TargetData, DataType);
            BasePapersDataSet.PapersRow[] searchedRow = null;

            string query = "";
            if (title != "")
            {
                if (query != "")
                    query += " AND ";
                query += "[p_title] = '" + title + "'";
            }
            if (subject != "")
            {
                if (query != "")
                    query += " AND ";
                BasePapersDataSet.SubjectsRow[] subjRow = (BasePapersDataSet.SubjectsRow[])
                     PapersDataSet.Subjects.Select("[subj_name] = '" + subject + "'");
                query += "[subj_id] = '" + subjRow[0].subj_id.ToString() + "'";
            }
            if (language != "")
            {
                if (query != "")
                    query += " AND ";
                BasePapersDataSet.LanguagesRow[] langRow = (BasePapersDataSet.LanguagesRow[])
                     PapersDataSet.Languages.Select("[language_name] = '" + language + "'");
                query += "[language_id] = '" + langRow[0].language_id.ToString() + "'";
            }

                    
            searchedRow = (BasePapersDataSet.PapersRow[])PapersDataSet.Papers.Select(query);
                 

            List<Paper> papers = new List<Paper>();

            foreach (BasePapersDataSet.PapersRow paperRow in searchedRow)
            {
                Paper paper = new Paper();
                paper.Title = paperRow.p_title;
                paper.ID = paperRow.p_id;
                paper.Language = paperRow.LanguagesRow.language_name;
                paper.languageID = paperRow.LanguagesRow.language_id;
                paper.PublishedDate = paperRow.p_date;
                paper.subjectID = paperRow.subj_id;
                paper.Subject = paperRow.SubjectsRow.subj_name;
                papers.Add(paper);
            }

            return papers;
        }
        
        public bool addPaper(Paper paper)
        {
            if (!isPaperInDB(paper))
            {
                BasePapersDataSet.LanguagesRow[] langRow = (BasePapersDataSet.LanguagesRow[])
                 PapersDataSet.Languages.Select("[language_name] = '" + paper.Language + "'");
                BasePapersDataSet.SubjectsRow[] subjRow = (BasePapersDataSet.SubjectsRow[])
                 PapersDataSet.Subjects.Select("[subj_name] = '" + paper.Subject + "'");
                PapersDataSet.Papers.AddPapersRow(paper.Title, paper.Abstract, paper.PublishedDate, langRow[0], subjRow[0]);
                provider.UpdateAllData();
                return true;
            };
            return false;
        }

        public bool modifyPaper(Paper paper)
        {
            if (isPaperInDB(paper.ID))
            {
                BasePapersDataSet.PapersRow[] paperRow = (BasePapersDataSet.PapersRow[])
                    PapersDataSet.Papers.Select("[p_id] = '" + paper.ID.ToString() + "'");
                if (paper.Language != "")
                {
                    BasePapersDataSet.LanguagesRow[] languageRow = (BasePapersDataSet.LanguagesRow[])
                        PapersDataSet.Languages.Select("[language_name] = '" + paper.Language.ToString() + "'");
                    paperRow[0].language_id = languageRow[0].language_id;
                }
                if (paper.Title != "")
                    paperRow[0].p_title = paper.Title;

                if (paper.Subject != "")
                {
                    BasePapersDataSet.SubjectsRow[] subjectRow = (BasePapersDataSet.SubjectsRow[])
                        PapersDataSet.Subjects.Select("[subj_name] = '" + paper.Subject.ToString() + "'");
                    paperRow[0].subj_id = subjectRow[0].subj_id;
                }

                provider.UpdateAllData();
                return true;
            };
            return false;
        }

        public bool deletePaper(int ID)
        {
            if (isPaperInDB(ID))
            {
                DataRow[] PaperRow = PapersDataSet.Papers.Select("[p_id] = '" + ID.ToString() + "'");
                PaperRow[0].Delete();
                provider.UpdateAllData();
                return true;
            };
            return false;
        }
        bool isPaperInDB(int ID)
        {
            DataRow[] PaperRow = PapersDataSet.Papers.Select("[p_id] = '" + ID.ToString() + "'");
            return PaperRow != null && PaperRow.Length > 0;
        }


        bool isPaperInDB(Paper paper)
        {
            var scies = from sci in PapersDataSet.Papers.AsEnumerable()
                        where sci.p_title == paper.Title
                        select sci;
            return scies.Count() > 0;

            /*
            
            DataRow[] OrganisationRow = PapersDataSet.Organisations.Select("[org_name] = '" + organisation.Name.ToString() + "'");
            return OrganisationRow != null && OrganisationRow.Length > 0;*/
        }
        public List<Scientist> getAllAuthors(int paperID, string Name)
        {
            PapersDataSet = provider.GetAllData(TargetData, DataType);
            BasePapersDataSet.Auths_papersRow[] searchedRow = null;

            string query = "[p_id] = '" + paperID + "'";
            if ( Name != "" ) 
            {
                BasePapersDataSet.ScientistsRow[] sciRow = (BasePapersDataSet.ScientistsRow[])
                        PapersDataSet.Scientists.Select("[s_name] = '" + Name + "'");
                if ( sciRow.Length > 0 )
                query += " AND [s_id] = '" + sciRow[0].s_id.ToString() + "'";
                else
                    query += " AND [s_id] = '" + (10000000).ToString() + "'";
            }
            searchedRow = (BasePapersDataSet.Auths_papersRow[])PapersDataSet.Auths_papers.Select(query);
            List<Scientist> scientists = new List<Scientist>();
            foreach (BasePapersDataSet.Auths_papersRow authorsRow in searchedRow)
            {
                Scientist scientist = new Scientist();
                scientist.ID = authorsRow.author_paper_id;
                scientist.Name = authorsRow.ScientistsRow.s_name;
                scientists.Add(scientist);
            }
            return scientists;
        }
        public bool addAuthor(int paperID, Scientist scientist)
        {
            if (!isAuthorInDB(paperID, scientist))
            {
                BasePapersDataSet.PapersRow[] paperRow = (BasePapersDataSet.PapersRow[])
                 PapersDataSet.Papers.Select("[p_id] = '" + paperID + "'");
                BasePapersDataSet.ScientistsRow[] sciRow = (BasePapersDataSet.ScientistsRow[])
                 PapersDataSet.Scientists.Select("[s_name] = '" + scientist.Name + "'");
                PapersDataSet.Auths_papers.AddAuths_papersRow(paperRow[0], sciRow[0]);
                provider.UpdateAllData();
                return true;
            };
            return false;
        }
        public bool deleteAuthor(int ID)
        {
            if (isAuthorInDB(ID))
            {
                DataRow[] PaperRow = PapersDataSet.Auths_papers.Select("[author_paper_id] = '" + ID.ToString() + "'");
                PaperRow[0].Delete();
                provider.UpdateAllData();
                return true;
            };
            return false;
        }
        bool isAuthorInDB(int paperID, Scientist sci)
        {
            BasePapersDataSet.ScientistsRow[] sciRow = (BasePapersDataSet.ScientistsRow[])
                 PapersDataSet.Scientists.Select("[s_name] = '" + sci.Name + "'");
            DataRow[] PaperRow = PapersDataSet.Auths_papers.Select("[p_id] = '" + paperID + "' AND " +
                                                                   "[s_id] = '" + sciRow[0].s_id.ToString() + "'");
            return PaperRow != null && PaperRow.Length > 0;
        }
        bool isAuthorInDB(int id)
        {
            DataRow[] PaperRow = PapersDataSet.Auths_papers.Select("[author_paper_id] = '" + id.ToString() + "'");
            return PaperRow != null && PaperRow.Length > 0;
        }
    }
}
