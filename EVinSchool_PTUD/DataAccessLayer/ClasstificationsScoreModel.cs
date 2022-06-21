using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ClasstificationsScoreModel
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public decimal? Math { get; set; }
        public decimal? Vietnamese { get; set; }
        public decimal? English { get; set; }
        public decimal? Morality { get; set; }
        public decimal? NatureSocial { get; set; }
        public decimal? HistoryGeography { get; set; }
        public decimal? Music { get; set; }
        public decimal? Arts { get; set; }
        public decimal? Sports { get; set; }
        public decimal? Attendance { get; set; }
        public decimal? Total { get; set; }
        public string Result { get; set; }
    }
}
