using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace HospitalfinderApp.Models
{
    //public class HospitalModel
    //{
    //    public int id { get; set; }

    //    [JsonProperty("Value")]
    //    public string name { get; set; }
    //    public WaitingListModel waitingList { get; set; }
    //    public LocationModel location { get; set; }
    //}

    public partial class HospitalModel
    {
        [JsonProperty("hospitals")]
        public List<Hospital> Hospitals { get; set; }
    }

    public partial class Hospital
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("waitingList")]
        public List<WaitingList> WaitingList { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }
    }

    public partial class Location
    {
        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lng")]
        public double Lng { get; set; }
    }

    public partial class WaitingList
    {
        [JsonProperty("patientCount")]
        public long PatientCount { get; set; }

        [JsonProperty("levelOfPain")]
        public long LevelOfPain { get; set; }

        [JsonProperty("averageProcessTime")]
        public long AverageProcessTime { get; set; }
    }
}
