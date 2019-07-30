using EVENT_MANAGEMENT.Context;
using EVENT_MANAGEMENT.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVENT_MANAGEMENT.Manager
{
   
    public class UserLoginManager
    {
        public static UserLoginManager Instance { get; internal set; }

        public UserLogin AddUserLogin(UserLogin UserLoginFromForm)
        {
            UserLogin UserLogin = null;
            if(UserLoginFromForm!=null)
            {
                using (AccountContext AccountContext=new AccountContext())
                {
                    UserLogin=AccountContext.UserLogins.Add(UserLoginFromForm);
                }
            }
            return UserLogin;

        }

        public UserLogin GetUserByLogin(string Login)
        {
            UserLogin UserInfo = null;
            using (AccountContext Context = new AccountContext())
            {
                UserInfo= Context.UserLogins.FirstOrDefault(x=>x.Username == Login);         
                return UserInfo;
            }

        }
        
    } 
}
