using DLWMS.WinForms.P10;

using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DLWMS.WinForms.DB
{

    //DLWMSContext
    internal class KonekcijaNaBazu : DbContext
    {

        public KonekcijaNaBazu() : base("DLWMSPutanja")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Kandidat>().ToTable("Kandidati");
            modelBuilder.Entity<P7.Student>().ToTable("Studenti");


            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

        }



        public DbSet<Kandidat> Kandidati { get; set; }
        public DbSet<P7.Student> Studenti { get; set; }


    }
}