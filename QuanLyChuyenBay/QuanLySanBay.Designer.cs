namespace QuanLyChuyenBay
{
    partial class SanBay
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
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtMaSanBay = new System.Windows.Forms.TextBox();
            this.txtTenSanBay = new System.Windows.Forms.TextBox();
            this.btnThemSB = new System.Windows.Forms.Button();
            this.btnTaoMoiSB = new System.Windows.Forms.Button();
            this.btnThoatSB = new System.Windows.Forms.Button();
            this.dgvSanBay = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTinhThanh = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanBay)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(65, 15);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(270, 47);
            this.Label1.TabIndex = 34;
            this.Label1.Text = "THÊM SÂN BAY";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(79, 81);
            this.Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(95, 23);
            this.Label2.TabIndex = 35;
            this.Label2.Text = "Mã Sân Bay";
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(78, 122);
            this.Label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(95, 23);
            this.Label3.TabIndex = 36;
            this.Label3.Text = "Tên Sân Bay";
            // 
            // txtMaSanBay
            // 
            this.txtMaSanBay.ForeColor = System.Drawing.Color.Blue;
            this.txtMaSanBay.Location = new System.Drawing.Point(178, 78);
            this.txtMaSanBay.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaSanBay.Name = "txtMaSanBay";
            this.txtMaSanBay.Size = new System.Drawing.Size(210, 20);
            this.txtMaSanBay.TabIndex = 37;
            // 
            // txtTenSanBay
            // 
            this.txtTenSanBay.ForeColor = System.Drawing.Color.Blue;
            this.txtTenSanBay.Location = new System.Drawing.Point(178, 119);
            this.txtTenSanBay.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenSanBay.Name = "txtTenSanBay";
            this.txtTenSanBay.Size = new System.Drawing.Size(210, 20);
            this.txtTenSanBay.TabIndex = 38;
            // 
            // btnThemSB
            // 
            this.btnThemSB.BackColor = System.Drawing.Color.AliceBlue;
            this.btnThemSB.Location = new System.Drawing.Point(69, 198);
            this.btnThemSB.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemSB.Name = "btnThemSB";
            this.btnThemSB.Size = new System.Drawing.Size(73, 32);
            this.btnThemSB.TabIndex = 39;
            this.btnThemSB.Text = "Thêm";
            this.btnThemSB.UseVisualStyleBackColor = false;
            this.btnThemSB.Click += new System.EventHandler(this.btnThemSB_Click);
            // 
            // btnTaoMoiSB
            // 
            this.btnTaoMoiSB.BackColor = System.Drawing.Color.AliceBlue;
            this.btnTaoMoiSB.Location = new System.Drawing.Point(193, 198);
            this.btnTaoMoiSB.Margin = new System.Windows.Forms.Padding(2);
            this.btnTaoMoiSB.Name = "btnTaoMoiSB";
            this.btnTaoMoiSB.Size = new System.Drawing.Size(72, 32);
            this.btnTaoMoiSB.TabIndex = 40;
            this.btnTaoMoiSB.Text = "Tạo Mới";
            this.btnTaoMoiSB.UseVisualStyleBackColor = false;
            // 
            // btnThoatSB
            // 
            this.btnThoatSB.BackColor = System.Drawing.Color.AliceBlue;
            this.btnThoatSB.Location = new System.Drawing.Point(315, 198);
            this.btnThoatSB.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoatSB.Name = "btnThoatSB";
            this.btnThoatSB.Size = new System.Drawing.Size(73, 32);
            this.btnThoatSB.TabIndex = 41;
            this.btnThoatSB.Text = "Thoát";
            this.btnThoatSB.UseVisualStyleBackColor = false;
            this.btnThoatSB.Click += new System.EventHandler(this.btnThoatSB_Click);
            // 
            // dgvSanBay
            // 
            this.dgvSanBay.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvSanBay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanBay.Location = new System.Drawing.Point(8, 234);
            this.dgvSanBay.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSanBay.Name = "dgvSanBay";
            this.dgvSanBay.RowTemplate.Height = 24;
            this.dgvSanBay.Size = new System.Drawing.Size(435, 209);
            this.dgvSanBay.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(78, 161);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 23);
            this.label4.TabIndex = 36;
            this.label4.Text = "Tỉnh Thành";
            // 
            // txtTinhThanh
            // 
            this.txtTinhThanh.ForeColor = System.Drawing.Color.Blue;
            this.txtTinhThanh.Location = new System.Drawing.Point(178, 158);
            this.txtTinhThanh.Margin = new System.Windows.Forms.Padding(2);
            this.txtTinhThanh.Name = "txtTinhThanh";
            this.txtTinhThanh.Size = new System.Drawing.Size(210, 20);
            this.txtTinhThanh.TabIndex = 38;
            // 
            // SanBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(455, 450);
            this.Controls.Add(this.dgvSanBay);
            this.Controls.Add(this.btnThoatSB);
            this.Controls.Add(this.btnTaoMoiSB);
            this.Controls.Add(this.btnThemSB);
            this.Controls.Add(this.txtTinhThanh);
            this.Controls.Add(this.txtTenSanBay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMaSanBay);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SanBay";
            this.Text = "SanBay";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanBay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtMaSanBay;
        internal System.Windows.Forms.TextBox txtTenSanBay;
        internal System.Windows.Forms.Button btnThemSB;
        internal System.Windows.Forms.Button btnTaoMoiSB;
        internal System.Windows.Forms.Button btnThoatSB;
        private System.Windows.Forms.DataGridView dgvSanBay;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox txtTinhThanh;
    }
}