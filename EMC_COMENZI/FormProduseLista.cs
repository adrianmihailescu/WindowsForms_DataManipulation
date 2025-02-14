using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EMC_COMENZI
{
    public partial class FormProduseLista : Form
    {
        public FormProduseLista()
        {
            InitializeComponent();
        }

        Utils u = new Utils();

        #region properties
        public string ModPagina { get; set; } // Selectare sau Vizualizare
        public int IdProdusSelectat { get; set; }
        public string CodProdusSelectat { get; set;}
        #endregion properties


        #region dataset methods
        private void FormProduseLista_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eMC_COMENZIDataSet.CLIENTI' table. You can move, or remove it, as needed.
            int? ERC = null;
            string MESSAGE = null;

            // this.pRODUSETableAdapter.Fill(this.eMC_COMENZIDataSet.PRODUSE, ref ERC, ref MESSAGE, null, null, null, null, null);
            FillGrid();
            SetControlsVisibility();

            // dataGridView1.ClearSelection();
        }

        #endregion dataset methods

        #region data access methods

        /// <summary>
        /// reseteaza controalele din form
        /// </summary>
        protected void FormLoadControlsOnStartup()
        {
            txtCodProdus.Text = "";
            txtDenumire.Text = "";
            txtUnitateMasura.Text = "";
            txtCodBare.Text = "";
        }

        /// <summary>
        /// face butoanele vizibile sau nu in functie de context
        /// </summary>
        protected void SetControlsVisibility()
        {
            btnAdaugare.Enabled = btnModificare.Enabled = btnStergere.Enabled = (this.ModPagina != "Selectare");
            btnSelectare.Enabled = (this.ModPagina == "Selectare");
        }

        /// <summary>
        /// umple grid-ul din pagina
        /// </summary>
        protected void FillGrid()
        {
            // setez valorile parametrilor
            string strCodProdus = (txtCodProdus.Text == "" ? null : txtCodProdus.Text);
            string strDenumire = (txtDenumire.Text == "" ? null : txtDenumire.Text);
            string strUnitateMasura = (txtUnitateMasura.Text == "" ? null : txtUnitateMasura.Text);
            string strPret = (txtPret.Text == "" ? null : txtPret.Text);
            string strCodBare = (txtCodBare.Text == "" ? null : txtCodBare.Text);

            ArrayList alListaParametri = new ArrayList();
            alListaParametri.Add("@cod_produs");
            alListaParametri.Add("@denumire");
            alListaParametri.Add("@unitate_masura");
            alListaParametri.Add("@pret");
            alListaParametri.Add("@cod_bare");

            ArrayList alValoriParametri = new ArrayList();
            alValoriParametri.Add(strCodProdus);
            alValoriParametri.Add(strDenumire);
            alValoriParametri.Add(strUnitateMasura);
            alValoriParametri.Add(strPret);
            alValoriParametri.Add(strCodBare);

            // FillGrid();
            u.FillGridGeneric(dataGridView1, "sp_Produse_Select", "Produse", alListaParametri, alValoriParametri);
            // dataGridView1.ClearSelection();

            txtCodProdus.Select();

            lblTotalCount.Text = "produse in lista: " + dataGridView1.Rows.Count.ToString();
        }

        #endregion data access methods

        #region form methods
        /// <summary>
        /// click pe filtrare
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCauta_Click(object sender, EventArgs e)
        {
            FillGrid();
        }

        /// <summary>
        /// adauga o noua linie in grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            FormProduseOperatii fco = new FormProduseOperatii();
            fco.TipOperatie = "Adaugare";
            fco.ShowDialog();
            FillGrid();
            FormLoadControlsOnStartup();
        }

        /// <summary>
        /// pentru modificare linie in grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificare_Click(object sender, EventArgs e)
        {
            if (!u.isEmptyGrid(dataGridView1))
            {
                if (u.isOneRowSelectedInGrid(dataGridView1))
                {
                    UpdateSelectedRow();
                }

                else
                {
                    MessageBox.Show(u.SELECTATI_UN_PRODUS_DIN_LISTA, "Produse");
                }
            }

            else
            {
                MessageBox.Show(u.ADAUGATI_CEL_PUTIN_UN_PRODUS_IN_LISTA, "Produse");
            }
        }

        /// <summary>
        /// apelata la stergerea unui client din lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStergere_Click(object sender, EventArgs e)
        {
            if (!u.isEmptyGrid(dataGridView1))
            {
                if (u.isOneRowSelectedInGrid(dataGridView1))
                {
                    DialogResult result = MessageBox.Show(u.DORITI_SA_STERGETI_ACEST_PRODUS, "Produse", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (result.Equals(DialogResult.OK))
                    {
                        DeleteSelectedRow();
                    }
                }

                else
                {
                    MessageBox.Show(u.SELECTATI_UN_PRODUS_DIN_LISTA, "Produse");
                }
            }

            else
            {
                MessageBox.Show(u.ADAUGATI_CEL_PUTIN_UN_PRODUS_IN_LISTA, "Produse");
            }
        }

        /// <summary>
        /// apelat atunci cand selectez o linie din grid pentru a alege o entitate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectare_Click(object sender, EventArgs e)
        {
            if (this.ModPagina == "Selectare")
            {
                if (!u.isEmptyGrid(dataGridView1))
                {
                    if (u.isOneRowSelectedInGrid(dataGridView1))
                    {
                        //IdProdusSelectat = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                        IdProdusSelectat = (int)dataGridView1.SelectedRows[0].Cells["ID_PRODUS"].Value;
                        CodProdusSelectat = dataGridView1.SelectedRows[0].Cells["COD_PRODUS"].Value.ToString();
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show(u.SELECTATI_UN_PRODUS_DIN_LISTA, "Produse");
                    }
                }

                else
                {
                    MessageBox.Show(u.ADAUGATI_CEL_PUTIN_UN_PRODUS_IN_LISTA, "Produse");
                }
            }
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
        /// apelat la double click pe o linie din lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.ModPagina == "Selectare")
                btnSelectare.PerformClick();

            else
            {
                btnModificare.PerformClick();
            }
        }

        /// <summary>
        /// aplicat la formatarea coloanelor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dataGridView1.Columns["ID_PRODUS"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; // numerele aliniate catre dreapta
            dataGridView1.Columns["PRET"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; // numerele aliniate catre dreapta
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        #endregion form methods

        #region data access methods

        /// <summary>
        /// sterge linia selectata
        /// </summary>
        protected void DeleteSelectedRow()
        {
            // setez valorile parametrilor
            int IdProdusSelectat = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID_PRODUS"].Value);

            ArrayList alListaParametri = new ArrayList();
            alListaParametri.Add("@id_produs");

            ArrayList alValoriParametri = new ArrayList();
            alValoriParametri.Add(IdProdusSelectat);

            u.DeleteSelectedRowGeneric(dataGridView1, "sp_Produse_Delete", "Produse", alListaParametri, alValoriParametri);
            FillGrid();
        }

        /// <summary>
        /// updateaza linia selectata
        /// </summary>
        private void UpdateSelectedRow()
        {
            FormProduseOperatii fpo = new FormProduseOperatii();

            DataGridViewRow linieSelectata = dataGridView1.SelectedRows[0];

            fpo.TipOperatie = "Modificare";
            fpo.IdLinie = (int)linieSelectata.Cells["ID_PRODUS"].Value;
            fpo.CodProdus = (string)linieSelectata.Cells["COD_PRODUS"].Value;
            fpo.Denumire = (string)linieSelectata.Cells["DENUMIRE"].Value;
            fpo.UnitateMasura = (string)linieSelectata.Cells["UNITATE_MASURA"].Value;
            fpo.Pret = (double)linieSelectata.Cells["PRET"].Value; // aici
            fpo.CodBare = (string)linieSelectata.Cells["COD_BARE"].Value;

            fpo.ShowDialog();

            FillGrid();
            FormLoadControlsOnStartup();
        }
        #endregion data access methods
    }
}
