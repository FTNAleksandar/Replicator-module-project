using DataSet = Database_Component.DataSetModel.DataSet;
using Database_Component.DataSetModel;
using System;
using System.Collections.Generic;
using System.Data;
using Reader_Component.DatabaseConnection;
using Database_Component.Utils;

namespace Reader_Component.Interface.Impl
{
    public class ReaderImpl : IReader
    {
        public List<DataSet> GetBrojiloData()
        {
            string query = "select * from usageBrojilo";
            List<DataSet> dataList = new List<DataSet>();

            using (IDbConnection connection = ConnectionUtil_Pooling.GetConnection()) {
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
                                DataSet data= new DataSet(reader.GetInt32(0),reader.GetDecimal(1),reader.GetString(2));
                                dataList.Add(data);
                            }
                        }
                    }
                }
                return dataList;
            }
        }

        public List<DataSetUser> GetUsersData()
        {
            string query = "select * from userBrojilo";
            List<DataSetUser> dataList = new List<DataSetUser>();

            using (IDbConnection connection = ConnectionUtil_Pooling.GetConnection())
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
                                DataSetUser data = new DataSetUser(reader.GetInt32(0),reader.GetString(1),reader.GetString(2),reader.GetInt32(3),reader.GetString(4),reader.GetString(5));
                                dataList.Add(data);
                            }
                        }
                    }
                }
                return dataList;
            }
        }
       
        public void InsertDataSet(DataSet data)
        {
            if(data == null)
            {
                throw new ArgumentNullException();
            }
            using (IDbConnection connection = ConnectionUtil_Pooling.GetConnection())
            {
                connection.Open();


                string insertSql = "insert into usageBrojilo (id_brojila , usage , month) " +
                    "values (:id_brojila, :usage , :month)";



                using (IDbCommand command = connection.CreateCommand())
                {
                    try
                    {
                        command.CommandText = insertSql;

                        ParameterUtil.AddParameter(command, "id_brojila", DbType.Int64);
                        ParameterUtil.AddParameter(command, "usage", DbType.Decimal);
                        ParameterUtil.AddParameter(command, "month", DbType.String, 50);

                        command.Prepare();
                        ParameterUtil.SetParameterValue(command, "id_brojila", data.BrojiloId);
                        ParameterUtil.SetParameterValue(command, "usage", data.SpentWater);
                        ParameterUtil.SetParameterValue(command, "month", data.Month);

                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }

                }
            }
        }
        public void InsertDataSetUser(DataSetUser data)
        {

            if (data == null)
            {
                throw new ArgumentNullException();
            }

            using (IDbConnection connection = ConnectionUtil_Pooling.GetConnection())
            {
                connection.Open();


                string insertSql = "insert into userBrojilo (id_brojila , user_name, user_street , user_street_num , user_city , user_postal_code) " +
                    "values (:id_brojila, :user_name , :user_street, :user_street_num , :user_city ,:user_postal_code)";


                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = insertSql;

                    ParameterUtil.AddParameter(command, "id_brojila", DbType.Int64);
                    ParameterUtil.AddParameter(command, "user_name", DbType.String,50);
                    ParameterUtil.AddParameter(command, "user_street", DbType.String, 50);
                    ParameterUtil.AddParameter(command, "user_street_num", DbType.Int64);
                    ParameterUtil.AddParameter(command, "user_city", DbType.String, 50);
                    ParameterUtil.AddParameter(command, "user_postal_code", DbType.Int64, 50);
                    command.Prepare();
                    ParameterUtil.SetParameterValue(command, "id_brojila", data.BrojiloId);
                    ParameterUtil.SetParameterValue(command, "user_name", data.UserName);
                    ParameterUtil.SetParameterValue(command, "user_street", data.UserStreet);
                    ParameterUtil.SetParameterValue(command, "user_street_num", data.UserStreetNo);
                    ParameterUtil.SetParameterValue(command, "user_city", data.UserCity);
                    ParameterUtil.SetParameterValue(command, "user_postal_code", data.UserZip);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
