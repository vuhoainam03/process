namespace process_management
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            btnShowProcess = new Button();
            btnExit = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnShowProcess
            // 
            btnShowProcess.Location = new Point(419, 879);
            btnShowProcess.Name = "btnShowProcess";
            btnShowProcess.Size = new Size(325, 97);
            btnShowProcess.TabIndex = 0;
            btnShowProcess.Text = "Hiển thị tất cả tiến trình";
            btnShowProcess.UseVisualStyleBackColor = true;
            btnShowProcess.Click += btnShowProcess_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(897, 879);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(325, 97);
            btnExit.TabIndex = 1;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(61, 77);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1456, 756);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1583, 1058);
            Controls.Add(pictureBox1);
            Controls.Add(btnExit);
            Controls.Add(btnShowProcess);
            Name = "Home";
            Text = "Home";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnShowProcess;
        private Button btnExit;
        private PictureBox pictureBox1;
    }
}