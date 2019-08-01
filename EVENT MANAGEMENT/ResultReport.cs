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
        public ResultReport()
        {
            MarkEntryManager = new MarkEntryManager();
            JudgesManager = new JudgesManager();
            InitializeComponent();
        }
        private void LoadEvent()
        {
            try
            {
                string FilterString =ComboBoxResultReportEvents.Text.Trim();
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
    }
}
