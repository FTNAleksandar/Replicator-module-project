

namespace Database_Component_Test
{
    [TestFixture]
    public class Tests
    {
    

        [Test]
        [TestCase()]
        public void DatasetTest()
        {
            DataSet data = new DataSet();

            Assert.NotNull(data);
        }

        [Test]
        [TestCase(1, 120, "januar")]
        [TestCase(2, 45.2, "februar")]
        [TestCase(3, 142.1, "mart")]
        
        public void DatasetParamsTest(int BrojiloId, decimal spentWater, string month)
        {
            DataSet data = new DataSet(BrojiloId, spentWater, month);

            Assert.NotNull(data);
        }

        [Test]
        [TestCase(1, 12, null)]
       
        public void DatasetParamsNullTest(int BrojiloId, decimal spentWater, string month)
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                DataSet data = new DataSet(BrojiloId, spentWater, month);

            });
        }

        [Test]
        [TestCase()]
        public void PropertyTests()
        {
            DataSet data = new DataSet();

            data.BrojiloId = 1;
            data.SpentWater = 45;
            data.Month = "test";
           

            Assert.AreEqual(1, data.BrojiloId);
            Assert.AreEqual(45, data.SpentWater);
            Assert.AreEqual("test", data.Month);
         
        }

        [Test]
        [TestCase()]
        public void DatasetUserTest()
        {
            DataSetUser data = new DataSetUser();

            Assert.NotNull(data);
        }

        [Test]
        [TestCase(1,"Ime", "Ulica", 1,"Novi Sad","21000")]
        [TestCase(2, "Ime1", "Ulica3", 15, "Beograd", "11000")]
        [TestCase(3, "Ime2", "Ulica5", 4561, "Kraljevo", "36000")]

        public void DatasetUserParamsTest(int brojiloId, string userName, string userStreet, int userStreetNo, string userCity, string userZip)
        {
            DataSetUser data = new DataSetUser(brojiloId, userName, userStreet, userStreetNo, userCity, userZip);
            
            Assert.NotNull(data);
        }

        [Test]
        [TestCase(1, null, "Ulica", 1, "Novi Sad", "21000")]
        [TestCase(2, "Ime1", null, 15, "Beograd", "11000")]
        [TestCase(3, "Ime2", "Ulica5", 4561, null, "36000")]
        [TestCase(3, "Ime2", "Ulica5", 4561, null, null)]
        public void DatasetUserParamsNullTest(int brojiloId, string userName, string userStreet, int userStreetNo, string userCity, string userZip)
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                DataSetUser data = new DataSetUser(brojiloId, userName, userStreet, userStreetNo, userCity, userZip);

            });
        }

        [Test]
        [TestCase()]
        public void PropertyUserTests()
        {
            DataSetUser data = new DataSetUser();

            data.BrojiloId = 1;
            data.UserName = "Test";
            data.UserCity = "Test";
            data.UserZip = "Test";
            data.UserStreet = "Test";
            data.UserStreetNo = 1;
            


            Assert.AreEqual(1, data.BrojiloId);
            Assert.AreEqual(1, data.UserStreetNo);
            Assert.AreEqual("Test", data.UserName);
            Assert.AreEqual("Test", data.UserCity);
            Assert.AreEqual("Test", data.UserZip);
            Assert.AreEqual("Test", data.UserStreet);

        }

    }
}