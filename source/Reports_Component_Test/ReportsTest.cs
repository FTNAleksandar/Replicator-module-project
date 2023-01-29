using Reports_Component.Interface;
using Reports_Component.Interface.Impl;
using System.Diagnostics.Metrics;
using System.IO;

namespace Reports_Component_Test
{
    [TestFixture]
    public class Tests
    {
        [Test]
        [TestCase("Petra Drapsina")]
        public void getMonthbyStreetDataTest(string street)
        {
            ReportsImpl rp = new ReportsImpl();
            Assert.DoesNotThrow(() =>
            {
               
                List<DataSet> list = rp.getMonthbyStreetData(street);
            });
        }

        [Test]
        [TestCase(null)]
        public void getMonthbyStreetDataWrongTest(string street)
        {
            ReportsImpl rp = new ReportsImpl();
            Assert.Throws<ArgumentNullException>(() =>
            {

                List<DataSet> list = rp.getMonthbyStreetData(street);
            });

        }

        [Test]
        [TestCase(1)]
        public void getMonthbyIdDataTest(int id)
        {
            ReportsImpl rp = new ReportsImpl();

            Assert.DoesNotThrow(() =>
            {

                List<DataSet> list = rp.getMonthbyIdData(id);
            });
        }


        [Test]
        [TestCase(-5)]
        public void getMonthbyIdDataWrongTest(int id)
        {
            ReportsImpl rp = new ReportsImpl();

            Assert.Throws<ArgumentException>(() =>
            {

                List<DataSet> list = rp.getMonthbyIdData(id);
            });
        }
        

        [Test]
        [TestCase(0)]
        public void getMonthbyIdDataGranicniTest(int id)
        {
            ReportsImpl rp = new ReportsImpl();

            Assert.DoesNotThrow(() =>
            {

                List<DataSet> list = rp.getMonthbyIdData(id);
            });
        }
       
    }
}