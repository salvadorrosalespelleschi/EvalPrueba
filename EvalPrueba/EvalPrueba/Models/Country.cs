using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Profile;

namespace EvalPrueba.Models
{
    public class GeoRef {
        [Required]
        [Range(-90,90)]
        public double Lat { get; set; }
        [Required]
        [Range(-180,180)]
        public double Lng { get; set; }
    }

    public class Currency {
        [Required]
        public string Code { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Symbol { get; set; }
    }
    public class Country
    {
        [Key]
        [Required]
        [StringLength(150,MinimumLength=3,ErrorMessage = "Nombre no valido")]
        public string Name { get; set; }
        [Required]
        [StringLength(150,MinimumLength = 3,ErrorMessage = "Nombre no valido")]
        public string Capital { get; set; }
        [Required]
        [Range(1,400000000000)]
        public int Population { get; set; }
        [Required]
        public List<GeoRef> LatLng { get; set; }
        [Required]
        public List<String> Timezones { get; set; }
        [Required]
        public List<Currency> Currencies { get; set; }
        [Required]
        [RegularExpression("/https?://(?:[-w]+.)?([-w]+).w+(?:.w+)?/?.*/i")]
        public string Flag { get; set; }
    }
}