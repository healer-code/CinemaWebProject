using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MegaCinemaModel.Abstracts;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MegaCinemaModel.Models
{
    [Table("SeatLists")]
    public class SeatList:Auditable
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SeatID { get; set; }

        [Required]
        public int SeatTypeID { get; set; }

        [Required, DataType("nvarchar"), MaxLength(3), DefaultValue("SEA")]
        public string SeatPrefix { get; set; }

        [DataType("nvarchar"), MaxLength(100), DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string SeatCode { get; set; }

        [Required, DataType("nvarchar"), MaxLength(100)]
        public string SeatName { get; set; }

        public int SeatCouple { get; set; }

        [Required]
        public int SeatRoomID { get; set; }

        [Required]
        public int SeatRow { get; set; }

        [Required]
        public int SeatColumn { get; set; }

        [Required, DataType("nvarchar"), MaxLength(3)]
        public string SeatStatus { get; set; }

        public virtual SeatList SeatDetailCouple { get; set; }

        [ForeignKey("SeatStatus")]
        public virtual Status Status { get; set; }

    }
}
