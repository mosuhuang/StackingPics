using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Oracle.DataAccess.Client;
using MySql.Data.MySqlClient;
using System.Data;
namespace StackingPics
{
    class DBTools
    {
        // Oracle Connection String Sample.
        // private static string gOracleConnection = @"Data Source=khtcpfr.world;Persist Security Info=True;User ID=TPREPORT;Password=TPREPORT;";
        private static string gOracleConnection = @"Data Source=KHFAB01.WORLD;Persist Security Info=True;User ID=KHFAB_K800;Password=K800KHFAB;";
        public OracleDataAdapter gOracleAdapter = new OracleDataAdapter();
        public OracleConnection gOracleCn = new OracleConnection();
        public DataTable gOracleTable = new DataTable();

        private static string gMysqlConnection = "server=10.41.0.191;uid=root;pwd=kgk;database=kgkinspectdb";
        public MySqlDataAdapter gMysqlAdapter = new MySqlDataAdapter();
        public MySqlConnection gMysqlCn = new MySqlConnection();
        public DataTable gMysqlTable = new DataTable();

        private string selectCommand;
        public string SelectCommand
        {
            set { selectCommand = value; }
        }

        private string insertCommand;
        public string InsertCommand
        {
            set { insertCommand = value; }
        }

        private string deleteCommand;
        public string DeleteCommand
        {
            set { deleteCommand = value; }
        }

        private string updateCommand;
        public string UpdateCommand
        {
            set { updateCommand = value; }
        }

        public bool OpenOracleConnection()
        {
            gOracleCn.ConnectionString = gOracleConnection;
            gOracleCn.Open();
            if (gOracleCn.State.ToString().ToUpper() == "OPEN")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // Select
        public void OracleDataSelect()
        {
            gOracleAdapter.SelectCommand = new OracleCommand(selectCommand, gOracleCn);
            gOracleAdapter.Fill(gOracleTable);
        }

        // Insert
        public void OracleDataInsert()
        {
            gOracleAdapter.InsertCommand = new OracleCommand(insertCommand, gOracleCn);
            gOracleAdapter.InsertCommand.ExecuteNonQuery();
        }

        // Delete
        public void OracleDataDelete()
        {
            gOracleAdapter.DeleteCommand = new OracleCommand(deleteCommand, gOracleCn);
            gOracleAdapter.DeleteCommand.ExecuteNonQuery();
        }

        // Update
        public void OracleDataUpdate()
        {
            gOracleAdapter.UpdateCommand = new OracleCommand(updateCommand, gOracleCn);
            gOracleAdapter.UpdateCommand.ExecuteNonQuery();
        }

        public void OracleReleased()
        {
            gOracleAdapter.Dispose();
            gOracleTable.Dispose();
            gOracleCn.Close();
            gOracleCn.Dispose();
        }

        // Mysql部分
        public bool OpenMysqlConnection()
        {
            gMysqlCn.ConnectionString = gMysqlConnection;
            gMysqlCn.Open();
            if (gMysqlCn.State.ToString().ToUpper() == "OPEN")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void MysqlDataSelect()
        {
            gMysqlAdapter.SelectCommand = new MySqlCommand(selectCommand, gMysqlCn);
            gMysqlAdapter.Fill(gMysqlTable);
        }

        public void MysqlReleased()
        {
            gMysqlAdapter.Dispose();
            gMysqlTable.Dispose();
            gMysqlCn.Close();
            gMysqlCn.Dispose();
        }

        public bool CheckMysqlDB(string _dbName)
        {
            string _sql = "";
            bool result = false;
            if (gMysqlCn.State != 0)
            {
                _sql = "SELECT SCHEMA_NAME FROM INFORMATION_SCHEMA.SCHEMATA WHERE SCHEMA_NAME = '";
                _sql += _dbName + "'";
                gMysqlAdapter.SelectCommand = new MySqlCommand(_sql, gMysqlCn);
                gMysqlAdapter.Fill(gMysqlTable);
                if (gMysqlTable.Rows.Count > 0)
                {
                    result = true;
                }
            }
            gMysqlTable.Reset();
            gMysqlAdapter.Dispose();
            gMysqlTable.Dispose();
            return result;
        }
    }
}
