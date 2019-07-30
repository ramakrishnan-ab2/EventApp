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
        public FormMarkEntry()
        {
            InitializeComponent();
        }
      
        public IList<Event> ListEventId(long EventId)
        {
            using (AccountContext Context = new AccountContext())
            {
                IList<Event> EventInfo = (from Event in Context.Events select Event).ToList();
                return EventInfo;
            }
        }
        private void MarkEntry_Load(object sender, EventArgs e)
        {
            int i;
            dataGridView1.Rows.Clear();
            Event a = new Event();
            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {


                for (i = 0; i <= dataGridView1.Rows.Count; i++)
                {
                    a.Id = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value.ToString());
                    a.EventName = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    dataGridView1.Rows.Add(a);
                    dataGridView1.DataSource = a.EventName.ToList();
                }
            }
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

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
