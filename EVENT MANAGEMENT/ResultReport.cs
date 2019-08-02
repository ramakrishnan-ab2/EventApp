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
        private void LoadEvent()
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
            LoadEvent();
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
                dataGridViewResultReport.Rows.Add(RegisterEntryInfo.Count);
                int i = 0;
                foreach (var lSaleEntryInfo in RegisterEntryInfo)
                {
                    double Avgmarks =0;
                    dataGridViewResultReport.Rows[i].Cells[0].Value = i+1;
                    dataGridViewResultReport.Rows[i].Cells[1].Value = lSaleEntryInfo.EventRollNo;
                    dataGridViewResultReport.Rows[i].Cells[2].Value = lSaleEntryInfo.Id;
                    dataGridViewResultReport.Rows[i].Cells[3].Value = (lSaleEntryInfo.StudentName == null) ? lSaleEntryInfo.Qualification.Name : lSaleEntryInfo.Qualification.Name;
                    //double judge1 = 0;
                    //double judge2 = 0;
                    //double judge3 = 0;
                    //dataGridViewResultReport.Rows[i].Cells[4].Value= judge1;
                    //dataGridViewResultReport.Rows[i].Cells[5].Value = judge2;
                    //dataGridViewResultReport.Rows[i].Cells[6].Value = judge3;
                    //if (dataGridViewResultReport.Rows[i].Cells[4] != null)
                    //{
                    //    judge1 = double.Parse(dataGridViewResultReport.Rows[i].Cells[4].Value.ToString());

                    //}
                   
                    //if (dataGridViewResultReport.Rows[i].Cells[5] != null)
                    //{
                    //    judge2 = double.Parse(dataGridViewResultReport.Rows[i].Cells[5].Value.ToString());

                    //}
                   
                    //if (dataGridViewResultReport.Rows[i].Cells[6] != null)
                    //{
                    //    judge1 = double.Parse(dataGridViewResultReport.Rows[i].Cells[6].Value.ToString());

                    //}
                    // Avgmarks =judge1+judge2+judge3;
                    //dataGridViewResultReport.Rows[i].Cells[7].Value =Avgmarks ;
                    i++;
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

            }
            else if (ComboBoxResultReportEvents.Text == "ELOCUTION - TAMIL")
            {

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

        private void ResultReport_Load_1(object sender, EventArgs e)
        {
            LoadEvent();
        }
    }
    
}
