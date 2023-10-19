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
    public partial class Home : Form
    {
        private List<ProcessInfo> processList;
        public Home()
        {
            InitializeComponent();
            processList = new List<ProcessInfo>();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        internal List<ProcessInfo> getAllProcess()
        {
            Process[] processes = Process.GetProcesses();
            foreach (var process in processes)
            {
                ProcessInfo processInfo = new ProcessInfo();
                processInfo.id = process.Id;
                processInfo.name = process.ProcessName;
                processInfo.memoryusage = process.WorkingSet64;
                processInfo.sessionId = process.SessionId;
                processList.Add(processInfo);
            }

            return processList;
        }

        public void btnShowProcess_Click(object sender, EventArgs e)
        {
            ShowProcessing showProcessing = new ShowProcessing(getAllProcess());
            showProcessing.Show();
        }
    }
}
