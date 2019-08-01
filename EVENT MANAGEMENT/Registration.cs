using EVENT_MANAGEMENT.Manager;
using EVENT_MANAGEMENT.Model;
using EVENT_MANAGEMENT.Printing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EVENT_MANAGEMENT
{
    public partial class FormRegistration : Form
    {
        RegisterManager RegisterManager = null;
        public FormRegistration()
        {
            RegisterManager = new RegisterManager();
            InitializeComponent();
        }
   
        private void LoadRegistration()
        {
            string FilterString = TxtRegistrationSearch.Text.Trim();
            listBoxRgistrationlistbox.Items.Clear();
            IList<Register> Register = RegisterManager.ListRegistration();
            foreach (var lRegister in Register)
            {
                if (FilterString == null || string.IsNullOrEmpty(FilterString.Trim()) || lRegister.StudentName.IndexOf(FilterString, StringComparison.OrdinalIgnoreCase) > -1 || lRegister.PhoneNo.IndexOf(FilterString, StringComparison.OrdinalIgnoreCase) > -1)
                {
                    listBoxRgistrationlistbox.Items.Add(lRegister);
                }
            }

            if (listBoxRgistrationlistbox.Items.Count > 0)
            {
                listBoxRgistrationlistbox.SelectedIndex = 0;
            }
                       
        }
        private void loadCombo()
        {
            LoadQualificationCombo();
            LoadCategoryCombo();
            LoadEventCombo();
            LoadSchoolCombo();
        }
        private void EnableForm(bool enable)
        {
            if (listBoxRgistrationlistbox.Items.Count > 0)
            {
                TxtRegistrationSearch.ReadOnly = enable;
                TxtRegistrationSearch.TabStop = !enable;
                listBoxRgistrationlistbox.Enabled = !enable;
            }
            else
            {
                listBoxRgistrationlistbox.Enabled = false;
                TxtRegistrationSearch.ReadOnly = true;
                TxtRegistrationSearch.TabStop = false;
                BtnRegistartionNew.Select();
            }
            TxtRegistartionName.ReadOnly = !enable;
            TxtRegistartionFathersName.ReadOnly = !enable;
            TxtRegistartionPhoneNo.ReadOnly = !enable;
            TxtRegistrationFee.ReadOnly = !enable;

            TxtRegistartionName.TabStop = enable;
            TxtRegistartionFathersName.TabStop = enable;
            TxtRegistartionPhoneNo.TabStop = enable;
            TxtRegistrationFee.TabStop = enable;

            comboBoxRegistartionQualification.Enabled = enable;
            comboBoxRegistartionCategory.Enabled = false;
            comboBoxRegistartionEvent.Enabled = false;
            comboBoxRegistartionSchoolName.Enabled = enable;
            dateTimePickerRegistartionDate.Enabled = enable;

            if (enable)
            {
                
                BtnRegistrationPrint.Enabled = !enable;
                BtnRegistartionDelete.Enabled = !enable;
                BtnRegistartionEdit.Enabled = !enable;
                BtnRegistartionNew.Enabled = !enable;
                BtnRegistartionSave.Enabled = enable;
                BtnRegistartionCancel.Enabled = enable;
            }
            else
            {
                if (listBoxRgistrationlistbox.SelectedIndex < 0)
                {
                    BtnRegistrationPrint.Enabled =enable;
                    BtnRegistartionDelete.Enabled = enable;
                    BtnRegistartionEdit.Enabled = enable;
                }
                else
                {
                    BtnRegistrationPrint.Enabled = !enable;
                    BtnRegistartionDelete.Enabled = !enable;
                    BtnRegistartionEdit.Enabled = !enable;
                }
                
                BtnRegistartionNew.Enabled = !enable;
                BtnRegistartionSave.Enabled = enable;
                BtnRegistartionCancel.Enabled = enable;
            }
            
        }
        private void FormRegistration_Load(object sender, EventArgs e)
        {
            ResetForm();
            EnableForm(false);
            loadCombo();
            LoadRegistration();
        }
        private void ResetForm()
        {
            ErrorMsg.Text = string.Empty;
            TextBoxRegId.Text = Convert.ToString(0);
            TxtRegistartionName.Text = "";
            TxtRegistartionFathersName.Text = "";
            TxtRegistartionEventRollNo.Text = Convert.ToString(000);
            TxtRegistartionPhoneNo.Text = "";
            comboBoxRegistartionCategory.SelectedIndex=-1;
            comboBoxRegistartionEvent.SelectedIndex = -1;
            comboBoxRegistartionQualification.SelectedIndex = -1;
            comboBoxRegistartionSchoolName.SelectedIndex = -1;
            comboBoxRegistartionCategory.ResetText();
            comboBoxRegistartionEvent.ResetText();
            comboBoxRegistartionQualification.ResetText();
            comboBoxRegistartionSchoolName.ResetText();
            TxtRollNo.Text = Convert.ToString(000);
            TxtRegistrationFee.Text = "0.00";
            dateTimePickerRegistartionDate.Value = DateTime.Now;
        }
        private void BtnRegistartionNew_Click(object sender, EventArgs e)
        {
            ResetForm();
            EnableForm(true);
            TxtRegistartionName.Select();
        }
        private void BtnRegistartionEdit_Click(object sender, EventArgs e)
        {
            EnableForm(true);
            comboBoxRegistartionCategory.Enabled = true;
            comboBoxRegistartionEvent.Enabled = true;
            TxtRegistartionName.Select();
        }
        private void BtnRegistartionDelete_Click(object sender, EventArgs e)
        {
            ErrorMsg.Text = "";
               DialogResult Result = MessageBox.Show("Do you want to delete the "+ TxtRegistartionName.Text+ " registration.", "Delete Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (Result == DialogResult.Yes)
            {
                if(RegisterManager.DeleteRegister(int.Parse(TextBoxRegId.Text)))
                {
                    ErrorMsg.Text = "Successfully removed.";
                    ResetForm();
                    loadCombo();
                    LoadRegistration();
                    TxtRegistrationSearch.Clear();
                    EnableForm(false);
                }
                else
                {
                    ErrorMsg.Text = "Some thing went wrong, Error in delete";
                }
            }
        }
        private Register GetRegisterFromForm()
        {
            Register Register = new Register();
            Register.Id = string.IsNullOrEmpty(TextBoxRegId.Text)?0:Convert.ToInt32(TextBoxRegId.Text);
            Register.StudentName = TxtRegistartionName.Text.Trim();
            Register.FathersName = TxtRegistartionFathersName.Text.Trim();
            Register.QualificationId = ((Qualification)comboBoxRegistartionQualification.Items[comboBoxRegistartionQualification.SelectedIndex]).Id;
            Register.CategoryId = ((Category)comboBoxRegistartionCategory.Items[comboBoxRegistartionCategory.SelectedIndex]).Id;
            Register.EventId = ((Event)comboBoxRegistartionEvent.Items[comboBoxRegistartionEvent.SelectedIndex]).Id;
            Register.SchoolId = ((School)comboBoxRegistartionSchoolName.Items[comboBoxRegistartionSchoolName.SelectedIndex]).Id;

            Register.EventRollNo = string.IsNullOrEmpty(TxtRegistartionEventRollNo.Text) ?0 :int.Parse(TxtRegistartionEventRollNo.Text);
            Register.PhoneNo = TxtRegistartionPhoneNo.Text.Trim();
            Register.Date = Convert.ToDateTime(dateTimePickerRegistartionDate.Text);
            Register.Fee = double.Parse(TxtRegistrationFee.Text);
            return Register;

        }

        private void BtnRegistartionSave_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                Cursor.Current = Cursors.WaitCursor;
                Register Register = GetRegisterFromForm();
                if (!RegisterManager.IsSameRegistration(Register))
                {
                    Register RegisterDB = null;
                    if (Register.Id == 0)
                    {
                        Register.EventRollNo = RegisterManager.GetEventRollNo((int)Register.CategoryId, (int)Register.EventId);
                        RegisterDB = RegisterManager.AddRegister(Register);
                    }
                    else
                    {
                        RegisterDB = RegisterManager.UpdateRegister(Register);
                    }
                    ResetForm();
                    loadCombo();
                    LoadRegistration();
                    listBoxRgistrationlistbox.SelectedIndex = listBoxRgistrationlistbox.FindStringExact(RegisterDB.StudentName);
                }
                else
                {
                    ErrorMsg.Text = "This person already register in "+comboBoxRegistartionEvent.Text+" event ";
                }               
            }            
        }
        private bool validate()
        {
            if(string.IsNullOrEmpty(TxtRegistartionName.Text.Trim()))
            {
                ErrorMsg.Text = "please enter name";
                TxtRegistartionName.Select();
                return false;
            }
            if (string.IsNullOrEmpty(TxtRegistartionFathersName.Text.Trim()))
            {
                ErrorMsg.Text = "please enter fathers name";
                TxtRegistartionFathersName.Select();
                return false;
            }
            if (string.IsNullOrEmpty(TxtRegistartionPhoneNo.Text.Trim()))
            {
                ErrorMsg.Text = "please enter phone number";
                TxtRegistartionPhoneNo.Select();
                return false;
            }
            if (comboBoxRegistartionQualification.SelectedIndex<0)
            {
                ErrorMsg.Text = "please select qualification";
                comboBoxRegistartionQualification.Select();
                return false;
            }
            if (comboBoxRegistartionCategory.SelectedIndex < 0)
            {
                ErrorMsg.Text = "please select category";
                comboBoxRegistartionCategory.Select();
                return false;
            }
            if (comboBoxRegistartionEvent.SelectedIndex < 0)
            {
                ErrorMsg.Text = "please select event";
                comboBoxRegistartionEvent.Select();
                return false;
            }
            if (comboBoxRegistartionSchoolName.SelectedIndex < 0)
            {
                ErrorMsg.Text = "please select school";
                comboBoxRegistartionSchoolName.Select();
                return false;
            }
            

            return true;
        }
        private void BtnRegistartionExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnRegistartionCancel_Click(object sender, EventArgs e)
        {
            ResetForm();
            loadCombo();
            LoadRegistration();
            EnableForm(false);
        }

        private void BtnRegistartionSchoolnameNew_Click(object sender, EventArgs e)
        {
            string Temp = comboBoxRegistartionSchoolName.Text;
            FormSchoolRegistration FormSchoolRegistration = new FormSchoolRegistration();
            FormSchoolRegistration.ShowDialog();
            LoadSchoolCombo();
            if(comboBoxRegistartionSchoolName.Items.Count>0 && comboBoxRegistartionSchoolName.FindStringExact(Temp)>-1)
            {
                comboBoxRegistartionSchoolName.FindStringExact(Temp);
            }
            else
            {
                comboBoxRegistartionSchoolName.SelectedIndex = -1;
            }
        }
        
        private void comboBoxRegistartionQualification_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxRegistartionCategory.ResetText();
            if (comboBoxRegistartionQualification.SelectedIndex > -1)
            {
                comboBoxRegistartionCategory.Enabled = true;
                LoadCategoryCombo();
            }
            else
            {
                comboBoxRegistartionCategory.SelectedIndex = -1;
                comboBoxRegistartionCategory.Enabled = false;
            }
        }
        private void LoadCategoryCombo()
        {
            //string Temp = comboBoxRegistartionCategory.Text.Trim();

            int QualificationId = (comboBoxRegistartionQualification.SelectedIndex>-1)?((Qualification)comboBoxRegistartionQualification.Items[comboBoxRegistartionQualification.SelectedIndex]).Id:0;
            CategoryManager CategoryManager =new  CategoryManager();
            comboBoxRegistartionCategory.Items.Clear();
            comboBoxRegistartionCategory.Items.AddRange(CategoryManager.ListCategory(QualificationId).ToArray<Category>());

            if (comboBoxRegistartionCategory.Items.Count > 0 )
            {
                comboBoxRegistartionCategory.SelectedIndex = 0;
            }
            //else
            //{
            //    comboBoxRegistartionCategory.SelectedIndex = comboBoxRegistartionCategory.FindStringExact(Temp);
            //}
        }
        private void LoadQualificationCombo()
        {
            //string Temp = comboBoxRegistartionQualification.Text.Trim();

            int CategoryId = (comboBoxRegistartionCategory.SelectedIndex > -1) ? ((Category)comboBoxRegistartionCategory.Items[comboBoxRegistartionCategory.SelectedIndex]).Id : 0;
            QualificationManager QualificationManager = new QualificationManager();
            comboBoxRegistartionQualification.Items.Clear();
            comboBoxRegistartionQualification.Items.AddRange(QualificationManager.ListQualification(CategoryId).ToArray<Qualification>());

            //if (string.IsNullOrEmpty(Temp) || comboBoxRegistartionQualification.Items.Count == 0 || comboBoxRegistartionQualification.FindStringExact(Temp) < 0)
            //{
                comboBoxRegistartionQualification.SelectedIndex = -1;
            //}
            //else
            //{
            //    comboBoxRegistartionQualification.SelectedIndex = comboBoxRegistartionQualification.FindStringExact(Temp);
            //}
        }
        private void LoadEventCombo()
        {
            //string Temp = comboBoxRegistartionEvent.Text.Trim();

            int CategoryId = (comboBoxRegistartionCategory.SelectedIndex > -1) ? ((Category)comboBoxRegistartionCategory.Items[comboBoxRegistartionCategory.SelectedIndex]).Id : 0;
            EventManager EventManager = new EventManager();
            comboBoxRegistartionEvent.Items.Clear();
            comboBoxRegistartionEvent.Items.AddRange(EventManager.ListEvent(CategoryId).ToArray<Event>());

            //if (string.IsNullOrEmpty(Temp)|| comboBoxRegistartionEvent.Items.Count==0 || comboBoxRegistartionEvent.FindStringExact(Temp)<0)
            //{
                comboBoxRegistartionEvent.SelectedIndex = -1;
            //}
            //else
            //{
            //    comboBoxRegistartionEvent.SelectedIndex = comboBoxRegistartionEvent.FindStringExact(Temp);
            //}

        }
        private void LoadSchoolCombo()
        {
            SchoolManager SchoolManager = new SchoolManager();
            comboBoxRegistartionSchoolName.Items.Clear();
            comboBoxRegistartionSchoolName.Items.AddRange(SchoolManager.ListSchool().ToArray<School>());
        }
        private void listBoxRgistrationlistbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetForm();
            if(listBoxRgistrationlistbox.SelectedIndex>-1)
            {
                Register RegisterFF = ((Register)listBoxRgistrationlistbox.Items[listBoxRgistrationlistbox.SelectedIndex]);
                if (RegisterFF != null)
                {
                    Register Register = RegisterManager.GetRegisterById(RegisterFF.Id);
                    if (Register != null)
                    {
                        TextBoxRegId.Text = Register.Id.ToString();
                        TxtRegistartionName.Text = Register.StudentName;
                        TxtRegistartionFathersName.Text = Register.FathersName;
                        TxtRegistartionEventRollNo.Text = Register.EventRollNo.ToString();
                        TxtRegistartionPhoneNo.Text = Register.PhoneNo;
                        TxtRegistrationFee.Text = Register.Fee.ToString();
                        dateTimePickerRegistartionDate.Value = Register.Date;
                        comboBoxRegistartionQualification.SelectedIndex = comboBoxRegistartionQualification.FindStringExact(Register.Qualification.Name);
                        comboBoxRegistartionCategory.SelectedIndex = comboBoxRegistartionCategory.FindStringExact(Register.Category.CategoryName);
                        comboBoxRegistartionEvent.SelectedIndex = comboBoxRegistartionEvent.FindStringExact(Register.Event.EventName);
                        comboBoxRegistartionSchoolName.SelectedIndex = comboBoxRegistartionSchoolName.FindStringExact(Register.School.Name);

                        TxtRollNo.Text = Register.Id.ToString();
                    }
                }
            }
            EnableForm(false);
        }

        private void comboBoxRegistartionCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxRegistartionEvent.ResetText();
            if (comboBoxRegistartionCategory.SelectedIndex>-1)
            {
                comboBoxRegistartionEvent.Enabled = true;
                LoadEventCombo();
                comboBoxRegistartionEvent.SelectedIndex = -1;
            }
            else
            {
                comboBoxRegistartionEvent.SelectedIndex = -1;
                comboBoxRegistartionEvent.Enabled = false;
            }
        }

        private void TxtRegistartionPhoneNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && e.KeyChar != Convert.ToChar(Keys.Enter) && e.KeyChar != Convert.ToChar(Keys.Escape) && !char.IsControl(e.KeyChar))
            {

                if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                {
                    e.Handled = true;
                }
            }
        }

        private void TxtRegistrationFee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && e.KeyChar != Convert.ToChar(Keys.Enter) && e.KeyChar != Convert.ToChar(Keys.Escape) && !char.IsControl(e.KeyChar))
            {

                if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == '.')))
                {
                    e.Handled = true;
                }
                else if (e.KeyChar == '.' && TxtRegistrationFee.Text.IndexOf('.') > -1)
                {
                    e.Handled = true;
                }
            }
        }

        private void BtnRegistartionSave_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                e.IsInputKey = true;
                TxtRegistartionName.Select();
            }
            if (e.Modifiers == Keys.Shift && e.KeyCode == Keys.Tab)
            {
                e.IsInputKey = true;
                comboBoxRegistartionSchoolName.Select();
            }
        }

        private void TxtRegistartionName_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                e.IsInputKey = true;
                TxtRegistartionFathersName.Select();
            }
            if (e.Modifiers == Keys.Shift && e.KeyCode == Keys.Tab)
            {
                e.IsInputKey = true;
                BtnRegistartionSave.Select();
            }
        }

        private void BtnRegistrationPrint_Click(object sender, EventArgs e)
        {
            RegistrationPrinting RegistrationPrinting = new RegistrationPrinting();
            RegistrationPrinting.GenerateRegistrationPrinting(int.Parse(TextBoxRegId.Text),PicBox.Image);
        }

        private void TxtRegistrationSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                listBoxRgistrationlistbox.Select();
            }
            
        }
        private void TxtRegistrationSearch_TextChanged(object sender, EventArgs e)
        {         
            ResetForm();
            loadCombo();
            LoadRegistration();
            if (listBoxRgistrationlistbox.Items.Count > 0) { BtnRegistartionEdit.Enabled = true; BtnRegistartionDelete.Enabled = true; }
            else { BtnRegistartionEdit.Enabled = false; BtnRegistartionDelete.Enabled = false; }
        }
        
    }
}

