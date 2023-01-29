namespace Writer_Component_Test
{
    [TestFixture]
    public class Tests
    {
        [Test]
        [TestCase()]
        [TestCase()]
        [TestCase()]
        [TestCase()]
        public void PassDataOk()
        {
            Mock<IWriter> mock = new Mock<IWriter>();
            mock.Setup(p => p.DataPassThrought(new DataSet()));
        }

        [Test]
        [TestCase(1, 50.2, "Januar")]
        [TestCase(2, 19.7, "Februar")]
        [TestCase(3, 78.0, "Mart")]
        [TestCase(4, 8.9, "Januar")]
        [TestCase(5, 69.1, "Januar")]
        [TestCase(6, 32.6, "Januar")]
        [TestCase(7, 12.4, "Januar")]
        [TestCase(8, 40.6, "Januar")]
        [TestCase(9, 21.3, "Januar")]
        [TestCase(10, 90.8, "Januar")]
        public void PassDataParams(int BrojiloId, decimal spentWater, string month)
        {
            DataSet dataset = new DataSet(BrojiloId, spentWater, month);


            Mock<IWriter> mock = new Mock<IWriter>();

            for (int i = 0; i < 8; i++)
            {
                // change field value
                dataset.BrojiloId = BrojiloId + i * 8;

                mock.Setup(p => p.DataPassThrought(dataset));
            }
        }

        [Test]
        [TestCase(1,153.5, null)]
       

        public void PassWrongParams(int BrojiloId, decimal spentWater, string month)
        {


            try
            {
                DataSet dataset = new DataSet(BrojiloId, spentWater, month);
                Mock<IWriter> mock = new Mock<IWriter>();

                for (int i = 0; i < 8; i++)
                {
                    // change field value
                    dataset.BrojiloId = BrojiloId + i * 8;

                    mock.Setup(p => p.DataPassThrought(dataset));
                }
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine(" NULL DATA PASSED");
            }
            catch (ArgumentException)
            {
                Console.WriteLine(" INVALID DATA PASSED");
            }
        }

    }
}