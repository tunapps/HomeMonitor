using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeMonitor.DAL.Models
{
    public class BasicInfo
    {
        [JsonProperty(PropertyName = "rPumpTT07")] // aktualní teplota vnitrniho cidla
        public double IndoorTemp { get; set; }
        [JsonProperty(PropertyName = "rPumpTT06")] // aktualni teplota teple vody
        public double WarmWaterTemp { get; set; }
        [JsonProperty(PropertyName = "rPumpTT04")] // teplota otopne vody v podlaze
        public double FloorWaterTemp { get; set; }
        [JsonProperty(PropertyName = "rPumpTT08")] // aktualni teplota venkovniho cidla
        public double OutdoorTemp { get; set; }
        [JsonProperty(PropertyName = "rPvBatteryCapacity")]
        public double BatteryCapacity { get; set; }
        [JsonProperty(PropertyName = "rPvBatteryPower")]
        public double BatteryPower { get; set; } // aktualni vydej/prijem z/do baterie
        [JsonProperty(PropertyName = "rPvSolarPower")]
        public double SolarPower { get; set; } //aktualní výroba z panelů
        [JsonProperty(PropertyName = "rPvOutPower")]
        public double OutPower { get; set; } // Aktuální odběr elektřiny baráku
        [JsonProperty(PropertyName = "rPvGridPower")]
        public double GridPower { get; set; } // Aktuální odběr z venkovní sítě
        [JsonProperty(PropertyName = "rPVSolarOpportunity")]
        public double SolarOpportunity { get; set; } // Aktuální odběr elektřiny baráku
    }
}
