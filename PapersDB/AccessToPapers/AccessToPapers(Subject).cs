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
        public List<Subject> GetAllSubjects()
        {
            return basePapers.Subjects.Local.ToList();
        }
        public bool addSubject(Subject Subject)
        {
            if (!isSubjectInDB(Subject))
            {
                basePapers.Subjects.Add(Subject);
                basePapers.SaveChanges();
                return true;
            };
            return false;
        }
        public bool deleteSubject(Subject subject)
        {
            if (subjectLinked(subject)) return true;

            basePapers.Subjects.Remove(basePapers.Subjects.Find(subject.subj_id));
            basePapers.SaveChanges();

            return false;
        }
        public void modifySubject(Subject subject)
        {
            
                Subject subject_mod = basePapers.Subjects.First(i => i.subj_id == subject.subj_id);

                subject_mod.subj_name = subject.subj_name;

                basePapers.SaveChanges();
                
        }
        bool isSubjectInDB(Subject subject)
        {
            return (from subject_f in basePapers.Subjects
                    where
                     subject_f.subj_name == subject.subj_name ||
                     subject_f.subj_id == subject.subj_id
                    select
                     subject_f.subj_id).Any();
        }
        bool subjectLinked(Subject subject)
        {
            return (from paper in basePapers.Papers
                    where
                        paper.subj_id == subject.subj_id
                    select
                        paper).Any();
        }
        
    }
}
