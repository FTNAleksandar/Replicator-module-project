using System;
using DataSet = Database_Component.DataSetModel.DataSet;
using Database_Component.DataSetModel;
using Replicator_Sender_Component.Interface.Impl;
using static System.Net.Mime.MediaTypeNames;
using System.Threading.Tasks;

namespace Replicator_Sender_Component.Interfaces.Impl
{
    public class ReplicatorSenderImpl : IReplicatorSender
    {
        public async void getUsageDataFromWriter(DataSet data)
        {
            IReplicatorReceiver replicatorReceiver = new ReplicatorReceiverImpl();
            await Task.Delay(2000);     //Wait 2seconds
            replicatorReceiver.getUsageDataFromReplicatorSender(data);
        }

        public async void getUserDataFromWriter(DataSetUser data)
        {
            IReplicatorReceiver replicatorReceiver = new ReplicatorReceiverImpl();
            await Task.Delay(2000);     //Wait 2seconds
            replicatorReceiver.getUserDataFromReplicatorSender(data);
        }

     
    }
}
