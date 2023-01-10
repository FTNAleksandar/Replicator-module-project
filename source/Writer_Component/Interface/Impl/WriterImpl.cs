using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Replicator;
using Replicator.DataSetModel;
using Replicator_Component.DataSetModel;

namespace Writer.Interface.Impl
{
    internal class WriterImpl : IWrite
    {
        public void DataPassThrought(DataSet data)
        {
            //TODO replicator
            throw new NotImplementedException();
        }

        public void UserDataPassThrought(DataSetUser data)
        {
            //TODO replicator
            throw new NotImplementedException();
        }
    }
}
