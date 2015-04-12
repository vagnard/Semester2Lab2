using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccessToPapers;
using Common;

namespace PapersDB
{
    public partial class ClientLol : Form
    {
        AccessToPapers.AccessToPapers accessToPapers;
        List<string> CountryNames;
        List<string> LanguageNames;
        List<string> SubjectNames;
        List<string> OrgNames;
        List<string> ScientistNames;
        public ClientLol()
        {
            InitializeComponent();
            CountryNames = new List<string>();
            LanguageNames = new List<string>();
            SubjectNames = new List<string>();
            OrgNames = new List<string>();
            ScientistNames = new List<string>();

            LogIn logIn = new LogIn();
            if (logIn.ShowDialog() == DialogResult.OK)
            {
                accessToPapers = new AccessToPapers.AccessToPapers(logIn.DBType, logIn.ConnectionParameters);

                CountriesRefresh_btn_Click(null, null);
                OrganisationRefresh_Click(null, null);
                languageRefresh_btn_Click(null, null);
                subjectRefresh_btn_Click(null, null);
                Scientist_Refresh_Click(null, null);
                PapersRefresh_Click(null, null);
            }
            
        }

        


        // Country


        private void CountriesRefresh_btn_Click(object sender, EventArgs e)
        {
            List<Country> allCountries = new List<Country>();
            allCountries = accessToPapers.GetAllCountries();
            countries_dgv.DataSource = allCountries;
            countries_dgv.Columns["ID"].ReadOnly = true;
            countries_dgv.Columns["Name"].ReadOnly = true;

            CountryNames.Clear();
            CountryNames.Add("");
            foreach (Country country in allCountries)
                CountryNames.Add(country.Name);

        }

        private void addCountryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCountry newCountry = new AddCountry();
            if (newCountry.ShowDialog() == DialogResult.OK)
            {

                if (!accessToPapers.addCountry(newCountry.NewCountry))
                    MessageBox.Show("Such country already exists");
                CountriesRefresh_btn_Click(null, null);
            }

        }
        
        private void deleteCountryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteCountry deleteCountry = new DeleteCountry();
            if (deleteCountry.ShowDialog() == DialogResult.OK)
            {

                if (!accessToPapers.deleteCountry(deleteCountry.ID))
                    MessageBox.Show("Such country does not exist");
                CountriesRefresh_btn_Click(null, null);
            }
        }

        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifyCountry modifyCountry = new ModifyCountry();
            if (modifyCountry.ShowDialog() == DialogResult.OK)
            {
                if (!accessToPapers.modifyCountry(modifyCountry.modifyCountry))
                    MessageBox.Show("Such country does not exist");
                CountriesRefresh_btn_Click(null, null);
            }
        }

        // Organisation

        private void OrganisationRefresh_Click(object sender, EventArgs e)
        {
            List<Organisation> allOrgs = new List<Organisation>();
            allOrgs = accessToPapers.GetAllOrganisations(orgNameFilter_txbx.Text.Trim(), OrgCountry_cmbx.Text.Trim());
            org_dgv.DataSource = allOrgs;

            org_dgv.Columns["CountryID"].Visible = false;

            org_dgv.Columns["ID"].ReadOnly = true;
            org_dgv.Columns["Name"].ReadOnly = true;
            org_dgv.Columns["Country"].ReadOnly = true;
            org_dgv.Columns["Website"].ReadOnly = true;

            OrgCountry_cmbx.DataSource = CountryNames;

            OrgNames.Clear();
            OrgNames.Add("");
            foreach (Organisation Org in allOrgs)
                OrgNames.Add(Org.Name);
        }

        private void addOrganisationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddOrganisation newOrganisation = new AddOrganisation(CountryNames);
            if (newOrganisation.ShowDialog() == DialogResult.OK)
            {

                if (!accessToPapers.addOrganisation(newOrganisation.NewOrganisation))
                    MessageBox.Show("Such Organisation already exists");
                OrganisationRefresh_Click(null, null);
            }
        }
       

        private void deleteOrganisationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteOrganisation deleteOrganisation = new DeleteOrganisation();
            if (deleteOrganisation.ShowDialog() == DialogResult.OK)
            {

                if (!accessToPapers.deleteOrganisation(deleteOrganisation.ID))
                    MessageBox.Show("Such Organisation does not exist");
                OrganisationRefresh_Click(null, null);
            }
        }

        private void modifyOrganisationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifyOrganisation modifyOrganisation = new ModifyOrganisation(CountryNames);
            if (modifyOrganisation.ShowDialog() == DialogResult.OK)
            {
                if (!accessToPapers.modifyOrganisation(modifyOrganisation.modifyOrg))
                    MessageBox.Show("Such Organisation does not exist");
                OrganisationRefresh_Click(null, null);
            }
        }

        private void OrgCountry_cmbx_TextChanged(object sender, EventArgs e)
        {
            OrganisationRefresh_Click(null, null);
        }

        private void orgNameFilter_txbx_TextChanged(object sender, EventArgs e)
        {
            OrganisationRefresh_Click(null, null);
        }

        // Language

        private void languageRefresh_btn_Click(object sender, EventArgs e)
        {
            List<Language> allLanguages = new List<Language>();
            allLanguages = accessToPapers.GetAllLanguages();
            language_dgv.DataSource = allLanguages;
            language_dgv.Columns["ID"].ReadOnly = true;
            language_dgv.Columns["Name"].ReadOnly = true;

            LanguageNames.Clear();
            LanguageNames.Add("");
            foreach (Language Language in allLanguages)
                LanguageNames.Add(Language.Name);

        }

        private void addLanguageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddLanguage newLanguage = new AddLanguage();
            if (newLanguage.ShowDialog() == DialogResult.OK)
            {

                if (!accessToPapers.addLanguage(newLanguage.NewLanguage))
                    MessageBox.Show("Such Language already exists");
                languageRefresh_btn_Click(null, null);
            }
        }

        private void deleteLanguageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteLanguage deleteLanguage = new DeleteLanguage();
            if (deleteLanguage.ShowDialog() == DialogResult.OK)
            {

                if (!accessToPapers.deleteLanguage(deleteLanguage.ID))
                    MessageBox.Show("Such Language does not exist");
                languageRefresh_btn_Click(null, null);
            }
        }

        private void modifyLanguageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifyLanguage modifyLanguage = new ModifyLanguage();
            if (modifyLanguage.ShowDialog() == DialogResult.OK)
            {
                if (!accessToPapers.modifyLanguage(modifyLanguage.modifyLanguage))
                    MessageBox.Show("Such Language does not exist");
                languageRefresh_btn_Click(null, null);
            }
        }

        // Subject

        private void subjectRefresh_btn_Click(object sender, EventArgs e)
        {
            List<Subject> allSubjects = new List<Subject>();
            allSubjects = accessToPapers.GetAllSubjects();
            subject_dgv.DataSource = allSubjects;
            subject_dgv.Columns["ID"].ReadOnly = true;
            subject_dgv.Columns["Name"].ReadOnly = true;

            SubjectNames.Clear();
            SubjectNames.Add("");
            foreach (Subject Subject in allSubjects)
                SubjectNames.Add(Subject.Name);
        }

        private void addSubjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSubject newSubject = new AddSubject();
            if (newSubject.ShowDialog() == DialogResult.OK)
            {

                if (!accessToPapers.addSubject(newSubject.NewSubject))
                    MessageBox.Show("Such Subject already exists");
                subjectRefresh_btn_Click(null, null);
            }
        }

        private void deleteSubjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteSubject deleteSubject = new DeleteSubject();
            if (deleteSubject.ShowDialog() == DialogResult.OK)
            {

                if (!accessToPapers.deleteSubject(deleteSubject.ID))
                    MessageBox.Show("Such Subject does not exist");
                subjectRefresh_btn_Click(null, null);
            }
        }

        private void modifySubjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifySubject modifySubject = new ModifySubject();
            if (modifySubject.ShowDialog() == DialogResult.OK)
            {
                if (!accessToPapers.modifySubject(modifySubject.modifySubject))
                    MessageBox.Show("Such Subject does not exist");
                subjectRefresh_btn_Click(null, null);
            }
        }

        // Scientist

        private void Scientist_Refresh_Click(object sender, EventArgs e)
        {
           
            List<Scientist> allScientists = new List<Scientist>();
            allScientists = accessToPapers.GetAllScientists(SciNameFilter_txbx.Text.Trim(), SciOrganisation_cmbx.Text.Trim());
            SciOrganisation_cmbx.DataSource = OrgNames;
            sci_dgv.DataSource = allScientists;
            sci_dgv.Columns["OrganisationID"].Visible = false;
            sci_dgv.Columns["ID"].ReadOnly = true;
            sci_dgv.Columns["Name"].ReadOnly = true;
            sci_dgv.Columns["organisationName"].ReadOnly = true;
            sci_dgv.Columns["Email"].ReadOnly = true;
            sci_dgv.Columns["hindex"].ReadOnly = true;

            ScientistNames.Clear();
            foreach (Scientist sci in allScientists)
                ScientistNames.Add(sci.Name);
        }

        private void addScientistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddScientist newScientist = new AddScientist(OrgNames);
            if (newScientist.ShowDialog() == DialogResult.OK)
            {

                if (!accessToPapers.addScientist(newScientist.NewScientist))
                    MessageBox.Show("Such scientist already exists");
                Scientist_Refresh_Click(null, null);
            }
        }

        private void deleteScientistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteScientist deleteScientist = new DeleteScientist();
            if (deleteScientist.ShowDialog() == DialogResult.OK)
            {

                if (!accessToPapers.deleteScientist(deleteScientist.ID))
                    MessageBox.Show("Such scientist does not exist");
                Scientist_Refresh_Click(null, null);
            }
        }

        private void modifyScientistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifyScientist modifyScientist = new ModifyScientist(OrgNames);
            if (modifyScientist.ShowDialog() == DialogResult.OK)
            {
                if (!accessToPapers.modifyScientist(modifyScientist.modifySci))
                    MessageBox.Show("Such scientist does not exist");
                Scientist_Refresh_Click(null, null);
            }
        }

        private void SciNameFilter_txbx_TextChanged(object sender, EventArgs e)
        {
            Scientist_Refresh_Click(null, null);
        }

        private void SciOrganisation_cmbx_TextChanged(object sender, EventArgs e)
        {
            Scientist_Refresh_Click(null, null);
        }

        

        // Papers

        private void PapersRefresh_Click(object sender, EventArgs e)
        {
            List<Paper> allPaper = new List<Paper>();
            allPaper = accessToPapers.GetAllPapers(title_txbx.Text.Trim(), subj_cmbx.Text.Trim(), lang_cmbx.Text.Trim());
            subj_cmbx.DataSource = SubjectNames;
            lang_cmbx.DataSource = LanguageNames;
            papers_dgv.DataSource = allPaper;
            papers_dgv.Columns["Abstract"].Visible = false;
            papers_dgv.Columns["PublishedDate"].Visible = false;
            papers_dgv.Columns["LanguageID"].Visible = false;
            papers_dgv.Columns["SubjectID"].Visible = false;
            papers_dgv.Columns["ID"].ReadOnly = true;
            papers_dgv.Columns["Title"].ReadOnly = true;
            papers_dgv.Columns["Subject"].ReadOnly = true;
            papers_dgv.Columns["Language"].ReadOnly = true;
        }

        private void addPaperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPaper newPaper = new AddPaper(SubjectNames, LanguageNames);
            if (newPaper.ShowDialog() == DialogResult.OK)
            {

                if (!accessToPapers.addPaper(newPaper.newPaper))
                    MessageBox.Show("Such paper already exists");
                PapersRefresh_Click(null, null);
            }
        }

        private void deletePaperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeletePaper deletePaper = new DeletePaper();
            if (deletePaper.ShowDialog() == DialogResult.OK)
            {

                if (!accessToPapers.deletePaper(deletePaper.ID))
                    MessageBox.Show("Such paper does not exist");
                PapersRefresh_Click(null, null);
            }
        }

        private void modifyPaperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifyPaper modifyPaper = new ModifyPaper(SubjectNames, LanguageNames);
            if (modifyPaper.ShowDialog() == DialogResult.OK)
            {
                if (!accessToPapers.modifyPaper(modifyPaper.modifyPaper))
                    MessageBox.Show("Such paper does not exist");
                PapersRefresh_Click(null, null);
            }
        }

        private void authorCall_btn_Click(object sender, EventArgs e)
        {
            Authors author = new Authors(accessToPapers, (int)papers_dgv.CurrentRow.Cells["ID"].Value, ScientistNames);
            author.ShowDialog();
        }

        private void reviewerCall_btn_Click(object sender, EventArgs e)
        {

        }

        private void title_txbx_TextChanged(object sender, EventArgs e)
        {
            PapersRefresh_Click(null, null);
        }

        private void subj_cmbx_TextChanged(object sender, EventArgs e)
        {
            PapersRefresh_Click(null, null);
        }

        private void lang_cmbx_TextChanged(object sender, EventArgs e)
        {
            PapersRefresh_Click(null, null);
        }


       


    }
}
