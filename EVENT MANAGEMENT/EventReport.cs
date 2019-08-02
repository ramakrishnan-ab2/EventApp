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
    public partial class EventReport : Form
    {
        MarkEntryManager MarkEntryManager = null;
        JudgesManager JudgesManager = null;
        RegisterManager RegisterManager = null;
        // public IList<Register> RegisterEntryInfo=RegisterManager.ListRegistration();

        public EventReport()
        {
            {
                MarkEntryManager = new MarkEntryManager();
                JudgesManager = new JudgesManager();
                RegisterManager = new RegisterManager();
                InitializeComponent();
            }
        }

        private void btnEventReportExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadEvent()
        {
            try
            {
                string FilterString = ComboBoxEventReport.Text.Trim();
                ComboBoxEventReport.Items.Clear();
                IList<Event> Events = MarkEntryManager.ListEvent();
                foreach (var lEvent in Events)
                {

                    ComboBoxEventReport.Items.Add(lEvent);

                    if (ComboBoxEventReport.Items.Count > 0)
                    {
                        ComboBoxEventReport.SelectedIndex = 0;
                    }

                }
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            
        }
        private void EventReport_Load(object sender, EventArgs e)
        {
            LoadEvent();
        }

        private void Memory()
        {
          
            Register Register = new Register();
            IList<Register> RegisterEntryInfo = RegisterManager.ListRegistration();

            if (RegisterEntryInfo.Count > 0)
            {
                dataGridViewEventReport.Rows.Add(RegisterEntryInfo.Count);
                int i = 0;
                foreach (var lSaleEntryInfo in RegisterEntryInfo)
                {

                    dataGridViewEventReport.Rows[i].Cells[0].Value = lSaleEntryInfo.EventRollNo;
                    dataGridViewEventReport.Rows[i].Cells[1].Value = lSaleEntryInfo.Id;
                    dataGridViewEventReport.Rows[i].Cells[2].Value = lSaleEntryInfo.StudentName;
                    dataGridViewEventReport.Rows[i].Cells[3].Value = (lSaleEntryInfo.StudentName == null) ? lSaleEntryInfo.Qualification.Name : lSaleEntryInfo.Qualification.Name;
                    i++;
                }
            }
        }
        private void LblEventReportGo_Click(object sender, EventArgs e)
        {
            dataGridViewEventReport.AllowUserToResizeColumns = false;

            if (ComboBoxEventReport.Text == "MEMORY CHALLENGE")
            {
                Memory();

            }
            else if (ComboBoxEventReport.Text == "QUIZ")
            {

            }
            else if (ComboBoxEventReport.Text == "ELOCUTION - TAMIL")
            {

            }
            else if (ComboBoxEventReport.Text == "ELOCUTION-ENGLISH")
            {

            }
            else if (ComboBoxEventReport.Text == "SUDOKU")
            {

            }
            else if (ComboBoxEventReport.Text == "GROUP DANCE")
            {

            }
            else if (ComboBoxEventReport.Text == "INTELLECTUAL PRESENTATION")
            {

            }
            else if (ComboBoxEventReport.Text == "PELAI THIRUTHUM POTTI")
            {


            }
            else if (ComboBoxEventReport.Text == "GROUP SONG")
            {

            }
            else if (ComboBoxEventReport.Text == "WORD POWER")
            {

            }
            else if (ComboBoxEventReport.Text == "ADMAD")
            {

            }
            else if (ComboBoxEventReport.Text == "DRAWING")
            {


            }
            else if (ComboBoxEventReport.Text == "SPELL BEE")
            {


            }
            else if (ComboBoxEventReport.Text == "TURNCOAT")
            {


            }
            else if (ComboBoxEventReport.Text == "ESSAY WRITING-ENGLISH")
            {


            }
            else if (ComboBoxEventReport.Text == "FANCY DRESS")
            {


            }
            else if (ComboBoxEventReport.Text == "SOAP CARVING")
            {


            }
            else if (ComboBoxEventReport.Text == "BHARATHA NATYAM")
            {


            }
            else if (ComboBoxEventReport.Text == "ESSAY WRITING-TAMIL")
            {


            }
            else if (ComboBoxEventReport.Text == "GROUP DANCE(WITHOUT PROPERTY)")
            {

            }
            
            else
            {
                 toolStripStatusLabel1.Text=("Something Went Wrong,Please Check Ur Event Selection");
            }
        }
    }
    
}
