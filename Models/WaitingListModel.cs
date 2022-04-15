using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalfinderApp.Models
{
    public class WaitingListModel
    {
        public int patientCount { get; set; }
        public int levelOfPain { get; set; }
        public int avgProcessTime { get; set; }
    }
}
