namespace BangGiaXe
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_hangxe = new System.Windows.Forms.TextBox();
            this.tb_phienban = new System.Windows.Forms.TextBox();
            this.tb_dongxe = new System.Windows.Forms.TextBox();
            this.tb_dongco = new System.Windows.Forms.TextBox();
            this.tb_gia = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dtgr_Card = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgr_Card)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hãng xe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dòng xe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phiên bản";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(372, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Động cơ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(372, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giá";
            // 
            // tb_hangxe
            // 
            this.tb_hangxe.Location = new System.Drawing.Point(120, 34);
            this.tb_hangxe.Name = "tb_hangxe";
            this.tb_hangxe.Size = new System.Drawing.Size(100, 22);
            this.tb_hangxe.TabIndex = 5;
            // 
            // tb_phienban
            // 
            this.tb_phienban.Location = new System.Drawing.Point(120, 122);
            this.tb_phienban.Name = "tb_phienban";
            this.tb_phienban.Size = new System.Drawing.Size(100, 22);
            this.tb_phienban.TabIndex = 6;
            // 
            // tb_dongxe
            // 
            this.tb_dongxe.Location = new System.Drawing.Point(120, 75);
            this.tb_dongxe.Name = "tb_dongxe";
            this.tb_dongxe.Size = new System.Drawing.Size(100, 22);
            this.tb_dongxe.TabIndex = 7;
            // 
            // tb_dongco
            // 
            this.tb_dongco.Location = new System.Drawing.Point(452, 32);
            this.tb_dongco.Name = "tb_dongco";
            this.tb_dongco.Size = new System.Drawing.Size(100, 22);
            this.tb_dongco.TabIndex = 8;
            // 
            // tb_gia
            // 
            this.tb_gia.Location = new System.Drawing.Point(452, 73);
            this.tb_gia.Name = "tb_gia";
            this.tb_gia.Size = new System.Drawing.Size(100, 22);
            this.tb_gia.TabIndex = 9;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(666, 33);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 10;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(666, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(666, 122);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(666, 161);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "Tìm kiếm";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dtgr_Card
            // 
            this.dtgr_Card.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgr_Card.Location = new System.Drawing.Point(12, 288);
            this.dtgr_Card.Name = "dtgr_Card";
            this.dtgr_Card.RowHeadersWidth = 51;
            this.dtgr_Card.RowTemplate.Height = 24;
            this.dtgr_Card.Size = new System.Drawing.Size(776, 150);
            this.dtgr_Card.TabIndex = 14;
            this.dtgr_Card.SelectionChanged += new System.EventHandler(this.dtgr_Card_SelectionChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgr_Card);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.tb_gia);
            this.Controls.Add(this.tb_dongco);
            this.Controls.Add(this.tb_dongxe);
            this.Controls.Add(this.tb_phienban);
            this.Controls.Add(this.tb_hangxe);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Bảng giá xe";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgr_Card)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_hangxe;
        private System.Windows.Forms.TextBox tb_phienban;
        private System.Windows.Forms.TextBox tb_dongxe;
        private System.Windows.Forms.TextBox tb_dongco;
        private System.Windows.Forms.TextBox tb_gia;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dtgr_Card;
    }
}

