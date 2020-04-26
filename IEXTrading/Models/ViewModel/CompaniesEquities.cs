using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IEXTrading.Models.ViewModel
{
    public class CompaniesEquities
    {
        public List<Company> Companies { get; set; }
        public List<Equity> Equities { get; set; }
        public Equity Current { get; set; }
        public string Date { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public string Race { get; set; }
        public string Location { get; set; }
        public string Description_of_injury { get; set; }
        public string Cause_of_Death { get; set; }
        public string Manner_of_Death { get; set; }
        public CompaniesEquities(List<Company> companies, string date, int age, string sex, string race, string location, string descriptionofinjury, string cod, string mannerofdeath)
        {
            Companies = companies;
            Date = date;
            Age = age;
            Sex = sex;
            Race = race;
            Location = location;
            Description_of_injury = descriptionofinjury;
            Cause_of_Death = cod;
            Manner_of_Death = mannerofdeath;
        }
    }
}
