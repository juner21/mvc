using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class MyConfig
    {
        /// <summary>
        /// 实体模型
        /// </summary>
        public System.Data.Entity.DbContext db {get;private set;}

        public MyConfig()
        {
            db = new DBEntity();
        }


        public static string connStr = "";

        public static IDbConnection connection
        {
            get
            {
                IDbConnection defaultConn = null;
                //数据库类型
                string action = ConfigurationManager.AppSettings["daoType"];
                switch (action)
                {
                    //case "oracle":
                    //    defaultConn = new Oracle.ManagedDataAccess.Client.OracleConnection();
                    //    DefaultConnectionString = ConfigurationManager.ConnectionStrings["OracleConnectionString"].ConnectionString;
                    //    break;
                    case "mssql":
                        defaultConn = new System.Data.SqlClient.SqlConnection();
                        connStr = ConfigurationManager.ConnectionStrings["SqlConnectionString"].ConnectionString;
                        break;
                    default:
                        break;
                }
                return defaultConn;
            }
        }

        public static string DataBaseConnectionString(string EntityName)
        {
            IDbConnection con = connection;
            return EFConnectionStringModle(EntityName, connStr);
        }

        static string EFConnectionStringModle(string EntityName, string DBsoure)
        {
            return string.Concat("metadata=res://*/",
                EntityName, ".csdl|res://*/",
                EntityName, ".ssdl|res://*/",
                EntityName, ".msl;provider=System.Data.SqlClient;provider connection string='",
                DBsoure, "'");
        }

    }
}
