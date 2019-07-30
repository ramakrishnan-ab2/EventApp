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
        public FormRegistration()
        {
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

        private void FormRegistration_Load(object sender, EventArgs e)
        {
            BtnRegistartionDelete.Enabled = false;
            BtnRegistartionEdit.Enabled = false;
        }

        private void BtnRegistartionNew_Click(object sender, EventArgs e)
        {
            //listBoxRgistrationlistbox.SelectedIndex = 0;
            BtnRegistartionDelete.Enabled = false;
            BtnRegistartionEdit.Enabled = false;
            BtnRegistartionNew.Enabled = false;
            TxtRegistartionName.Focus();

        }

        private void BtnRegistartionEdit_Click(object sender, EventArgs e)
        {
            
        }
       
            private void BtnRegistartionSave_Click(object sender, EventArgs e)
            {
             Cursor.Current = Cursors.WaitCursor;
           
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
    }
}

