using System;
using System.Collections.Generic;
using System.Data;
using DataSet = Database_Component.DataSetModel.DataSet;
using Database_Component.DataSetModel;
using Reader_Component.DatabaseConnection;
using Database_Component.Utils;

namespace Reports_Component.Interface.Impl
{
    class ReportsImpl : IReports
    {
        public List<DataSet> getMonthbyIdData(int id)
        {
            string query = "select id_brojila, usage, month  from usageBrojilo where id_brojila =: id_brojila";
            List<DataSet> dataList = new List<DataSet>();

            using (IDbConnection connection = ConnectionUtil_Pooling.GetConnection())
            {
                {
                    {
                        connection.Open();
                        using (IDbCommand command = connection.CreateCommand())
                        {
                            command.CommandText = query;
                          

                            ParameterUtil.AddParameter(command, "id_brojila", DbType.Int32);
                            command.Prepare();
                            ParameterUtil.SetParameterValue(command, "id_brojila", id);

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
        }

        public List<DataSet> getMonthbyStreetData(string street)
        {
            string query = "select us.id_brojila, usage, month  from usageBrojilo us, userBrojilo ur where us.id_brojila = ur.id_brojila  and user_street =: user_street";
            List<DataSet> dataList = new List<DataSet>();

            using (IDbConnection connection = ConnectionUtil_Pooling.GetConnection())
            {
                {
                    {
                        connection.Open();
                        using (IDbCommand command = connection.CreateCommand())
                        {
                            command.CommandText = query;


                            ParameterUtil.AddParameter(command, "user_street", DbType.String,50);
                            command.Prepare();
                            ParameterUtil.SetParameterValue(command, "user_street", street);

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
        }


        public void showDataset(List<DataSet> dataSets)
        {
            Console.WriteLine("=====================POTROSNJA===================");
            foreach (DataSet data in dataSets)
            {
                
                Console.WriteLine("Brojilo : "+data.BrojiloId +"\nMesec: " +data.Month + "\tPotosilo: " + data.SpentWater);
                
            }
            Console.WriteLine("-----------------------------------------------");
        }
    }
}
