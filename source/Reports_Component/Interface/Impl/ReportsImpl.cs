using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 

namespace Reports_Component.Interface.Impl
{
    class ReportsImpl : IReports
    {
        public void getMonthbyId()
        {
            string query = "select id_brojila, usage, month  from usageBrojilo";
            List<DataSet> dataList = new List<DataSet>();

            using (IDbConnection connection = InternalDataCollectionBase.
            {
                {
                    connection.Open();
                    using (IDbCommand command = connection.CreateCommand())
                    {
                        command.CommandText = query;
                        command.Prepare();

                        using (IDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                DataSet data = new DataSet(reader.GetInt32(0), reader.GetDecimal(1), reader.GetString(2));
                                dataList.Add(data);
                                
                            }
                        }
                    }
                }
                return dataList;
            }
        
    }

        public void getMonthbyStreet()
        {
            throw new NotImplementedException();
        }
    }
}
