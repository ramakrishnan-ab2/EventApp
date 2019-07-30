using EVENT_MANAGEMENT.Context;
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
        public FormSchoolRegistration()
        {
            InitializeComponent();
        }

        private void BtnSchoolRegistrationCancel_Click(object sender, EventArgs e)
        {
            TxtSchoolRegistrationAddress.ResetText();
            TxtSchoolRegistrationSchoolName.ResetText();
        }

        private void FormSchoolRegistration_Load(object sender, EventArgs e)
        {
            BtnSchoolRegistrationDelete.Enabled = false;
            BtnSchoolRegistrationEdit.Enabled = false;
        }

        private void BtnSchoolRegistrationExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSchoolRegistrationNew_Click(object sender, EventArgs e)
        {
            BtnSchoolRegistrationDelete.Enabled = false;
            BtnSchoolRegistrationEdit.Enabled = false;
            TxtSchoolRegistrationSchoolName.Focus();
            TxtSchoolRegId.Text = string.Empty;

            clears();
            BtnSchoolRegistrationNew.Enabled = false;
            BtnSchoolRegistrationDelete.Enabled = false;
            BtnSchoolRegistrationEdit.Enabled = false;
            BtnSchoolRegistrationSave.Enabled = true;
            BtnSchoolRegistrationCancel.Enabled = true;
            listBoxSchoolRegistration.Enabled = false;
            // listBox1.Text = "";
            TxtSchoolRegistrationSchoolName.Text = "";
            TxtSchoolRegistrationAddress.Text = "";
            TxtSchoolRegistrationSchoolName.ReadOnly = false;
            TxtSchoolRegistrationAddress.ReadOnly = false;
        }

        private void BtnSchoolRegistrationSave_Click(object sender, EventArgs e)
        {
            School a = new School();
            try
            {
                a.Name= TxtSchoolRegistrationSchoolName.Text.Trim();
                a.Address= TxtSchoolRegistrationAddress.Text.Trim();
              
                a.Id= string.IsNullOrEmpty(TxtSchoolRegId.Text) ? 0 : int.Parse(TxtSchoolRegId.Text);

                using (AccountContext db = new AccountContext())
                {
                    School Info = null;

                    if (a.Id== 0)
                    {
                        Info = db.Schools.Add(a);
                        db.SaveChanges();
                        MessageBox.Show("Saved");
                        statusStripBtnSchoolRegistration.Text = "Saved";
                    }
                    if (string.IsNullOrEmpty(TxtSchoolRegistrationSchoolName.Text))
                    {
                        statusStripBtnSchoolRegistration.Text ="Please Enter School Name";
                        TxtSchoolRegistrationSchoolName.Focus();
                        //textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = "";
                    }
                    else
                    {
                        db.Entry(a).State = EntityState.Modified;
                        db.SaveChanges();
                    }
                    // err.Text="Saved";
                    statusStripBtnSchoolRegistration.Text = "Saved";
                }
               
            }
            catch
            {

            }

            statusStripBtnSchoolRegistration.Text = string.Empty;

            TxtSchoolRegistrationAddress.Text = TxtSchoolRegistrationSchoolName.Text = "";
           
            listBoxSchoolRegistration.Refresh();
            display();
            //clears();
            BtnSchoolRegistrationNew.Enabled = true;
            BtnSchoolRegistrationDelete.Enabled = true;
            BtnSchoolRegistrationEdit.Enabled = true;
            BtnSchoolRegistrationCancel.Enabled = false;
            BtnSchoolRegistrationSave.Enabled = false;
            BtnSchoolRegistrationExit.Enabled = true;
            listBoxSchoolRegistration.Enabled = true;
            TxtSchoolRegistrationAddress.ReadOnly = true;
            TxtSchoolRegistrationSchoolName.ReadOnly = true;
          
            listBoxSchoolRegistration.SelectedIndex =listBoxSchoolRegistration.FindStringExact(a.Name);
            listBoxSchoolRegistration.SelectedIndex.ToString();
           
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

        private void BtnSchoolRegistrationEdit_Click(object sender, EventArgs e)
        {
            School a = new School();
            try
            {
                a.Name = TxtSchoolRegistrationSchoolName.Text.Trim();
                a.Address = TxtSchoolRegistrationAddress.Text.Trim();

                a.Id = string.IsNullOrEmpty(TxtSchoolRegId.Text) ? 0 : int.Parse(TxtSchoolRegId.Text);

                using (AccountContext db = new AccountContext())
                {
                    School Info = null;

                    if (a.Id == 0)
                    {
                        Info = db.Schools.Add(a);
                        db.SaveChanges();
                    }
                    if (string.IsNullOrEmpty(TxtSchoolRegistrationSchoolName.Text))
                    {
                        statusStripBtnSchoolRegistration.Text = "Please Enter School Name";
                        TxtSchoolRegistrationSchoolName.Focus();
                        //textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = "";
                    }
                    else
                    {
                        db.Entry(a).State = EntityState.Modified;
                        db.SaveChanges();
                    }
                    // err.Text="Saved";
                    statusStripBtnSchoolRegistration.Text = "Saved";
                }

            }
            catch
            {

            }

            statusStripBtnSchoolRegistration.Text = string.Empty;

            TxtSchoolRegistrationAddress.Text = TxtSchoolRegistrationSchoolName.Text = "";

            listBoxSchoolRegistration.Refresh();
            display();
            //clears();
            BtnSchoolRegistrationNew.Enabled = true;
            BtnSchoolRegistrationDelete.Enabled = true;
            BtnSchoolRegistrationEdit.Enabled = true;
            BtnSchoolRegistrationCancel.Enabled = false;
            BtnSchoolRegistrationSave.Enabled = false;
            BtnSchoolRegistrationExit.Enabled = true;
            listBoxSchoolRegistration.Enabled = true;
            TxtSchoolRegistrationAddress.ReadOnly = true;
            TxtSchoolRegistrationSchoolName.ReadOnly = true;

            listBoxSchoolRegistration.SelectedIndex = listBoxSchoolRegistration.FindStringExact(a.Name);
            listBoxSchoolRegistration.SelectedIndex.ToString();

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
            School a = new School();
            if (MessageBox.Show("Are you sure to delete this record ?", "SchoolInfo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {

                    using (AccountContext db = new AccountContext())
                    {
                        a.Name = TxtSchoolRegistrationSchoolName.Text.Trim();
                        a.Address = TxtSchoolRegistrationAddress.Text.Trim();
                        TxtSchoolRegId.Text = a.Id.ToString();
                        db.Entry(a).State = EntityState.Deleted;
                        db.SaveChanges();
                        listBoxSchoolRegistration.Refresh();
                        display();
                        clears();
                        statusStripBtnSchoolRegistration.Text = "Deleted";
                        TxtSchoolRegistrationSchoolName.ReadOnly = true;
                        TxtSchoolRegistrationAddress.ReadOnly = true;
                        listBoxSchoolRegistration.SelectedItem.ToString();
                        statusStripBtnSchoolRegistration.Text = string.Empty;
                        display();
                        TxtSchoolRegistrationSchoolName.Focus();
                        BtnSchoolRegistrationNew.Enabled = true;
                        BtnSchoolRegistrationDelete.Enabled = true;
                        BtnSchoolRegistrationEdit.Enabled = true;
                        BtnSchoolRegistrationCancel.Enabled = false;
                        BtnSchoolRegistrationSave.Enabled = false;
                        BtnSchoolRegistrationExit.Enabled = true;

                    }
                }
                catch
                {
                    MessageBox.Show("error");
                }
            }
            else
            {

            }


        }

        private void listBoxSchoolRegistration_SelectedIndexChanged(object sender, EventArgs e)
        {
            School a = new School();
            if (listBoxSchoolRegistration.SelectedIndex > -1)
            {
                a.Id = ((School)listBoxSchoolRegistration.Items[listBoxSchoolRegistration.SelectedIndex]).Id;
                using (AccountContext db = new AccountContext())
                {
                     a= db.Schools.Where(x => x.Id == a.Id).FirstOrDefault();
                    TxtSchoolRegistrationSchoolName.Text = a.Name;
                    TxtSchoolRegistrationAddress.Text = a.Address;
                    
                    //listBox1.SelectedItem.ToString();
                    //textBox6.Text = listBox1.SelectedIndex.ToString();
                }
                

            }
            listBoxSchoolRegistration.Refresh();
        }
    }
}
