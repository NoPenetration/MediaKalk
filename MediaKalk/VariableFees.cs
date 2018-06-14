using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaKalk
{
    class VariableFees
    {
        public int Id { get; set; }
        public int PrId { get; set; }
        public string Name { get; set; }
        public DateTime PeriodFrom { get; set; }
        public DateTime PeriodTo { get; set; }
        public double TheGrossAmount { get; set; }
        public int AccuntNumber { get; set; }

        public VariableFees()
        {

        }
        public VariableFees(int prId, string name, DateTime periodFrom, DateTime periodTo, double theGrossAmount):this()
        {
            PrId = prId;
            Name = name;
            PeriodFrom = periodFrom;
            PeriodTo = periodTo;
            TheGrossAmount = theGrossAmount;
        }
        public VariableFees(int prId, string name, DateTime periodFrom, DateTime periodTo, double theGrossAmount, int accuntNumber) : this(prId, name, periodFrom, periodTo, theGrossAmount)
        {
            this.AccuntNumber = accuntNumber;
        }
    }
}
