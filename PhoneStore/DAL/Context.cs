namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Context : DbContext
    {
       
        public Context()   : base("name=Context")
        {
        }

        public virtual DbSet<DALUser> Users { get; set; }
        public virtual DbSet<DALOrder> Orders { get; set; }
        public virtual DbSet<DALPhone> Phones { get; set; }

       
    }

   
}