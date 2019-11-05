namespace WinformApp
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
            this.Sync = new System.Windows.Forms.TabControl();
            this.SyncTab = new System.Windows.Forms.TabPage();
            this.StopButton = new System.Windows.Forms.Button();
            this.SyncButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Sync.SuspendLayout();
            this.SyncTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // Sync
            // 
            this.Sync.AccessibleName = "";
            this.Sync.Controls.Add(this.SyncTab);
            this.Sync.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Sync.ItemSize = new System.Drawing.Size(58, 18);
            this.Sync.Location = new System.Drawing.Point(0, 0);
            this.Sync.Name = "Sync";
            this.Sync.SelectedIndex = 0;
            this.Sync.Size = new System.Drawing.Size(784, 561);
            this.Sync.TabIndex = 3;
            // 
            // SyncTab
            // 
            this.SyncTab.Controls.Add(this.richTextBox1);
            this.SyncTab.Controls.Add(this.StopButton);
            this.SyncTab.Controls.Add(this.SyncButton);
            this.SyncTab.Location = new System.Drawing.Point(4, 22);
            this.SyncTab.Name = "SyncTab";
            this.SyncTab.Padding = new System.Windows.Forms.Padding(3);
            this.SyncTab.Size = new System.Drawing.Size(776, 535);
            this.SyncTab.TabIndex = 0;
            this.SyncTab.Text = "Sync";
            this.SyncTab.UseVisualStyleBackColor = true;
            // 
            // StopButton
            // 
            this.StopButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopButton.Location = new System.Drawing.Point(157, 3);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(148, 47);
            this.StopButton.TabIndex = 1;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // SyncButton
            // 
            this.SyncButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SyncButton.Location = new System.Drawing.Point(3, 3);
            this.SyncButton.Name = "SyncButton";
            this.SyncButton.Size = new System.Drawing.Size(148, 47);
            this.SyncButton.TabIndex = 0;
            this.SyncButton.Text = "Sync";
            this.SyncButton.UseVisualStyleBackColor = true;
            this.SyncButton.Click += new System.EventHandler(this.SyncButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Desktop;
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Location = new System.Drawing.Point(3, 56);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(773, 479);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.Sync);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Sync.ResumeLayout(false);
            this.SyncTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Sync;
        private System.Windows.Forms.TabPage SyncTab;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button SyncButton;
    }
}

