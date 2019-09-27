using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SDC = System.Data.Common;
using A1Rentals.Types;
using System.Data;

namespace A1Rentals.DAL
{
    public class DAL
    {
        private static SDC.DbConnection Connection(SDC.DbProviderFactory dalFactory)
        {
            SDC.DbConnection conn = dalFactory.CreateConnection();
            conn.ConnectionString = Properties.Settings.Default.cnn;
            return conn;
        }

        public static int SendData(string sproc, List<ParamStruct> paramList)
        {
            SDC.DbProviderFactory factory = SDC.DbProviderFactories.GetFactory(Properties.Settings.Default.provider);

            SDC.DbCommand comm = factory.CreateCommand();
            comm = BuildCommand(sproc, paramList);

            SDC.DbConnection conn = Connection(factory);
            comm.Connection = conn;

            conn.Open();

            int count = comm.ExecuteNonQuery();

            for (int i = 0; i < comm.Parameters.Count - 1; i++ )
            {
                ParamStruct x = paramList[i];
                x.paramValue = comm.Parameters[i].Value;
                paramList[i] = x;
            }

            return count;
        }

        public static SDC.DbDataReader ReadData(string sproc, List<ParamStruct> paramList)
        {
            SDC.DbProviderFactory factory = SDC.DbProviderFactories.GetFactory(Properties.Settings.Default.provider);

            SDC.DbCommand comm = factory.CreateCommand();
            comm = BuildCommand(sproc, paramList);

            SDC.DbConnection conn = Connection(factory);
            comm.Connection = conn;

            conn.Open();
            SDC.DbDataReader  dr = comm.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

            return dr;
        }

        private static SDC.DbCommand BuildCommand(string sproc, List<ParamStruct> list)
        {
            SDC.DbProviderFactory factory = SDC.DbProviderFactories.GetFactory(Properties.Settings.Default.provider);

            SDC.DbCommand comm = factory.CreateCommand();

            comm.CommandText = sproc;
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            
            SDC.DbParameter param = factory.CreateParameter();
            

            foreach (ParamStruct item in list)
            {
                param.ParameterName = item.paramId;
                param.Value = item.paramValue;
                param.DbType = item.paramType;
                param.Size = item.paramLength;
                param.Direction = item.paramDirection;
                comm.Parameters.Add(param);
                param = factory.CreateParameter();
                
                
            }
            
            return comm;
        }

        public static DataTable ReadTable(string sproc, List<ParamStruct> paramList)
        {
            DataTable dt = new DataTable();
            SDC.DbProviderFactory factory = SDC.DbProviderFactories.GetFactory(Properties.Settings.Default.provider);

            SDC.DbCommand comm = factory.CreateCommand();
            comm = BuildCommand(sproc, paramList);
            SDC.DbDataAdapter da = factory.CreateDataAdapter();
            SDC.DbConnection conn = Connection(factory);
            comm.Connection = conn;
            da.SelectCommand = comm;
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            using (conn)
            {
                conn.Open();
                da.Fill(dt);
                return dt;
            }
        }
       
    }
}
