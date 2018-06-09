namespace BitScrambler
{
    partial class Window
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
            this.selectFileBtn = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.filesSelected = new System.Windows.Forms.Label();
            this.encKey = new System.Windows.Forms.TextBox();
            this.encKeyLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.decRadio = new System.Windows.Forms.RadioButton();
            this.encRadio = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.begin = new System.Windows.Forms.Button();
            this.errorMsg = new System.Windows.Forms.Label();
            this.succLabel = new System.Windows.Forms.Label();
            this.selectFolderBtn = new System.Windows.Forms.Button();
            this.openFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.workingLabel = new System.Windows.Forms.Label();
            this.infoBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectFileBtn
            // 
            this.selectFileBtn.Location = new System.Drawing.Point(464, 104);
            this.selectFileBtn.Name = "selectFileBtn";
            this.selectFileBtn.Size = new System.Drawing.Size(82, 23);
            this.selectFileBtn.TabIndex = 0;
            this.selectFileBtn.Text = "Select File(s)";
            this.selectFileBtn.UseVisualStyleBackColor = true;
            this.selectFileBtn.Click += new System.EventHandler(this.selectFileBtn_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.InitialDirectory = "@\"C:\\\"";
            this.openFileDialog.Multiselect = true;
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // filesSelected
            // 
            this.filesSelected.AutoSize = true;
            this.filesSelected.Location = new System.Drawing.Point(374, 109);
            this.filesSelected.Name = "filesSelected";
            this.filesSelected.Size = new System.Drawing.Size(84, 13);
            this.filesSelected.TabIndex = 1;
            this.filesSelected.Text = "X file(s) selected";
            // 
            // encKey
            // 
            this.encKey.Location = new System.Drawing.Point(96, 106);
            this.encKey.Name = "encKey";
            this.encKey.Size = new System.Drawing.Size(142, 20);
            this.encKey.TabIndex = 4;
            // 
            // encKeyLabel
            // 
            this.encKeyLabel.AutoSize = true;
            this.encKeyLabel.Location = new System.Drawing.Point(12, 109);
            this.encKeyLabel.Name = "encKeyLabel";
            this.encKeyLabel.Size = new System.Drawing.Size(78, 13);
            this.encKeyLabel.TabIndex = 5;
            this.encKeyLabel.Text = "Encryption Key";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Hippopotamus Apocalypse", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "BitScrambler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Developed by FireBreath15";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.decRadio);
            this.groupBox1.Controls.Add(this.encRadio);
            this.groupBox1.Location = new System.Drawing.Point(15, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(112, 69);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operation";
            // 
            // decRadio
            // 
            this.decRadio.AutoSize = true;
            this.decRadio.Location = new System.Drawing.Point(16, 42);
            this.decRadio.Name = "decRadio";
            this.decRadio.Size = new System.Drawing.Size(62, 17);
            this.decRadio.TabIndex = 1;
            this.decRadio.Text = "Decrypt";
            this.decRadio.UseVisualStyleBackColor = true;
            // 
            // encRadio
            // 
            this.encRadio.AutoSize = true;
            this.encRadio.Checked = true;
            this.encRadio.Location = new System.Drawing.Point(16, 19);
            this.encRadio.Name = "encRadio";
            this.encRadio.Size = new System.Drawing.Size(61, 17);
            this.encRadio.TabIndex = 0;
            this.encRadio.TabStop = true;
            this.encRadio.Text = "Encrypt";
            this.encRadio.UseVisualStyleBackColor = true;
            // 
            // begin
            // 
            this.begin.Location = new System.Drawing.Point(15, 263);
            this.begin.Name = "begin";
            this.begin.Size = new System.Drawing.Size(531, 23);
            this.begin.TabIndex = 10;
            this.begin.Text = "Start";
            this.begin.UseVisualStyleBackColor = true;
            this.begin.Click += new System.EventHandler(this.begin_Click);
            // 
            // errorMsg
            // 
            this.errorMsg.AutoSize = true;
            this.errorMsg.ForeColor = System.Drawing.Color.Red;
            this.errorMsg.Location = new System.Drawing.Point(12, 247);
            this.errorMsg.Name = "errorMsg";
            this.errorMsg.Size = new System.Drawing.Size(169, 13);
            this.errorMsg.TabIndex = 12;
            this.errorMsg.Text = "There was an error with something";
            // 
            // succLabel
            // 
            this.succLabel.AutoSize = true;
            this.succLabel.ForeColor = System.Drawing.Color.Green;
            this.succLabel.Location = new System.Drawing.Point(228, 247);
            this.succLabel.Name = "succLabel";
            this.succLabel.Size = new System.Drawing.Size(95, 13);
            this.succLabel.TabIndex = 13;
            this.succLabel.Text = "Operation Finished";
            // 
            // selectFolderBtn
            // 
            this.selectFolderBtn.Location = new System.Drawing.Point(464, 134);
            this.selectFolderBtn.Name = "selectFolderBtn";
            this.selectFolderBtn.Size = new System.Drawing.Size(82, 23);
            this.selectFolderBtn.TabIndex = 14;
            this.selectFolderBtn.Text = "Select Folder";
            this.selectFolderBtn.UseVisualStyleBackColor = true;
            this.selectFolderBtn.Click += new System.EventHandler(this.selectFolderBtn_Click);
            // 
            // workingLabel
            // 
            this.workingLabel.AutoSize = true;
            this.workingLabel.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workingLabel.Location = new System.Drawing.Point(269, 247);
            this.workingLabel.Name = "workingLabel";
            this.workingLabel.Size = new System.Drawing.Size(277, 12);
            this.workingLabel.TabIndex = 15;
            this.workingLabel.Text = "Working - do NOT close the program";
            // 
            // infoBtn
            // 
            this.infoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.infoBtn.Location = new System.Drawing.Point(514, 12);
            this.infoBtn.Name = "infoBtn";
            this.infoBtn.Size = new System.Drawing.Size(32, 32);
            this.infoBtn.TabIndex = 16;
            this.infoBtn.Text = "?";
            this.infoBtn.UseVisualStyleBackColor = true;
            this.infoBtn.Click += new System.EventHandler(this.infoBtn_Click);
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 292);
            this.Controls.Add(this.infoBtn);
            this.Controls.Add(this.workingLabel);
            this.Controls.Add(this.selectFolderBtn);
            this.Controls.Add(this.succLabel);
            this.Controls.Add(this.errorMsg);
            this.Controls.Add(this.begin);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.encKeyLabel);
            this.Controls.Add(this.encKey);
            this.Controls.Add(this.filesSelected);
            this.Controls.Add(this.selectFileBtn);
            this.Name = "Window";
            this.Text = "BitScrambler";
            this.Load += new System.EventHandler(this.Window_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectFileBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label filesSelected;
        private System.Windows.Forms.TextBox encKey;
        private System.Windows.Forms.Label encKeyLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton decRadio;
        private System.Windows.Forms.RadioButton encRadio;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button begin;
        private System.Windows.Forms.Label errorMsg;
        private System.Windows.Forms.Label succLabel;
        private System.Windows.Forms.Button selectFolderBtn;
        private System.Windows.Forms.FolderBrowserDialog openFolderDialog;
        private System.Windows.Forms.Label workingLabel;
        private System.Windows.Forms.Button infoBtn;
    }
}

