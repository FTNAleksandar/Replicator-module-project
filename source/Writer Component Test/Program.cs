using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database_Component.DataSetModel;
using Moq;
using NUnit.Framework;
using Writer_Component.Interface;

namespace Writer_Component_Test
{
    [TestFixture]
    class Program
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
        [TestCase(1,50.2,  "Januar")]
        [TestCase(2,19.7, "Februar")]
        [TestCase(3,78.0, "Mart")]
        [TestCase(4,8.9, "Januar")]
        [TestCase(5,69.1, "Januar")]
        [TestCase(6,32.6, "Januar")]
        [TestCase(7,12.4, "Januar")]
        [TestCase(8,40.6,  "Januar")]
        [TestCase(9,21.3,  "Januar")]
        [TestCase(10,90.8,  "Januar")]
        public void PassDataParams(int BrojiloId, decimal spentWater, string month)
        {
            DataSet dataset = new DataSet( BrojiloId, spentWater, month);
            
            
            Mock<IWriter> mock = new Mock<IWriter>();

            for (int i = 0; i < 8; i++)
            {
                // change field value
                dataset.BrojiloId = BrojiloId + i * 8;

                mock.Setup(p => p.DataPassThrought(dataset));
            }
        }

        [Test]
        [TestCase(1, null, "Januar")]
        [TestCase(2, 19.7, "")]
        [TestCase(3, 78.9, null)]
        [TestCase(4, null, "Januar")]
        [TestCase(5, 69.1, "")]
        [TestCase(null, 32.6, "Januar")]
        [TestCase(7, null, "Januar")]
        [TestCase(null, 40.6, "Januar")]
        
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
        

        
    

