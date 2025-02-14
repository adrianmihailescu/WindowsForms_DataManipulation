namespace EMC_COMENZI
{
    partial class FormComenziLista
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnStergeFiltru = new System.Windows.Forms.Button();
            this.dtDataStop = new System.Windows.Forms.DateTimePicker();
            this.btnSelectieProdus = new System.Windows.Forms.Button();
            this.txtCodProdus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodClient = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCauta = new System.Windows.Forms.Button();
            this.dtDataStart = new System.Windows.Forms.DateTimePicker();
            this.btnSelectieClient = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_COMANDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_CLIENT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COD_CLIENT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA_COMANDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA_LIVRARE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComenziBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EMC_COMENZIDataSet = new EMC_COMENZI.EMC_COMENZIDataSet();
            this.btnDetalii = new System.Windows.Forms.Button();
            this.btnCreareComanda = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ComenziTableAdapter = new EMC_COMENZI.EMC_COMENZIDataSetTableAdapters.COMENZITableAdapter();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComenziBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EMC_COMENZIDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnStergeFiltru, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.dtDataStop, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSelectieProdus, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtCodProdus, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtCodClient, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCauta, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.dtDataStart, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSelectieClient, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(961, 77);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btnStergeFiltru
            // 
            this.btnStergeFiltru.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnStergeFiltru.Location = new System.Drawing.Point(590, 53);
            this.btnStergeFiltru.Name = "btnStergeFiltru";
            this.btnStergeFiltru.Size = new System.Drawing.Size(127, 21);
            this.btnStergeFiltru.TabIndex = 23;
            this.btnStergeFiltru.Text = "Sterge Filtru";
            this.btnStergeFiltru.UseVisualStyleBackColor = true;
            this.btnStergeFiltru.Click += new System.EventHandler(this.btnStergeFiltru_Click);
            // 
            // dtDataStop
            // 
            this.dtDataStop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtDataStop.Location = new System.Drawing.Point(723, 28);
            this.dtDataStop.Name = "dtDataStop";
            this.dtDataStop.Size = new System.Drawing.Size(235, 20);
            this.dtDataStop.TabIndex = 4;
            // 
            // btnSelectieProdus
            // 
            this.btnSelectieProdus.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSelectieProdus.Location = new System.Drawing.Point(451, 53);
            this.btnSelectieProdus.Name = "btnSelectieProdus";
            this.btnSelectieProdus.Size = new System.Drawing.Size(26, 21);
            this.btnSelectieProdus.TabIndex = 11;
            this.btnSelectieProdus.Text = "+";
            this.btnSelectieProdus.UseVisualStyleBackColor = true;
            this.btnSelectieProdus.Click += new System.EventHandler(this.btnSelectieProdus_Click);
            // 
            // txtCodProdus
            // 
            this.txtCodProdus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCodProdus.Location = new System.Drawing.Point(243, 28);
            this.txtCodProdus.Name = "txtCodProdus";
            this.txtCodProdus.ReadOnly = true;
            this.txtCodProdus.Size = new System.Drawing.Size(234, 20);
            this.txtCodProdus.TabIndex = 2;
            this.txtCodProdus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client";
            // 
            // txtCodClient
            // 
            this.txtCodClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCodClient.Location = new System.Drawing.Point(3, 28);
            this.txtCodClient.Name = "txtCodClient";
            this.txtCodClient.ReadOnly = true;
            this.txtCodClient.Size = new System.Drawing.Size(234, 20);
            this.txtCodClient.TabIndex = 1;
            this.txtCodClient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Location = new System.Drawing.Point(243, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Produs";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Location = new System.Drawing.Point(483, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data Inceput Comanda";
            // 
            // btnCauta
            // 
            this.btnCauta.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCauta.Location = new System.Drawing.Point(883, 53);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(75, 21);
            this.btnCauta.TabIndex = 9;
            this.btnCauta.Text = "Cauta";
            this.btnCauta.UseVisualStyleBackColor = true;
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click);
            // 
            // dtDataStart
            // 
            this.dtDataStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtDataStart.Location = new System.Drawing.Point(483, 28);
            this.dtDataStart.Name = "dtDataStart";
            this.dtDataStart.Size = new System.Drawing.Size(234, 20);
            this.dtDataStart.TabIndex = 3;
            // 
            // btnSelectieClient
            // 
            this.btnSelectieClient.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSelectieClient.Location = new System.Drawing.Point(211, 53);
            this.btnSelectieClient.Name = "btnSelectieClient";
            this.btnSelectieClient.Size = new System.Drawing.Size(26, 21);
            this.btnSelectieClient.TabIndex = 3;
            this.btnSelectieClient.Text = "+";
            this.btnSelectieClient.UseVisualStyleBackColor = true;
            this.btnSelectieClient.Click += new System.EventHandler(this.btnSelectieClient_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label4.Location = new System.Drawing.Point(723, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Data Sfarsit Comanda";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(584, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nota: Campurile se vor lasa necompletate pentru a aduce toate valorile. Double cl" +
                "ick pe linia selectata pentru a o modifica.";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_COMANDA,
            this.ID_CLIENT,
            this.COD_CLIENT,
            this.NUME,
            this.DATA_COMANDA,
            this.DATA_LIVRARE});
            this.dataGridView1.DataSource = this.ComenziBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 167);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(973, 378);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.btnDetalii_Click);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // ID_COMANDA
            // 
            this.ID_COMANDA.DataPropertyName = "ID_COMANDA";
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            this.ID_COMANDA.DefaultCellStyle = dataGridViewCellStyle3;
            this.ID_COMANDA.HeaderText = "Nr. Crt.";
            this.ID_COMANDA.Name = "ID_COMANDA";
            this.ID_COMANDA.ReadOnly = true;
            this.ID_COMANDA.Width = 65;
            // 
            // ID_CLIENT
            // 
            this.ID_CLIENT.DataPropertyName = "ID_CLIENT";
            this.ID_CLIENT.HeaderText = "ID Client";
            this.ID_CLIENT.Name = "ID_CLIENT";
            this.ID_CLIENT.ReadOnly = true;
            this.ID_CLIENT.Visible = false;
            this.ID_CLIENT.Width = 72;
            // 
            // COD_CLIENT
            // 
            this.COD_CLIENT.DataPropertyName = "COD_CLIENT";
            this.COD_CLIENT.HeaderText = "Cod Client";
            this.COD_CLIENT.Name = "COD_CLIENT";
            this.COD_CLIENT.ReadOnly = true;
            this.COD_CLIENT.Width = 80;
            // 
            // NUME
            // 
            this.NUME.DataPropertyName = "NUME";
            this.NUME.HeaderText = "Nume";
            this.NUME.Name = "NUME";
            this.NUME.ReadOnly = true;
            this.NUME.Width = 60;
            // 
            // DATA_COMANDA
            // 
            this.DATA_COMANDA.DataPropertyName = "DATA_COMANDA";
            this.DATA_COMANDA.HeaderText = "Data Comanda";
            this.DATA_COMANDA.Name = "DATA_COMANDA";
            this.DATA_COMANDA.ReadOnly = true;
            this.DATA_COMANDA.Width = 103;
            // 
            // DATA_LIVRARE
            // 
            this.DATA_LIVRARE.DataPropertyName = "DATA_LIVRARE";
            this.DATA_LIVRARE.HeaderText = "Data Livrare";
            this.DATA_LIVRARE.Name = "DATA_LIVRARE";
            this.DATA_LIVRARE.ReadOnly = true;
            this.DATA_LIVRARE.Width = 90;
            // 
            // ComenziBindingSource
            // 
            this.ComenziBindingSource.DataMember = "COMENZI";
            this.ComenziBindingSource.DataSource = this.EMC_COMENZIDataSet;
            // 
            // EMC_COMENZIDataSet
            // 
            this.EMC_COMENZIDataSet.DataSetName = "EMC_COMENZIDataSet";
            this.EMC_COMENZIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnDetalii
            // 
            this.btnDetalii.Location = new System.Drawing.Point(751, 136);
            this.btnDetalii.Name = "btnDetalii";
            this.btnDetalii.Size = new System.Drawing.Size(75, 23);
            this.btnDetalii.TabIndex = 9;
            this.btnDetalii.Text = "Detalii";
            this.btnDetalii.UseVisualStyleBackColor = true;
            this.btnDetalii.Click += new System.EventHandler(this.btnDetalii_Click);
            // 
            // btnCreareComanda
            // 
            this.btnCreareComanda.Location = new System.Drawing.Point(833, 136);
            this.btnCreareComanda.Name = "btnCreareComanda";
            this.btnCreareComanda.Size = new System.Drawing.Size(134, 23);
            this.btnCreareComanda.TabIndex = 10;
            this.btnCreareComanda.Text = "Creare Comanda";
            this.btnCreareComanda.UseVisualStyleBackColor = true;
            this.btnCreareComanda.Click += new System.EventHandler(this.btnCreareComanda_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Datele din lista sunt in formatul luna/zi/an";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(4, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(975, 116);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // ComenziTableAdapter
            // 
            this.ComenziTableAdapter.ClearBeforeFill = true;
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.AutoSize = true;
            this.lblTotalCount.Location = new System.Drawing.Point(3, 548);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(35, 13);
            this.lblTotalCount.TabIndex = 15;
            this.lblTotalCount.Text = "label8";
            // 
            // FormComenziLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 563);
            this.Controls.Add(this.lblTotalCount);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCreareComanda);
            this.Controls.Add(this.btnDetalii);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormComenziLista";
            this.Text = "Lista Comenzi";
            this.Load += new System.EventHandler(this.FormComenziLista_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComenziBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EMC_COMENZIDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.TextBox txtCodProdus;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtCodClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCauta;
        private System.Windows.Forms.DateTimePicker dtDataStart;
        private System.Windows.Forms.Button btnSelectieClient;
        private System.Windows.Forms.Button btnSelectieProdus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtDataStop;
        private System.Windows.Forms.BindingSource ComenziBindingSource;
        private EMC_COMENZIDataSet EMC_COMENZIDataSet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private EMC_COMENZI.EMC_COMENZIDataSetTableAdapters.COMENZITableAdapter ComenziTableAdapter;
        private System.Windows.Forms.Button btnDetalii;
        private System.Windows.Forms.Button btnCreareComanda;
        private System.Windows.Forms.Button btnStergeFiltru;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_COMANDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CLIENT;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_CLIENT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUME;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA_COMANDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA_LIVRARE;
    }
}