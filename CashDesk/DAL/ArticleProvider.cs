using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CashDesk.DTO;

namespace CashDesk.DAL
{
    public class ArticleProvider
    {
        /// <summary>
        /// Recupère la liste de toutes les entités
        /// </summary>
        /// <returns>La Liste de toutes les entités</returns>
        public List<Article> GetAll()
        {
            using (Context context = new Context())
            {
                try
                {
                    return context.Articles.ToList();
                }
                catch
                {
                    throw;
                }
            }
        }

        public int CountAll()
        {
            using (Context context = new Context())
            {
                try
                {
                    return context.Articles.Count();
                }
                catch
                {
                    throw;
                }
            }
        }
    }
}
