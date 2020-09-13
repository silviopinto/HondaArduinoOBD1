namespace HondaDashboard
{
    partial class Connection
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
            this.cb_port = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_boudRate = new System.Windows.Forms.ComboBox();
            this.cb_bits = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl_newPort = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_port
            // 
            this.cb_port.FormattingEnabled = true;
            this.cb_port.Location = new System.Drawing.Point(86, 18);
            this.cb_port.Name = "cb_port";
            this.cb_port.Size = new System.Drawing.Size(121, 21);
            this.cb_port.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Baud Rate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Bits:";
            // 
            // cb_boudRate
            // 
            this.cb_boudRate.FormattingEnabled = true;
            this.cb_boudRate.Location = new System.Drawing.Point(86, 60);
            this.cb_boudRate.Name = "cb_boudRate";
            this.cb_boudRate.Size = new System.Drawing.Size(121, 21);
            this.cb_boudRate.TabIndex = 5;
            // 
            // cb_bits
            // 
            this.cb_bits.FormattingEnabled = true;
            this.cb_bits.Location = new System.Drawing.Point(86, 101);
            this.cb_bits.Name = "cb_bits";
            this.cb_bits.Size = new System.Drawing.Size(121, 21);
            this.cb_bits.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(130, 176);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(77, 23);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "&Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(30, 176);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "&Refresh";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_newPort
            // 
            this.lbl_newPort.AutoSize = true;
            this.lbl_newPort.ForeColor = System.Drawing.Color.Green;
            this.lbl_newPort.Location = new System.Drawing.Point(89, 41);
            this.lbl_newPort.Name = "lbl_newPort";
            this.lbl_newPort.Size = new System.Drawing.Size(95, 13);
            this.lbl_newPort.TabIndex = 10;
            this.lbl_newPort.Text = "New port available";
            this.lbl_newPort.Visible = false;
            // 
            // Connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 213);
            this.Controls.Add(this.lbl_newPort);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_bits);
            this.Controls.Add(this.cb_boudRate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_port);
            this.Name = "Connection";
            this.Text = "Connection";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Connection_FormClosing);
            this.Load += new System.EventHandler(this.Connection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_port;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_boudRate;
        private System.Windows.Forms.ComboBox cb_bits;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl_newPort;
    }
}