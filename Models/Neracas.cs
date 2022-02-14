using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Arafah_Honey.Models
{
    public class Neracas
    {
        [Key,Column(TypeName = "varchar(50)"),DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string neraca_id { get; set; }
        [Required]
        public DateTime tanggal_neraca { get; set; }
        [Required,Column(TypeName = "varchar(MAX)"),DataType(DataType.MultilineText)]
        public string keterangan { get; set; }
        [Required, Column(TypeName = "varchar(1)")]
        public String debitkredit { get; set; }
        [Required, Column(TypeName = "Decimal(18,2)")]
        public decimal QTY { get; set; }
        [Required,Column(TypeName = "Decimal(18,2)")]
        public decimal nominal { get; set; }
    }
}
