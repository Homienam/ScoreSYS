namespace Project_idk
{
    partial class adddiem
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbBcourse = new System.Windows.Forms.ComboBox();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.txtBio = new System.Windows.Forms.TextBox();
            this.buttonAddDiem = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbBid = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Sinh viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Khóa học";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Điểm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mô tả";
            // 
            // cbBcourse
            // 
            this.cbBcourse.FormattingEnabled = true;
            this.cbBcourse.Location = new System.Drawing.Point(145, 139);
            this.cbBcourse.Name = "cbBcourse";
            this.cbBcourse.Size = new System.Drawing.Size(182, 21);
            this.cbBcourse.TabIndex = 5;
            this.cbBcourse.SelectedIndexChanged += new System.EventHandler(this.cbBcourse_SelectedIndexChanged);
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(145, 197);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(182, 20);
            this.txtScore.TabIndex = 6;
            this.txtScore.TextChanged += new System.EventHandler(this.txtScore_TextChanged);
            // 
            // txtBio
            // 
            this.txtBio.Location = new System.Drawing.Point(145, 253);
            this.txtBio.Multiline = true;
            this.txtBio.Name = "txtBio";
            this.txtBio.Size = new System.Drawing.Size(196, 79);
            this.txtBio.TabIndex = 7;
            // 
            // buttonAddDiem
            // 
            this.buttonAddDiem.Location = new System.Drawing.Point(41, 385);
            this.buttonAddDiem.Name = "buttonAddDiem";
            this.buttonAddDiem.Size = new System.Drawing.Size(300, 23);
            this.buttonAddDiem.TabIndex = 8;
            this.buttonAddDiem.Text = "Add Điểm";
            this.buttonAddDiem.UseVisualStyleBackColor = true;
            this.buttonAddDiem.Click += new System.EventHandler(this.buttonAddDiem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(405, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(473, 426);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // cbBid
            // 
            this.cbBid.FormattingEnabled = true;
            this.cbBid.Location = new System.Drawing.Point(145, 71);
            this.cbBid.Name = "cbBid";
            this.cbBid.Size = new System.Drawing.Size(182, 21);
            this.cbBid.TabIndex = 10;
            // 
            // adddiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 450);
            this.Controls.Add(this.cbBid);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonAddDiem);
            this.Controls.Add(this.txtBio);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.cbBcourse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "adddiem";
            this.Text = "Adddiem_Form";
            this.Load += new System.EventHandler(this.adddiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbBcourse;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.TextBox txtBio;
        private System.Windows.Forms.Button buttonAddDiem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbBid;
    }
}