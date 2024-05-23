using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections;

using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Windows.Forms;


namespace DbDiff.Code
{
    class OldDbDataLayer
    {
        public OleDbConnection conObjERP;

        public OldDbDataLayer(string path, string _password)
        {
            conObjERP = new OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + path + ";Jet OLEDB:Database Password=" + _password + "");
           
        }

        public DataTable readTable()
        {
            string[] restrictions = new string[4];
            restrictions[3] = "Table";
            IntializeConnection();


            // Get list of user tables
            DataTable userTables = conObjERP.GetSchema("Tables", restrictions);
            return userTables;



        }








        public void IntializeConnection()
        {
            //if (conObjERP.State == ConnectionState.Open)
            //{
            //    conObjERP.Close();
            //}
            if (conObjERP.State == ConnectionState.Closed)
            {
                conObjERP.Open();

            }
        }

        public void ExecuteCMD(OleDbCommand cmd)
        {
            IntializeConnection();
            OleDbTransaction sqlTrans = conObjERP.BeginTransaction();
            cmd.Connection = conObjERP;
            cmd.Transaction = sqlTrans;
            cmd.ExecuteNonQuery();
            sqlTrans.Commit();

        }
        public DataTable GetDataTable(OleDbCommand cmd)
        {
            IntializeConnection();
            cmd.Connection = conObjERP;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt != null)
            {
                return dt;
            }
            else
            {
                return null;
            }


        }

        public DataTable GetDataTable(string qry)
        {
            conObjERP.Close();

            conObjERP.Open();
            OleDbCommand cmd = new OleDbCommand(qry, conObjERP);

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt != null)
            {
                return dt;
            }
            else
            {
                return null;
            }

        }


        public DataSet ReturnDataSet(OleDbCommand cmd)
        {
            IntializeConnection();
            cmd.Connection = conObjERP;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            if (dt != null)
            {
                return dt;
            }
            else
            {
                return null;
            }


        }
        public OleDbDataReader GetReader(OleDbCommand cmd)
        {
            IntializeConnection();
            cmd.Connection = conObjERP;
            OleDbDataReader read = cmd.ExecuteReader();


            return read;

        }

        public void ExecuteQuery(string strQrystr)
        {
            IntializeConnection();
            OleDbTransaction sqlTrans = conObjERP.BeginTransaction();

            OleDbCommand cmd = new OleDbCommand(strQrystr, conObjERP);
            cmd.Transaction = sqlTrans;
            cmd.ExecuteNonQuery();


            sqlTrans.Commit();

        }
    }


}
