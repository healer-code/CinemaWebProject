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
        public int SeatID { get; set; }
        public int SeatTypeID { get; set; }
        public string SeatPrefix { get; set; }
        public string SeatCode { get; set; }
        public string SeatName { get; set; }
        public int SeatCouple { get; set; }
        public int SeatRoomID { get; set; }
        public int SeatRow { get; set; }
        public int SeatColumn { get; set; }
        public string SeatStatus { get; set; }
    }
}
