using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MegaCinemaModel.Abstracts;
using System.ComponentModel;

namespace MegaCinemaModel.Models
{
    [Table("AccountTypes")]
    public class AccountType:Auditable
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TypeID { get; set; }

        [Required, DataType("nvarchar"),MaxLength(100)]
        public string TypeName { get; set; }

        [Required,DefaultValue(0)]
        public int TypePoint { get; set; }

        [Required, DefaultValue(0)]
        public decimal TypeDiscount { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
    }
}
