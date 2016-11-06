using MegaCinemaModel.Abstracts;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MegaCinemaModel.Models
{
    [Table("Cinemas")]
    public class Cinema:Auditable
    {
        public int CinemaID { get; set; }
        public string CinemaPrefix { get; set; }
        public string CinemaCode { get; set; }
        public string CinemaFullName { get; set; }
        public string CinemaAddress { get; set; }
        public string CinemaPhone { get; set; }
        public string CinemaEmail { get; set; }
        public int CinemaManager { get; set; }
        public string CinemaStatus { get; set; }
    }
}
