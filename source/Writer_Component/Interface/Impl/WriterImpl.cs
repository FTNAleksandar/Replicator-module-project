
using Replicator_Sender_Component.Interfaces;
using Replicator_Sender_Component.Interfaces.Impl;
using DataSet = Database_Component.DataSetModel.DataSet;
using Database_Component.DataSetModel;

namespace Writer_Component.Interface.Impl
{
    public class WriterImpl : IWriter
    {
        public void DataPassThrought(DataSet data)
        {

            IReplicatorSender replicatorSender = new ReplicatorSenderImpl();
            replicatorSender.getUsageDataFromWriter(data);

        }

        public void UserDataPassThrought(DataSetUser data)
        {

            IReplicatorSender replicatorSender = new ReplicatorSenderImpl();
            replicatorSender.getUserDataFromWriter(data);

        }
    }
}
