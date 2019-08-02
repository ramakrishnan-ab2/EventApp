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
using static EVENT_MANAGEMENT.Container;

namespace EVENT_MANAGEMENT
{
    public partial class Login : Form
    {
        public static string AccountLockErrorMsg = "Your Account is locked, Please contact administrator!";
        public static string LoginFailedErrorMsg = "Login Failed, Please verify your UserName !";

        Container parent;
        
        public Login()
        {
            InitializeComponent();
        }

          public Login(object sender)
        {
            InitializeComponent();
            parent = (Container) sender;
        }    
        private void CheckEnableLoginBtn()
        {
            if (TxtLoginLogin.Text.Length > 0 && TxtLoginPassword.Text.Length > 0)
            {
                BtnLoginLogin.Enabled = true;
            }
            else
            {
                BtnLoginLogin.Enabled = false;
            }
        }
       
        private void BtnLoginLogin_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                       Global.User = null;
                       UserLoginManager UserManager = new UserLoginManager();
                    UserLogin User = UserManager.GetUserByLogin(TxtLoginLogin.Text);
                    if (User!=null)
                    {
                        if(TxtLoginPassword.Text==User.Password)
                        {
                            Global.User = User;
                            parent.setmain(true);
                            this.Hide();
                        }
                        else
                        {
                        MessageBox.Show("please check password");
                        }
                 
                    }
                    else
                    {
                        MessageBox.Show(LoginFailedErrorMsg);
                        return;
                    }
            }
            catch(Exception ex)
            {

            }
        }
        
        private void BtnLoginCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtLoginLogin_TextChanged(object sender, EventArgs e)
        {
            CheckEnableLoginBtn();
        }

        private void TxtLoginPassword_TextChanged(object sender, EventArgs e)
        {
            CheckEnableLoginBtn();
        }
    }
}
