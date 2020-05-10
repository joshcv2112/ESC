using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading.Tasks;

namespace MotoInventory.Models
{
    public class MotorcycleInfo
    {
        [Required]
        public string VINNumber { get; set; }
        [Required]
        public string ESCNumber { get; set; }
        public string Owner { get; set; }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string TurnInDate { get; set; }
        public string DateAcquired { get; set; }
        public string EngineCC { get; set; }
        public string SiteID { get; set; }
        public string SiteLocation { get; set; }
        public string PurchasePrice { get; set; }
        public string CurrentValue { get; set; }

    }
}
