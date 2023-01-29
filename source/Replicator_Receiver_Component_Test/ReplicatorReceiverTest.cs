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
    }
}