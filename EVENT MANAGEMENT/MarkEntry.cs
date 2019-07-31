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
        public FormMarkEntry()
        {
            MarkEntryManager = new MarkEntryManager(); 
            InitializeComponent();
        }
      
      
        private void MarkEntry_Load(object sender, EventArgs e)
        { 
                LoadEvent();
           

        }
        private void LoadEvent()
        {
            string FilterString = toolStripComboBox1.Text.Trim();
            toolStripComboBox1.Items.Clear();
            IList<Event> Events =MarkEntryManager.ListEvent();
            foreach (var lEvent in Events)
            {
                
                    toolStripComboBox1.Items.Add(lEvent);
                
                if (toolStripComboBox1.Items.Count > 0)
                {
                    toolStripComboBox1.SelectedIndex = 0;
                }
                Event CurrencyFromDB = GetEventByName();
                if (CurrencyFromDB != null)
                {
                   
                    var CurrencyPricision = CurrencyFromDB.EventName;
                    toolStripComboBox1.SelectedIndex = toolStripComboBox1.FindStringExact("" + CurrencyFromDB.EventName);
                }
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
           
        }
    }
}
