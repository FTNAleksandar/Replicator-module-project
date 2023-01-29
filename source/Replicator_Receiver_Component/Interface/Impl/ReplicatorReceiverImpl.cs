using DataSet = Database_Component.DataSetModel.DataSet;
using Database_Component.DataSetModel;
using System;
using Reader_Component.Interface;
using Reader_Component.Interface.Impl;

namespace Replicator_Sender_Component.Interface.Impl
{
    public class ReplicatorReceiverImpl : IReplicatorReceiver
    {
        public void getUsageDataFromReplicatorSender(DataSet data)
        {
            if (data == null)
            {
                throw new ArgumentNullException();
            }

            IReader reader = new ReaderImpl();
            reader.InsertDataSet(data);
        }

        public void getUserDataFromReplicatorSender(DataSetUser data)
        {
            if (data == null)
            {
                throw new ArgumentNullException();
            }

            IReader reader = new ReaderImpl();
            reader.InsertDataSetUser(data);
        }
    }
}
