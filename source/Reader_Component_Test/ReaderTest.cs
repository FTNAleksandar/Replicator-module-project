using Reader_Component.Interface.Impl;
using System.IO;

namespace Reader_Component_Test
{
    [TestFixture]
    public class Tests
    {
        [Test]
        [TestCase(null)]
        public void InsertDataSetWrongTest(DataSet data)
        {
            ReaderImpl rd = new ReaderImpl();
            Assert.Throws<ArgumentNullException>(() =>
            {

               rd.InsertDataSet(data);
            
            });
        }

        [Test]
        [TestCase(null)]
        public void InsertDataSetUserWrongTest(DataSetUser data)
        {
            ReaderImpl rd = new ReaderImpl();
            Assert.Throws<ArgumentNullException>(() =>
            {

                rd.InsertDataSetUser(data);

            });
        }

        [Test]
        public void GetBrojiloDataTest()
        {
            ReaderImpl rd = new ReaderImpl();
            Assert.DoesNotThrow(() =>
            {
                List<DataSet> list = rd.GetBrojiloData();
            });
        }

        [Test]
       public void GetUsersDataTest()
        {
            
            ReaderImpl rd = new ReaderImpl();
            Assert.DoesNotThrow(() =>
            {
                List<DataSetUser> list = rd.GetUsersData();
            });
        }

    }
}