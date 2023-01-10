using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Replicator.DataSetModel
{
    public class DataSet
    {
        public int BrojiloId { get; set; }
        public decimal SpentWater { get; set; }
        public string Month { get; set; }

        public DataSet(int brojiloId, decimal spentWater, string month)
        {
            BrojiloId = brojiloId;
            SpentWater = spentWater;
            Month = month;
        }

        public DataSet()
        {
        }
    }
}
