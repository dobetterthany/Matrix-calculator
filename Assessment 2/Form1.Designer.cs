namespace Assessment_2
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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnTranspose = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.btnCreate2 = new System.Windows.Forms.Button();
            this.btnCreate1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbColumn2 = new System.Windows.Forms.TextBox();
            this.tbRow2 = new System.Windows.Forms.TextBox();
            this.tbColumn1 = new System.Windows.Forms.TextBox();
            this.tbRow1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(746, 515);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 37;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnTranspose
            // 
            this.btnTranspose.Enabled = false;
            this.btnTranspose.Location = new System.Drawing.Point(189, 380);
            this.btnTranspose.Name = "btnTranspose";
            this.btnTranspose.Size = new System.Drawing.Size(110, 23);
            this.btnTranspose.TabIndex = 36;
            this.btnTranspose.Text = "Transpose";
            this.btnTranspose.UseVisualStyleBackColor = true;
            this.btnTranspose.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Enabled = false;
            this.btnMultiply.Font = new System.Drawing.Font("Gulim", 13F);
            this.btnMultiply.Location = new System.Drawing.Point(513, 478);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(90, 60);
            this.btnMultiply.TabIndex = 35;
            this.btnMultiply.Text = "Multiply x";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Enabled = false;
            this.btnMinus.Font = new System.Drawing.Font("Gulim", 13F);
            this.btnMinus.Location = new System.Drawing.Point(417, 478);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(75, 60);
            this.btnMinus.TabIndex = 34;
            this.btnMinus.Text = "Minus -";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Enabled = false;
            this.btnPlus.Font = new System.Drawing.Font("Gulim", 13F);
            this.btnPlus.Location = new System.Drawing.Point(317, 478);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(75, 60);
            this.btnPlus.TabIndex = 33;
            this.btnPlus.Text = "Plus   +";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(213, 556);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 15);
            this.label5.TabIndex = 32;
            this.label5.Text = "Result";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(278, 556);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 27;
            this.dataGridView3.Size = new System.Drawing.Size(365, 214);
            this.dataGridView3.TabIndex = 31;
            // 
            // btnCreate2
            // 
            this.btnCreate2.Location = new System.Drawing.Point(216, 168);
            this.btnCreate2.Name = "btnCreate2";
            this.btnCreate2.Size = new System.Drawing.Size(75, 23);
            this.btnCreate2.TabIndex = 30;
            this.btnCreate2.Text = "Create";
            this.btnCreate2.UseVisualStyleBackColor = true;
            this.btnCreate2.Click += new System.EventHandler(this.btnCreate2_Click);
            // 
            // btnCreate1
            // 
            this.btnCreate1.Location = new System.Drawing.Point(224, 168);
            this.btnCreate1.Name = "btnCreate1";
            this.btnCreate1.Size = new System.Drawing.Size(75, 23);
            this.btnCreate1.TabIndex = 29;
            this.btnCreate1.Text = "Create";
            this.btnCreate1.UseVisualStyleBackColor = true;
            this.btnCreate1.Click += new System.EventHandler(this.btnCreate1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(51, 215);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(240, 150);
            this.dataGridView2.TabIndex = 28;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(59, 215);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 27;
            // 
            // tbColumn2
            // 
            this.tbColumn2.Location = new System.Drawing.Point(157, 126);
            this.tbColumn2.Name = "tbColumn2";
            this.tbColumn2.Size = new System.Drawing.Size(100, 25);
            this.tbColumn2.TabIndex = 26;
            this.tbColumn2.TextChanged += new System.EventHandler(this.tbColumn2_TextChanged);
            // 
            // tbRow2
            // 
            this.tbRow2.Location = new System.Drawing.Point(157, 71);
            this.tbRow2.Name = "tbRow2";
            this.tbRow2.Size = new System.Drawing.Size(100, 25);
            this.tbRow2.TabIndex = 25;
            // 
            // tbColumn1
            // 
            this.tbColumn1.Location = new System.Drawing.Point(143, 126);
            this.tbColumn1.Name = "tbColumn1";
            this.tbColumn1.Size = new System.Drawing.Size(100, 25);
            this.tbColumn1.TabIndex = 24;
            // 
            // tbRow1
            // 
            this.tbRow1.Location = new System.Drawing.Point(143, 74);
            this.tbRow1.Name = "tbRow1";
            this.tbRow1.Size = new System.Drawing.Size(100, 25);
            this.tbRow1.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "Column";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Row";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Column";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Row";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Font = new System.Drawing.Font("Gulim", 12F);
            this.label6.Location = new System.Drawing.Point(139, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 38;
            this.label6.Text = "Matrix A";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Font = new System.Drawing.Font("Gulim", 12F);
            this.label7.Location = new System.Drawing.Point(135, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 39;
            this.label7.Text = "Matrix B";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbRow1);
            this.groupBox1.Controls.Add(this.btnTranspose);
            this.groupBox1.Controls.Add(this.tbColumn1);
            this.groupBox1.Controls.Add(this.btnCreate1);
            this.groupBox1.Location = new System.Drawing.Point(73, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 431);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Silver;
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbColumn2);
            this.groupBox2.Controls.Add(this.tbRow2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnCreate2);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(478, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(343, 431);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 806);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView3);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnTranspose;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button btnCreate2;
        private System.Windows.Forms.Button btnCreate1;
        private System.Windows.Forms.DataGridView dataGridView2;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbColumn2;
        private System.Windows.Forms.TextBox tbRow2;
        private System.Windows.Forms.TextBox tbColumn1;
        private System.Windows.Forms.TextBox tbRow1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

