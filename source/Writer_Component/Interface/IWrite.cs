using Replicator.DataSetModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Writer.Interface
{
    internal interface IWrite
    {
         void DataPassThrought(DataSet data);
    }
}
