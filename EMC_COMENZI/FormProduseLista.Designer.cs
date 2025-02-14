namespace EMC_COMENZI
{
    partial class FormProduseLista
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
            this.txtNume = new System.Windows.Forms.TextBox();
            this.bntModificare = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.btnStergere = new System.Windows.Forms.Button();
            this.txtUnitateMasura = new System.Windows.Forms.TextBox();
            this.btnModificare = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDenumire = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCodBare = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodProdus = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCauta = new System.Windows.Forms.Button();
            this.txtPret = new System.Windows.Forms.NumericUpDown();
            this.ProduseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EMC_COMENZIDataSet = new EMC_COMENZI.EMC_COMENZIDataSet();
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.btnSelectare = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ProduseTableAdapter = new EMC_COMENZI.EMC_COMENZIDataSetTableAdapters.PRODUSETableAdapter();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_PRODUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COD_PRODUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DENUMIRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UNITATE_MASURA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRET = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COD_BARE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FLAG_DEL = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPret)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProduseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EMC_COMENZIDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNume
            // 
            this.txtNume.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNume.Location = new System.Drawing.Point(53, 23);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(44, 20);
            this.txtNume.TabIndex = 6;
            // 
            // bntModificare
            // 
            this.bntModificare.Location = new System.Drawing.Point(407, -10);
            this.bntModificare.Name = "bntModificare";
            this.bntModificare.Size = new System.Drawing.Size(75, 23);
            this.bntModificare.TabIndex = 15;
            this.bntModificare.Text = "Modificare";
            this.bntModificare.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-280, -134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(275, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Selectati o linie din lista pentru a o vizualiza sau actualiza";
            // 
            // txtAdresa
            // 
            this.txtAdresa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAdresa.Location = new System.Drawing.Point(3, 23);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(44, 20);
            this.txtAdresa.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-281, -37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(593, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nota: Campurile se vor lasa necompletate pentru a aduce toate valorile. Se va fol" +
                "osi * pentru a aduce o valoare aproximativa";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.txtNume, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtAdresa, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTelefon.Location = new System.Drawing.Point(537, 26);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(174, 20);
            this.txtTelefon.TabIndex = 4;
            // 
            // btnStergere
            // 
            this.btnStergere.Location = new System.Drawing.Point(845, 149);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(75, 23);
            this.btnStergere.TabIndex = 9;
            this.btnStergere.Text = "Stergere";
            this.btnStergere.UseVisualStyleBackColor = true;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // txtUnitateMasura
            // 
            this.txtUnitateMasura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUnitateMasura.Location = new System.Drawing.Point(359, 26);
            this.txtUnitateMasura.Name = "txtUnitateMasura";
            this.txtUnitateMasura.Size = new System.Drawing.Size(172, 20);
            this.txtUnitateMasura.TabIndex = 3;
            this.txtUnitateMasura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // btnModificare
            // 
            this.btnModificare.Location = new System.Drawing.Point(764, 149);
            this.btnModificare.Name = "btnModificare";
            this.btnModificare.Size = new System.Drawing.Size(75, 23);
            this.btnModificare.TabIndex = 8;
            this.btnModificare.Text = "Modificare";
            this.btnModificare.UseVisualStyleBackColor = true;
            this.btnModificare.Click += new System.EventHandler(this.btnModificare_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Selectati o linie din lista pentru a o vizualiza sau actualiza";
            // 
            // txtDenumire
            // 
            this.txtDenumire.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDenumire.Location = new System.Drawing.Point(181, 26);
            this.txtDenumire.Name = "txtDenumire";
            this.txtDenumire.Size = new System.Drawing.Size(172, 20);
            this.txtDenumire.TabIndex = 2;
            this.txtDenumire.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(836, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nota: Campurile se vor lasa necompletate pentru a aduce toate valorile. Se va fol" +
                "osi * pentru a aduce o valoare aproximativa. Double click pe linia selectata pen" +
                "tru a o modifica.";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.label9, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtUnitateMasura, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtDenumire, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtCodBare, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtCodProdus, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label7, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label8, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnCauta, 4, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtPret, 3, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(10, 31);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(892, 71);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label9.Location = new System.Drawing.Point(715, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Cod Bare";
            // 
            // txtCodBare
            // 
            this.txtCodBare.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCodBare.Location = new System.Drawing.Point(715, 26);
            this.txtCodBare.Name = "txtCodBare";
            this.txtCodBare.Size = new System.Drawing.Size(174, 20);
            this.txtCodBare.TabIndex = 5;
            this.txtCodBare.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Location = new System.Drawing.Point(3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cod Produs";
            // 
            // txtCodProdus
            // 
            this.txtCodProdus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCodProdus.Location = new System.Drawing.Point(3, 26);
            this.txtCodProdus.Name = "txtCodProdus";
            this.txtCodProdus.Size = new System.Drawing.Size(172, 20);
            this.txtCodProdus.TabIndex = 1;
            this.txtCodProdus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label4.Location = new System.Drawing.Point(181, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Denumire";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label7.Location = new System.Drawing.Point(359, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "U.M.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label8.Location = new System.Drawing.Point(537, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Pret";
            // 
            // btnCauta
            // 
            this.btnCauta.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCauta.Location = new System.Drawing.Point(814, 49);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(75, 19);
            this.btnCauta.TabIndex = 9;
            this.btnCauta.Text = "Cauta";
            this.btnCauta.UseVisualStyleBackColor = true;
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click);
            // 
            // txtPret
            // 
            this.txtPret.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPret.DecimalPlaces = 2;
            this.txtPret.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPret.Location = new System.Drawing.Point(537, 26);
            this.txtPret.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.txtPret.Name = "txtPret";
            this.txtPret.Size = new System.Drawing.Size(172, 20);
            this.txtPret.TabIndex = 4;
            this.txtPret.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // ProduseBindingSource
            // 
            this.ProduseBindingSource.DataMember = "PRODUSE";
            this.ProduseBindingSource.DataSource = this.EMC_COMENZIDataSet;
            // 
            // EMC_COMENZIDataSet
            // 
            this.EMC_COMENZIDataSet.DataSetName = "EMC_COMENZIDataSet";
            this.EMC_COMENZIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.Location = new System.Drawing.Point(683, 149);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(75, 23);
            this.btnAdaugare.TabIndex = 7;
            this.btnAdaugare.Text = "Adaugare";
            this.btnAdaugare.UseVisualStyleBackColor = true;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // btnSelectare
            // 
            this.btnSelectare.Location = new System.Drawing.Point(603, 149);
            this.btnSelectare.Name = "btnSelectare";
            this.btnSelectare.Size = new System.Drawing.Size(75, 23);
            this.btnSelectare.TabIndex = 6;
            this.btnSelectare.Text = "Selectare";
            this.btnSelectare.UseVisualStyleBackColor = true;
            this.btnSelectare.Click += new System.EventHandler(this.btnSelectare_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(908, 132);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // ProduseTableAdapter
            // 
            this.ProduseTableAdapter.ClearBeforeFill = true;
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.AutoSize = true;
            this.lblTotalCount.Location = new System.Drawing.Point(9, 608);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(35, 13);
            this.lblTotalCount.TabIndex = 16;
            this.lblTotalCount.Text = "label8";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_PRODUS,
            this.COD_PRODUS,
            this.DENUMIRE,
            this.UNITATE_MASURA,
            this.PRET,
            this.COD_BARE,
            this.FLAG_DEL});
            this.dataGridView1.DataSource = this.ProduseBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 178);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(908, 427);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // ID_PRODUS
            // 
            this.ID_PRODUS.DataPropertyName = "ID_PRODUS";
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            this.ID_PRODUS.DefaultCellStyle = dataGridViewCellStyle3;
            this.ID_PRODUS.HeaderText = "Nr. Crt.";
            this.ID_PRODUS.Name = "ID_PRODUS";
            this.ID_PRODUS.ReadOnly = true;
            this.ID_PRODUS.Width = 65;
            // 
            // COD_PRODUS
            // 
            this.COD_PRODUS.DataPropertyName = "COD_PRODUS";
            this.COD_PRODUS.HeaderText = "Cod Produs";
            this.COD_PRODUS.Name = "COD_PRODUS";
            this.COD_PRODUS.ReadOnly = true;
            this.COD_PRODUS.Width = 87;
            // 
            // DENUMIRE
            // 
            this.DENUMIRE.DataPropertyName = "DENUMIRE";
            this.DENUMIRE.HeaderText = "Denumire";
            this.DENUMIRE.Name = "DENUMIRE";
            this.DENUMIRE.ReadOnly = true;
            this.DENUMIRE.Width = 77;
            // 
            // UNITATE_MASURA
            // 
            this.UNITATE_MASURA.DataPropertyName = "UNITATE_MASURA";
            this.UNITATE_MASURA.HeaderText = "Unitate Masura";
            this.UNITATE_MASURA.Name = "UNITATE_MASURA";
            this.UNITATE_MASURA.ReadOnly = true;
            this.UNITATE_MASURA.Width = 104;
            // 
            // PRET
            // 
            this.PRET.DataPropertyName = "PRET";
            this.PRET.HeaderText = "Pret";
            this.PRET.Name = "PRET";
            this.PRET.ReadOnly = true;
            this.PRET.Width = 51;
            // 
            // COD_BARE
            // 
            this.COD_BARE.DataPropertyName = "COD_BARE";
            this.COD_BARE.HeaderText = "Cod Bare";
            this.COD_BARE.Name = "COD_BARE";
            this.COD_BARE.ReadOnly = true;
            this.COD_BARE.Width = 76;
            // 
            // FLAG_DEL
            // 
            this.FLAG_DEL.DataPropertyName = "FLAG_DEL";
            this.FLAG_DEL.HeaderText = "Inactiv";
            this.FLAG_DEL.Name = "FLAG_DEL";
            this.FLAG_DEL.ReadOnly = true;
            this.FLAG_DEL.Visible = false;
            this.FLAG_DEL.Width = 45;
            // 
            // FormProduseLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 624);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblTotalCount);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSelectare);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.btnModificare);
            this.Controls.Add(this.btnAdaugare);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormProduseLista";
            this.Text = "Lista Produse";
            this.Load += new System.EventHandler(this.FormProduseLista_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPret)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProduseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EMC_COMENZIDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.Button bntModificare;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.TextBox txtUnitateMasura;
        private System.Windows.Forms.Button btnModificare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDenumire;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtCodBare;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodProdus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCauta;
        private EMC_COMENZIDataSet EMC_COMENZIDataSet;
        private System.Windows.Forms.Button btnAdaugare;
        private EMC_COMENZI.EMC_COMENZIDataSetTableAdapters.PRODUSETableAdapter ProduseTableAdapter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSelectare;
        private System.Windows.Forms.NumericUpDown txtPret;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.BindingSource ProduseBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PRODUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_PRODUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DENUMIRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn UNITATE_MASURA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRET;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_BARE;
        private System.Windows.Forms.DataGridViewCheckBoxColumn FLAG_DEL;
    }
}