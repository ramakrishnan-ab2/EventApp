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

    }
}
