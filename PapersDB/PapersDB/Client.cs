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
using System.Data.Entity;

namespace PapersDB
{
    public partial class ClientLol : Form
    {
        private AccessToPapers.AccessToPapers accessToPapers = new AccessToPapers.AccessToPapers();
        BindingList<string> CountryNames;
        BindingList<string> LanguageNames;
        BindingList<string> SubjectNames;
        BindingList<string> OrgNames;
        BindingList<string> ScientistNames;
        public ClientLol()
        {
            InitializeComponent();
            CountryNames = new BindingList<string>();
            LanguageNames = new BindingList<string>();
            SubjectNames = new BindingList<string>();
            OrgNames = new BindingList<string>();
            ScientistNames = new BindingList<string>();
            
            CountriesRefresh_btn_Click(null, null);
            OrganisationRefresh_Click(null, null);
            languageRefresh_btn_Click(null, null);
            subjectRefresh_btn_Click(null, null);
            Scientist_Refresh_Click(null, null);
            PapersRefresh_Click(null, null);
            
            
        }

        


        // Country


        private void CountriesRefresh_btn_Click(object sender, EventArgs e)
        {
            List<Country> allCountries = accessToPapers.GetAllCountries();
            countryBindingSource.DataSource = null;
            countryBindingSource.DataSource = allCountries;

            CountryNames.Clear();
            CountryNames.Add("");
            foreach (Country country in allCountries)
              CountryNames.Add(country.country_name);
            
        }

        private void addCountryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCountry newCountry = new AddCountry();
            if (newCountry.ShowDialog() == DialogResult.OK)
            {
                if (!accessToPapers.addCountry(newCountry.country))
                    MessageBox.Show("Such country already exists");
                CountriesRefresh_btn_Click(null, null);
            }

        }
        
        private void deleteCountryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Country delCountry = new Country();
            delCountry.country_id = Convert.ToInt32(countries_dgv.CurrentRow.Cells[0].EditedFormattedValue.ToString());
            if (!accessToPapers.deleteCountry(delCountry))
                MessageBox.Show("Some organisation depends on this country");
            CountriesRefresh_btn_Click(null, null);
        }

        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifyCountry modifyCountry = new ModifyCountry(Convert.ToInt32(countries_dgv.CurrentRow.Cells[0].EditedFormattedValue.ToString()));
            if (modifyCountry.ShowDialog() == DialogResult.OK)
            {
                accessToPapers.modifyCountry(modifyCountry.modifyCountry);
                CountriesRefresh_btn_Click(null, null);
            }
        }
        
        // Organisation

        string filterCountry = "";

        private void OrganisationRefresh_Click(object sender, EventArgs e)
        {
           
            OrgCountry_cmbx.DataSource = CountryNames;

            var allOrgs = accessToPapers.GetAllOrganisations(orgNameFilter_txbx.Text.Trim(), filterCountry);

            organisationBindingSource.DataSource = null;
            organisationBindingSource.DataSource = allOrgs;

            OrgNames.Clear();
            OrgNames.Add("");
            foreach (var Org in allOrgs)
                OrgNames.Add(Org.org_name);
        }

        private void addOrganisationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddOrganisation newOrganisation = new AddOrganisation(CountryNames);
            if (newOrganisation.ShowDialog() == DialogResult.OK)
            {

                if (!accessToPapers.addOrganisation(newOrganisation.NewOrganisation))
                    MessageBox.Show("Such organisation already exists");
                OrganisationRefresh_Click(null, null);
            }
        }
       

        private void deleteOrganisationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Organisation delOrganisation = new Organisation();
            delOrganisation.org_id = Convert.ToInt32(org_dgv.CurrentRow.Cells[0].EditedFormattedValue.ToString());
            if (!accessToPapers.deleteOrganisation(delOrganisation))
                MessageBox.Show("Some scientist depends on this organisation");
            OrganisationRefresh_Click(null, null);
        }

        private void modifyOrganisationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            ModifyOrganisation modifyOrganisation =
                new ModifyOrganisation(Convert.ToInt32(org_dgv.CurrentRow.Cells[0].EditedFormattedValue.ToString()), CountryNames);
            if (modifyOrganisation.ShowDialog() == DialogResult.OK)
            {
                accessToPapers.modifyOrganisation(modifyOrganisation.modifyOrg);
                OrganisationRefresh_Click(null, null);
            }
            
        }

        private void OrgCountry_cmbx_TextChanged(object sender, EventArgs e)
        {
            filterCountry = OrgCountry_cmbx.Text.Trim();
            OrganisationRefresh_Click(null, null);
        }

        private void orgNameFilter_txbx_TextChanged(object sender, EventArgs e)
        {
            OrganisationRefresh_Click(null, null);
        }

        // Language

        private void languageRefresh_btn_Click(object sender, EventArgs e)
        {
            List<Language> allLanguages = accessToPapers.GetAllLanguages();

            languageBindingSource.DataSource = null;
            languageBindingSource.DataSource = allLanguages;
            
            LanguageNames.Clear();
            LanguageNames.Add("");
            foreach (Language language in allLanguages)
                LanguageNames.Add(language.language_name);
            
        }

        private void addLanguageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddLanguage newLanguage = new AddLanguage();
            if (newLanguage.ShowDialog() == DialogResult.OK)
            {

                if (!accessToPapers.addLanguage(newLanguage.NewLanguage))
                    MessageBox.Show("Such language already exists");
                languageRefresh_btn_Click(null, null);
            }
        }

        private void deleteLanguageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Language delLanguage = new Language();
            delLanguage.language_id = Convert.ToInt32(language_dgv.CurrentRow.Cells[0].EditedFormattedValue.ToString());
            if (!accessToPapers.deleteLanguage(delLanguage))
                MessageBox.Show("Some paper depends on this language");

            languageRefresh_btn_Click(null, null);

        }

        private void modifyLanguageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifyLanguage modifyLanguage = new ModifyLanguage();
            if (modifyLanguage.ShowDialog() == DialogResult.OK)
            {
                accessToPapers.modifyLanguage(modifyLanguage.modifyLanguage);
      
                languageRefresh_btn_Click(null, null);
            }
        }

        // Subject

        private void subjectRefresh_btn_Click(object sender, EventArgs e)
        {
            List<Subject> allSubjects = accessToPapers.GetAllSubjects();

            subjectBindingSource.DataSource = null;
            subjectBindingSource.DataSource = allSubjects;
            
            SubjectNames.Clear();
            SubjectNames.Add("");
            foreach (Subject subject in allSubjects)
                SubjectNames.Add(subject.subj_name);
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
            Subject delSubject = new Subject();
            delSubject.subj_id = Convert.ToInt32(subject_dgv.CurrentRow.Cells[0].EditedFormattedValue.ToString());
            if (!accessToPapers.deleteSubject(delSubject))
                MessageBox.Show("Some paper depends on this language");

            subjectRefresh_btn_Click(null, null);
 
        }

        private void modifySubjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifySubject modifySubject = new ModifySubject();
            if (modifySubject.ShowDialog() == DialogResult.OK)
            {
                accessToPapers.modifySubject(modifySubject.modifySubject);
                subjectRefresh_btn_Click(null, null);
            }
        }

        // Scientist

        string filterOrganisation = "";

        private void Scientist_Refresh_Click(object sender, EventArgs e)
        {
            SciOrganisation_cmbx.DataSource = OrgNames;

            var allSci = accessToPapers.GetAllScientists(SciNameFilter_txbx.Text.Trim(), filterOrganisation);

            scientistBindingSource.DataSource = null;
            scientistBindingSource.DataSource = allSci;
           

            ScientistNames.Clear();
            
            foreach (var sci in allSci)
                ScientistNames.Add(sci.s_name);
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
            Scientist delSci = new Scientist();
            delSci.s_id = Convert.ToInt32(sci_dgv.CurrentRow.Cells[0].EditedFormattedValue.ToString());
            if (!accessToPapers.deleteScientist(delSci))
                MessageBox.Show("Some paper depends on this scientist");
            Scientist_Refresh_Click(null, null); 
        }

        private void modifyScientistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifyScientist modifySci =
               new ModifyScientist(Convert.ToInt32(sci_dgv.CurrentRow.Cells[0].EditedFormattedValue.ToString()), OrgNames);
            
            if (modifySci.ShowDialog() == DialogResult.OK)
            {
                accessToPapers.modifyScientist(modifySci.modifySci);
                    
                Scientist_Refresh_Click(null, null);
            }
        }

        private void SciNameFilter_txbx_TextChanged(object sender, EventArgs e)
        {
            
            Scientist_Refresh_Click(null, null);
        }
       
        private void SciOrganisation_cmbx_TextChanged(object sender, EventArgs e)
        {
            filterOrganisation = SciOrganisation_cmbx.Text.Trim();
            Scientist_Refresh_Click(null, null);
        }

      
        // Papers

        string filterSubject = "";
        string filterLanguage = "";

        private void PapersRefresh_Click(object sender, EventArgs e)
        {
            lang_cmbx.DataSource = LanguageNames;
            subj_cmbx.DataSource = SubjectNames;

            var allPaper = accessToPapers.GetAllPapers(title_txbx.Text.Trim(), filterSubject, filterLanguage);

            paperBindingSource.DataSource = null;
            paperBindingSource.DataSource = allPaper;
           
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
            Paper delPaper = new Paper();
            
            delPaper.p_id = Convert.ToInt32(papers_dgv.CurrentRow.Cells[0].EditedFormattedValue.ToString());
            if (!accessToPapers.deletePaper(delPaper))
                MessageBox.Show("Some scientist depends on this paper");
            PapersRefresh_Click(null, null);
        }
        

        private void modifyPaperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifyPaper modifyPaper =
               new ModifyPaper(Convert.ToInt32(papers_dgv.CurrentRow.Cells[0].EditedFormattedValue.ToString()), SubjectNames, LanguageNames);

            if (modifyPaper.ShowDialog() == DialogResult.OK)
            {
                accessToPapers.modifyPaper(modifyPaper.modifyPaper);

                PapersRefresh_Click(null, null);
            }
        }
       

     
        private void authorCall_btn_Click(object sender, EventArgs e)
        {
            Authors author = new Authors(accessToPapers, Convert.ToInt32(papers_dgv.CurrentRow.Cells[0].EditedFormattedValue.ToString()), ScientistNames);
            author.ShowDialog();
        }

        private void title_txbx_TextChanged(object sender, EventArgs e)
        {
            PapersRefresh_Click(null, null);
        }

        private void subj_cmbx_TextChanged(object sender, EventArgs e)
        {
            filterSubject = subj_cmbx.Text.Trim();
            PapersRefresh_Click(null, null);
        }

        private void lang_cmbx_TextChanged(object sender, EventArgs e)
        {
            filterLanguage = lang_cmbx.Text.Trim();
            PapersRefresh_Click(null, null);
        }

        
       


    }
}
