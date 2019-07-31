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
            //if ()
            //{
            //    DialogResult Result = MessageBox.Show("There are unsaved changes, Do you want cancel?", "Confirm",
            //        MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            //    if (Result == DialogResult.No)
            //    {
            //        TxtSchoolRegistrationSchoolName.Select();
            //        return;
            //    }
            //}
            ResetForm();
            LoadSchoolInfo();
            //EnableForm(false);
            //this.formIsDirty = false;
            BtnSchoolRegistrationDelete.Enabled = true;
            BtnSchoolRegistrationEdit.Enabled = true;
            BtnSchoolRegistrationNew.Enabled = true;
            BtnSchoolRegistrationExit.Enabled = true;
            BtnSchoolRegistrationSave.Enabled = false;
            BtnSchoolRegistrationCancel.Enabled = false;
            TxtSchoolRegistrationAddress.ResetText();
            TxtSchoolRegistrationSchoolName.ResetText();
            listBoxSchoolRegistration.Enabled = true;
        }

        private void FormSchoolRegistration_Load(object sender, EventArgs e)
        {
            BtnSchoolRegistrationDelete.Enabled = true;
            BtnSchoolRegistrationEdit.Enabled = true;
            BtnSchoolRegistrationNew.Enabled = true;
            BtnSchoolRegistrationExit.Enabled = true;
            BtnSchoolRegistrationSave.Enabled = false;
            BtnSchoolRegistrationCancel.Enabled = false;
            LoadSchoolsWithFilter();
            ResetForm();
            //EnableForm(false);

        }

        private void BtnSchoolRegistrationExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSchoolRegistrationNew_Click(object sender, EventArgs e)
        {
            BtnSchoolRegistrationDelete.Enabled = false;
            BtnSchoolRegistrationEdit.Enabled = false;
            BtnSchoolRegistrationNew.Enabled = false;
            BtnSchoolRegistrationExit.Enabled = true;
            BtnSchoolRegistrationSave.Enabled = true;
            BtnSchoolRegistrationCancel.Enabled = true;
            TxtSchoolRegistrationSchoolName.Focus();
            TxtSchoolRegId.Text = string.Empty;

            //clears();

            ResetForm();
            listBoxSchoolRegistration.Enabled = false;
            // listBox1.Text = "";
            TxtSchoolRegistrationSchoolName.Text = "";
            TxtSchoolRegistrationAddress.Text = "";
            TxtSchoolRegistrationSchoolName.ReadOnly = false;
            TxtSchoolRegistrationAddress.ReadOnly = false;
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
            //string FilterString = TxtSchoolSearch.Text.Trim();
            listBoxSchoolRegistration.Items.Clear();
            IList<School> Schools = SchoolManager.GetAllSchools();
            foreach (var lSchool in Schools)
            {
                //if(FilterString == null || string.IsNullOrEmpty(FilterString.Trim()) || lSchool.Name.IndexOf(FilterString, StringComparison.OrdinalIgnoreCase) > -1)
                //{
                    listBoxSchoolRegistration.Items.Add(lSchool);
                //}
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
                    //Cursor.Current = Cursors.WaitCursor;
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
                            //EnableForm(false);
                            MessageBox.Show("saved");
                        }
                        else
                        {
                            MessageBox.Show(lSchool.Name + " already exists");
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
                               // EnableForm(false);
                                //this.formIsDirty = false;

                            }
                            else
                            {
                                MessageBox.Show(lSchool.Name + " already exists");
                                TxtSchoolRegistrationSchoolName.Select();
                            }
                        }
                        else
                        {
                            DisplaySystemError("Somting went wrong, please check this currency is still valid.");
                            return;
                        }
                    }
                //statusStripBtnSchoolRegistration.Text = string.Empty;

                TxtSchoolRegistrationAddress.Text = TxtSchoolRegistrationSchoolName.Text = "";

                listBoxSchoolRegistration.Refresh();
                //display();
                clears();
                BtnSchoolRegistrationNew.Enabled = true;
                BtnSchoolRegistrationDelete.Enabled = true;
                BtnSchoolRegistrationEdit.Enabled = true;
                BtnSchoolRegistrationCancel.Enabled = false;
                BtnSchoolRegistrationSave.Enabled = false;
                BtnSchoolRegistrationExit.Enabled = true;
                listBoxSchoolRegistration.Enabled = true;
                TxtSchoolRegistrationAddress.ReadOnly = true;
                TxtSchoolRegistrationSchoolName.ReadOnly = true;

                //listBoxSchoolRegistration.SelectedIndex = listBoxSchoolRegistration.FindStringExact(a.Name);
                //listBoxSchoolRegistration.SelectedIndex.ToString();
            }
           
        }
        //private void EnableForm(Boolean enable)
        //{
        //    if (listBoxSchoolRegistration.Items.Count > 0)
        //    {
                
        //        listBoxSchoolRegistration.Enabled = !enable;
        //    }
        //    else
        //    {
        //        listBoxSchoolRegistration.Enabled = false;
                
        //        BtnSchoolRegistrationNew.Select();
        //    }           
        //    TxtSchoolRegistrationSchoolName.ReadOnly = !enable;
        //    TxtSchoolRegistrationAddress.ReadOnly = !enable;           
        //    TxtSchoolRegistrationSchoolName.TabStop = enable;
        //    TxtSchoolRegistrationAddress.TabStop = enable;
           
        //    if (!enable)
        //    {
                
        //        if (listBoxSchoolRegistration.SelectedIndex < 0)
        //        {
        //            BtnSchoolRegistrationDelete.Enabled = enable;
        //            BtnSchoolRegistrationEdit.Enabled = enable;
        //        }
        //        else
        //        {
        //            BtnSchoolRegistrationDelete.Enabled = !enable;
        //            BtnSchoolRegistrationEdit.Enabled = !enable;
        //        }
        //        BtnSchoolRegistrationNew.Enabled = !enable;
        //        BtnSchoolRegistrationSave.Enabled = enable;
        //    }
        //    else
        //    {
        //        BtnSchoolRegistrationNew.Enabled = !enable;
        //        BtnSchoolRegistrationDelete.Enabled = !enable;
        //        BtnSchoolRegistrationEdit.Enabled = !enable;
        //        BtnSchoolRegistrationSave.Enabled = enable;
              
        //    }
        //}
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
        private void ResetForm()
        {
            
            TxtSchoolRegId.ResetText();
            TxtSchoolRegistrationSchoolName.ResetText();
            TxtSchoolRegistrationAddress.ResetText();
        }
       
        public void display()
        {
            listBoxSchoolRegistration.Items.Clear();
            TxtSchoolRegId.Visible = false;
            AccountContext db = new AccountContext();
            School s = new School();
            //listBoxSchoolRegistration.Items.AddRange(a);
           // TxtSchoolRegistrationSchoolName.Text =Name;
           // TxtSchoolRegistrationAddress.Text =Address;
           

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
            else
            {
               // DisplaySystemError("Somthing went wrong, the selected currency is not valid.");
                return;
            }
        }
        private void DisplaySystemError(string Message)
        {
            MessageBox.Show(Message);
            //this.formIsDirty = false;
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
                //listBoxSchoolRegistration.ValueMember =Convert.ToString( lSchool.Id);
                //listBoxSchoolRegistration.DisplayMember= lSchool.Name;
            }
            return null;
        }

        private void BtnSchoolRegistrationEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtSchoolRegId.Text))
            {
                MessageBox.Show("saved");
                return;
            }
            LoadSchoolInfo();
            //EnableForm(true);
            TxtSchoolRegistrationSchoolName.Select();
            BtnSchoolRegistrationNew.Enabled = false;
            BtnSchoolRegistrationDelete.Enabled = false;
            BtnSchoolRegistrationEdit.Enabled = false;
            BtnSchoolRegistrationCancel.Enabled = true;
            BtnSchoolRegistrationSave.Enabled = true;
            BtnSchoolRegistrationExit.Enabled = true;
            TxtSchoolRegistrationSchoolName.ReadOnly = false;
            TxtSchoolRegistrationAddress.ReadOnly = false;
            TxtSchoolRegistrationSchoolName.Select();

        }
        void clears()
        {
            School a = new School();
            statusStripBtnSchoolRegistration.Text = string.Empty;
           
            TxtSchoolRegistrationSchoolName.Text = TxtSchoolRegistrationAddress.Text = "";
            TxtSchoolRegId.Text = string.Empty;
            //cancel.Enabled = true;
            //save.Enabled = true;
            BtnSchoolRegistrationExit.Enabled = true;
            listBoxSchoolRegistration.SelectedIndex = listBoxSchoolRegistration.FindStringExact(a.Name);
            //listBoxSchoolRegistration.SelectedIndex = 0;
            listBoxSchoolRegistration.Refresh();
        }
        private void BtnSchoolRegistrationDelete_Click(object sender, EventArgs e)
        {
           if (string.IsNullOrEmpty(TxtSchoolRegId.Text))
            {
                MessageBox.Show("Somting went wrong, please check this currency is still valid.");
                return;
            }
            School lSchool = GetSchoolInfo();
            if (lSchool != null)
            {
                DialogResult Result = MessageBox.Show("Do you want to delete the currency " + lSchool.Name + "?", "Delete Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (Result == DialogResult.Yes)
                {
                    Boolean Deleted = SchoolManager.DeleteSchool(lSchool.Id);
                    if (Deleted)
                    {
                        ResetForm();
                        LoadSchoolsWithFilter();
                        //TextBoxCurrencySearch.Clear();
                        //EnableForm(false);
                        //this.formIsDirty = false;

                    }
                    else
                    {
                        MessageBox.Show("Could not delete Currency," + lSchool.Name + "!, Please retry. \r\n [This currency data might have been used in other entries like Company, Please verify.]", "Error Deleting Currency", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Somting went wrong, please check this currency is still valid.");
                return;
            }
            BtnSchoolRegistrationNew.Enabled = true;
            BtnSchoolRegistrationDelete.Enabled = true;
            BtnSchoolRegistrationEdit.Enabled = true;
            BtnSchoolRegistrationCancel.Enabled = false;
            BtnSchoolRegistrationSave.Enabled = false;
            BtnSchoolRegistrationExit.Enabled = true;
        }
        private void groupBoxSchoolRegistrationSchoolDetails_Enter(object sender, EventArgs e)
        {

        }

        private void listBoxSchoolRegistration_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetForm();
            LoadSchoolInfo();
            //EnableForm(false);
        }
    }
}
