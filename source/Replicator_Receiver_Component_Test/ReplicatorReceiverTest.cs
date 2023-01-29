using Replicator_Sender_Component;
using Replicator_Sender_Component.Interface.Impl;

namespace Replicator_Receiver_Component_Test
{
    [TestFixture]
    public class Tests
    {

       [Test]
       [TestCase(null)]
       public void getUsageDataFromReplicatorSenderTest(DataSet data)
        {
            ReplicatorReceiverImpl rr = new ReplicatorReceiverImpl();

            Assert.Throws<ArgumentNullException>(() =>
            {

                rr.getUsageDataFromReplicatorSender(data);

            });

        }

        [Test]
        [TestCase(null)]
        public void getUserDataFromReplicatorSenderTest(DataSetUser data)
        {
            ReplicatorReceiverImpl rr = new ReplicatorReceiverImpl();

            Assert.Throws<ArgumentNullException>(() =>
            {

                rr.getUserDataFromReplicatorSender(data);

            });

        }
        public void mockReplicatorReceiverDataUsage()
        {
            Mock<IReplicatorReceiver> mock = new Mock<IReplicatorReceiver>();

            mock.Setup(p => p.getUsageDataFromReplicatorSender(new DataSet(1, 1234, "januar")));

        }

        public void mockReplicatorReceiverDataUser()
        {
            Mock<IReplicatorReceiver> mock = new Mock<IReplicatorReceiver>();

            mock.Setup(p => p.getUserDataFromReplicatorSender(new DataSetUser(1, "Ime", "Ulica", 1, "Grad", "36000")));
            

        }
    }
}