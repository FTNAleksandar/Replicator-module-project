using DataSet = Database_Component.DataSetModel.DataSet;
using Database_Component.DataSetModel;

namespace Replicator_Sender_Component
{
    public interface IReplicatorReceiver
    {
        void getUsageDataFromReplicatorSender(DataSet data);

        void getUserDataFromReplicatorSender(DataSetUser data);
    }
}
