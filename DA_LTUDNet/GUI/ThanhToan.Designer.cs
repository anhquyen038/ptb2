namespace DA_LTUDNet
{
    partial class ThanhToan
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_GiaPhong = new System.Windows.Forms.Label();
            this.txt_ThanhToan = new System.Windows.Forms.Label();
            this.txt_NgayO = new System.Windows.Forms.Label();
            this.txt_PhongO = new System.Windows.Forms.Label();
            this.btn_TinhTien = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thanh toán hóa đơn";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 248);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(801, 249);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(743, 190);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_GiaPhong);
            this.groupBox2.Controls.Add(this.txt_ThanhToan);
            this.groupBox2.Controls.Add(this.txt_NgayO);
            this.groupBox2.Controls.Add(this.txt_PhongO);
            this.groupBox2.Controls.Add(this.btn_TinhTien);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(510, 165);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thanh toán";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(319, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Giá Phòng";
            // 
            // txt_GiaPhong
            // 
            this.txt_GiaPhong.AutoSize = true;
            this.txt_GiaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GiaPhong.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_GiaPhong.Location = new System.Drawing.Point(430, 33);
            this.txt_GiaPhong.Name = "txt_GiaPhong";
            this.txt_GiaPhong.Size = new System.Drawing.Size(0, 18);
            this.txt_GiaPhong.TabIndex = 7;
            // 
            // txt_ThanhToan
            // 
            this.txt_ThanhToan.AutoSize = true;
            this.txt_ThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ThanhToan.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_ThanhToan.Location = new System.Drawing.Point(210, 110);
            this.txt_ThanhToan.Name = "txt_ThanhToan";
            this.txt_ThanhToan.Size = new System.Drawing.Size(0, 18);
            this.txt_ThanhToan.TabIndex = 6;
            // 
            // txt_NgayO
            // 
            this.txt_NgayO.AutoSize = true;
            this.txt_NgayO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NgayO.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_NgayO.Location = new System.Drawing.Point(210, 71);
            this.txt_NgayO.Name = "txt_NgayO";
            this.txt_NgayO.Size = new System.Drawing.Size(0, 18);
            this.txt_NgayO.TabIndex = 5;
            // 
            // txt_PhongO
            // 
            this.txt_PhongO.AutoSize = true;
            this.txt_PhongO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PhongO.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_PhongO.Location = new System.Drawing.Point(210, 33);
            this.txt_PhongO.Name = "txt_PhongO";
            this.txt_PhongO.Size = new System.Drawing.Size(0, 18);
            this.txt_PhongO.TabIndex = 4;
            // 
            // btn_TinhTien
            // 
            this.btn_TinhTien.BackColor = System.Drawing.Color.PeachPuff;
            this.btn_TinhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TinhTien.Location = new System.Drawing.Point(390, 130);
            this.btn_TinhTien.Name = "btn_TinhTien";
            this.btn_TinhTien.Size = new System.Drawing.Size(75, 29);
            this.btn_TinhTien.TabIndex = 3;
            this.btn_TinhTien.Text = "Tính tiền";
            this.btn_TinhTien.UseVisualStyleBackColor = false;
            this.btn_TinhTien.Click += new System.EventHandler(this.btn_TinhTien_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tổng Tiền Thanh Toán";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số Ngày Ở";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Phòng Khách Ở";
            // 
            // ThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(897, 561);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "ThanhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThanhToan";
            this.Load += new System.EventHandler(this.ThanhToan_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_TinhTien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txt_ThanhToan;
        private System.Windows.Forms.Label txt_NgayO;
        private System.Windows.Forms.Label txt_PhongO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txt_GiaPhong;
    }
}