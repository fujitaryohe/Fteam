using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampApp.Models
{
    public class SubscriptionModel
    {
        public string name { get; set; }
        public string furigana { get; set; }
        public bool gender { get; set; }
        public string birthday { get; set; }
        public string ID { get; set; }
        public string rePassword { get; set; }
        public string address { get; set; }
        public string phonenum { get; set; }
        public string mail { get; set; }
    }
}