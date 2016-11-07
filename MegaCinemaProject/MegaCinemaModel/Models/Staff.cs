using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MegaCinemaModel.Abstracts;

namespace MegaCinemaModel.Models
{
    [Table("Staffs")]
    public class Staff:Auditable
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StaffID { get; set; }

        [Required, DataType("nvarchar"), MaxLength(3), DefaultValue("STF")]
        public string StaffPrefix { get; set; }

        [DataType("nvarchar"), MaxLength(100), DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string StaffCode { get; set; }

        [Required, DataType("nvarchar"), MaxLength(100)]
        public string StaffFirstName { get; set; }

        [Required, DataType("nvarchar"), MaxLength(100)]
        public string StaffLastName { get; set; }

        [Required]
        public DateTime StaffBirthday { get; set; }

        [Required, DefaultValue(true)] //male
        public bool StaffSex { get; set; }

        [Required, DataType("varchar"), MaxLength(12)]
        public string StaffSSN { get; set; }

        [Required, DataType("varchar"), MaxLength(12)]
        public string StaffPhone { get; set; }

        [Required, DataType("nvarchar"), MaxLength(100)]
        public string StaffAddress { get; set; }

        [DataType("nvarchar"), MaxLength(100)]
        public string StaffDistrict { get; set; }

        [DataType("nvarchar"), MaxLength(100)]
        public string StaffCity { get; set; }

        [Required, DataType("nvarchar"), MaxLength(100)]
        public string StaffEmail { get; set; }

        [Required, DataType("nvarchar"), MaxLength(100)]
        public string StaffPassword { get; set; }

        [DataType("nvarchar"), MaxLength(100)]
        public string StaffAvatar { get; set; }

        [Required]
        public int StaffRegencyID { get; set; }

        [Required, DataType("nvarchar"), MaxLength(3)]
        public string StaffStatus { get; set; }

        [ForeignKey("StaffRegencyID")]
        public virtual Regency Regency { get; set; }

        [ForeignKey("StaffStatus")]
        public virtual Status Status { get; set; }

        public virtual Cinema Cinema { get; set; }
    }
}
