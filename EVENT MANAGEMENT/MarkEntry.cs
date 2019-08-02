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
        RegisterManager RegisterManager = null;
        EventManager EventManager = null;
        enum EventColumn
        {
            SNO, EventRollNo, Judges, AvgMarks
        }
        public FormMarkEntry()
        {
            MarkEntryManager = new MarkEntryManager();
            JudgesManager = new JudgesManager();
            RegisterManager = new RegisterManager();
            EventManager = new EventManager();
            InitializeComponent();
        }
        public void eventid()
        {
            int EventId = (toolStripComboBox1.SelectedIndex);
            AccountContext Context = new AccountContext();
            var q = from p in Context.Registers
                    where p.EventRollNo == toolStripComboBox1.SelectedIndex
                    select p;
                 //       var hasEmp = Context.Registers
                 //.Where(e =>e.EventRollNo==EventId)
                 //.Select(d => d.EventRollNo).ToList()
                 //;
        }
        public void MemoryChallenge()
        {
            if (toolStripComboBox1.SelectedIndex >= 0)
            {
              
                int EventId = (toolStripComboBox1.SelectedIndex);
                // dataGridView1.Rows.Add(RegisterManager.ListRegistration());
                dataGridView1.Rows.Clear();
                IList<Register> Event = RegisterManager.ListRegistration();
                int j = 0;
                IList<Judges> ljudges = JudgesManager.ListJudges();
                for (int i = 0; i <= dataGridView1.Rows.Count; i++)
                {
                    foreach (DataGridViewRow dr in dataGridView1.Rows)
                    {

                        dr.Cells[(int)EventColumn.SNO].Value = j + 1;

                        foreach (var lEvents in dataGridView1.Rows)
                        {

                            (dr.Cells[(int)EventColumn.EventRollNo] as DataGridViewComboBoxCell).DataSource = null;
                            (dr.Cells[(int)EventColumn.EventRollNo] as DataGridViewComboBoxCell).DataSource = Event;
                            (dr.Cells[(int)EventColumn.EventRollNo] as DataGridViewComboBoxCell).ValueMember = "Id";
                            (dr.Cells[(int)EventColumn.EventRollNo] as DataGridViewComboBoxCell).DisplayMember = "EventRollNo";

                            // (dr.Cells[(int)EventColumn.EventRollNo] as DataGridViewComboBoxCell).Items.AddRange(q.ToList<Register>());

                            foreach (var judge in ljudges)
                            {

                                (dr.Cells[(int)EventColumn.Judges] as DataGridViewComboBoxCell).DataSource = null;
                                (dr.Cells[(int)EventColumn.Judges] as DataGridViewComboBoxCell).DataSource = ljudges;
                                (dr.Cells[(int)EventColumn.Judges] as DataGridViewComboBoxCell).ValueMember = "Id";
                                (dr.Cells[(int)EventColumn.Judges] as DataGridViewComboBoxCell).DisplayMember = "JudgeName";
                            }
                           

                        }
                    }
                }
            }

        }
        public void Quiz()
        {
            MemoryChallenge();
        }
        public void ELOCUTIONTAMIL() { MemoryChallenge(); }
        public void ELOCUTIONENGLISH() { MemoryChallenge(); }
        public void SUDOKU() { MemoryChallenge(); }
        public void GROUPDANCE() { MemoryChallenge(); }
        public void INTELLECTUALPRESENTATION() { MemoryChallenge(); }
        public void PELAITHIRUTHUMPOTTI() { MemoryChallenge(); }
        public void GROUPSONG() { MemoryChallenge(); }
        public void WORDPOWER() { MemoryChallenge(); }
        public void ADMAD() { MemoryChallenge(); }
        public void DRAWING() { MemoryChallenge(); }
        public void SPELLBEE() { MemoryChallenge(); }
        public void TURNCOAT() { MemoryChallenge(); }
        public void ESSAYWRITINGENGLISH() { MemoryChallenge(); }
        public void FANCYDRESS() { MemoryChallenge(); }
        public void SOAPCARVING() { MemoryChallenge(); }
        public void BHARATHANATYAM() { MemoryChallenge(); }
        public void GROUPDANCEWITHOUT() { MemoryChallenge(); }
        public void ESSAYWRITINGTAMIL() { MemoryChallenge(); }
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
            int Index = toolStripComboBox1.SelectedIndex;
            if (Index > -1)
            {
                Event lEvent = (Event)toolStripComboBox1.Items[Index];
                if (lEvent != null)
                {
                    Event EventFromDB = MarkEntryManager.GetEventById(lEvent.Id);
                    return EventFromDB;
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
            if (toolStripComboBox1.SelectedIndex == 0)
            {

            }
        }
       

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToResizeColumns = false;
            if (toolStripComboBox1.Text == "MEMORY CHALLENGE")
            {
                MemoryChallenge();

            }
            else if (toolStripComboBox1.Text == "QUIZ")
            {
                Quiz();
            }
            else if (toolStripComboBox1.Text == "ELOCUTION - TAMIL")
            {
                ELOCUTIONTAMIL();
            }
            else if (toolStripComboBox1.Text == "ELOCUTION-ENGLISH")
            {
                ELOCUTIONENGLISH();
            }
            else if (toolStripComboBox1.Text == "SUDOKU")
            {
                SUDOKU();
            }
            else if (toolStripComboBox1.Text == "GROUP DANCE")
            {
                GROUPDANCE();
            }
            else if (toolStripComboBox1.Text == "INTELLECTUAL PRESENTATION")
            {
                INTELLECTUALPRESENTATION();
            }
            else if (toolStripComboBox1.Text == "PELAI THIRUTHUM POTTI")
            {
                PELAITHIRUTHUMPOTTI();

            }
            else if (toolStripComboBox1.Text == "GROUP SONG")
            {
                GROUPSONG();
            }
            else if (toolStripComboBox1.Text == "WORD POWER")
            {
                WORDPOWER();
            }
            else if (toolStripComboBox1.Text == "ADMAD")
            {
                ADMAD();
            }
            else if (toolStripComboBox1.Text == "DRAWING")
            {
                DRAWING();

            }
            else if (toolStripComboBox1.Text == "SPELL BEE")
            {
                SPELLBEE();

            }
            else if (toolStripComboBox1.Text == "TURNCOAT")
            {
                TURNCOAT();

            }
            else if (toolStripComboBox1.Text == "ESSAY WRITING-ENGLISH")
            {
                ESSAYWRITINGENGLISH();

            }
            else if (toolStripComboBox1.Text == "FANCY DRESS")
            {

                FANCYDRESS();
            }
            else if (toolStripComboBox1.Text == "SOAP CARVING")
            {

                SOAPCARVING();
            }
            else if (toolStripComboBox1.Text == "BHARATHA NATYAM")
            {

                BHARATHANATYAM();
            }
            else if (toolStripComboBox1.Text == "ESSAY WRITING-TAMIL")
            {

                ESSAYWRITINGTAMIL();
            }
            else if (toolStripComboBox1.Text == "GROUP DANCE(WITHOUT PROPERTY)")
            {
                GROUPDANCEWITHOUT();
            }
            else
            {
                toolStripStatusLabel1.Text = ("Something Went Wrong,Please Check Ur Event Selection");
            }
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

    }
}
