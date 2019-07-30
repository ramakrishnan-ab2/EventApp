
using EVENT_MANAGEMENT.Context;
using EVENT_MANAGEMENT.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVENT_MANAGEMENT.Manager
{
    public class RegisterManager
    {

        public Register AddRegister(Register RegisterFromForm)
        {
            Register RegisterInfo = null;
            if (RegisterFromForm != null)
            {
                using (AccountContext AccountContext = new AccountContext())
                {
                    try
                    {
                        if (RegisterInfo != null)
                        {
                            RegisterInfo = AccountContext.Registers.Add(RegisterFromForm);
                            AccountContext.SaveChanges();
                        }
                      
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex);
                        RegisterInfo = null;
                    }
                }
            }
            return RegisterInfo;

        }
        public Register GetRegisterByName(string RegName)
        {
            Register RegInfo = null;
            using (AccountContext Context = new AccountContext())
            {
                RegInfo = Context.Registers.FirstOrDefault(x => x.StudentName == RegName);
                return RegInfo;
            }
        }
        public Register UpdateRegister(Register StudentId)
        {
            Register Reginfo = null;
            using (AccountContext Context = new AccountContext())
            {
                Reginfo = Context.Registers.Find(Reginfo.Id);
                try
                {
                    Reginfo = Context.Registers.Where(i => i.Id == StudentId.Id).FirstOrDefault();
                    if (Reginfo != null)
                    {
                        Context.Entry(Reginfo).State=EntityState.Modified;
                        Context.SaveChanges();
                    }
                   
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex);
                }
                return Reginfo;

            }
        }
        public Register DeleteRegister(Register StudentId)
        {
            Register Reginfo = null;
            using (AccountContext Context = new AccountContext())
            {
                 Reginfo = Context.Registers.Where(i => i.Id == StudentId.Id).FirstOrDefault();
                try
                {
                    if (Reginfo != null)
                    {
                        Context.Entry(Reginfo).State = EntityState.Deleted;
                        Context.SaveChanges();
                    }
                  
                    
                }
                catch(Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            return Reginfo;
        }
    }
}
