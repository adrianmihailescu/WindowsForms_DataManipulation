namespace EMC_COMENZI
{
    partial class FormClientiLista
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_CLIENT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EMC_COMENZIDataSet = new EMC_COMENZI.EMC_COMENZIDataSet();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCauta = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnStergere = new System.Windows.Forms.Button();
            this.btnModificare = new System.Windows.Forms.Button();
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.btnSelectare = new System.Windows.Forms.Button();
            this.ClientiTableAdapter = new EMC_COMENZI.EMC_COMENZIDataSetTableAdapters.CLIENTITableAdapter();
            this.btnCreareComanda = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.FLAG_DEL = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FAX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADRESA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COD_CLIENT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EMC_COMENZIDataSet)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_CLIENT,
            this.COD_CLIENT,
            this.NUME,
            this.ADRESA,
            this.TELEFON,
            this.FAX,
            this.EMAIL,
            this.FLAG_DEL});
            this.dataGridView1.DataSource = this.ClientiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 164);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(859, 378);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.btnSelectare_Click);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // ID_CLIENT
            // 
            this.ID_CLIENT.DataPropertyName = "ID_CLIENT";
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            this.ID_CLIENT.DefaultCellStyle = dataGridViewCellStyle2;
            this.ID_CLIENT.HeaderText = "Nr. Crt.";
            this.ID_CLIENT.Name = "ID_CLIENT";
            this.ID_CLIENT.ReadOnly = true;
            this.ID_CLIENT.Width = 65;
            // 
            // ClientiBindingSource
            // 
            this.ClientiBindingSource.DataMember = "CLIENTI";
            this.ClientiBindingSource.DataSource = this.EMC_COMENZIDataSet;
            // 
            // EMC_COMENZIDataSet
            // 
            this.EMC_COMENZIDataSet.DataSetName = "EMC_COMENZIDataSet";
            this.EMC_COMENZIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.45562F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.79882F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.68639F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.940828F));
            this.tableLayoutPanel1.Controls.Add(this.txtNume, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtAdresa, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtTelefon, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtCod, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCauta, 4, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 35);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(845, 59);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // txtNume
            // 
            this.txtNume.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNume.Location = new System.Drawing.Point(172, 32);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(226, 20);
            this.txtNume.TabIndex = 2;
            this.txtNume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // txtAdresa
            // 
            this.txtAdresa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAdresa.Location = new System.Drawing.Point(404, 32);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(212, 20);
            this.txtAdresa.TabIndex = 3;
            this.txtAdresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // txtTelefon
            // 
            this.txtTelefon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTelefon.Location = new System.Drawing.Point(622, 32);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(135, 20);
            this.txtTelefon.TabIndex = 4;
            this.txtTelefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cod Client";
            // 
            // txtCod
            // 
            this.txtCod.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCod.Location = new System.Drawing.Point(3, 32);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(163, 20);
            this.txtCod.TabIndex = 1;
            this.txtCod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Location = new System.Drawing.Point(172, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nume";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Location = new System.Drawing.Point(404, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Adresa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label4.Location = new System.Drawing.Point(622, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Telefon";
            // 
            // btnCauta
            // 
            this.btnCauta.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCauta.Location = new System.Drawing.Point(767, 32);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(75, 24);
            this.btnCauta.TabIndex = 5;
            this.btnCauta.Text = "Cauta";
            this.btnCauta.UseVisualStyleBackColor = true;
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(593, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nota: Campurile se vor lasa necompletate pentru a aduce toate valorile. Se va fol" +
                "osi * pentru a aduce o valoare aproximativa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(509, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Selectati o linie din lista pentru a o vizualiza sau actualiza. Double click pe l" +
                "inia selectata pentru a modifica.";
            // 
            // btnStergere
            // 
            this.btnStergere.Location = new System.Drawing.Point(799, 133);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(75, 23);
            this.btnStergere.TabIndex = 10;
            this.btnStergere.Text = "Stergere";
            this.btnStergere.UseVisualStyleBackColor = true;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // btnModificare
            // 
            this.btnModificare.Location = new System.Drawing.Point(718, 133);
            this.btnModificare.Name = "btnModificare";
            this.btnModificare.Size = new System.Drawing.Size(75, 23);
            this.btnModificare.TabIndex = 9;
            this.btnModificare.Text = "Modificare";
            this.btnModificare.UseVisualStyleBackColor = true;
            this.btnModificare.Click += new System.EventHandler(this.btnModificare_Click);
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.Location = new System.Drawing.Point(637, 133);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(75, 23);
            this.btnAdaugare.TabIndex = 8;
            this.btnAdaugare.Text = "Adaugare";
            this.btnAdaugare.UseVisualStyleBackColor = true;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // btnSelectare
            // 
            this.btnSelectare.Location = new System.Drawing.Point(556, 133);
            this.btnSelectare.Name = "btnSelectare";
            this.btnSelectare.Size = new System.Drawing.Size(75, 23);
            this.btnSelectare.TabIndex = 7;
            this.btnSelectare.Text = "Selectare";
            this.btnSelectare.UseVisualStyleBackColor = true;
            this.btnSelectare.Click += new System.EventHandler(this.btnSelectare_Click);
            // 
            // ClientiTableAdapter
            // 
            this.ClientiTableAdapter.ClearBeforeFill = true;
            // 
            // btnCreareComanda
            // 
            this.btnCreareComanda.Location = new System.Drawing.Point(13, 133);
            this.btnCreareComanda.Name = "btnCreareComanda";
            this.btnCreareComanda.Size = new System.Drawing.Size(103, 23);
            this.btnCreareComanda.TabIndex = 6;
            this.btnCreareComanda.Text = "Creare Comanda";
            this.btnCreareComanda.UseVisualStyleBackColor = true;
            this.btnCreareComanda.Click += new System.EventHandler(this.btnCreareComanda_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(117, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(284, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Puteti crea direct o comanda pentru clientul selectat in lista";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(15, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(858, 120);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.AutoSize = true;
            this.lblTotalCount.Location = new System.Drawing.Point(9, 545);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(35, 13);
            this.lblTotalCount.TabIndex = 14;
            this.lblTotalCount.Text = "label8";
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
            // EMAIL
            // 
            this.EMAIL.DataPropertyName = "EMAIL";
            this.EMAIL.HeaderText = "E-mail";
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.ReadOnly = true;
            this.EMAIL.Width = 60;
            // 
            // FAX
            // 
            this.FAX.DataPropertyName = "FAX";
            this.FAX.HeaderText = "Fax";
            this.FAX.Name = "FAX";
            this.FAX.ReadOnly = true;
            this.FAX.Width = 49;
            // 
            // TELEFON
            // 
            this.TELEFON.DataPropertyName = "TELEFON";
            this.TELEFON.HeaderText = "Telefon";
            this.TELEFON.Name = "TELEFON";
            this.TELEFON.ReadOnly = true;
            this.TELEFON.Width = 68;
            // 
            // ADRESA
            // 
            this.ADRESA.DataPropertyName = "ADRESA";
            this.ADRESA.HeaderText = "Adresa";
            this.ADRESA.Name = "ADRESA";
            this.ADRESA.ReadOnly = true;
            this.ADRESA.Width = 65;
            // 
            // NUME
            // 
            this.NUME.DataPropertyName = "NUME";
            this.NUME.HeaderText = "Nume";
            this.NUME.Name = "NUME";
            this.NUME.ReadOnly = true;
            this.NUME.Width = 60;
            // 
            // COD_CLIENT
            // 
            this.COD_CLIENT.DataPropertyName = "COD_CLIENT";
            this.COD_CLIENT.HeaderText = "Cod Client";
            this.COD_CLIENT.Name = "COD_CLIENT";
            this.COD_CLIENT.ReadOnly = true;
            this.COD_CLIENT.Width = 80;
            // 
            // FormClientiLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 563);
            this.Controls.Add(this.lblTotalCount);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCreareComanda);
            this.Controls.Add(this.btnSelectare);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.btnModificare);
            this.Controls.Add(this.btnAdaugare);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormClientiLista";
            this.Text = "Lista Clienti";
            this.Load += new System.EventHandler(this.FormClientiLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EMC_COMENZIDataSet)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private EMC_COMENZIDataSet EMC_COMENZIDataSet;
        private System.Windows.Forms.BindingSource ClientiBindingSource;
        private EMC_COMENZI.EMC_COMENZIDataSetTableAdapters.CLIENTITableAdapter ClientiTableAdapter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCauta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.Button btnModificare;
        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.Button btnSelectare;
        private System.Windows.Forms.Button btnCreareComanda;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CLIENT;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_CLIENT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUME;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADRESA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFON;
        private System.Windows.Forms.DataGridViewTextBoxColumn FAX;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL;
        private System.Windows.Forms.DataGridViewCheckBoxColumn FLAG_DEL;
    }
}