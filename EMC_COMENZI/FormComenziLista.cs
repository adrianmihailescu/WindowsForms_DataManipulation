using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace EMC_COMENZI
{
    public partial class FormComenziLista : Form
    {
        public FormComenziLista()
        {
            InitializeComponent();
            // txtCodClient.Text = this.CodClientSelectat;
        }

        Utils u = new Utils();


        #region properties
        public string IdClientSelectat { get; set; }
        public string CodClientSelectat { get; set; }
        public string IdProdusSelectat { get; set; }
        public string CodProdusSelectat { get; set; }
        public string TipOperatie { get; set; }
        #endregion properties

        #region data methods
        /// <summary>
        /// umple grid-ul din pagina
        /// </summary>
        protected void FillGrid()
        {
            // setez valorile parametrilor
            // setez valorile parametrilor
            string strIdClient = IdClientSelectat;
            string strIdProdus = IdProdusSelectat;
            DateTime strDataStart = dtDataStart.Value;
            DateTime strDataStop = dtDataStop.Value;

            ArrayList alListaParametri = new ArrayList();
            alListaParametri.Add("@id_client");
            alListaParametri.Add("@id_produs");
            alListaParametri.Add("@data_start");
            alListaParametri.Add("@data_stop");

            ArrayList alValoriParametri = new ArrayList();
            alValoriParametri.Add(strIdClient);
            alValoriParametri.Add(strIdProdus);
            alValoriParametri.Add(strDataStart);
            alValoriParametri.Add(strDataStop);

            // FillGrid();
            u.FillGridGeneric(dataGridView1, "sp_Comenzi_Select", "Comenzi", alListaParametri, alValoriParametri);
            // dataGridView1.ClearSelection();
            txtCodClient.Select();
            lblTotalCount.Text = "comenzi in lista: " + dataGridView1.Rows.Count.ToString();
        }

        #endregion data methods

        #region form methods
        /// <summary>
        /// se deschide forma de selectie client in modul selectare
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectieClient_Click(object sender, EventArgs e)
        {
            // this.Close();

            using (FormClientiLista fcl = new FormClientiLista())
            {
                fcl.ModPagina = "Selectare";
                fcl.ShowDialog();               
                txtCodClient.Text = fcl.CodClientSelectat;
                this.IdClientSelectat = fcl.IdClientSelectat; // AICI 08062011
                txtCodClient.Select();
            }
        }

        /// <summary>
        /// se deschide forma de selectie produs in modul selectare
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectieProdus_Click(object sender, EventArgs e)
        {
            //this.Close();

            using (FormProduseLista fpl = new FormProduseLista())
            {
                fpl.ModPagina = "Selectare";
                fpl.ShowDialog();
                txtCodProdus.Text = fpl.CodProdusSelectat;
                this.IdProdusSelectat = fpl.IdProdusSelectat.ToString();
                txtCodProdus.Select();
            }
        }

        /// <summary>
        /// apelat la detaliu pe o comanda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDetalii_Click(object sender, EventArgs e)
        {
            if (!u.isEmptyGrid(dataGridView1))
            {
                if (u.isOneRowSelectedInGrid(dataGridView1))
                {
                    ShowSelectedRowsDetails();
                }

                else
                {
                    MessageBox.Show(u.SELECTATI_O_COMANDA_DIN_LISTA_PENTRU_A_AFISA_DETALIILE, "Comenzi");
                }
            }

            else
            {
                MessageBox.Show(u.ADAUGATI_CEL_PUTIN_O_COMANDA_IN_LISTA, "Comenzi");
            }
        }

        private void FormComenziLista_Load(object sender, EventArgs e)
        {
            FillFormOnLoad();

            if (this.TipOperatie == "CreareComanda") // daca am venit din forma cu clienti - de pe butonul creare comanda
                btnCreareComanda.PerformClick();
            
            // dataGridView1.ClearSelection();
        }

        /// <summary>
        /// apelat la filtrare date
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCauta_Click(object sender, EventArgs e)
        {
            TimeSpan tsDataStartDataStop = dtDataStop.Value.Subtract(dtDataStart.Value);

            // sa nu aleg o data stop inaintea celei de start
            if (tsDataStartDataStop.Days >= 0)
            {
                FillGrid();
            }

            else
            {
                MessageBox.Show(u.DATA_DE_SFARSIT_A_INTERVALULUI_NU_POATE_FI_INAINTEA_DATEI_DE_INCEPUT, "Comenzi");
            }
        }

        /// <summary>
        /// apelata cand se da click pe creare comanda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreareComanda_Click(object sender, EventArgs e)
        {
            FormComenziCreare fcc = new FormComenziCreare();
            fcc.ShowDialog();
            FillFormOnLoad();

        }

        /// <summary>
        /// umple formularul la inceputul paginii
        /// </summary>
        private void FillFormOnLoad()
        {
            FillFormControlsOnLoad();
            FillGrid();
        }

        /// <summary>
        /// umple controalele din pagina la incarcarea paginii
        /// </summary>
        private void FillFormControlsOnLoad()
        {
            txtCodProdus.Text = txtCodClient.Text = String.Empty;
            IdClientSelectat = IdProdusSelectat = null;

            dtDataStart.Value = new DateTime(1900, 1, 1);
            dtDataStop.Value = new DateTime(2100, 1, 1);
        }

        /// <summary>
        /// afiseaza o cautare noua fara nici un parametru
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStergeFiltru_Click(object sender, EventArgs e)
        {
            FillFormControlsOnLoad();
            btnCauta.PerformClick();
        }

        /// <summary>
        /// daca apas ESC, sa se inchida formularul
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="keyData"></param>
        /// <returns></returns>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        /// <summary>
        /// apasat la click pe enter pentru a filtra direct
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnCauta.PerformClick();
            }
        }

        /// <summary>
        /// aplicat la formatarea datelor din coloane
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dataGridView1.Columns["ID_COMANDA"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; // valorile data aliniate catre dreapta           
            dataGridView1.Columns["DATA_COMANDA"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; // valorile data aliniate catre dreapta
            dataGridView1.Columns["DATA_LIVRARE"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; // valorile data aliniate catre dreapta
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        #endregion form methods

        #region data access methods
        /// <summary>
        /// afiseaza detaliile despre linia selectata
        /// </summary>
        private void ShowSelectedRowsDetails()
        {
            FormComenziDetaliu fcd = new FormComenziDetaliu();
            // fcd.IdDetaliuComanda = (int)dataGridView1.SelectedRows[0].Cells["ID_DETALIU_COMANDA"].Value;
            fcd.IdComanda = (int)dataGridView1.SelectedRows[0].Cells["ID_COMANDA"].Value;
            fcd.IdClient = (int)dataGridView1.SelectedRows[0].Cells["ID_CLIENT"].Value;
            fcd.DataStart = dtDataStart.Value;
            fcd.DataStop = dtDataStop.Value;

            fcd.ShowDialog();
        }
        #endregion data access methods

    }
}
