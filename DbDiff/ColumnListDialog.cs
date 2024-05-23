using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Code;

namespace WindowsFormsApplication1
{
    public partial class ColumnListDialog : Form
    {
        public virtual System.Drawing.ContentAlignment TextAlign { get; set; }

        public ArrayList tableListEntity = new ArrayList();
        public ColumnListDialog()
        {
            InitializeComponent();
           
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             
        }

        public void addColumnName(string _name)
        {
            Label newLabel = new Label();
            newLabel.Text = _name.ToString();
            this.Controls.Add(newLabel);
        }
        public void addTableName(string _name)
        {
            Label newLabel = new Label();
            newLabel.Text = _name.ToString();
            newLabel.TextAlign = ContentAlignment.MiddleCenter;
            newLabel.ForeColor = Color.Red;
            newLabel.BorderStyle = BorderStyle.Fixed3D;
            
            this.Controls.Add(newLabel);
        }

        public void setTableList(ArrayList tableList)
        {
            this.tableListEntity = tableList;
            for (int i = 0; i < tableList.Count; i++)
            {
                tableEntity tableObj=tableList[i] as tableEntity;
                if (tableObj.MissingList.Count >= 1)
                {
                    listBox1.Items.Add("       "+tableObj.tableName+"       ");

                    listBox1.Items.Add("___________________________");
                }
               
                for (int j = 0; j < tableObj.MissingList.Count; j++)
                {
                    listBox1.Items.Add(tableObj.MissingList[j].ToString());

                 //listView1.Items.Add(tableObj.MissingList[j].ToString());
                   
                }
                if (tableObj.MissingList.Count >= 1)
                {
                    listBox1.Items.Add("___________________________");
                    listBox1.Items.Add("");
                }
               
              

                
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       
    }
}
