namespace EMC_COMENZI
{
    partial class FormComenziCreare
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
            this.label2 = new System.Windows.Forms.Label();
            this.dtDataLivrare = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtDataComanda = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodClient = new System.Windows.Forms.TextBox();
            this.btnSelectareClient = new System.Windows.Forms.Button();
            this.btnOKComanda = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dtDataLivrare, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtDataComanda, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtCodClient, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSelectareClient, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(397, 86);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Location = new System.Drawing.Point(3, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data Comanda";
            // 
            // dtDataLivrare
            // 
            this.dtDataLivrare.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtDataLivrare.Location = new System.Drawing.Point(87, 58);
            this.dtDataLivrare.Name = "dtDataLivrare";
            this.dtDataLivrare.Size = new System.Drawing.Size(277, 20);
            this.dtDataLivrare.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Location = new System.Drawing.Point(48, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client";
            // 
            // dtDataComanda
            // 
            this.dtDataComanda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtDataComanda.Location = new System.Drawing.Point(87, 32);
            this.dtDataComanda.Name = "dtDataComanda";
            this.dtDataComanda.Size = new System.Drawing.Size(277, 20);
            this.dtDataComanda.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Location = new System.Drawing.Point(16, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data Livrare";
            // 
            // txtCodClient
            // 
            this.txtCodClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCodClient.Location = new System.Drawing.Point(87, 3);
            this.txtCodClient.Name = "txtCodClient";
            this.txtCodClient.ReadOnly = true;
            this.txtCodClient.Size = new System.Drawing.Size(277, 20);
            this.txtCodClient.TabIndex = 1;
            // 
            // btnSelectareClient
            // 
            this.btnSelectareClient.Location = new System.Drawing.Point(370, 3);
            this.btnSelectareClient.Name = "btnSelectareClient";
            this.btnSelectareClient.Size = new System.Drawing.Size(26, 23);
            this.btnSelectareClient.TabIndex = 2;
            this.btnSelectareClient.Text = "+";
            this.btnSelectareClient.UseVisualStyleBackColor = true;
            this.btnSelectareClient.Click += new System.EventHandler(this.btnSelectareClient_Click);
            // 
            // btnOKComanda
            // 
            this.btnOKComanda.Location = new System.Drawing.Point(306, 146);
            this.btnOKComanda.Name = "btnOKComanda";
            this.btnOKComanda.Size = new System.Drawing.Size(75, 24);
            this.btnOKComanda.TabIndex = 6;
            this.btnOKComanda.Text = "OK";
            this.btnOKComanda.UseVisualStyleBackColor = true;
            this.btnOKComanda.Click += new System.EventHandler(this.btnOKComanda_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(11, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 118);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(104, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Detalii";
            // 
            // FormComenziCreare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 180);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOKComanda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormComenziCreare";
            this.Text = "Creare Comanda";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker dtDataComanda;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DateTimePicker dtDataLivrare;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtCodClient;
        private System.Windows.Forms.Button btnSelectareClient;
        public System.Windows.Forms.Button btnOKComanda;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
    }
}