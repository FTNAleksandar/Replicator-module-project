using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataSet = Database_Component.DataSetModel.DataSet;
using Database_Component.DataSetModel;

namespace Writer_Component.Interface
{
    internal interface IWriter
    {
        void DataPassThrought(DataSet data);

        void UserDataPassThrought(DataSetUser data);
    }
}
