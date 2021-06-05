using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.IO;
using OfficeOpenXml;


namespace GiaoTiepPC
{
    public partial class Themes : Form
    {
        StringBuilder sbuilder = new StringBuilder();
        Int32 numInOnDay = 0;
        Int32 numInGarage = 0;
        Int32 numFree = 0;
        bool flagIn = false;
        bool flagOut = false;
        static int lineIndex = 0;
        static string dataIn = string.Empty;
        static string dataOut = string.Empty;
        string path = @"dataExport.csv";
        String Test = "ID" + "," + "Date In" + "," + "Time In" + "," + "Date Out" + "," + "Time Out";
        delegate void SetTextCallBack(string text);
        string InputData = string.Empty;
        public Themes()
        {
            InitializeComponent();
            UART.DataReceived += new SerialDataReceivedEventHandler(DataReceived);
            lbIn.BackColor = Color.Gray;
            lbOut.BackColor = Color.Gray;
            lbInfo.Enabled = false;
            tbxInfo.Enabled = false;
        }

        // Get port COM avaiable to conect
        private void UART_Load(object sender, EventArgs e)
        {
            cbxCom.DataSource = SerialPort.GetPortNames();
            if (cbxCom.Items.Count > 0)
                cbxCom.SelectedIndex = 0;
            lblStatus.Text = "Port is closed !";
            sbuilder.AppendLine(Test);
            File.WriteAllText(path, sbuilder.ToString());
        }

        // Press the button to conect with port COM
        private void BtnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (UART.IsOpen == true)
                {
                    UART.DiscardInBuffer();
                    UART.Close();

                }
                UART.PortName = cbxCom.Text;
                UART.Open();
                lblStatus.Text = "PC is connecting with " + UART.PortName.ToString();
                if (UART.IsOpen == true)
                {
                    btnConnect.Enabled = false;
                    btnDisconnect.Enabled = true;
                }
            }
            catch
            {
                MessageBox.Show("Bạn chưa chọn cổng COM !");
            }

        }
        //  Press the button to disconect with port COM
        private void BtnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (UART.IsOpen)
                {
                    while (UART.BytesToWrite > 0) { }
                    UART.DiscardInBuffer();
                    UART.Dispose();
                    UART.Close();

                    btnConnect.Enabled = true;
                    btnDisconnect.Enabled = false;
                    lblStatus.Text = "Port is closed !";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // Get date and time 
        private void tm1_Tick(object sender, EventArgs e)
        {
            this.timelabel.Text = DateTime.Now.ToString("HH:mm:ss");
            this.Datelabel.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
        // Processing data recieve via port COM
        private void DataReceived(object obj, SerialDataReceivedEventArgs e)
        {
            Thread.Sleep(100);
            InputData = UART.ReadExisting();
            if (InputData != string.Empty)
            {
                SetText(InputData);
            }
        }
        private void SetText(string text)
        {
            if (tbxIdIn.InvokeRequired)
            {
                SetTextCallBack d = new SetTextCallBack(SetText);
                Invoke(d, new object[] { text });
            }
            else
            {
                string[] arrGateStatus = text.Split(',');
                switch (arrGateStatus[0])
                {
                    case "0":
                        tbxInfo.Clear();
                        // Caculate and show on themes
                        numInOnDay++;
                        tbxIdIn.Text = arrGateStatus[1];
                        txNumIn.Text = numInOnDay.ToString();
                        numInGarage = numInOnDay;
                        numFree = 100 - numInGarage;
                        txNumOccupied.Text = numInGarage.ToString();
                        txNumFree.Text = numFree.ToString();
                        // get date time and show on themes
                        tbxDateIn.Text = DateTime.Now.ToString("dd/MM/yyyy");
                        tbxTimeIn.Text = DateTime.Now.ToString("HH:mm:ss");
                        flagIn = true;
                        // write data to exel file
                        dataIn =tbxIdIn.Text + "," + tbxDateIn.Text + "," + tbxTimeIn.Text;
                        sbuilder.AppendLine(dataIn);
                        File.WriteAllText(path, sbuilder.ToString());     
                        // show label on themes
                        lbIn.BackColor = Color.Red;
                        lbOut.BackColor = Color.Gray;
                        lbInfo.Enabled = false;
                        tbxInfo.Enabled = false;                        
                        break;

                    case "1" :
                        var package = new ExcelPackage(new FileInfo("dataExport.csv"));
                        ExcelWorksheet workSheet = package.Workbook.Worksheets[1];
                        for (int i = workSheet.Dimension.Start.Row; i <= workSheet.Dimension.End.Row; i++)
                        {
                            try
                            {
                                // lấy ra cột họ tên tương ứng giá trị tại vị trí [i, 1]. i lần đầu là 2
                                // tăng j lên 1 đơn vị sau khi thực hiện xong câu lệnh
                                string IDcard = workSheet.Cells[i, 1].Value.ToString();

                                // lấy ra cột ngày sinh tương ứng giá trị tại vị trí [i, 2]. i lần đầu là 2
                                // tăng j lên 1 đơn vị sau khi thực hiện xong câu lệnh
                                // lấy ra giá trị ngày tháng và ép kiểu thành DateTime                      
                                if (IDcard == tbxIdOut.Text)
                                {
                                    dataOut = "," + "," +","+ tbxDateOut.Text + "," + tbxTimeOut.Text;                     
                                    sbuilder.AppendLine(dataIn);
                                    File.WriteAllText(path, sbuilder.ToString()); 
                                }


                                /*                         

                                Đừng lười biến mà dùng đoạn code này sẽ gây ra lỗi nếu giá trị value không thỏa kiểu DateTime

                                DateTime birthday = (DateTime)workSheet.Cells[i, j++].Value;

                                 */
                            }
                            catch (Exception exe)
                            {

                            } 
                        }
                        // Caculate and show on themes
                        numInGarage = numInGarage - 1;
                        numFree = numFree + 1;
                        txNumOccupied.Text = numInGarage.ToString();
                        txNumFree.Text = numFree.ToString();
                        tbxIdOut.Text = arrGateStatus[1];
                        // get date time and show on themes
                        tbxDateOut.Text = DateTime.Now.ToString("dd/MM/yyyy");
                        tbxTimeOut.Text = DateTime.Now.ToString("HH:mm:ss");

                        tbxInfo.Text = arrGateStatus[1];
                        flagOut = true;
                        // show label on themes
                        lbInfo.Enabled = true;
                        tbxInfo.Enabled = true;
                        lbInfo.BackColor = Color.Green;
                        lbIn.BackColor = Color.Gray;
                        lbOut.BackColor = Color.Green ;                       
                        break;

                    case "FF":
                        MessageBox.Show("The khong hop le", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    default:
                        break;
                }               
                if (flagIn == true)
                {
                    File.AppendAllText(@"E:/ExportDataIn.txt", dataIn + Environment.NewLine);
                    flagIn = false;
                }
                if (flagOut == true)
                {
                    File.AppendAllText(@"E:/ExportDataOut.txt", dataOut + Environment.NewLine);
                    flagOut = false; 
                }
                
                            
            }
        }

    }
}
