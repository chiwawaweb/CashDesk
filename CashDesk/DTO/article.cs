using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CashDesk.DTO
{
    public class Article
    {
        // data
        [Key]
        [Column("ID")]
        public int? Id { get; set; }
        [Column("REFERENCE")]
        public string Reference { get; set; }
        [Column("DESIGNATION")]
        public string Designation { get; set; }
        [Column("QTE")]
        public int Qte { get; set; }
        [Column("PUTTC")]
        public double PuTTC { get; set; }
        [Required]
        [Column("OFFRE_ID")]
        public int OffreId { get; set; }
        /*
        [Required]
        [ForeignKey("OffreId")]
        public virtual Offre offres { get; set; }
    */    
    [ConcurrencyCheck]
        [Column("VERSIONING")]
        public int? Versioning { get; set; }
    }
}
