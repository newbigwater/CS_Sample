using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MsSqlSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            try
            {
                // Type1
//                 DataBaseManager db = new DataBaseManager();
//                 db.Connect();
//                 {
//                     SqlDataAdapter ad = new SqlDataAdapter("select * from Student", DataBaseManager.SqlConn);
//                     DataTable date_table = new DataTable();
// 
//                     ad.Fill(date_table);
//                     dataGridView1.DataSource = date_table;
//                     dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
//                 }
//                 db.DisConnect();

                //Type2
                DataClasses1DataContext db = new DataClasses1DataContext();
                var alarmList =
                    from alarm in db.AlarmTable
                    select alarm;
                
                dataGridView1.DataSource = alarmList;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                throw;
            }
        }
    }
}
