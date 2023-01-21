using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataSet = Database_Component.DataSetModel.DataSet;
using Database_Component.DataSetModel;

namespace Reader_Component.Interface
{
    public interface IReader
    {
        void InsertDataSet(DataSet data);

        void InsertDataSetUser(DataSetUser data);

        List<DataSet> GetBrojiloData();

        List<DataSetUser> GetUsersData();

    }
}
