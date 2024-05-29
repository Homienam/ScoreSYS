namespace Project_idk
{
    partial class ManageScore
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.buttonAddDiem2 = new System.Windows.Forms.Button();
            this.txtBio2 = new System.Windows.Forms.TextBox();
            this.txtScore2 = new System.Windows.Forms.TextBox();
            this.cbBcourse2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonXoaDiem = new System.Windows.Forms.Button();
            this.buttonDiemTB = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonShowSV = new System.Windows.Forms.Button();
            this.buttonShowScore = new System.Windows.Forms.Button();
            this.cbBid2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(315, 39);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(473, 387);
            this.dataGridView2.TabIndex = 19;
            this.dataGridView2.Click += new System.EventHandler(this.dataGridView2_Click);
            // 
            // buttonAddDiem2
            // 
            this.buttonAddDiem2.Location = new System.Drawing.Point(75, 360);
            this.buttonAddDiem2.Name = "buttonAddDiem2";
            this.buttonAddDiem2.Size = new System.Drawing.Size(193, 23);
            this.buttonAddDiem2.TabIndex = 18;
            this.buttonAddDiem2.Text = "Add Điểm";
            this.buttonAddDiem2.UseVisualStyleBackColor = true;
            this.buttonAddDiem2.Click += new System.EventHandler(this.buttonAddDiem2_Click);
            // 
            // txtBio2
            // 
            this.txtBio2.Location = new System.Drawing.Point(86, 253);
            this.txtBio2.Multiline = true;
            this.txtBio2.Name = "txtBio2";
            this.txtBio2.Size = new System.Drawing.Size(196, 79);
            this.txtBio2.TabIndex = 17;
            // 
            // txtScore2
            // 
            this.txtScore2.Location = new System.Drawing.Point(86, 197);
            this.txtScore2.Name = "txtScore2";
            this.txtScore2.Size = new System.Drawing.Size(182, 20);
            this.txtScore2.TabIndex = 16;
            this.txtScore2.TextChanged += new System.EventHandler(this.txtScore2_TextChanged);
            // 
            // cbBcourse2
            // 
            this.cbBcourse2.FormattingEnabled = true;
            this.cbBcourse2.Location = new System.Drawing.Point(86, 142);
            this.cbBcourse2.Name = "cbBcourse2";
            this.cbBcourse2.Size = new System.Drawing.Size(182, 21);
            this.cbBcourse2.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Mô tả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Điểm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Khóa học";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID Sinh viên";
            // 
            // buttonXoaDiem
            // 
            this.buttonXoaDiem.Location = new System.Drawing.Point(75, 389);
            this.buttonXoaDiem.Name = "buttonXoaDiem";
            this.buttonXoaDiem.Size = new System.Drawing.Size(193, 23);
            this.buttonXoaDiem.TabIndex = 20;
            this.buttonXoaDiem.Text = "Xoa";
            this.buttonXoaDiem.UseVisualStyleBackColor = true;
            this.buttonXoaDiem.Click += new System.EventHandler(this.buttonXoaDiem_Click);
            // 
            // buttonDiemTB
            // 
            this.buttonDiemTB.Location = new System.Drawing.Point(75, 418);
            this.buttonDiemTB.Name = "buttonDiemTB";
            this.buttonDiemTB.Size = new System.Drawing.Size(193, 23);
            this.buttonDiemTB.TabIndex = 21;
            this.buttonDiemTB.Text = "Diem TB theo khoa hoc";
            this.buttonDiemTB.UseVisualStyleBackColor = true;
            this.buttonDiemTB.Click += new System.EventHandler(this.buttonDiemTB_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(386, 429);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(358, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "de edit diem ta can xoa diem can xoa di,sau do add lai gia tri ma ban muon";
            // 
            // buttonShowSV
            // 
            this.buttonShowSV.Location = new System.Drawing.Point(315, 10);
            this.buttonShowSV.Name = "buttonShowSV";
            this.buttonShowSV.Size = new System.Drawing.Size(157, 23);
            this.buttonShowSV.TabIndex = 23;
            this.buttonShowSV.Text = "Hien bang sinh vien";
            this.buttonShowSV.UseVisualStyleBackColor = true;
            this.buttonShowSV.Click += new System.EventHandler(this.buttonShowSV_Click);
            // 
            // buttonShowScore
            // 
            this.buttonShowScore.Location = new System.Drawing.Point(631, 10);
            this.buttonShowScore.Name = "buttonShowScore";
            this.buttonShowScore.Size = new System.Drawing.Size(157, 23);
            this.buttonShowScore.TabIndex = 24;
            this.buttonShowScore.Text = "Hien bang diem";
            this.buttonShowScore.UseVisualStyleBackColor = true;
            this.buttonShowScore.Click += new System.EventHandler(this.buttonShowScore_Click);
            // 
            // cbBid2
            // 
            this.cbBid2.FormattingEnabled = true;
            this.cbBid2.Location = new System.Drawing.Point(86, 72);
            this.cbBid2.Name = "cbBid2";
            this.cbBid2.Size = new System.Drawing.Size(182, 21);
            this.cbBid2.TabIndex = 25;
            // 
            // ManageScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbBid2);
            this.Controls.Add(this.buttonShowScore);
            this.Controls.Add(this.buttonShowSV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonDiemTB);
            this.Controls.Add(this.buttonXoaDiem);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.buttonAddDiem2);
            this.Controls.Add(this.txtBio2);
            this.Controls.Add(this.txtScore2);
            this.Controls.Add(this.cbBcourse2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ManageScore";
            this.Text = "ManageScore";
            this.Load += new System.EventHandler(this.ManageScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button buttonAddDiem2;
        private System.Windows.Forms.TextBox txtBio2;
        private System.Windows.Forms.TextBox txtScore2;
        private System.Windows.Forms.ComboBox cbBcourse2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonXoaDiem;
        private System.Windows.Forms.Button buttonDiemTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonShowSV;
        private System.Windows.Forms.Button buttonShowScore;
        private System.Windows.Forms.ComboBox cbBid2;
    }
}