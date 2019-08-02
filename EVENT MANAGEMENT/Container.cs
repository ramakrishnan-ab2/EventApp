using EVENT_MANAGEMENT.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EVENT_MANAGEMENT
{
    public partial class Container : Form
    {
        public Container()
        {
            InitializeComponent();
        }

        private void Container_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
            try
            {
                setmain(false);
                Login loginFrm = new Login(this);
                loginFrm.ShowDialog(this);
               
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Something went wrong ,Please contact administrator");
            }
        }

        

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegistration R = new FormRegistration();
            R.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login(this);
            login.ShowDialog(this);

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void eventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EventReport ER = new EventReport();
            ER.Show();
        }

        private void resultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResultReport ReR = new ResultReport();
            ReR.Show();
        }

        private void schoolNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSchoolRegistration SR = new FormSchoolRegistration();
            SR.Show();
        }

        private void markUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMarkEntry ME = new FormMarkEntry();
            ME.Show();
        }
        
        public  void setmain(bool login)
        {
            if (login)
            {
                masterToolStripMenuItem.Visible = true;
                reportToolStripMenuItem.Visible = true;
                logoutToolStripMenuItem.Visible = true;
                loginToolStripMenuItem.Visible = false;

            }
            else
            {
                masterToolStripMenuItem.Visible = false;
                reportToolStripMenuItem.Visible = false;
                logoutToolStripMenuItem.Visible = false;
                loginToolStripMenuItem.Visible = true;
            }
            
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Global.User = null;
               setmain(false);
        }

        private void Container_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult Result = MessageBox.Show("Exit From Application", "Exit Confirm",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            if (Result == DialogResult.No)
            {
                e.Cancel = true;
            }
            
        }
    }
}
