using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalfinderApp.Models
{
    public class SeverityModel
    {
        public enum Severity :int {
            VeryLow=0,
            Low=1,
            Medium=2,
            High=3,
            VeryHigh=4
        }
    }
}
