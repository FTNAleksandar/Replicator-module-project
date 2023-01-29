
using Replicator_Sender_Component.Interfaces;

namespace Replicator_Sender_Component_Test
{
    public class Tests
    {

        [Test]
        public void mockReplicatorSenderDataUsage()
        {
            Mock<IReplicatorSender> mock = new Mock<IReplicatorSender>();

            mock.Setup(p => p.getUsageDataFromWriter(new DataSet(1, 1234, "januar")));

        }

        [Test]
        public void mockReplicatorSenderDataUser()
        {
            Mock<IReplicatorSender> mock = new Mock<IReplicatorSender>();

            mock.Setup(p => p.getUserDataFromWriter(new DataSetUser(1, "Ime", "Ulica", 1, "Grad", "36000")));

        }

        
    }
}