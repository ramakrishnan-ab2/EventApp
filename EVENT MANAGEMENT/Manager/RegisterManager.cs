
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
        public Register GetRegisterById(long RegisterId)
        {
            Register RegisterInfo = null;
            using (AccountContext Context=new AccountContext())
            {
                RegisterInfo = Context.Registers.Find(RegisterId);
                if (RegisterInfo != null)
                {
                    RegisterInfo = Context.Registers.Include("StudentName").Include("PhoneNo").Include("FathersName").FirstOrDefault(x => x.Id == RegisterId);
                }
                return RegisterInfo;
            }
        }
        public Register AddRegisterInfo(Register Register)
        {
            Register RegisterInfo = null;
            using (AccountContext Context = new AccountContext())
            {
                using (var dbContextTransaction = Context.Database.BeginTransaction())
                {
                    try
                    {
                        RegisterInfo = Context.Registers.Add(Register);
                        Context.SaveChanges();
                        dbContextTransaction.Commit();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        RegisterInfo = null;
                        dbContextTransaction.Rollback();
                        throw (e);
                    }
                }
            }
            return RegisterInfo;
        }
        public Register UpdateRegister(Register Register)
        {


            Register RegisterInfo = null;
            using (AccountContext Context = new AccountContext())
            {
                RegisterInfo = Context.Registers.Find(Register.Id);
                using (var dbContextTransaction = Context.Database.BeginTransaction())
                {
                    try
                    {
                        if (RegisterInfo != null)
                        {
                            Context.Entry(RegisterInfo).CurrentValues.SetValues(Register);
                            Context.SaveChanges();

                            Register SupplierInfoFromDB = GetRegisterById(Register.Id);


                            Context.Entry(SupplierInfoFromDB).State = EntityState.Modified;

                            Context.SaveChanges();
                        }

                            dbContextTransaction.Commit();
                        
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        RegisterInfo = null;
                        dbContextTransaction.Rollback();
                        throw (e);
                    }
                }
            }
            return RegisterInfo;
        }
        public bool DeleteRegister(long RegisterId)
        {

            bool deleted = false;
            using (AccountContext context = new AccountContext())
            {
                using (var dbContextTransaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        Register Register = context.Registers.Include("FathersName").Include("PhoneNo").Include("StudentName").Include("Qualification").Where(p => p.Id== RegisterId).First<Register>();

                        //if (Register != null)
                        //{
                        //    if (Register.StudentName != null)
                        //    {
                        //        context.Registers.Where(Badd => Badd.StudentName== Register.StudentName).ToList().ForEach(Badd => context.Registers.Remove(Badd));
                        //    }
                        //    if (Register.PhoneNo!= null)
                        //    {
                        //        context.ContactInfos.Where(ci => ci.Id == Register.ContactInfo.Id).ToList().ForEach(ci => context.ContactInfos.Remove(ci));
                        //    }
                        //    if (Register.ShippingAddress != null)
                        //    {
                        //        context.Addresses.Where(Sadd => Sadd.AddressId == Register.ShippingAddress.AddressId).ToList().ForEach(Sadd => context.Addresses.Remove(Sadd));
                        //    }

                        //    if (Register.RegisterLicenceDetail.Count > 0)
                        //    {
                        //        context.RegisterLicenceDetails.Where(p => p.RegisterId == Register.Id).ToList().ForEach(p => context.RegisterLicenceDetails.Remove(p));
                        //    }

                        //}
                        context.Registers.Remove(Register);
                        context.SaveChanges();
                        dbContextTransaction.Commit();
                        deleted = true;
                    }
                    catch (Exception e)
                    {
                        dbContextTransaction.Rollback();
                        deleted = false;
                    }
                }
            }
            return deleted;
        }
    }
}
