using Reader_Component.Interface;
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
            
            Mock<IReader> mock = new Mock<IReader>();

            mock.Setup(p => p.GetBrojiloData()).Returns(new List<DataSet>());
            Assert.NotNull(mock.Object);

        }

       

        [Test]
       public void GetUsersDataTest()
        {
            

            Mock<IReader> mock = new Mock<IReader>();

            mock.Setup(p => p.GetUsersData()).Returns(new List<DataSetUser>());
            Assert.NotNull(mock.Object);
        }

    }
}