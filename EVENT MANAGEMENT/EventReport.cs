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
        EventManager EventManager = new EventManager();
        public EventReport()
        {
            InitializeComponent();
        }

        private void btnEventReportExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EventReport_Load(object sender, EventArgs e)
        {
            LoadEvent();
            BtnScoringFinalReport.Enabled = false;
            BtnScoringReport.Enabled = false;
        }
        private void LoadEvent()
        {
            ComboBoxEventReport.Items.Clear();
            IList<Event> Events = EventManager.ListEvent();
            foreach (var lEvent in Events)
            {
                ComboBoxEventReport.Items.Add(lEvent);     
                ComboBoxEventReport.SelectedIndex = -1;              
            }
        }

        private void LblEventReportGo_Click(object sender, EventArgs e)
        {
            int Index = ComboBoxEventReport.SelectedIndex;
            if (Index > -1)
            {
                Event lEvent = (Event)ComboBoxEventReport.Items[Index];
                if (lEvent != null)
                {
                    LoadEventGrid(lEvent.Id);
                }
            }
            else
            {
                Errormsg.Text = "Please choose the event.";
            }
        }
        private void LoadEventGrid(int Id)
        {
            dataGridViewEventReport.Rows.Clear();
            RegisterManager RegisterManager = new RegisterManager();
            IList<Register> Register = RegisterManager.ListRegistrationByEventId(Id);
            if (Register != null && Register.Count>0)
            {
                foreach(var reg in Register)
                {

                }

            }
        }

        private void ComboBoxEventReport_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Index = ComboBoxEventReport.SelectedIndex;
            if (Index > -1)
            {
                BtnScoringFinalReport.Enabled = true;
                BtnScoringReport.Enabled = true;
            }
            else
            {
                BtnScoringFinalReport.Enabled = false;
                BtnScoringReport.Enabled = false;
            }
        }
    }
}

