namespace Project_idk
{
    partial class AddSinhvien_Form
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbGender = new System.Windows.Forms.TextBox();
            this.txbKhoa = new System.Windows.Forms.TextBox();
            this.txtNganh = new System.Windows.Forms.TextBox();
            this.lblDiachi = new System.Windows.Forms.Label();
            this.lblSdt = new System.Windows.Forms.Label();
            this.txbDiachi = new System.Windows.Forms.TextBox();
            this.txbSdt = new System.Windows.Forms.TextBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.dtpdate = new System.Windows.Forms.DateTimePicker();
            this.buttonAddSinhvien = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(58, 56);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Ho ten";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(58, 99);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(54, 13);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Ngay sinh";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(58, 146);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(45, 13);
            this.lblGender.TabIndex = 2;
            this.lblGender.Text = "Gioi tinh";
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Location = new System.Drawing.Point(58, 206);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(31, 13);
            this.lblKhoa.TabIndex = 3;
            this.lblKhoa.Text = "khóa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nganh";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(177, 48);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(100, 20);
            this.txbName.TabIndex = 6;
            // 
            // txbGender
            // 
            this.txbGender.Location = new System.Drawing.Point(177, 143);
            this.txbGender.Name = "txbGender";
            this.txbGender.Size = new System.Drawing.Size(100, 20);
            this.txbGender.TabIndex = 8;
            // 
            // txbKhoa
            // 
            this.txbKhoa.Location = new System.Drawing.Point(177, 203);
            this.txbKhoa.Name = "txbKhoa";
            this.txbKhoa.Size = new System.Drawing.Size(100, 20);
            this.txbKhoa.TabIndex = 9;
            // 
            // txtNganh
            // 
            this.txtNganh.Location = new System.Drawing.Point(177, 270);
            this.txtNganh.Name = "txtNganh";
            this.txtNganh.Size = new System.Drawing.Size(100, 20);
            this.txtNganh.TabIndex = 10;
            // 
            // lblDiachi
            // 
            this.lblDiachi.AutoSize = true;
            this.lblDiachi.Location = new System.Drawing.Point(61, 339);
            this.lblDiachi.Name = "lblDiachi";
            this.lblDiachi.Size = new System.Drawing.Size(40, 13);
            this.lblDiachi.TabIndex = 11;
            this.lblDiachi.Text = "Dia chi";
            // 
            // lblSdt
            // 
            this.lblSdt.AutoSize = true;
            this.lblSdt.Location = new System.Drawing.Point(61, 390);
            this.lblSdt.Name = "lblSdt";
            this.lblSdt.Size = new System.Drawing.Size(21, 13);
            this.lblSdt.TabIndex = 12;
            this.lblSdt.Text = "sdt";
            // 
            // txbDiachi
            // 
            this.txbDiachi.Location = new System.Drawing.Point(177, 332);
            this.txbDiachi.Name = "txbDiachi";
            this.txbDiachi.Size = new System.Drawing.Size(100, 20);
            this.txbDiachi.TabIndex = 13;
            // 
            // txbSdt
            // 
            this.txbSdt.Location = new System.Drawing.Point(177, 387);
            this.txbSdt.Name = "txbSdt";
            this.txbSdt.Size = new System.Drawing.Size(100, 20);
            this.txbSdt.TabIndex = 14;
            // 
            // dtpdate
            // 
            this.dtpdate.Location = new System.Drawing.Point(177, 99);
            this.dtpdate.Name = "dtpdate";
            this.dtpdate.Size = new System.Drawing.Size(200, 20);
            this.dtpdate.TabIndex = 15;
            // 
            // buttonAddSinhvien
            // 
            this.buttonAddSinhvien.Location = new System.Drawing.Point(478, 174);
            this.buttonAddSinhvien.Name = "buttonAddSinhvien";
            this.buttonAddSinhvien.Size = new System.Drawing.Size(229, 142);
            this.buttonAddSinhvien.TabIndex = 16;
            this.buttonAddSinhvien.Text = "ADD";
            this.buttonAddSinhvien.UseVisualStyleBackColor = true;
            this.buttonAddSinhvien.Click += new System.EventHandler(this.buttonAddSinhvien_Click);
            // 
            // AddSinhvien_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAddSinhvien);
            this.Controls.Add(this.dtpdate);
            this.Controls.Add(this.txbSdt);
            this.Controls.Add(this.txbDiachi);
            this.Controls.Add(this.lblSdt);
            this.Controls.Add(this.lblDiachi);
            this.Controls.Add(this.txtNganh);
            this.Controls.Add(this.txbKhoa);
            this.Controls.Add(this.txbGender);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblKhoa);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblName);
            this.Name = "AddSinhvien_Form";
            this.Text = "AddSinhvien_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.Label label6;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbGender;
        private System.Windows.Forms.TextBox txbKhoa;
        private System.Windows.Forms.TextBox txtNganh;
        private System.Windows.Forms.Label lblDiachi;
        private System.Windows.Forms.Label lblSdt;
        private System.Windows.Forms.TextBox txbDiachi;
        private System.Windows.Forms.TextBox txbSdt;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.DateTimePicker dtpdate;
        private System.Windows.Forms.Button buttonAddSinhvien;
    }
}