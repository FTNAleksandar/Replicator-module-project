
namespace Reader_Component_Test
{
    [TestFixture]
    public class Tests
    {
        DataSet data = null;


        [SetUp]
        public void Setup()
        {
            data = new DataSet(1 ,420,"januar");

        }
      //  
//[Test]
      //  [TestCase(data)]
        public void InsertDataSetTest(DataSet data)
        {
            
        }

      //  void InsertDataSetUser(DataSetUser data);

       // List<DataSet> GetBrojiloData();

       // List<DataSetUser> GetUsersData();

    }
}