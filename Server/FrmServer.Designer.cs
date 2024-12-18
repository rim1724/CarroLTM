namespace Server
{
    partial class FrmServer
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
            this.pn_chess2 = new System.Windows.Forms.Panel();
            this.dg_2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_name2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_mark2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_mark1 = new System.Windows.Forms.Label();
            this.lbl_name1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_time_sever = new System.Windows.Forms.Label();
            this.tm_server = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dg_2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_chess2
            // 
            this.pn_chess2.BackColor = System.Drawing.SystemColors.Control;
            this.pn_chess2.Location = new System.Drawing.Point(5, 25);
            this.pn_chess2.Name = "pn_chess2";
            this.pn_chess2.Size = new System.Drawing.Size(362, 394);
            this.pn_chess2.TabIndex = 2;
            // 
            // dg_2
            // 
            this.dg_2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_2.Location = new System.Drawing.Point(373, 279);
            this.dg_2.Name = "dg_2";
            this.dg_2.Size = new System.Drawing.Size(232, 140);
            this.dg_2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(450, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bảng xếp Hạng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên Người Chơi";
            // 
            // lbl_name2
            // 
            this.lbl_name2.AutoSize = true;
            this.lbl_name2.Location = new System.Drawing.Point(93, 26);
            this.lbl_name2.Name = "lbl_name2";
            this.lbl_name2.Size = new System.Drawing.Size(56, 13);
            this.lbl_name2.TabIndex = 5;
            this.lbl_name2.Text = "txt_name2";
            this.lbl_name2.Click += new System.EventHandler(this.lbl_name2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Điểm";
            // 
            // lbl_mark2
            // 
            this.lbl_mark2.AutoSize = true;
            this.lbl_mark2.Location = new System.Drawing.Point(93, 53);
            this.lbl_mark2.Name = "lbl_mark2";
            this.lbl_mark2.Size = new System.Drawing.Size(35, 13);
            this.lbl_mark2.TabIndex = 7;
            this.lbl_mark2.Text = "label4";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbl_mark2);
            this.groupBox1.Controls.Add(this.lbl_name2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(382, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 88);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Người Chơi";
            
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lbl_mark1);
            this.groupBox2.Controls.Add(this.lbl_name1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(382, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 88);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Đối thủ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tên Đối thủ";
            // 
            // lbl_mark1
            // 
            this.lbl_mark1.AutoSize = true;
            this.lbl_mark1.Location = new System.Drawing.Point(93, 53);
            this.lbl_mark1.Name = "lbl_mark1";
            this.lbl_mark1.Size = new System.Drawing.Size(35, 13);
            this.lbl_mark1.TabIndex = 7;
            this.lbl_mark1.Text = "label4";
            // 
            // lbl_name1
            // 
            this.lbl_name1.AutoSize = true;
            this.lbl_name1.Location = new System.Drawing.Point(93, 26);
            this.lbl_name1.Name = "lbl_name1";
            this.lbl_name1.Size = new System.Drawing.Size(56, 13);
            this.lbl_name1.TabIndex = 5;
            this.lbl_name1.Text = "txt_name2";
            this.lbl_name1.Click += new System.EventHandler(this.lbl_name2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Điểm";
            // 
            // lbl_time_sever
            // 
            this.lbl_time_sever.AutoSize = true;
            this.lbl_time_sever.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time_sever.Location = new System.Drawing.Point(459, 124);
            this.lbl_time_sever.Name = "lbl_time_sever";
            this.lbl_time_sever.Size = new System.Drawing.Size(40, 26);
            this.lbl_time_sever.TabIndex = 9;
            this.lbl_time_sever.Text = "60";
            // 
            // tm_server
            // 
            this.tm_server.Tick += new System.EventHandler(this.tm_server_Tick);
            // 
            // FrmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 444);
            this.Controls.Add(this.lbl_time_sever);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dg_2);
            this.Controls.Add(this.pn_chess2);
            this.Name = "FrmServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pn_chess2;
        private System.Windows.Forms.DataGridView dg_2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_name2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_mark2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_mark1;
        private System.Windows.Forms.Label lbl_name1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_time_sever;
        private System.Windows.Forms.Timer tm_server;
    }
}

