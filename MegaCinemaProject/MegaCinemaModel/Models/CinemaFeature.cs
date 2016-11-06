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
    [Table("CinemaFeatures")]
    public class CinemaFeature:Auditable
    {
        public int FeatureID { get; set; }
        public bool FeatureType { get; set; }
        public string FeatureContent { get; set; }
        public string FeatureDescription { get; set; }
    }
}
