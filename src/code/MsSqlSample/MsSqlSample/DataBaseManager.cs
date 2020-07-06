using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MsSqlSample
{
    class DataBaseManager
    {
        private static SqlConnection m_sqlConn = null;
        public static SqlConnection SqlConn
        {
            get { return m_sqlConn; }
            set { m_sqlConn = value; }
        }
        public static SqlCommand m_sqlCmd = null;

        public string m_strConnInfo;

        public DataBaseManager()
        {
            m_strConnInfo = "server = localhost;"
                            + "uid = sa;"
                            + "pwd = 1234;"
                            + "database = NBW;"
                            + "Connection Timeout=2";
        }

        public void Connect()
        {
            try
            {
                SqlConn = new SqlConnection(m_strConnInfo);
                m_sqlCmd = new SqlCommand();
                m_sqlCmd.Connection = SqlConn;

                SqlConn.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                throw;
            }
        }

        public void DisConnect()
        {
            try
            {
                if(1 == (int)SqlConn.State)
                    SqlConn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                throw;
            }
        }
    }
}
