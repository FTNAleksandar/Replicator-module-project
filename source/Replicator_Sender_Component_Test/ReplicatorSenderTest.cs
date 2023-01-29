
namespace Replicator_Sender_Component_Test
{
    public class Tests
    {

        [Test]
        [TestCase(null)]
        public void getUsageDataFromWriter(DataSet data)
        {
            ReplicatorSenderImpl rs = new ReplicatorSenderImpl();

            Assert.Throws<ArgumentNullException>(() =>
            {

                rs.getUsageDataFromWriter(data);

            });

        }

        [Test]
        [TestCase(null)]
        public void getUserDataFromReplicatorSenderTest(DataSetUser data)
        {
            ReplicatorSenderImpl rs = new ReplicatorSenderImpl();

            Assert.Throws<ArgumentNullException>(() =>
            {

                rs.getUserDataFromWriter(data);

            });

        }
    }
}