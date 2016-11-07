﻿using System;
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
    [Table("SeatTypes")]
    public class SeatType:Auditable
    {
        public int SeatTypeID { get; set; }
        public string SeatTypeName { get; set; }
        public decimal SeatTypeSurcharge { get; set; }
        public string SeatTypeStatus { get; set; }
    }
}
