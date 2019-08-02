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
            toolStripComboBox1.Items.Clear();
            IList<Event> Events =MarkEntryManager.ListEvent();
            foreach (var lEvent in Events)
            {
                toolStripComboBox1.Items.Add(lEvent);
                
                if (toolStripComboBox1.Items.Count > 0)
                {
                    toolStripComboBox1.SelectedIndex = 0;
                }
                
            }
        }
        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            int Index = toolStripComboBox1.SelectedIndex;
            if (Index > -1)
            {
                Event lEvent = (Event)toolStripComboBox1.Items[Index];
                if (lEvent != null)
                {
                    //Event CurrencyFromDB = MarkEntryManager.GetEventById(lCurrency.Id);
                }
            }
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

       

        
    }
}
