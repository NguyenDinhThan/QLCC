namespace QLCC
{
    partial class Form8
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnvaold = new System.Windows.Forms.Button();
            this.btnra = new System.Windows.Forms.Button();
            this.btntangca = new System.Windows.Forms.Button();
            this.btnload = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.btnvao = new System.Windows.Forms.Button();
            this.btnbc = new System.Windows.Forms.Button();
            this.btnrs = new System.Windows.Forms.Button();
            this.btncc = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(0, 300);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 133);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(279, 75);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID nhân viên: ";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(107, 222);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nghỉ phép: ";
            // 
            // btnvaold
            // 
            this.btnvaold.Location = new System.Drawing.Point(420, 66);
            this.btnvaold.Name = "btnvaold";
            this.btnvaold.Size = new System.Drawing.Size(104, 37);
            this.btnvaold.TabIndex = 7;
            this.btnvaold.Text = "Vào lần đầu";
            this.btnvaold.UseVisualStyleBackColor = true;
            this.btnvaold.Click += new System.EventHandler(this.btnvaold_Click);
            // 
            // btnra
            // 
            this.btnra.Location = new System.Drawing.Point(234, 138);
            this.btnra.Name = "btnra";
            this.btnra.Size = new System.Drawing.Size(104, 37);
            this.btnra.TabIndex = 9;
            this.btnra.Text = "Ra";
            this.btnra.UseVisualStyleBackColor = true;
            this.btnra.Click += new System.EventHandler(this.btnra_Click);
            // 
            // btntangca
            // 
            this.btntangca.Location = new System.Drawing.Point(399, 138);
            this.btntangca.Name = "btntangca";
            this.btntangca.Size = new System.Drawing.Size(104, 37);
            this.btntangca.TabIndex = 10;
            this.btntangca.Text = "Tăng ca";
            this.btntangca.UseVisualStyleBackColor = true;
            this.btntangca.Click += new System.EventHandler(this.btntangca_Click);
            // 
            // btnload
            // 
            this.btnload.Location = new System.Drawing.Point(592, 138);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(104, 37);
            this.btnload.TabIndex = 11;
            this.btnload.Text = "Load";
            this.btnload.UseVisualStyleBackColor = true;
            this.btnload.Click += new System.EventHandler(this.btnload_Click);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(725, 1);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 23);
            this.btnback.TabIndex = 12;
            this.btnback.Text = "Quay Lại";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnvao
            // 
            this.btnvao.Location = new System.Drawing.Point(76, 138);
            this.btnvao.Name = "btnvao";
            this.btnvao.Size = new System.Drawing.Size(103, 37);
            this.btnvao.TabIndex = 8;
            this.btnvao.Text = "Vào";
            this.btnvao.UseVisualStyleBackColor = true;
            this.btnvao.Click += new System.EventHandler(this.btnvao_Click);
            // 
            // btnbc
            // 
            this.btnbc.Location = new System.Drawing.Point(12, 259);
            this.btnbc.Name = "btnbc";
            this.btnbc.Size = new System.Drawing.Size(75, 23);
            this.btnbc.TabIndex = 13;
            this.btnbc.Text = "báo cáo";
            this.btnbc.UseVisualStyleBackColor = true;
            this.btnbc.Click += new System.EventHandler(this.btnbc_Click);
            // 
            // btnrs
            // 
            this.btnrs.Location = new System.Drawing.Point(685, 237);
            this.btnrs.Name = "btnrs";
            this.btnrs.Size = new System.Drawing.Size(75, 23);
            this.btnrs.TabIndex = 14;
            this.btnrs.Text = "reset ngày";
            this.btnrs.UseVisualStyleBackColor = true;
            this.btnrs.Click += new System.EventHandler(this.btnrs_Click);
            // 
            // btncc
            // 
            this.btncc.Location = new System.Drawing.Point(519, 237);
            this.btncc.Name = "btncc";
            this.btncc.Size = new System.Drawing.Size(75, 23);
            this.btncc.TabIndex = 15;
            this.btncc.Text = "Chấm công";
            this.btncc.UseVisualStyleBackColor = true;
            this.btncc.Click += new System.EventHandler(this.btncc_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8});
            this.dataGridView2.Location = new System.Drawing.Point(0, 439);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(800, 97);
            this.dataGridView2.TabIndex = 16;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.DataPropertyName = "iEmployeeID";
            this.Column7.HeaderText = "ID nhân viên";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.DataPropertyName = "iDayWork";
            this.Column8.HeaderText = "Số ngày đi làm";
            this.Column8.Name = "Column8";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "iTimeSheetID";
            this.Column1.HeaderText = "STT";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "iEmployeeID";
            this.Column2.HeaderText = "ID nhân viên";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "dDateTimeIn";
            this.Column3.HeaderText = "Giờ vào";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "dDateTimeOut";
            this.Column4.HeaderText = "Giờ ra";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "dWorkOvertime";
            this.Column5.HeaderText = "Ngày tăng ca";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "sAllowOff";
            this.Column6.HeaderText = "Nghỉ phép";
            this.Column6.Name = "Column6";
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 537);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btncc);
            this.Controls.Add(this.btnrs);
            this.Controls.Add(this.btnbc);
            this.Controls.Add(this.btnvao);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnload);
            this.Controls.Add(this.btntangca);
            this.Controls.Add(this.btnra);
            this.Controls.Add(this.btnvaold);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form8";
            this.Text = "Form8";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnvaold;
        private System.Windows.Forms.Button btnra;
        private System.Windows.Forms.Button btntangca;
        private System.Windows.Forms.Button btnload;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnvao;
        private System.Windows.Forms.Button btnbc;
        private System.Windows.Forms.Button btnrs;
        private System.Windows.Forms.Button btncc;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}