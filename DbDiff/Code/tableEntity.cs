using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Code
{   
    class tableEntity
    {
        public string tableName { get; set; }
        public ArrayList columnList = new ArrayList();
        public ArrayList FoundList = new ArrayList();
        public ArrayList MissingList =new ArrayList();
        public int columnCount;

        
        
        public tableEntity(string _name)
        {
            this.tableName = _name;
          
         

        }

        public void AddColumnsList(OleDbDataReader rdr)
        {
            try
            {
               
                    for (int c = 0; c < rdr.VisibleFieldCount; c++)
                    {
                        columnList.Add(rdr.GetName(c));
                    }
                
            }
            catch (OutOfMemoryException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                System.Windows.Forms.MessageBox.Show(ex.Source);
                //System.Windows.Forms.MessageBox.Show(ex.InnerException.ToString());
                System.Windows.Forms.MessageBox.Show(ex.HelpLink);
                System.Windows.Forms.MessageBox.Show(columnList.Count.ToString());



            }
            
             
          
            
        }
  
        public void CompareTables(tableEntity table)
        {
            if (columnList.Count == table.columnList.Count)
            {
                for (int i = 0; i < table.columnList.Count; i++)
                {
                    if (!this.columnList.Contains(table.columnList[i]))
                    {
                        this.MissingList.Add(table.columnList[i]);
                    }
                    else
                    {
                        this.FoundList.Add(table.columnList[i]);
                    }
                }
            }
            else if (table.columnList.Count < columnList.Count)
            {
                
                for (int i = 0; i <table.columnList.Count; i++)
                {
                    try
                    {
                        int index = this.columnList.IndexOf(table.columnList[i]);
                        if (index > 0)
                        {
                            this.FoundList.Add(columnList[index]);

                        }
                        else
                        {
                            this.MissingList.Add(table.columnList[i]);
                        }
                        if (i == table.columnList.Count-1)
                        {
                            for(int k=table.columnList.Count;k<columnList.Count;k++){
                                if (FoundList.Contains(this.columnList[k]))
                                {
                                    continue;

                                }
                                else
                                {
                                    MissingList.Add(columnList[k]);

                                }
                            }
                           

                        }
                        
                    }
                    catch (ArgumentOutOfRangeException ex)
                    {
                        continue;

                    }
                  
                }

            }
           
         
           
        }

        public ArrayList getMissingColumns()
        {
            return this.MissingList;
        }

        
    }
}
