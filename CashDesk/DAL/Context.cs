using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using CashDesk.DTO;

namespace CashDesk.DAL
{
    public class Context : DbContext
    {
        public DbSet<Article> articles { get; set; }

        public Context() : base("DefaultConnection")
        {
            Database.SetInitializer<Context>(new ContextInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Article>();
            
        }

        public class ContextInitializer : DropCreateDatabaseIfModelChanges<Context>
        {
            protected override void Seed(Context context)
            {
                base.Seed(context);

                Article[] Articles =
            {
                /*
                new Article { Reference="KDL32W510", Designation="TV 102CM SONY LED F-HD", Qte=1, PuTTC=295.99, offres=Offres[0]},
                new Article { Reference="WALL2205B", Designation="SUPPORT MURAL", Qte=1, PuTTC=129, offres=Offres[0]},
                new Article { Reference="61002910", Designation="MONTRE CONNECTEE FITBIT IONIC", Qte=1, PuTTC=349.95, offres=Offres[1]},
                new Article { Reference="31000987", Designation="AMPLI YAMAHA RDC-450B", Qte=1, PuTTC=349.95, offres=Offres[2]},
                new Article { Reference="45006743", Designation="TUNER RADIO CD DENON YSP-677", Qte=1, PuTTC=455, offres=Offres[2]},
                new Article { Reference="41004534", Designation="TABLETTE APPLE IPAD 9.7", Qte=1, PuTTC=399, offres=Offres[3]},
                new Article { Reference="T0130", Designation="GARANTIE ETENDUE 3 ANS", Qte=1, PuTTC=49.00, offres=Offres[3]}
                */
            };

                foreach (Article article in Articles)
                {
                    context.articles.Add(article);
                }
            }
        }
    }
}
