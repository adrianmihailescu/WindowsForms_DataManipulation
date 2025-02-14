namespace EMC_COMENZI
{
    partial class FormComenziDetaliu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnStergere = new System.Windows.Forms.Button();
            this.btnModificare = new System.Windows.Forms.Button();
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_DETALIU_COMANDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_COMANDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_PRODUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COD_PRODUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DENUMIRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTITATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UNITATE_MASURA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FLAG_DEL = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.COMENZI_DETALIUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EMC_COMENZIDataSet = new EMC_COMENZI.EMC_COMENZIDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.COMENZI_DETALIUTableAdapter = new EMC_COMENZI.EMC_COMENZIDataSetTableAdapters.COMENZI_DETALIUTableAdapter();
            this.lblTotalCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.COMENZI_DETALIUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EMC_COMENZIDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStergere
            // 
            this.btnStergere.Location = new System.Drawing.Point(742, 15);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(114, 23);
            this.btnStergere.TabIndex = 3;
            this.btnStergere.Text = "Stergere";
            this.btnStergere.UseVisualStyleBackColor = true;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // btnModificare
            // 
            this.btnModificare.Location = new System.Drawing.Point(626, 15);
            this.btnModificare.Name = "btnModificare";
            this.btnModificare.Size = new System.Drawing.Size(110, 23);
            this.btnModificare.TabIndex = 2;
            this.btnModificare.Text = "Modificare";
            this.btnModificare.UseVisualStyleBackColor = true;
            this.btnModificare.Click += new System.EventHandler(this.btnModificare_Click);
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.Location = new System.Drawing.Point(515, 15);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(105, 23);
            this.btnAdaugare.TabIndex = 1;
            this.btnAdaugare.Text = "Adaugare";
            this.btnAdaugare.UseVisualStyleBackColor = true;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_DETALIU_COMANDA,
            this.ID_COMANDA,
            this.ID_PRODUS,
            this.COD_PRODUS,
            this.DENUMIRE,
            this.CANTITATE,
            this.UNITATE_MASURA,
            this.FLAG_DEL});
            this.dataGridView1.DataSource = this.COMENZI_DETALIUBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 44);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(846, 378);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // ID_DETALIU_COMANDA
            // 
            this.ID_DETALIU_COMANDA.DataPropertyName = "ID_DETALIU_COMANDA";
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            this.ID_DETALIU_COMANDA.DefaultCellStyle = dataGridViewCellStyle2;
            this.ID_DETALIU_COMANDA.HeaderText = "Nr. Crt.";
            this.ID_DETALIU_COMANDA.Name = "ID_DETALIU_COMANDA";
            this.ID_DETALIU_COMANDA.ReadOnly = true;
            this.ID_DETALIU_COMANDA.Width = 65;
            // 
            // ID_COMANDA
            // 
            this.ID_COMANDA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID_COMANDA.DataPropertyName = "ID_COMANDA";
            this.ID_COMANDA.HeaderText = "Nr. Comanda";
            this.ID_COMANDA.Name = "ID_COMANDA";
            this.ID_COMANDA.ReadOnly = true;
            this.ID_COMANDA.Visible = false;
            // 
            // ID_PRODUS
            // 
            this.ID_PRODUS.DataPropertyName = "ID_PRODUS";
            this.ID_PRODUS.HeaderText = "ID Produs";
            this.ID_PRODUS.Name = "ID_PRODUS";
            this.ID_PRODUS.ReadOnly = true;
            this.ID_PRODUS.Visible = false;
            this.ID_PRODUS.Width = 79;
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
            // CANTITATE
            // 
            this.CANTITATE.DataPropertyName = "CANTITATE";
            this.CANTITATE.HeaderText = "Cantitate";
            this.CANTITATE.Name = "CANTITATE";
            this.CANTITATE.ReadOnly = true;
            this.CANTITATE.Width = 74;
            // 
            // UNITATE_MASURA
            // 
            this.UNITATE_MASURA.DataPropertyName = "UNITATE_MASURA";
            this.UNITATE_MASURA.HeaderText = "U. M.";
            this.UNITATE_MASURA.Name = "UNITATE_MASURA";
            this.UNITATE_MASURA.ReadOnly = true;
            this.UNITATE_MASURA.Width = 58;
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
            // COMENZI_DETALIUBindingSource
            // 
            this.COMENZI_DETALIUBindingSource.DataMember = "COMENZI_DETALIU";
            this.COMENZI_DETALIUBindingSource.DataSource = this.EMC_COMENZIDataSet;
            // 
            // EMC_COMENZIDataSet
            // 
            this.EMC_COMENZIDataSet.DataSetName = "EMC_COMENZIDataSet";
            this.EMC_COMENZIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Double click pe linia selectata pentru a o modifica";
            // 
            // COMENZI_DETALIUTableAdapter
            // 
            this.COMENZI_DETALIUTableAdapter.ClearBeforeFill = true;
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.AutoSize = true;
            this.lblTotalCount.Location = new System.Drawing.Point(9, 425);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(35, 13);
            this.lblTotalCount.TabIndex = 15;
            this.lblTotalCount.Text = "label8";
            // 
            // FormComenziDetaliu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 444);
            this.Controls.Add(this.lblTotalCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.btnModificare);
            this.Controls.Add(this.btnAdaugare);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormComenziDetaliu";
            this.Text = "Detalii Comanda";
            this.Load += new System.EventHandler(this.FormComenziDetaliu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.COMENZI_DETALIUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EMC_COMENZIDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EMC_COMENZIDataSet EMC_COMENZIDataSet;
        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.Button btnModificare;
        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.DataGridView dataGridView1;
        private EMC_COMENZI.EMC_COMENZIDataSetTableAdapters.COMENZI_DETALIUTableAdapter COMENZI_DETALIUTableAdapter;
        private System.Windows.Forms.BindingSource COMENZI_DETALIUBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_DETALIU_COMANDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_COMANDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PRODUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_PRODUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DENUMIRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTITATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn UNITATE_MASURA;
        private System.Windows.Forms.DataGridViewCheckBoxColumn FLAG_DEL;
    }
}