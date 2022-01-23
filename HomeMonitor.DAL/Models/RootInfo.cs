using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeMonitor.DAL.Models
{
    public class RootInfo
    {
        [JsonProperty(PropertyName = "ApiSimple")]
        public BasicInfo ApiSimple { get; set; }
    }
}
