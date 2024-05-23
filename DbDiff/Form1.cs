using DbDiff.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;
using WindowsFormsApplication1.Code;

namespace DbDiff
{
    public partial class Form1 : Form
    {
        AppLogic Client;
        AppLogic Latest;
        public Form1()
        {
            InitializeComponent();
            txtLatestPass.Text = "ourlib";
            txtClientPass.Text = "ourlib";
            LatestTableList.Visible = false;
            ClientTables.Visible = false;
            MissingTables.Visible = false;
        }

        public OpenFileDialog openDilaog()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "mdb files (*.mdb)|*.mdb";
            fileDialog.Title = "Select Database";
            return fileDialog;
        }

        public void SelectClientDb()
        {
            OpenFileDialog dialog = openDilaog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Client = new AppLogic(dialog.FileName, txtClientPass.Text.ToString());
                Client.readTable();
                ClientTables.Visible = true;
                Client.LoadTableList(ClientTables);
                System.Windows.Forms.MessageBox.Show("Done Loading Client Tables");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Operation Canceled");
                return;
            }
        }
        public void SelectLatestDb()
        {
            OpenFileDialog dialog = openDilaog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Latest = new AppLogic(dialog.FileName, txtLatestPass.Text.ToString());
                Latest.readTable();
                LatestTableList.Visible = true;
                Latest.LoadTableList(LatestTableList);
                System.Windows.Forms.MessageBox.Show("Done Loading Latest Tables");


            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Operation Canceled");
                return;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLatest_Click(object sender, EventArgs e)
        {
            SelectLatestDb();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            SelectClientDb();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            MissingTables.Visible = true;
            if (ClientTables.Items.Count > 0)
            {
                if (Client != null && Latest != null)
                {
                    Latest.LoadMissingTables(Client.StaticTableName, MissingTables);
                }
            }
        }

        private void btnColumns_Click(object sender, EventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate()
            {
                Client.LoadTableColumns();
                Latest.LoadTableColumns();

                for (int i = 0; i < Client.tableList.Count; i++)
                {
                    if (Latest.StaticTableName.Contains(Client.StaticTableName[i]))
                    {
                        int index = Latest.StaticTableName.IndexOf(Client.StaticTableName[i]);
                        tableEntity tableObj = Latest.tableList[index] as tableEntity;
                        tableObj.CompareTables(Client.tableList[i] as tableEntity);
                    }

                }
                ColumnListDialog newDialog = new ColumnListDialog();
                newDialog.setTableList(Latest.tableList);
                if (newDialog != null)
                {
                    newDialog.ShowDialog();
                }
            }));
           
          
        }

        
    }
}
