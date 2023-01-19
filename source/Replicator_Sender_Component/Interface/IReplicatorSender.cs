using DataSet = Database_Component.DataSetModel.DataSet;
using Database_Component.DataSetModel;


namespace Replicator_Sender_Component.Interfaces
{
    public interface IReplicatorSender
    {
        void getUsageDataFromWriter(DataSet data);

        void getUserDataFromWriter(DataSetUser data);
    }
}
