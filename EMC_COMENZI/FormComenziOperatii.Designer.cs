namespace EMC_COMENZI
{
    partial class FormComenziOperatii
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtProdus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCantitate = new System.Windows.Forms.NumericUpDown();
            this.btnSelectieProdus = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOperation = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantitate)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.txtProdus, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtCantitate, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSelectieProdus, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(434, 65);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // txtProdus
            // 
            this.txtProdus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtProdus.Location = new System.Drawing.Point(71, 3);
            this.txtProdus.Name = "txtProdus";
            this.txtProdus.ReadOnly = true;
            this.txtProdus.Size = new System.Drawing.Size(329, 20);
            this.txtProdus.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 27);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cod Produs";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Location = new System.Drawing.Point(16, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 38);
            this.label3.TabIndex = 12;
            this.label3.Text = "Cantitate";
            // 
            // txtCantitate
            // 
            this.txtCantitate.DecimalPlaces = 2;
            this.txtCantitate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCantitate.Location = new System.Drawing.Point(71, 30);
            this.txtCantitate.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.txtCantitate.Name = "txtCantitate";
            this.txtCantitate.Size = new System.Drawing.Size(329, 20);
            this.txtCantitate.TabIndex = 4;
            // 
            // btnSelectieProdus
            // 
            this.btnSelectieProdus.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSelectieProdus.Location = new System.Drawing.Point(406, 3);
            this.btnSelectieProdus.Name = "btnSelectieProdus";
            this.btnSelectieProdus.Size = new System.Drawing.Size(28, 21);
            this.btnSelectieProdus.TabIndex = 3;
            this.btnSelectieProdus.Text = "+";
            this.btnSelectieProdus.UseVisualStyleBackColor = true;
            this.btnSelectieProdus.Click += new System.EventHandler(this.btnSelectieProdus_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "label4";
            // 
            // btnOperation
            // 
            this.btnOperation.Location = new System.Drawing.Point(312, 119);
            this.btnOperation.Name = "btnOperation";
            this.btnOperation.Size = new System.Drawing.Size(93, 23);
            this.btnOperation.TabIndex = 10;
            this.btnOperation.Text = "OK";
            this.btnOperation.UseVisualStyleBackColor = true;
            this.btnOperation.Click += new System.EventHandler(this.btnOperation_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 90);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // FormComenziOperatii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 148);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOperation);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormComenziOperatii";
            this.Text = "Comenzi";
            this.Load += new System.EventHandler(this.FormComenziOperatii_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantitate)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtProdus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txtCantitate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSelectieProdus;
        private System.Windows.Forms.Button btnOperation;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}