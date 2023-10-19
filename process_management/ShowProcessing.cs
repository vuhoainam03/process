using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace process_management
{
    public partial class ShowProcessing : Form
    {
        private List<ProcessInfo> processList;
        private string nameChoice;
        public ShowProcessing()
        {
            InitializeComponent();
        }
        internal ShowProcessing(List<ProcessInfo> processList)
        {
            InitializeComponent();
            this.processList = processList;

            showData();
        }

        private void showData()
        {
            tblProcessing.Rows.Clear();
            foreach (var processInfo in processList)
            {
                // Tạo một hàng mới
                int rowIndex = tblProcessing.Rows.Add();
                DataGridViewRow row = tblProcessing.Rows[rowIndex];

                // Đặt giá trị cho từng cột
                row.Cells["imageName"].Value = processInfo.name;
                row.Cells["processId"].Value = processInfo.id;
                row.Cells["memUsage"].Value = processInfo.memoryusage + "K";
                row.Cells["sessionId"].Value = processInfo.sessionId;
            }

        }
        private void updateData()
        {
            Home home = new Home();
            processList.Clear();
            processList = home.getAllProcess();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnKillProcess_Click(object sender, EventArgs e)
        {
            Process[] processes = Process.GetProcessesByName(nameChoice);
            if (processes.Length > 0)
            {

                foreach (Process process in processes)
                {
                    process.Kill();

                }
                MessageBox.Show("Tiến trình \" " + nameChoice + " \" đã bị hủy");
                updateData();
                showData();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tiên trình trước khi hủy");
            }
        }



        private void tblProcessing_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy giá trị của hàng (row) được click
                DataGridViewRow row = tblProcessing.Rows[e.RowIndex];

                // Lấy giá trị của image name đang được click
                nameChoice = row.Cells["imageName"].Value.ToString();
                MessageBox.Show(nameChoice);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            updateData();
            showData();
        }

        private void btnDepart_Click(object sender, EventArgs e)
        {
            string name = txtImageName.Text.Trim();
            if(name.Length >0)
            {
                ProcessStartInfo processStart = new ProcessStartInfo(name);
                processStart.Verb = "runas";

                try
                {
                    Process.Start(processStart);
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
