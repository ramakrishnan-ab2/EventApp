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
    public partial class ResultReport : Form
    {
        MarkEntryManager MarkEntryManager = null;
        JudgesManager JudgesManager = null;
        RegisterManager RegisterManager = null;
        public ResultReport()
        {
            MarkEntryManager = new MarkEntryManager();
            JudgesManager = new JudgesManager();
            RegisterManager = new RegisterManager();
            InitializeComponent();
        }
        private void LoadCategoryCombo()
        {
            //string Temp = comboBoxRegistartionCategory.Text.Trim();

            int EventId = (ComboBoxResultReportEvents.SelectedIndex > -1) ? ((Event)ComboBoxResultReportEvents.Items[ComboBoxResultReportEvents.SelectedIndex]).Id : 0;
            CategoryManager CategoryManager = new CategoryManager();
            ComboBoxResultReportCategory.Items.Clear();
            IList<Category> Category = CategoryManager.ListCategoryl(EventId);
            if (Category != null)
            {
                ComboBoxResultReportCategory.Items.AddRange(Category.ToArray());
            }
            if (ComboBoxResultReportCategory.Items.Count > 0)
            {
                ComboBoxResultReportCategory.SelectedIndex = 0;
            }
        }
            private void LoadEventCombo()
            {
            try
            {
            
                ComboBoxResultReportEvents.Items.Clear();
                IList<Event> Events = MarkEntryManager.ListEvent();
                foreach (var lEvent in Events)
                {

                    ComboBoxResultReportEvents.Items.Add(lEvent);

                    if (ComboBoxResultReportEvents.Items.Count > 0)
                    {
                        ComboBoxResultReportEvents.SelectedIndex = 0;
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        private void btnResultReportExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void ResultReport_Load(object sender, EventArgs e)
        {
            LoadEventCombo(); LoadCategoryCombo();
            dataGridViewResultReport.ReadOnly = true;
        }

        private void btnResultReportCancel_Click(object sender, EventArgs e)
        {
            ComboBoxResultReportEvents.SelectedIndex = 0;
            dataGridViewResultReport.Rows.Clear();
        }

        private void btnResultReportPrint_Click(object sender, EventArgs e)
        {

        }

        private void LblResultReportGo_Click(object sender, EventArgs e)
        {
            
        }
        private void Memory()
        {

            Register Register = new Register();
            IList<Register> RegisterEntryInfo = RegisterManager.ListRegistration();

            if (RegisterEntryInfo.Count > 0)
            {
                //dataGridViewResultReport.Rows.Add(RegisterEntryInfo.Count);
                
                    
                 foreach (var lSaleEntryInfo in RegisterEntryInfo)
                 {
                    int i = 0;
                    foreach (DataGridViewRow dr in dataGridViewResultReport.Rows)
                    {
                       
                        dr.Cells[0].Value =i+1;
                        dr.Cells[1].Value = lSaleEntryInfo.EventRollNo;
                        dr.Cells[2].Value = lSaleEntryInfo.RollNo;
                        dr.Cells[3].Value = lSaleEntryInfo.StudentName;
                        //double judge1 = 0;
                        //double judge2 = 0;
                        //double judge3 = 0;
                        //dr.Cells[4].Value = judge1;
                        //dr.Cells[5].Value = judge2;
                        //dr.Cells[6].Value = judge3;
                        //int sum = 0;

                        //for (int j = 0; j < dataGridViewResultReport.Rows.Count; j++)

                        //{

                        //    sum = Convert.ToInt32(dataGridViewResultReport.Rows[j].Cells[4].Value) + Convert.ToInt32(dataGridViewResultReport.Rows[j].Cells[5].Value) + Convert.ToInt32(dataGridViewResultReport.Rows[j].Cells[6].Value);
                        //    dataGridViewResultReport.Rows[j].Cells[7].Value = sum;
                        //}

                    }
                 }
            }
        }
        private void quiz()
        {
            string FilterString = ComboBoxResultReportEvents.Text.Trim();
            int eventid = ComboBoxResultReportEvents.SelectedIndex;
            dataGridViewResultReport.Rows.Clear();
            IList<Register> Register = RegisterManager.ListRegistration();
            if (Register.Count > 0)
            {
                foreach (var lRegister in Register)
                {
                    // if (FilterString == null || string.IsNullOrEmpty(FilterString.Trim()) || lRegister.EventId(FilterString, StringComparison.OrdinalIgnoreCase) > -1 )
                    {
                        int i = 0;
                        foreach (DataGridViewRow dr in dataGridViewResultReport.Rows)
                        {
                            dr.Cells[0].Value = i+1;
                            dr.Cells[1].Value = lRegister.EventRollNo;
                            dr.Cells[2].Value = lRegister.RollNo;
                            dr.Cells[3].Value = lRegister.StudentName;
                            // dr.Cells[4].Value
                          
                        }
                    }
                }
            }
            //if (ComboBoxResultReportEvents.Items.Count > 0)
            //{
            //    ComboBoxResultReportEvents.SelectedIndex = 0;
            //}

        }
        private void events()
        {
            int EventId = (ComboBoxResultReportEvents.SelectedIndex > -1) ? ((Event)ComboBoxResultReportEvents.Items[ComboBoxResultReportEvents.SelectedIndex]).Id : 0;
            RegisterManager RegisterManager = new RegisterManager();
            dataGridViewResultReport.Rows.Clear();
            IList<Register> Register = RegisterManager.ListRegistrationl(EventId);
            if (Register != null)
            {
                foreach (var lRegister in Register)
                {
                    // if (FilterString == null || string.IsNullOrEmpty(FilterString.Trim()) || lRegister.EventId(FilterString, StringComparison.OrdinalIgnoreCase) > -1 )
                    {
                        int i = 0;
                        foreach (DataGridViewRow dr in dataGridViewResultReport.Rows)
                        {
                            dr.Cells[0].Value = i + 1;
                            dr.Cells[1].Value = lRegister.EventRollNo;
                            dr.Cells[2].Value = lRegister.RollNo;
                            dr.Cells[3].Value = lRegister.StudentName;
                            // dr.Cells[4].Value

                        }
                    }
                }
            }
           
        }

        
            private void LblResultReportGo_Click_1(object sender, EventArgs e)
            {
            dataGridViewResultReport.AllowUserToResizeColumns = false;

            if (ComboBoxResultReportEvents.Text == "MEMORY CHALLENGE")
            {
                Memory();

            }
            else if (ComboBoxResultReportEvents.Text == "QUIZ")
            {
                quiz();
            }
            else if (ComboBoxResultReportEvents.Text == "ELOCUTION-TAMIL")
            {
                events();
            }
            else if (ComboBoxResultReportEvents.Text == "ELOCUTION-ENGLISH")
            {

            }
            else if (ComboBoxResultReportEvents.Text == "SUDOKU")
            {

            }
            else if (ComboBoxResultReportEvents.Text == "GROUP DANCE")
            {

            }
            else if (ComboBoxResultReportEvents.Text == "INTELLECTUAL PRESENTATION")
            {

            }
            else if (ComboBoxResultReportEvents.Text == "PELAI THIRUTHUM POTTI")
            {


            }
            else if (ComboBoxResultReportEvents.Text == "GROUP SONG")
            {

            }
            else if (ComboBoxResultReportEvents.Text == "WORD POWER")
            {

            }
            else if (ComboBoxResultReportEvents.Text == "ADMAD")
            {

            }
            else if (ComboBoxResultReportEvents.Text == "DRAWING")
            {


            }
            else if (ComboBoxResultReportEvents.Text == "SPELL BEE")
            {


            }
            else if (ComboBoxResultReportEvents.Text == "TURNCOAT")
            {


            }
            else if (ComboBoxResultReportEvents.Text == "ESSAY WRITING-ENGLISH")
            {


            }
            else if (ComboBoxResultReportEvents.Text == "FANCY DRESS")
            {


            }
            else if (ComboBoxResultReportEvents.Text == "SOAP CARVING")
            {


            }
            else if (ComboBoxResultReportEvents.Text == "BHARATHA NATYAM")
            {


            }
            else if (ComboBoxResultReportEvents.Text == "ESSAY WRITING-TAMIL")
            {


            }
            else if (ComboBoxResultReportEvents.Text == "GROUP DANCE(WITHOUT PROPERTY)")
            {

            }

            else
            {
                MessageBox.Show("Something Went Wrong,Please Check Ur Event Selection");
            }
        }

       
       
       
      

        private void ComboBoxResultReportEvents_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ComboBoxResultReportCategory.Items.Clear();
            if (ComboBoxResultReportEvents.SelectedIndex > -1)
            {
                ComboBoxResultReportCategory.Enabled = true;
                LoadCategoryCombo();
                ComboBoxResultReportCategory.SelectedIndex = -1;
            }
            else
            {
                ComboBoxResultReportCategory.SelectedIndex = -1;
                ComboBoxResultReportCategory.Enabled = false;
            }
        }
        
        private void ComboBoxResultReportCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewResultReport.Rows.Clear();
        }
    }
    
}
