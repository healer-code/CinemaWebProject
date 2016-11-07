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
    [Table("SeatMaintenances")]
    public class SeatMaintenance:Auditable
    {
        public int ID { get; set; }
        public int SeatID { get; set; }
        public int RoomID { get; set; }
        public string Description { get; set; }
        public string SeatStatus { get; set; }
    }
}
