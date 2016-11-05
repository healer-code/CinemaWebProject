using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MegaCinemaModel.Abstracts;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MegaCinemaModel.Models
{
    [Table("Statuss")]
    public class Status:Auditable
    {
        [Key]
        [DataType("nvarchar")]
        [MaxLength(3)]
        public string StatusID { get; set; }

        [DataType("nvarchar")]
        [MaxLength(100)]
        public string StatusName { get; set; }
    }
}
