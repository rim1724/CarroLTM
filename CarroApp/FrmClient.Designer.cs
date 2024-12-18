namespace CarroApp
{
    partial class FrmClient
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
            this.components = new System.ComponentModel.Container();
            this.pn_chess = new System.Windows.Forms.Panel();
            this.lbl_status = new System.Windows.Forms.Label();
            this.btn_connect = new System.Windows.Forms.Button();
            this.dg_1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_name1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_mark1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_mark2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_name2 = new System.Windows.Forms.Label();
            this.tm_client = new System.Windows.Forms.Timer(this.components);
            this.lbl_time_client = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_chess
            // 
            this.pn_chess.BackColor = System.Drawing.SystemColors.Control;
            this.pn_chess.Location = new System.Drawing.Point(12, 41);
            this.pn_chess.Name = "pn_chess";
            this.pn_chess.Size = new System.Drawing.Size(387, 394);
            this.pn_chess.TabIndex = 0;
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.Location = new System.Drawing.Point(205, 17);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(96, 18);
            this.lbl_status.TabIndex = 3;
            this.lbl_status.Text = "DisConnect";
            
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(70, 12);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(75, 23);
            this.btn_connect.TabIndex = 2;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // dg_1
            // 
            this.dg_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_1.Location = new System.Drawing.Point(405, 287);
            this.dg_1.Name = "dg_1";
            this.dg_1.Size = new System.Drawing.Size(230, 148);
            this.dg_1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(476, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bảng xếp Hạng";
            
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên Người Chơi";
            // 
            // lbl_name1
            // 
            this.lbl_name1.AutoSize = true;
            this.lbl_name1.Location = new System.Drawing.Point(93, 30);
            this.lbl_name1.Name = "lbl_name1";
            this.lbl_name1.Size = new System.Drawing.Size(35, 13);
            this.lbl_name1.TabIndex = 6;
            this.lbl_name1.Text = "label2";
            this.lbl_name1.Click += new System.EventHandler(this.lbl_name1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Số Điểm";
            // 
            // lbl_mark1
            // 
            this.lbl_mark1.AutoSize = true;
            this.lbl_mark1.Location = new System.Drawing.Point(93, 64);
            this.lbl_mark1.Name = "lbl_mark1";
            this.lbl_mark1.Size = new System.Drawing.Size(35, 13);
            this.lbl_mark1.TabIndex = 8;
            this.lbl_mark1.Text = "label4";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_mark1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbl_name1);
            this.groupBox1.Location = new System.Drawing.Point(429, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin người chơi";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_mark2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lbl_name2);
            this.groupBox2.Location = new System.Drawing.Point(429, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(183, 100);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin Đối thủ";
            // 
            // lbl_mark2
            // 
            this.lbl_mark2.AutoSize = true;
            this.lbl_mark2.Location = new System.Drawing.Point(93, 64);
            this.lbl_mark2.Name = "lbl_mark2";
            this.lbl_mark2.Size = new System.Drawing.Size(35, 13);
            this.lbl_mark2.TabIndex = 8;
            this.lbl_mark2.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tên Đối thủ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Số Điểm";
            // 
            // lbl_name2
            // 
            this.lbl_name2.AutoSize = true;
            this.lbl_name2.Location = new System.Drawing.Point(93, 30);
            this.lbl_name2.Name = "lbl_name2";
            this.lbl_name2.Size = new System.Drawing.Size(35, 13);
            this.lbl_name2.TabIndex = 6;
            this.lbl_name2.Text = "label2";
            // 
            // tm_client
            // 
            this.tm_client.Tick += new System.EventHandler(this.tm_client_Tick);
            // 
            // lbl_time_client
            // 
            this.lbl_time_client.AutoSize = true;
            this.lbl_time_client.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time_client.Location = new System.Drawing.Point(497, 129);
            this.lbl_time_client.Name = "lbl_time_client";
            this.lbl_time_client.Size = new System.Drawing.Size(40, 26);
            this.lbl_time_client.TabIndex = 10;
            this.lbl_time_client.Text = "60";
            // 
            // FrmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 444);
            this.Controls.Add(this.lbl_time_client);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dg_1);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.pn_chess);
            this.Controls.Add(this.btn_connect);
            this.Name = "FrmClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pn_chess;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.DataGridView dg_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_name1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_mark1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_mark2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_name2;
        private System.Windows.Forms.Timer tm_client;
        private System.Windows.Forms.Label lbl_time_client;
    }
}

