using ODP_NET_Theatre.Utils;
using Reader_Component.DatabaseConnection;
using Replicator_Component.DataSetModel;
using System;
using System.Collections.Generic;
using System.Data;
using DataSet = Replicator.DataSetModel.DataSet;


namespace Reader_Component.Interface.Impl
{
    internal class ReaderImpl : IReader
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
        internal bool ExistsById(int id, IDbConnection connection)
        {
            string query = "select * from theatre where id_th=:id_th";

            using (IDbCommand command = connection.CreateCommand())
            {
                command.CommandText = query;
                ParameterUtil.AddParameter(command, "id_th", DbType.Int32);
                command.Prepare();
                ParameterUtil.SetParameterValue(command, "id_th", id);
                return command.ExecuteScalar() != null;
            }
        }

        internal bool ExistsByIdUser(int id, IDbConnection connection)
        {
            string query = "select * from theatre where id_th=:id_th";

            using (IDbCommand command = connection.CreateCommand())
            {
                command.CommandText = query;
                ParameterUtil.AddParameter(command, "id_th", DbType.Int32);
                command.Prepare();
                ParameterUtil.SetParameterValue(command, "id_th", id);
                return command.ExecuteScalar() != null;
            }
        }
        public void InsertDataSet(DataSet data)
        {

            using (IDbConnection connection = ConnectionUtil_Pooling.GetConnection())
            {
                connection.Open();
               

                string insertSql = "insert into usageBrojilo (id_brojila , usage , month) " +
                    "values (:id_brojila, :usage , :month)";

                string updateSql = "update usageBrojilo set id_brojila=:id_brojila, usage=:usage, " +
                    "month=:month";

                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = ExistsById(data.BrojiloId, connection) ? updateSql : insertSql;

                    ParameterUtil.AddParameter(command, "id_brojila", DbType.Int64);
                    ParameterUtil.AddParameter(command, "usage", DbType.Decimal);
                    ParameterUtil.AddParameter(command, "month", DbType.String, 50);
                    
                    command.Prepare();
                    ParameterUtil.SetParameterValue(command, "id_brojila",data.BrojiloId);
                    ParameterUtil.SetParameterValue(command, "usage", data.SpentWater);
                    ParameterUtil.SetParameterValue(command, "month", data.Month);
                   
                    command.ExecuteNonQuery();
                }
            }
        }
        public void InsertDataSetUser(DataSetUser data)
        {
            using (IDbConnection connection = ConnectionUtil_Pooling.GetConnection())
            {
                connection.Open();


                string insertSql = "insert into userBrojilo (id_brojila , user_name, user_street , user_street_num , user_city , user_postal_code) " +
                    "values (:id_brojila, :user_name , :user_street, :user_street_num , :user_city ,:user_postal_code)";

                string updateSql = "update userBrojilo set id_brojila=:id_brojila, user_name=:user_name, user_street=:user_street, user_street_num=:user_street_num, user_city=:user_city," +
                    "user_postal_code=:user_postal_code";

                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = ExistsByIdUser(data.BrojiloId, connection) ? updateSql : insertSql;

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
