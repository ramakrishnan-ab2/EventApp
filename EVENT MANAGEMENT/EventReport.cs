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
        EventManager EventManager = null;
        MarkEntryManager MarkEntryManager = null;
        RegisterManager RegisterManager = null;
        

        //enum Event
        //{
        //    EventRollNo, RollNo, Name, Qualification
        //}
        public EventReport()
        {
            MarkEntryManager = new MarkEntryManager();
            RegisterManager = new RegisterManager();
            EventManager = new EventManager();
            InitializeComponent();
        }

        private void btnEventReportExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LblEventReportGo_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            dataGridViewEventReport.AllowUserToResizeColumns = false;

            if (ComboBoxEventReport.Text == "MEMORY CHALLENGE")
            {
                events();
            }
        }
       
        private void generateDefaultReport()
        {
            events();
        }
        private void LoadEvent()
        {
            try
            {
                string FilterString = ComboBoxEventReport.Text.Trim();
                ComboBoxEventReport.Items.Clear();
                IList<Event> Event = EventManager.ListEvent();
                //IList<Event> EventReport = EventManager.ListEvent();
                foreach (var lEvent in Event)
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
        
        private void events()
        {
           
            Register Register = new Register();
            IList<Register> RegisterEntryInfo = RegisterManager.ListRegistration();

            if (RegisterEntryInfo.Count > 0)
            {
                dataGridViewEventReport.Rows.Add(RegisterEntryInfo.Count);
                int i = 0;
                foreach (var lEventInfo in RegisterEntryInfo)
                {
                    dataGridViewEventReport.Rows[i].Cells[0].Value = lEventInfo.EventRollNo;
                    dataGridViewEventReport.Rows[i].Cells[1].Value = lEventInfo.Id;
                    dataGridViewEventReport.Rows[i].Cells[2].Value = lEventInfo.StudentName;
                    dataGridViewEventReport.Rows[i].Cells[3].Value = (lEventInfo.StudentName == null) ? lEventInfo.Qualification.Name : lEventInfo.Qualification.Name;
                    i++;
                }
            }
        }

        private void EventReport_Load(object sender, EventArgs e)
        {
            LoadEvent();
        }

        private void ComboBoxEventReport_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxEventReport.SelectedIndex > -1)
            {
                Event SelectedEvent = (Event)ComboBoxEventReport.Items[ComboBoxEventReport.SelectedIndex];
                //ComboUtils.InitializeCostCenterCombo(ComboBoxEventReport, SelectedEvent.);
                if (ComboBoxEventReport.Items.Count > 1)
                {
                    //LabelSelectCompanyCostcente.Visible = true;
                    ComboBoxEventReport.Visible = true;
                }
                else
                {
                    //LabelSelectCompanyCostcente.Visible = false;
                    ComboBoxEventReport.Visible = true;
                }
            }
        }
    }
}
