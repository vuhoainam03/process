namespace process_management
{
    partial class ShowProcessing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tblProcessing = new DataGridView();
            imageName = new DataGridViewTextBoxColumn();
            processId = new DataGridViewTextBoxColumn();
            sessionId = new DataGridViewTextBoxColumn();
            memUsage = new DataGridViewTextBoxColumn();
            btnDepart = new Button();
            label1 = new Label();
            txtImageName = new TextBox();
            btnKillProcess = new Button();
            btnExit = new Button();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)tblProcessing).BeginInit();
            SuspendLayout();
            // 
            // tblProcessing
            // 
            tblProcessing.AllowUserToAddRows = false;
            tblProcessing.AllowUserToDeleteRows = false;
            tblProcessing.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tblProcessing.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblProcessing.Columns.AddRange(new DataGridViewColumn[] { imageName, processId, sessionId, memUsage });
            tblProcessing.Location = new Point(12, 90);
            tblProcessing.Name = "tblProcessing";
            tblProcessing.ReadOnly = true;
            tblProcessing.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            tblProcessing.RowTemplate.Height = 37;
            tblProcessing.Size = new Size(1731, 685);
            tblProcessing.TabIndex = 0;
            tblProcessing.CellClick += tblProcessing_CellClick;
            // 
            // imageName
            // 
            imageName.HeaderText = "Image Name";
            imageName.MinimumWidth = 9;
            imageName.Name = "imageName";
            imageName.ReadOnly = true;
            // 
            // processId
            // 
            processId.HeaderText = "Mã tiến trình";
            processId.MinimumWidth = 9;
            processId.Name = "processId";
            processId.ReadOnly = true;
            // 
            // sessionId
            // 
            sessionId.HeaderText = "Mã Phiên của tiến trình";
            sessionId.MinimumWidth = 9;
            sessionId.Name = "sessionId";
            sessionId.ReadOnly = true;
            // 
            // memUsage
            // 
            memUsage.HeaderText = "Bộ nhớ sử dụng";
            memUsage.MinimumWidth = 9;
            memUsage.Name = "memUsage";
            memUsage.ReadOnly = true;
            // 
            // btnDepart
            // 
            btnDepart.Location = new Point(383, 949);
            btnDepart.Name = "btnDepart";
            btnDepart.Size = new Size(157, 40);
            btnDepart.TabIndex = 1;
            btnDepart.Text = "Khởi chạy";
            btnDepart.UseVisualStyleBackColor = true;
            btnDepart.Click += btnDepart_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 869);
            label1.Name = "label1";
            label1.Size = new Size(135, 30);
            label1.TabIndex = 2;
            label1.Text = "Tên tiến trình";
            // 
            // txtImageName
            // 
            txtImageName.Location = new Point(210, 869);
            txtImageName.Name = "txtImageName";
            txtImageName.Size = new Size(330, 35);
            txtImageName.TabIndex = 3;
            // 
            // btnKillProcess
            // 
            btnKillProcess.Location = new Point(842, 949);
            btnKillProcess.Name = "btnKillProcess";
            btnKillProcess.Size = new Size(157, 40);
            btnKillProcess.TabIndex = 4;
            btnKillProcess.Text = "Hủy tiến trình";
            btnKillProcess.UseVisualStyleBackColor = true;
            btnKillProcess.Click += btnKillProcess_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(1418, 949);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(157, 40);
            btnExit.TabIndex = 5;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(1123, 949);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(157, 40);
            btnRefresh.TabIndex = 6;
            btnRefresh.Text = "Làm mới";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // ShowProcessing
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1755, 1126);
            Controls.Add(btnRefresh);
            Controls.Add(btnExit);
            Controls.Add(btnKillProcess);
            Controls.Add(txtImageName);
            Controls.Add(label1);
            Controls.Add(btnDepart);
            Controls.Add(tblProcessing);
            Name = "ShowProcessing";
            Text = "ShowProcessing";
            ((System.ComponentModel.ISupportInitialize)tblProcessing).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tblProcessing;
        private DataGridViewTextBoxColumn imageName;
        private DataGridViewTextBoxColumn processId;
        private DataGridViewTextBoxColumn sessionId;
        private DataGridViewTextBoxColumn memUsage;
        private Button btnDepart;
        private Label label1;
        private TextBox txtImageName;
        private Button btnKillProcess;
        private Button btnExit;
        private Button btnRefresh;
    }
}