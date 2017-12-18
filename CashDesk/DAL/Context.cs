using CashDesk.DTO;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CashDesk.DAL
{
    public class Context : DbContext
    {
        public Context() : base("DefaultConnection")
        {
            Database.SetInitializer<Context>(new ContextInitializer());
        }

        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Article> Articles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            //modelBuilder.Conventions.Add<OneToManyCascadeDeleteConvention>();
            
            //base.OnModelCreating(modelBuilder);
            /*
            modelBuilder.Entity<Offre>()
            .HasRequired(i => i.articles)
            .WithMany()
            .HasForeignKey(i => i.articles)
            .WillCascadeOnDelete(true); //the one

            modelBuilder.Entity<Article>()
            .HasRequired(i => i.offres)
            .WithMany()
            .HasForeignKey(i => i.offres)
            .WillCascadeOnDelete(true); //the one
            */
        }


    }

    public class ContextInitializer : DropCreateDatabaseIfModelChanges<Context>
    {
        protected override void Seed(Context context)
        {
            base.Seed(context);
            /*
           Article[] Articles =
           {

               new Article { Reference="KDL32W510", Designation="TV 102CM SONY LED F-HD", Qte=1, PuTTC=295.99},
               new Article { Reference="WALL2205B", Designation="SUPPORT MURAL", Qte=1, PuTTC=129},
               new Article { Reference="61002910", Designation="MONTRE CONNECTEE FITBIT IONIC", Qte=1, PuTTC=349.95},
               new Article { Reference="31000987", Designation="AMPLI YAMAHA RDC-450B", Qte=1, PuTTC=349.95},
               new Article { Reference="45006743", Designation="TUNER RADIO CD DENON YSP-677", Qte=1, PuTTC=455},
               new Article { Reference="41004534", Designation="TABLETTE APPLE IPAD 9.7", Qte=1, PuTTC=399},
               new Article { Reference="T0130", Designation="GARANTIE ETENDUE 3 ANS", Qte=1, PuTTC=49.00}
            };
            
            foreach (Article article in Articles)
            {
                context.Articles.Add(article);
            }
            */
        }
    }
}
