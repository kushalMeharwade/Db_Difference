using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Code;

namespace DbDiff.Code
{
    class AppLogic
    {
        public ArrayList tableList = new ArrayList();
        public ArrayList StaticTableName = new ArrayList();
        public ArrayList MissingTables = new ArrayList();
        public ListBox tableListBox;
        public OldDbDataLayer DL;
        public AppLogic(string path, string _password)
        {
            DL = new OldDbDataLayer(path,_password);
           
        }


        public void readTable()
        {
            DataTable userTables = DL.readTable();
            for (int i = 0; i < userTables.Rows.Count; i++)
            {
                tableList.Add(new tableEntity(userTables.Rows[i]["TABLE_NAME"].ToString()));
            }
        }

        public void LoadTableColumns()
        {
            for (int i = 0; i < tableList.Count; i++)
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText =String.Format("SELECT TOP 1 * FROM [{0}]",(tableList[i] as tableEntity).tableName);
               
                OleDbDataReader reader = DL.GetReader(cmd);
                (tableList[i] as tableEntity).AddColumnsList(reader);
            }
        }

        public void LoadTableList(ListBox list)
        {

            for (int i = 0; i < tableList.Count; i++)
            {
                string _tableName = (tableList[i] as tableEntity).tableName;
                StaticTableName.Add(_tableName);
                list.Items.Add(_tableName);
            }
        }

        public void LoadMissingTables(ArrayList clientTableList, ListBox MissingTableList)
        {
            for (int i = 0; i < StaticTableName.Count; i++)
            {
                if (!clientTableList.Contains(StaticTableName[i]))
                {
                    MissingTables.Add(StaticTableName[i]);
                }
            }
            for (int i = 0; i < MissingTables.Count; i++)
            {
                MissingTableList.Items.Add(MissingTables[i]);
            }

        }

    }
}
