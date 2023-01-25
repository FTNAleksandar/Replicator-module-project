using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Component.DataSetModel
{
    public class DataSetUser
    {
        public int BrojiloId { get; set; }
        public string UserName { get; set; }
        public string UserStreet { get; set; }
        public int UserStreetNo { get; set; }
        public string UserCity { get; set; }
        public string UserZip { get; set; }

        public DataSetUser(int brojiloId, string userName, string userStreet, int userStreetNo, string userCity, string userZip)
        {
            if (userName == null || userStreet == null || userCity == null || userZip == null)
            {
                throw new ArgumentNullException();
            }

            BrojiloId = brojiloId;
            UserName = userName;
            UserStreet = userStreet;
            UserStreetNo = userStreetNo;
            UserCity = userCity;
            UserZip = userZip;
        }

        public DataSetUser()
        {
        }
    }
}
