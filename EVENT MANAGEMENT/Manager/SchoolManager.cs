using EVENT_MANAGEMENT.Context;
using EVENT_MANAGEMENT.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVENT_MANAGEMENT.Manager
{
    public class SchoolManager
    {
        private static volatile SchoolManager instance;
        private static object syncRoot = new Object();
        public Boolean AddSchoolInfo(School School)
        {
            Boolean Added = false;
            using (AccountContext Context = new AccountContext())
            {
                using (var dbContextTransaction = Context.Database.BeginTransaction())
                {
                    try
                    {
                        if (School.Id == 0)
                        {
                            School SchoolInfo = Context.Schools.Add(School);
                            Context.SaveChanges();
                            dbContextTransaction.Commit();
                            Added = true;
                        }                       
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Added = false;
                        dbContextTransaction.Rollback();
                        throw e;
                    }
                }
                return Added;
            }
            
           
           
        }
        public School GetSchoolByName(String Name)
        {
            School SchoolInfo = null;
            using (AccountContext Context = new AccountContext())
            {
                SchoolInfo = Context.Schools.FirstOrDefault(x => x.Name == Name);
                return SchoolInfo;
            }
        }
        public School GetSchoolById(int Id)
        {
            School SchoolInfo = null;
            using (AccountContext Context = new AccountContext())
            {
                SchoolInfo = Context.Schools.Find(Id);
                return SchoolInfo;
            }
        }
        public School CheckSchoolNameInUpdate(String Name, int Id)
        {
           School SchoolInfo = null;
            using (AccountContext Context = new AccountContext())
            {
                SchoolInfo = Context.Schools.FirstOrDefault(x => x.Name ==Name && !x.Id.Equals(Id));
                return SchoolInfo;
            }
        }
        public School UpdateSchool(School School)
        {
            School SchoolInfo = null;
            using (AccountContext Context = new AccountContext())
            {
                SchoolInfo = Context.Schools.Find(School.Id);
                using (var dbContextTransaction = Context.Database.BeginTransaction())
                {
                    try
                    {
                        if (SchoolInfo != null)
                        {
                            Context.Entry(SchoolInfo).CurrentValues.SetValues(School);
                            Context.SaveChanges();
                            dbContextTransaction.Commit();
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        SchoolInfo = null;
                        dbContextTransaction.Rollback();
                        throw (e);
                    }
                }
            }
            return SchoolInfo;
        }
        public static SchoolManager Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new SchoolManager();
                    }
                }

                return instance;
            }
        }
        public IList<School> GetAllSchools()
        {
            using (AccountContext Context = new AccountContext())
            {
                IList<School> SchoolInfo = Context.Schools.ToList<School>();
                return SchoolInfo;
            }
        }
        public Boolean DeleteSchool(int Id)
        {
            Boolean Deleted = false;
            School SchoolInfo = null;
            using (AccountContext Context = new AccountContext())
            {
                using (var dbContextTransaction = Context.Database.BeginTransaction())
                {
                    try
                    {
                        SchoolInfo = Context.Schools.Find(Id);
                        Context.Schools.Remove(SchoolInfo);
                        Context.SaveChanges();
                        dbContextTransaction.Commit();
                        Deleted = true;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Deleted = false;
                        dbContextTransaction.Rollback();
                        throw (e);
                    }
                }
            }
            return Deleted;
        }
        //public IList<School> GetAllGeneralAccountsByCompanyId(long CompanyId)
        //{
        //    using (AccountContext Context = new AccountContext())
        //    {
        //        IList<School> SchoolInfo = (from School in Context.Schools.Include("SchoolGroup") where School.Id ==CompanyId).OrderBy(y => y.Name).ToList();
        //        return SchoolInfo;
        //    }
        //}

    }
}
