namespace Concours35_MonitorRanking
{
    partial class Form1
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
            this.button_selectFile = new System.Windows.Forms.Button();
            this.label_selectedFile = new System.Windows.Forms.Label();
            this.button_selectOutputFolder = new System.Windows.Forms.Button();
            this.label_selectedOutputFolder = new System.Windows.Forms.Label();
            this.button_run = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_selectFile
            // 
            this.button_selectFile.Location = new System.Drawing.Point(102, 61);
            this.button_selectFile.Name = "button_selectFile";
            this.button_selectFile.Size = new System.Drawing.Size(149, 23);
            this.button_selectFile.TabIndex = 0;
            this.button_selectFile.Text = "Select .DAT file";
            this.button_selectFile.UseVisualStyleBackColor = true;
            this.button_selectFile.Click += new System.EventHandler(this.button_selectFile_Click);
            // 
            // label_selectedFile
            // 
            this.label_selectedFile.AutoSize = true;
            this.label_selectedFile.Location = new System.Drawing.Point(301, 61);
            this.label_selectedFile.Name = "label_selectedFile";
            this.label_selectedFile.Size = new System.Drawing.Size(121, 16);
            this.label_selectedFile.TabIndex = 1;
            this.label_selectedFile.Text = "No file selected yet";
            // 
            // button_selectOutputFolder
            // 
            this.button_selectOutputFolder.Location = new System.Drawing.Point(102, 195);
            this.button_selectOutputFolder.Name = "button_selectOutputFolder";
            this.button_selectOutputFolder.Size = new System.Drawing.Size(149, 23);
            this.button_selectOutputFolder.TabIndex = 2;
            this.button_selectOutputFolder.Text = "Select Output Folder";
            this.button_selectOutputFolder.UseVisualStyleBackColor = true;
            this.button_selectOutputFolder.Click += new System.EventHandler(this.button_selectOutputFolder_Click);
            // 
            // label_selectedOutputFolder
            // 
            this.label_selectedOutputFolder.AutoSize = true;
            this.label_selectedOutputFolder.Location = new System.Drawing.Point(304, 195);
            this.label_selectedOutputFolder.Name = "label_selectedOutputFolder";
            this.label_selectedOutputFolder.Size = new System.Drawing.Size(177, 16);
            this.label_selectedOutputFolder.TabIndex = 3;
            this.label_selectedOutputFolder.Text = "No output folder selected yet";
            // 
            // button_run
            // 
            this.button_run.Location = new System.Drawing.Point(102, 277);
            this.button_run.Name = "button_run";
            this.button_run.Size = new System.Drawing.Size(75, 23);
            this.button_run.TabIndex = 4;
            this.button_run.Text = "Run";
            this.button_run.UseVisualStyleBackColor = true;
            this.button_run.Click += new System.EventHandler(this.button_run_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(408, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "https://github.com/Marthaarman/Concours35-monitor-to-ranking";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 422);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "V1.0.0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_run);
            this.Controls.Add(this.label_selectedOutputFolder);
            this.Controls.Add(this.button_selectOutputFolder);
            this.Controls.Add(this.label_selectedFile);
            this.Controls.Add(this.button_selectFile);
            this.Name = "Form1";
            this.Text = "Concours35 monitor to ranking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_selectFile;
        private System.Windows.Forms.Label label_selectedFile;
        private System.Windows.Forms.Button button_selectOutputFolder;
        private System.Windows.Forms.Label label_selectedOutputFolder;
        private System.Windows.Forms.Button button_run;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

