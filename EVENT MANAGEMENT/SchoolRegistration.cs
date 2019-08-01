using EVENT_MANAGEMENT.Context;
using EVENT_MANAGEMENT.Manager;
using EVENT_MANAGEMENT.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EVENT_MANAGEMENT
{
    public partial class FormSchoolRegistration : Form
    {
        SchoolManager SchoolManager = null;
        public FormSchoolRegistration()
        {
            SchoolManager = new SchoolManager();
            InitializeComponent();
        }

        private void BtnSchoolRegistrationCancel_Click(object sender, EventArgs e)
        {           
            ResetForm();
            LoadSchoolsWithFilter();
        }

        private void FormSchoolRegistration_Load(object sender, EventArgs e)
        {
            ResetForm();
            EnableForm(true);           
            LoadSchoolsWithFilter();
        }
        private void EnableForm(bool enable)
        {
            TxtSchoolRegistrationSchoolName.ReadOnly = !enable;
            TxtSchoolRegistrationAddress.ReadOnly = !enable;
            TxtSchoolRegistrationSchoolName.TabStop = enable;
            TxtSchoolRegistrationAddress.TabStop = enable;
            if (enable)
            {
                BtnSchoolRegistrationDelete.Enabled = !enable;
                BtnSchoolRegistrationEdit.Enabled = !enable;
                BtnSchoolRegistrationNew.Enabled = !enable;
                BtnSchoolRegistrationSave.Enabled = enable;
                BtnSchoolRegistrationCancel.Enabled = enable;                
            }
            else
            {
                BtnSchoolRegistrationDelete.Enabled = !enable;
                BtnSchoolRegistrationEdit.Enabled = !enable;
                BtnSchoolRegistrationNew.Enabled = !enable;
                BtnSchoolRegistrationSave.Enabled = enable;
                BtnSchoolRegistrationCancel.Enabled = enable;
            }
        }
        private void ResetForm()
        {
            TxtSchoolRegId.ResetText();
            TxtSchoolRegistrationSchoolName.ResetText();
            TxtSchoolRegistrationAddress.ResetText();
        }
        private void BtnSchoolRegistrationExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSchoolRegistrationNew_Click(object sender, EventArgs e)
        {
            ResetForm();
            EnableForm(true);
            TxtSchoolRegistrationSchoolName.Select();
        }
        private School GetSchoolFromForm()
        {
            School lSchool = new School();
            if (!string.IsNullOrEmpty(TxtSchoolRegId.Text))
            {
                lSchool.Id = Convert.ToInt32(TxtSchoolRegId.Text);
            }
            else
            {
                lSchool.Id = 0;
            }
            
            lSchool.Name = TxtSchoolRegistrationSchoolName.Text.Trim();
            lSchool.Address= TxtSchoolRegistrationAddress.Text.Trim();
            return lSchool;
                        
        }
        private void LoadSchoolsWithFilter()
        {
            listBoxSchoolRegistration.Items.Clear();
            IList<School> Schools = SchoolManager.GetAllSchools();
            foreach (var lSchool in Schools)
            {                
                listBoxSchoolRegistration.Items.Add(lSchool);
            }
            if (listBoxSchoolRegistration.Items.Count > 0)
            {
                listBoxSchoolRegistration.SelectedIndex = 0;
            }
        }
        private void BtnSchoolRegistrationSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                    School lSchool = GetSchoolFromForm();
                    if (lSchool.Id == 0)
                    {
                        School lSchoolByName = SchoolManager.GetSchoolByName(lSchool.Name);
                        if (lSchoolByName == null)
                        {
                            SchoolManager.AddSchoolInfo(lSchool);
                            ResetForm();
                            LoadSchoolsWithFilter();
                            listBoxSchoolRegistration.SelectedIndex = listBoxSchoolRegistration.FindStringExact(lSchool.Address);
                        }
                        else
                        {
                            ErrorMsg.Text = lSchool.Name + " already exists";
                            TxtSchoolRegistrationSchoolName.Select();
                        }
                    }
                    else
                    {
                        School lSchoolById = SchoolManager.GetSchoolById(lSchool.Id);
                        if (lSchoolById != null)
                        {
                            School lCurrencyByName = SchoolManager.CheckSchoolNameInUpdate(lSchool.Name, lSchool.Id);
                            if (lCurrencyByName == null)
                            {
                                School SchoolInfo = SchoolManager.UpdateSchool(lSchool);
                                ResetForm();
                                LoadSchoolsWithFilter();
                                listBoxSchoolRegistration.SelectedIndex = listBoxSchoolRegistration.FindStringExact(lSchool.Name);
                            }
                            else
                            {
                                ErrorMsg.Text=lSchool.Name + " already exists";
                                TxtSchoolRegistrationSchoolName.Select();
                            }
                        }
                        else
                        {
                            DisplaySystemError("Somting went wrong, please check this currency is still valid.");
                            return;
                        }
                    }               
            }
           
        }       
        private Boolean ValidateForm()
        {
            if (string.IsNullOrEmpty(TxtSchoolRegistrationSchoolName.Text.Trim()))
            {
                MessageBox.Show("Currency Name could not be empty, Please enter Currency Name");
                TxtSchoolRegistrationSchoolName.Select();
                return false;
            }
            return true;
        }
       
        private void LoadSchoolInfo()
        {
            School SchoolFromDB = GetSchoolInfo();
            if (SchoolFromDB != null)
            {
                TxtSchoolRegId.Text = Convert.ToString(SchoolFromDB.Id);
                TxtSchoolRegistrationSchoolName.Text = SchoolFromDB.Name;
                TxtSchoolRegistrationAddress.Text = SchoolFromDB.Address;             
            }
            
        }
        private void DisplaySystemError(string Message)
        {
            MessageBox.Show(Message);
            LoadSchoolsWithFilter();
            return;
        }
        private School GetSchoolInfo()
        {
            int Index = listBoxSchoolRegistration.SelectedIndex;
            if (Index > -1)
            {
                School lSchool = (School)listBoxSchoolRegistration.Items[Index];
                if (lSchool != null)
                {
                    School SchoolFromDB = SchoolManager.GetSchoolById(lSchool.Id);
                    return SchoolFromDB;
                }
            }
            return null;
        }

        private void BtnSchoolRegistrationEdit_Click(object sender, EventArgs e)
        {
            EnableForm(true);
            TxtSchoolRegistrationSchoolName.Select();          
        }
        void clears()
        {
            School a = new School();
            statusStripBtnSchoolRegistration.Text = string.Empty;         
            TxtSchoolRegistrationSchoolName.Text = TxtSchoolRegistrationAddress.Text = "";
            TxtSchoolRegId.Text = string.Empty;
            BtnSchoolRegistrationExit.Enabled = true;
            listBoxSchoolRegistration.SelectedIndex = listBoxSchoolRegistration.FindStringExact(a.Name);
            listBoxSchoolRegistration.Refresh();
        }
        private void BtnSchoolRegistrationDelete_Click(object sender, EventArgs e)
        {
           if (string.IsNullOrEmpty(TxtSchoolRegId.Text))
            {
                MessageBox.Show("Somting went wrong, please check this school is still valid.");
                return;
            }
            School lSchool = GetSchoolInfo();
            if (lSchool != null)
            {
                DialogResult Result = MessageBox.Show("Do you want to delete the school " + lSchool.Name + "?", "Delete Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (Result == DialogResult.Yes)
                {
                    Boolean Deleted = SchoolManager.DeleteSchool(lSchool.Id);
                    if (Deleted)
                    {
                        ResetForm();
                        LoadSchoolsWithFilter();
                    }
                    else
                    {
                        ErrorMsg.Text="Could not delete school," + lSchool.Name + "!, Please retry. ";
                    }
                }
            }
            else
            {
                DisplaySystemError("Somting went wrong, please check this currency is still valid.");
                return;
            }
            
        }
        private void groupBoxSchoolRegistrationSchoolDetails_Enter(object sender, EventArgs e)
        {

        }

        private void listBoxSchoolRegistration_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetForm();
            LoadSchoolInfo();
            EnableForm(false);
        }
    }
}
