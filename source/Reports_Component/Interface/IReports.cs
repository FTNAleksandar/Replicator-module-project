using DataSet = Database_Component.DataSetModel.DataSet;
using Database_Component.DataSetModel;
using System.Collections.Generic;


namespace Reports_Component.Interface
{
    interface IReports
    {
        List<DataSet> getMonthbyStreetData(string street);

        List<DataSet> getMonthbyIdData(int id);

        void showDataset(List<DataSet> dataSets);

        

    }
}
