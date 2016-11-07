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
    [Table("RoomFilms")]
    public class RoomFilm:Auditable
    {
        public int RoomID { get; set; }
        public string RoomPrefix { get; set; }
        public string RoomCode { get; set; }
        public string RoomName { get; set; }
        public string RoomSeatPosition { get; set; }
        public string RoomCinemaDescription { get; set; }
        public string RoomPoster { get; set; }
        public int RoomCinemaID { get; set; }
        public string RoomStatus { get; set; }
    }
}
