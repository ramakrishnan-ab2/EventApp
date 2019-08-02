
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

        public IList<Register> ListRegistrationByEventId(int EId)
        {
            IList<Register> RegInfo = null;
            using (AccountContext Context = new AccountContext())
            {
                RegInfo = Context.Registers.Where(x=>x.EventId==EId).ToList();
            }
            return RegInfo;
        }
        public IList<Register> ListRegistration()
        {
            IList<Register> RegInfo = null;
            using (AccountContext Context = new AccountContext())
            {
                RegInfo = Context.Registers.ToList();
            }
            return RegInfo;
        }
        public Register GetRegisterById(int Id)
        {
            Register RegInfo = null;
            using (AccountContext Context = new AccountContext())
            {
                RegInfo = Context.Registers.Include("Qualification").Include("Category").Include("Event").Include("School").FirstOrDefault(x => x.Id == Id);
                return RegInfo;
            }
        }
        
        public int GetEventRollNo(int CId,int EId)
        {
            int Rno = 1;
            using (AccountContext Context = new AccountContext())
            {
                Rno += Context.Registers.Where(x => x.CategoryId == CId && x.EventId==EId).ToList().Count;

                if(Context.Registers.FirstOrDefault(x=>x.EventRollNo== Rno && x.CategoryId == CId && x.EventId == EId) !=null)
                {
                    for (int i = 1; i < 100; i++)
                    {
                        if (Context.Registers.FirstOrDefault(x => x.EventRollNo == i && x.CategoryId == CId && x.EventId == EId) == null)
                        {
                            return i;
                        }
                    }
                }
            }
            return Rno;
        }
        public bool IsSamePersonDetailDiffSchool(Register RegisterFromForm)
        {
            using (AccountContext Context = new AccountContext())
            {
                if (RegisterFromForm.Id == 0)
                {
                    if (Context.Registers.FirstOrDefault(x => x.StudentName == RegisterFromForm.StudentName && x.FathersName == RegisterFromForm.FathersName && x.PhoneNo == RegisterFromForm.PhoneNo && x.SchoolId != RegisterFromForm.SchoolId) != null)
                    {
                        return true;
                    }
                }
                
            }
            return false;
        }
        public bool IsSameRegistration(Register RegisterFromForm)
        {
            using (AccountContext Context = new AccountContext())
            {
                if(RegisterFromForm.Id==0)
                {
                    if(Context.Registers.FirstOrDefault(x=>x.StudentName== RegisterFromForm.StudentName && x.FathersName==RegisterFromForm.FathersName && x.PhoneNo == RegisterFromForm.PhoneNo && x.SchoolId==RegisterFromForm.SchoolId && x.EventId== RegisterFromForm.EventId) !=null)
                    {
                        return true;
                    }
                }
                else
                {
                    if (Context.Registers.FirstOrDefault(x => x.StudentName == RegisterFromForm.StudentName && x.FathersName == RegisterFromForm.FathersName && x.PhoneNo == RegisterFromForm.PhoneNo && x.SchoolId == RegisterFromForm.SchoolId && x.EventId == RegisterFromForm.EventId && x.Id != RegisterFromForm.Id) != null)
                    {
                        return true;
                    }
                }
            }
                return false;
        }
        
        public Register AddRegister(Register RegisterFromForm)
        {
            Register RegisterInfo = null;
            if (RegisterFromForm != null)
            {
                using (AccountContext AccountContext = new AccountContext())
                {
                    try
                    {
                        //roll no
                        Register Reg = AccountContext.Registers.FirstOrDefault(x => x.StudentName == RegisterFromForm.StudentName && x.FathersName == RegisterFromForm.FathersName && x.PhoneNo == RegisterFromForm.PhoneNo && x.SchoolId == RegisterFromForm.SchoolId);
                        if(Reg==null)
                        {
                            IList<RollNo> RollNoCK = AccountContext.RollNos.ToList();
                            RollNo RollNo = new RollNo();
                            RollNo.Number = ("R-" +(RollNoCK.Count==0? 1000 : (RollNoCK.OrderByDescending(x=>x.Id).First().Id + 1000)).ToString());
                            RollNo RollNoDB = AccountContext.RollNos.Add(RollNo);
                            if (RollNoDB != null)
                            {
                                RegisterFromForm.RollNo = RollNoDB.Number;
                            }
                        }
                        else
                        {
                            RegisterFromForm.RollNo = Reg.RollNo;
                        }

                        RegisterInfo = AccountContext.Registers.Add(RegisterFromForm);
                        AccountContext.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                        RegisterInfo = null;
                    }
                }
            }
            return RegisterInfo;

        }
        public Register UpdateRegister(Register RegisterFF)
        {
            Register Reginfo = null;
            try
            {
                using (AccountContext Context = new AccountContext())
                {
                    Reginfo = Context.Registers.Find(RegisterFF.Id);
                    if (Reginfo != null)
                    {
                        //rollno
                        Register Reg = Context.Registers.FirstOrDefault(x => x.StudentName == RegisterFF.StudentName && x.FathersName == RegisterFF.FathersName && x.PhoneNo == RegisterFF.PhoneNo && x.SchoolId == RegisterFF.SchoolId);
                        if (Reg != null)
                        {
                            RegisterFF.RollNo = Reg.RollNo;
                        }
                        else
                        {
                            RegisterFF.RollNo = Reginfo.RollNo;
                        }

                        Context.Entry(Reginfo).CurrentValues.SetValues(RegisterFF);
                        Context.SaveChanges();
                    }
                }                   
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
                return Reginfo;
        }
        public bool DeleteRegister(int Id)
        {
            bool Isdelete = false;
            using (AccountContext Context = new AccountContext())
            {
                Register Reginfo = Context.Registers.Where(i => i.Id == Id).FirstOrDefault();
                try
                {
                    if (Reginfo != null)
                    {
                        Context.Entry(Reginfo).State = EntityState.Deleted;
                        Context.SaveChanges();
                        Isdelete = true;
                    }                   
                }
                catch(Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            return Isdelete;
        }
    }
}
