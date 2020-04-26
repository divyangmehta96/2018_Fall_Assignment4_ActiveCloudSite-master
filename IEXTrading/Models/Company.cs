 using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace IEXTrading.Models
{
    public class Company
    {
        

        [Key]
        public string date { get; set; }
        public int age { get; set; }
        public string sex { get; set; }
        public string race { get; set; }
        public string location { get; set; }
        public string descriptionofinjury { get; set; }
        public string cod { get; set; }
        public string mannerofdeath { get; set; }
        public List<Equity> Equities {get; set; }
    }
}
