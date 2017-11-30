using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StackingPics
{
    public partial class StartingQuery : Form
    {
        public StartingQuery()
        {
            InitializeComponent();
        }

        private void buttonQuery_Click(object sender, EventArgs e)
        {
            // 2017/11/30 appended by Mosu
            string _querylotid = "";
            DBTools _dt = null;
            string _sql = "";
            string _lotid = "";
            string _path = "";
            try
            {
                if (textLotIDs.Text == null || textLotIDs.Text == "")
                {
                    throw new ArgumentException("請輸入Runcard號碼。");
                }
                textLotIDs.Text = textLotIDs.Text.ToUpper();

                _dt = new DBTools();

                if (!_dt.OpenOracleConnection())
                {
                    throw new ArgumentException("無法連接MES資料庫。");
                }

                if (!_dt.OpenMysqlConnection())
                {
                    throw new ArgumentException("無法連接MySQL資料庫。");
                }
                switch (comboLines.Text)
                {
                    case Constants.Line158:
                        _querylotid = textLotIDs.Text;
                        _sql = "select idLotName,idDeviceNumber,idMachineNumber,idjobNumber,idStartDate ";
                        _sql += "from kgkinspectdb.jobresulttbl j ";
                        _sql += "where 1 = 1 ";
                        _sql += "and idlotName like '%" + _querylotid + "%'";

                        //批號
                        string idLotName = "";
                        //Device編號固定為:00900000 (8碼)
                        string idDeviceNumber = "";
                        //idMachineNumber為機台編號:00000029 (8碼)
                        string idMachineNumber = "";
                        //工單編號.:00065820(8碼)
                        string idjobNumber = "";
                        string _imagepath = "";
                        
                        DataTable _temptable = new DataTable();
                        _temptable.Columns.Clear();
                        _temptable.Columns.Add("LotNo", typeof(String));
                        _temptable.Columns.Add("ImagePath", typeof(String));

                        _dt.SelectCommand = _sql;
                        _dt.MysqlDataSelect();

                        if (_dt.gMysqlTable.Rows.Count < 1)
                        {
                            throw new ArgumentException("此Runcard查無任何資料。\r\n請重新確認Runcard號碼。");
                        }

                        for (int _i = 0; _i < _dt.gMysqlTable.Rows.Count;_i++ )
                        { 
                            //批號idLotName
                            idLotName = _dt.gMysqlTable.Rows[_i][0].ToString();
                            //idDeviceNumber,
                            idDeviceNumber = _dt.gMysqlTable.Rows[_i][1].ToString();

                            //機台編號 (idMachineNumber)
                            idMachineNumber = _dt.gMysqlTable.Rows[_i][2].ToString();
                            // 00900000_00000014_00069554db

                            idjobNumber = _dt.gMysqlTable.Rows[_i][3].ToString();
                            if (idjobNumber.Length == 5)
                            {
                                _imagepath = "00" + idDeviceNumber + "_000000" + idMachineNumber + "_000" + idjobNumber;
                            }
                            else
                            {
                                _imagepath = "00" + idDeviceNumber + "_000000" + idMachineNumber + "_00" + idjobNumber;
                            }
                            _lotid = idLotName.Trim();
                            _path = @"\\10.41.0.190\d\Result\" + _imagepath;
                            //走資料庫
                            _temptable.Rows.Add(_lotid, _path);
                        }
                        dataLotPath.DataSource = _temptable;
                        dataLotPath.AutoResizeColumns();
                        dataLotPath.AutoResizeRows();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
        }
        

        private void StartingQuery_Load(object sender, EventArgs e)
        {
            comboLines.Items.Clear();
            comboLines.Items.Add(Constants.Line158);
        }
    }
}
