using Replicator_Component.DataSetModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataSet = Replicator.DataSetModel.DataSet;

namespace Reader_Component.Interface
{
    internal interface IReader
    {
        void InsertDataSet(DataSet data);

        void InsertDataSetUser(DataSetUser data);

        List<DataSet> GetBrojiloData();

        List<DataSetUser> GetUsersData();

    }
}
