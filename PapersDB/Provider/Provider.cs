using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Common;

namespace Provider
{
    public class Provider
    {
        BasePapersDataSet PapersDataSet = new BasePapersDataSet();
        SqlDataAdapter[] PapersDataAdapters;
        DataTable[] PapersTables;
        string[] TablesName;
        SourceType DataType;
        string TargetFile;

        public Provider()
        {

        }

        public BasePapersDataSet GetAllData(string TargetFile, SourceType DataType)
        {
            this.DataType = DataType;
            this.TargetFile = TargetFile;
            PapersDataSet.Clear();
            if (DataType == SourceType.XML)
            {
                PapersDataSet.ReadXml(TargetFile);
                return PapersDataSet;
            }
            else
            {
                PapersTables = new DataTable[]
                {
                    PapersDataSet.Countries,
                    PapersDataSet.Languages,
                    PapersDataSet.Organisations,
                    PapersDataSet.Papers,
                    PapersDataSet.Scientists,
                    PapersDataSet.Subjects,
                    PapersDataSet.Auths_papers,
                    PapersDataSet.Reviewers_papers
                };

                TablesName = new string[]{
                    "Countries", "Languages",
                    "Organisations", "Papers", "Scientists",
                    "Subjects", "Auths_papers", "Reviewers_papers"
                };

                int TablesCount = PapersTables.Length;

                PapersDataAdapters = new SqlDataAdapter[TablesCount];
                SqlConnection Connection = new SqlConnection(TargetFile);

                for (int i = 0; i < TablesCount ; i++)
                {
                    PapersDataAdapters[i] = new SqlDataAdapter(
                        "SELECT * FROM " + TablesName[i], Connection);
                    SqlCommandBuilder comld = new SqlCommandBuilder(PapersDataAdapters[i]);
                    PapersDataAdapters[i].Fill(PapersTables[i]);
                }
                    
                return PapersDataSet;
            }
        }

        public void UpdateAllData()
        {
            if (DataType == SourceType.XML)
                PapersDataSet.WriteXml(TargetFile);
            else
            {
                int TablesCount = PapersTables.Length;
                for (int i = 0; i < TablesCount; i++)
                    PapersDataAdapters[i].Update(PapersTables[i]);
            }
        }
    }
}
