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
        public List<Subject> GetAllSubjects()
        {
            PapersDataSet = provider.GetAllData(TargetData, DataType);
            DataRowCollection searchedRow = PapersDataSet.Subjects.Rows;
            List<Subject> Subjects = new List<Subject>();

            foreach (BasePapersDataSet.SubjectsRow SubjectRow in searchedRow)
            {
                Subject Subject = new Subject();
                Subject.Name = SubjectRow.subj_name;
                Subject.ID = SubjectRow.subj_id;
                Subjects.Add(Subject);
            }

            return Subjects;
        }
        public bool addSubject(Subject Subject)
        {
            if (!isSubjectInDB(Subject.Name))
            {
                PapersDataSet.Subjects.AddSubjectsRow(Subject.Name);
                provider.UpdateAllData();
                return true;
            };
            return false;
        }
        public bool deleteSubject(int ID)
        {
            if (isSubjectInDB(ID))
            {
                DataRow[] SubjectRow = PapersDataSet.Subjects.Select("[subj_id] = '" + ID.ToString() + "'");
                SubjectRow[0].Delete();
                provider.UpdateAllData();
                return true;
            };
            return false;
        }
        public bool modifySubject(Subject Subject)
        {
            if (isSubjectInDB(Subject.ID))
            {
                BasePapersDataSet.SubjectsRow[] SubjectRow = (BasePapersDataSet.SubjectsRow[])
                    PapersDataSet.Subjects.Select("[subj_id] = '" + Subject.ID.ToString() + "'");
                SubjectRow[0].subj_name = Subject.Name;
                provider.UpdateAllData();
                return true;
            };
            return false;
        }
        bool isSubjectInDB(string name)
        {
            DataRow[] SubjectRow = PapersDataSet.Subjects.Select("[subj_name] = '" + name.ToString() + "'");
            return SubjectRow != null && SubjectRow.Length > 0;
        }
        bool isSubjectInDB(int ID)
        {
            DataRow[] SubjectRow = PapersDataSet.Subjects.Select("[subj_id] = '" + ID.ToString() + "'");
            return SubjectRow != null && SubjectRow.Length > 0;
        }
    }
}
