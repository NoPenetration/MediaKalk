using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaKalk
{
    public enum Periodicity { weekly, two_weeks, three_weeks, mounthly, bi_mounthly, quaterly, half_year, annual}
    class FixedFees
    {
        public int Id { get; set; }
        public int PrId { get; set; }
        public string Name { get; set; }
        public DateTime PeriodFrom { get; set; }
        public DateTime PeriodTo { get; set; }
        public double TheGrossAmount { get; set; }
        public Periodicity Periodicity { get; set; }

        public FixedFees()
        {

        }
        public FixedFees(int prId, string name, DateTime periodFrom, DateTime periodTo, double theGrossAmount, Periodicity periodicity):this()
        {
            PrId = prId;
            Name = name;
            PeriodFrom = periodFrom;
            PeriodTo = periodTo;
            TheGrossAmount = theGrossAmount;
            Periodicity = periodicity;
        }
    }
}
