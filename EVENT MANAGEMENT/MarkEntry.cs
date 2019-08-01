using EVENT_MANAGEMENT.Context;
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
    public partial class FormMarkEntry : Form
    {
        MarkEntryManager MarkEntryManager = null;
        JudgesManager JudgesManager = null;
        enum JudgesColumn
        {
            SNO,EventRollNo,Judges,AvgMarks
        }
        public FormMarkEntry()
        {
            MarkEntryManager = new MarkEntryManager();
            JudgesManager = new JudgesManager();
            InitializeComponent();
        }
      
        public void MemoryChallenge()
        {
               
                foreach (DataGridViewRow r in dataGridView1.Rows)
                {
                    IList<Judges> judges = JudgesManager.ListJudges();
                    foreach (var lJudges in judges)
                    {
                        int rowcount = 0;
                    for (int i = 0; i <= dataGridView1.Rows.Count; i++)
                    {
                        r.Cells[0].Value = rowcount;
                        rowcount++;
                        DataGridViewComboBoxCell comboCell = (DataGridViewComboBoxCell)dataGridView1[2, 0];
                        comboCell.Items.Clear();
                        comboCell.Items.AddRange(lJudges);
                        if (comboCell.Items.Count > 0)
                        {
                            comboCell.Items.Add("JUDGE ONE");
                            comboCell.Items.Add("JUDGE TWO");
                        }

                    }
                    }
                }
        }
        public void Quiz()
        {

        }
        public void ELOCUTIONTAMIL() { }
        public void ELOCUTIONENGLISH() { }
        public void SUDOKU() { }
        public void GROUPDANCE() { }
        public void INTELLECTUALPRESENTATION() { }
        public void PELAITHIRUTHUMPOTTI() { }
        public void GROUPSONG() { }
        public void WORDPOWER() { }
        public void ADMAD() { }
        public void DRAWING() { }
        public void SPELLBEE() { }
        public void TURNCOAT() { }
        public void ESSAYWRITINGENGLISH() { }
        public void FANCYDRESS() { }
        public void SOAPCARVING() { }
        public void BHARATHANATYAM() { }
        public void GROUPDANCEWITHOUT(){}
        private void MarkEntry_Load(object sender, EventArgs e)
        { 
                LoadEvent();
           

        }
        private void LoadEvent()
        {
            try
            {
                string FilterString = toolStripComboBox1.Text.Trim();
                toolStripComboBox1.Items.Clear();
                IList<Event> Events = MarkEntryManager.ListEvent();
                foreach (var lEvent in Events)
                {

                    toolStripComboBox1.Items.Add(lEvent);

                    if (toolStripComboBox1.Items.Count > 0)
                    {
                        toolStripComboBox1.SelectedIndex = 0;
                    }
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        private Event GetEventByName()
        {
            int Index =toolStripComboBox1.SelectedIndex;
            if (Index > -1)
            {
                Event lCurrency = (Event)toolStripComboBox1.Items[Index];
                if (lCurrency != null)
                {
                    Event CurrencyFromDB = MarkEntryManager.GetEventById(lCurrency.Id);
                    return CurrencyFromDB;
                }
            }
            return null;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Event Eve = new Event();

            MarkEntryManager MarkEntryManager = new MarkEntryManager();
            Event Reg = MarkEntryManager.AddEvent(Eve);
            MessageBox.Show("Saved");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        private void EnableButtons(bool Enable)
        {
            btnMarkSave.Enabled = Enable;
            btnMarkExit.Enabled = Enable;
           
        }
        private void ResetForm()
        {
            dataGridView1.Rows.Clear();
            toolStripComboBox1.SelectedIndex = -1;
            EnableButtons(true);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if(toolStripComboBox1.SelectedIndex==0)
            {
               
            }
        }
        
        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            if(toolStripComboBox1.Text=="MEMORY CHALLENGE")
            {
                MemoryChallenge();

            }
            else if(toolStripComboBox1.Text == "QUIZ")
            {

            }
            else if(toolStripComboBox1.Text == "ELOCUTION - TAMIL")
            {

            }
            else if (toolStripComboBox1.Text == "ELOCUTION-ENGLISH")
            {

            }
            else if (toolStripComboBox1.Text == "SUDOKU")
            {

            }
            else if (toolStripComboBox1.Text == "GROUP DANCE")
            {

            }
            else if (toolStripComboBox1.Text == "INTELLECTUAL PRESENTATION")
            {

            }
            else if (toolStripComboBox1.Text == "PELAI THIRUTHUM POTTI")
            {


            }
            else if (toolStripComboBox1.Text == "GROUP SONG")
            {

            }
            else if (toolStripComboBox1.Text == "WORD POWER")
            {

            }
            else if (toolStripComboBox1.Text == "ADMAD")
            {

            }
            else if (toolStripComboBox1.Text == "DRAWING")
            {


            }
            else if (toolStripComboBox1.Text == "SPELL BEE")
            {


            }
            else if (toolStripComboBox1.Text == "TURNCOAT")
            {


            }
            else if (toolStripComboBox1.Text == "ESSAY WRITING-ENGLISH")
            {


            }
            else if (toolStripComboBox1.Text == "FANCY DRESS")
            {


            }
            else if (toolStripComboBox1.Text == "SOAP CARVING")
            {


            }
            else if (toolStripComboBox1.Text == "BHARATHA NATYAM")
            {


            }
            else if (toolStripComboBox1.Text == "ESSAY WRITING-TAMIL")
            {


            }
            else if (toolStripComboBox1.Text == "GROUP DANCE(WITHOUT PROPERTY)")
            {

            }
            else
            {
                MessageBox.Show("Something Went Wrong,Please Check Ur Event Selection");
            }
        }
    }
}
