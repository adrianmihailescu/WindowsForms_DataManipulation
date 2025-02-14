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
    public partial class FormClientiLista : Form
    {
        public FormClientiLista()
        {
            InitializeComponent();
        }

        Utils u = new Utils();

        #region properties
        public string ModPagina { get; set; } // Selectare sau Vizualizare
        public string IdClientSelectat { get; set; }
        public string CodClientSelectat { get; set; }
        #endregion properties


        #region dataset methods
        private void FormClientiLista_Load(object sender, EventArgs e)
        {
            // this.cLIENTITableAdapter.Fill(this.eMC_COMENZIDataSet.CLIENTI, ref ERC ,ref MESSAGE, null, null, null, null);
            FillGrid();
            SetControlsVisibility();

        }
        #endregion dataset methods

        #region data access methods

        /// <summary>
        /// face butoanele vizibile sau nu in functie de context
        /// </summary>
        protected void SetControlsVisibility()
        {
            btnAdaugare.Enabled = btnModificare.Enabled = btnStergere.Enabled = btnCreareComanda.Enabled = (this.ModPagina != "Selectare");
            btnSelectare.Enabled = (this.ModPagina == "Selectare");
        }

        /// <summary>
        /// umple grid-ul din pagina
        /// </summary>
        protected void FillGrid()
        {
            // setez valorile parametrilor
            string strCod = (txtCod.Text == "" ? null : txtCod.Text);
            string strNume = (txtNume.Text == "" ? null : txtNume.Text);
            string strAdresa = (txtAdresa.Text == "" ? null : txtAdresa.Text);
            string strTelefon = (txtTelefon.Text == "" ? null : txtTelefon.Text);

            ArrayList alListaParametri = new ArrayList();
            alListaParametri.Add("@cod_client");
            alListaParametri.Add("@nume");
            alListaParametri.Add("@adresa");
            alListaParametri.Add("@telefon");

            ArrayList alValoriParametri = new ArrayList();
            alValoriParametri.Add(strCod);
            alValoriParametri.Add(strNume);
            alValoriParametri.Add(strAdresa);
            alValoriParametri.Add(strTelefon);

            // FillGrid();
            u.FillGridGeneric(dataGridView1, "sp_Clienti_Select", "Clienti", alListaParametri, alValoriParametri);
            txtCod.Select();
            // dataGridView1.ClearSelection();
            lblTotalCount.Text = "clienti in lista: " + dataGridView1.Rows.Count.ToString();
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
            FormClientiOperatii fco = new FormClientiOperatii();
            fco.TipOperatie = "Adaugare";
            fco.ShowDialog();
            FillGrid();
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
                    MessageBox.Show(u.SELECTATI_UN_CLIENT_DIN_LISTA, "Clienti");
                }
            }

            else
            {
                MessageBox.Show(u.ADAUGATI_CEL_PUTIN_UN_CLIENT_IN_LISTA, "Clienti");
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
                if (u.isOneRowSelectedInGrid(dataGridView1)) // aici 09062011
                {
                    DialogResult result = MessageBox.Show(u.DORITI_SA_STERGETI_ACEST_CLIENT, "Clienti", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (result.Equals(DialogResult.OK))
                    {
                        DeleteSelectedRow();
                    }

                }

                else
                {
                    MessageBox.Show(u.SELECTATI_UN_CLIENT_DIN_LISTA, "Clienti");
                }
            }

            else
            {
                MessageBox.Show(u.ADAUGATI_CEL_PUTIN_UN_CLIENT_IN_LISTA, "Clienti");
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
                    if (u.isOneRowSelectedInGrid(dataGridView1)) // AICI
                    {
                        IdClientSelectat = dataGridView1.SelectedRows[0].Cells["ID_CLIENT"].Value.ToString();
                        CodClientSelectat = dataGridView1.SelectedRows[0].Cells["COD_CLIENT"].Value.ToString();

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(u.SELECTATI_UN_CLIENT_DIN_LISTA, "Clienti");
                    }
                }

                else
                {
                    MessageBox.Show(u.ADAUGATI_CEL_PUTIN_UN_CLIENT_IN_LISTA, "Clienti");
                }
            }
        }

        /// <summary>
        /// apelat cand se creaza o comanda, acelasi lucru ca si in pagina de comenzi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreareComanda_Click(object sender, EventArgs e)
        {
            if (!u.isEmptyGrid(dataGridView1))
            {
                if (u.isOneRowSelectedInGrid(dataGridView1))
                {
                    IdClientSelectat = dataGridView1.SelectedRows[0].Cells["ID_CLIENT"].Value.ToString();
                    CodClientSelectat = dataGridView1.SelectedRows[0].Cells["COD_CLIENT"].Value.ToString();

                    FormComenziCreare fcc = new FormComenziCreare();
                    fcc.txtCodClient.Text = CodClientSelectat;
                    fcc.IdClientSelectat = IdClientSelectat;
                    fcc.TipOperatie = "CreareComanda";
                    fcc.ShowDialog();
                }

                else
                {
                    MessageBox.Show(u.SELECTATI_UN_CLIENT_DIN_LISTA, "Clienti");
                }
            }

            else
            {
                MessageBox.Show(u.ADAUGATI_CEL_PUTIN_UN_CLIENT_IN_LISTA, "Clienti");
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
        /// apelat la double click pe o linie
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
        /// aplicat la formatarea datelor din coloane
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dataGridView1.Columns["ID_CLIENT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; // valorile data aliniate catre dreapta
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        #endregion form methods

        #region data access methods
        /// <summary>
        /// updateaza linia selectata
        /// </summary>
        private void UpdateSelectedRow()
        {
            FormClientiOperatii fco = new FormClientiOperatii();

            // if (dataGridView1.SelectedRows[0].Cells[5] == null)

            DataGridViewRow linieSelectata = dataGridView1.SelectedRows[0];

            fco.TipOperatie = "Modificare";
            fco.IdLinie = (int)linieSelectata.Cells["ID_CLIENT"].Value;
            fco.CodClient = (string)linieSelectata.Cells["COD_CLIENT"].Value;
            fco.Nume = (string)linieSelectata.Cells["NUME"].Value;
            fco.Adresa = (string)linieSelectata.Cells["ADRESA"].Value;
            fco.Telefon = linieSelectata.Cells["TELEFON"].Value.ToString(); // aici

            // fax                
            fco.Fax = (linieSelectata.Cells["FAX"].Value.ToString() == String.Empty) ? null : (string)linieSelectata.Cells["FAX"].Value;
            
            // email                
            fco.Email = (linieSelectata.Cells["EMAIL"].Value.ToString() == String.Empty) ? null : (string)linieSelectata.Cells["EMAIL"].Value;

            fco.ShowDialog();
            FillGrid();
        }

        /// <summary>
        /// sterge linia selectata
        /// </summary>
        protected void DeleteSelectedRow()
        {
            // setez valorile parametrilor
            int IdClientSelectat = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID_CLIENT"].Value);

            ArrayList alListaParametri = new ArrayList();
            alListaParametri.Add("@id_client");

            ArrayList alValoriParametri = new ArrayList();
            alValoriParametri.Add(IdClientSelectat);

            u.DeleteSelectedRowGeneric(dataGridView1, "sp_Clienti_Delete", "Clienti", alListaParametri, alValoriParametri);
            FillGrid();
        }
        #endregion data access methods
    }
}
