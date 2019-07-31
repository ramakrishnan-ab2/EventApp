using EVENT_MANAGEMENT.Manager;
using EVENT_MANAGEMENT.Model;
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void LoadRegistration()
        {
            listBoxRgistrationlistbox.Items.Clear();
            IList<Register> Register = RegisterManager.ListRegistration();
            if(Register!=null && Register.Count>0)
            {
                listBoxRgistrationlistbox.Items.AddRange(Register.ToArray<Register>());
                listBoxRgistrationlistbox.SelectedIndex = 0;
            }            
        }
        private void loadCombo()
        {

        }
        private void EnableForm(bool enable)
        {
            if(enable)
            {
                BtnRegistartionDelete.Enabled = !enable;
                BtnRegistartionEdit.Enabled = !enable;
                BtnRegistartionNew.Enabled = !enable;
                BtnRegistartionSave.Enabled = enable;
                BtnRegistartionCancel.Enabled = enable;
            }
            else
            {
                BtnRegistartionDelete.Enabled = enable;
                BtnRegistartionEdit.Enabled = enable;
                BtnRegistartionNew.Enabled = enable;
                BtnRegistartionSave.Enabled = !enable;
                BtnRegistartionCancel.Enabled = !enable;
            }
            
        }
        private void FormRegistration_Load(object sender, EventArgs e)
        {
            ResetForm();
            EnableForm(true);
            LoadRegistration();
        }
        private void ResetForm()
        {
            TextBoxRegId.Text = Convert.ToString(0);
            TxtRegistartionName.Text = "";
            TxtRegistartionFathersName.Text = "";
            TxtRegistartionEventRollNo.Text = Convert.ToString(000000);
            TxtRegistartionPhoneNo.Text = "";
            comboBoxRegistartionCategory.SelectedIndex=-1;
            comboBoxRegistartionEvent.SelectedIndex = -1;
            comboBoxRegistartionQualification.SelectedIndex = -1;
            comboBoxRegistartionSchoolName.SelectedIndex = -1;
            comboBoxRegistartionCategory.ResetText();
            comboBoxRegistartionEvent.ResetText();
            comboBoxRegistartionQualification.ResetText();
            comboBoxRegistartionSchoolName.ResetText();
            LblRegistartionRollN.Text = Convert.ToString(000000);          
        }
        private void BtnRegistartionNew_Click(object sender, EventArgs e)
        {
            ResetForm();
            EnableForm(true);
            TxtRegistartionName.Select();
        }
        private void BtnRegistartionEdit_Click(object sender, EventArgs e)
        {
            
        }
        private Register GetRegisterFromForm()
        {
            Register Register = new Register();

            Register.Id = string.IsNullOrEmpty(TextBoxRegId.Text)?0:Convert.ToInt32(TextBoxRegId.Text);
            Register.StudentName = TxtRegistartionName.Text.Trim();
            Register.FathersName = TxtRegistartionFathersName.Text.Trim();
            // R.Qualification = comboBoxRegistartionQualification.Text.ToString(
            //R.Event=
            Register.EventRollNo = Convert.ToInt32(TxtRegistartionEventRollNo.Text.Trim());
            // R.School=
            Register.PhoneNo = TxtRegistartionPhoneNo.Text.Trim();
            Register.Date = Convert.ToDateTime(dateTimePickerRegistartionDate.Text);
                 
            return Register;

        }

            private void BtnRegistartionSave_Click(object sender, EventArgs e)
            {
             Cursor.Current = Cursors.WaitCursor;
             Register R = new Register();
           
            if (R.Id == 0)
            {
                R.Id = Convert.ToInt32(TextBoxRegId.Text);
                R.StudentName = TxtRegistartionName.Text.Trim();
                R.FathersName = TxtRegistartionFathersName.Text.Trim();
                // R.Qualification = comboBoxRegistartionQualification.Text.ToString(
                //R.Event=
                R.EventRollNo = Convert.ToInt32(TxtRegistartionEventRollNo.Text.Trim());
                // R.School=
                R.PhoneNo = TxtRegistartionPhoneNo.Text.Trim();
                R.Date = Convert.ToDateTime(dateTimePickerRegistartionDate.Text);

            }
            try
            {
                if (R.Id==0)
                {
                    RegisterManager RegisterManager = new RegisterManager();
                    Register Reg = RegisterManager.AddRegister(R);
                    MessageBox.Show("Saved");
                }
                else
                {
                    RegisterManager RegisterManager = new RegisterManager();
                    Register Reg = RegisterManager.UpdateRegister(R);
                    MessageBox.Show("Edited");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }
           
            }
     
            private void BtnRegistartionExit_Click(object sender, EventArgs e)
            {
                this.Close();
            }

            private void BtnRegistartionCancel_Click(object sender, EventArgs e)
            {
                BtnRegistartionNew.Enabled = true;
                TxtRegistartionEventRollNo.Text = "";
                TxtRegistartionName.Text = "";
                TxtRegistartionFathersName.Text = "";
                TxtRegistartionPhoneNo.Text = "";
                LblRegistartionRollN.Text = "0000";
                comboBoxRegistartionCategory.ResetText();
                comboBoxRegistartionEvent.ResetText();
                comboBoxRegistartionQualification.ResetText();
                comboBoxRegistartionSchoolName.ResetText();
                dateTimePickerRegistartionDate.ResetText();


            }

            private void BtnRegistartionSchoolnameNew_Click(object sender, EventArgs e)
            {
                FormSchoolRegistration S = new FormSchoolRegistration();
                S.Show();
            }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxRegistartionQualification_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxRgistrationlistbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

