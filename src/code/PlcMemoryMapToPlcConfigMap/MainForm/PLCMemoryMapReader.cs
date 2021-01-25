using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _000_System.Define;
using _000_System.Exception;
using _012_Container.DesignPattern.GenerationPattern;
using Excel = Microsoft.Office.Interop.Excel;

namespace MainForm
{
    public enum E_COL_TYPE
    {
        Col_grpName  = 1,
        Col_addrName = 2,
        Col_Area     = 7,
        Col_Size     = 8,
        Col_Address  = 53
    }

    public class RowData
    {
        public string GrpName {get; set;}   = "";
        public string AddrName{get; set;}   = "";
        public string Area    {get; set;}   = "";
        public double Size    {get; set;}   = 0;
        public double Address { get; set; } = 0;
    }

    public class PLCMemoryMapReader : Singleton<PLCMemoryMapReader>
    {
        public List<RowData> dataList = new List<RowData>();

        private string _fileName = "";
        public void Start()
        {
            OpenFileDialog OFD = new OpenFileDialog();
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                _fileName = OFD.FileName;
            }
            else
                return;

            Excel.Workbook wb = null;
            Excel.Worksheet ws = null;
            Excel.Application ap = null;

            ap = new Excel.Application();
            wb = ap.Workbooks.Open(_fileName);
            ws = wb.Sheets[7];

            ap.Visible = false;
            Excel.Range range = ws.UsedRange;


            // Row
            for (int i = 17; i <= 4779; ++i)
            {
                // Col
                RowData row = new RowData();
                for (int j = 1; j < range.Columns.Count; ++j)
                {
                    if (range.Cells[i, j] != null && range.Cells[i, j].Value2 != null)
                    {
                        var data = (range.Cells[i, j] as Excel.Range).Value2;
                        switch ((E_COL_TYPE)j)
                        {
                            case E_COL_TYPE.Col_grpName : row.GrpName  = data; break;
                            case E_COL_TYPE.Col_addrName: row.AddrName = data; break;
                            case E_COL_TYPE.Col_Area    : row.Area     = data; break;
                            case E_COL_TYPE.Col_Size    : row.Size     = data; break;
                            case E_COL_TYPE.Col_Address : row.Address  = data; break;
                        }
                    }
                }
                dataList.Add(row);
            }

            DeleteObject(range);
            DeleteObject(ws);
            DeleteObject(wb);
            ap.Quit();
            DeleteObject(ap);
        }

        private void DeleteObject(object obj)
        {   // 메모리 해제를 위한 사용자 정의 함수
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("메모리 할당을 해제하는 중 문제가 발생하였습니다." + ex.ToString(), "경고!");
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
