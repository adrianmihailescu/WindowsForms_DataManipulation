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
    public partial class FormComenziDetaliu : Form
    {
        public FormComenziDetaliu()
        {
            InitializeComponent();
        }

        Utils u = new Utils();

        #region properties
        public int IdDetaliuComanda { get; set; }
        public int IdComanda { get; set; }
        public int IdClient { get; set; }
        public DateTime DataStart { get; set; }
        public DateTime DataStop { get; set; }
        #endregion properties

        #region form methods
        /// <summary>
        /// umple grid-ul din pagina
        /// </summary>
        protected void FillGrid()
        {
            // setez valorile parametrilor
            // setez valorile parametrilor
            int strIdComanda = IdComanda;

            ArrayList alListaParametri = new ArrayList();
            alListaParametri.Add("@id_comanda");

            ArrayList alValoriParametri = new ArrayList();
            alValoriParametri.Add(strIdComanda);

            // FillGrid();
            u.FillGridGeneric(dataGridView1, "sp_ComenziDetaliu_Select", "Comenzi", alListaParametri, alValoriParametri);
            // dataGridView1.ClearSelection();
            lblTotalCount.Text = "detalii pe comanda: " + dataGridView1.Rows.Count.ToString();
        }

        private void FormComenziDetaliu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eMC_COMENZIDataSet.COMENZI_DETALIU' table. You can move, or remove it, as needed.
            int? ERC = null;
            string MESSAGE = null;
            
            // this.cOMENZI_DETALIUTableAdapter.Fill(this.eMC_COMENZIDataSet.COMENZI_DETALIU, ref ERC, ref MESSAGE, null);
            FillGrid();

            // this.IdDetaliuComanda = (int)dataGridView1.SelectedRows[0].Cells["ID_DETALIU_COMANDA"].Value;
        }

        /// <summary>
        /// click la stergere pe detaliu comanda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStergere_Click(object sender, EventArgs e)
        {
            if (!u.isEmptyGrid(dataGridView1))
            {
                if (u.isOneRowSelectedInGrid(dataGridView1))
                {
                    DialogResult result = MessageBox.Show(u.DORITI_SA_STERGETI_DETALIUL_DE_PE_ACEASTA_COMANDA, "Comenzi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (result.Equals(DialogResult.OK))
                    {
                        DeleteSelectedRow();
                    }
                }

                else
                {
                    if (!u.isOneRowSelectedInGrid(dataGridView1))
                        MessageBox.Show(u.SELECTATI_UN_DETALIU_COMANDA_DIN_LISTA, "Comenzi");
                }
            }

            else
            {
                MessageBox.Show(u.ADAUGATI_CEL_PUTIN_UN_DETALIU_PE_ACEASTA_COMANDA, "Comenzi");
            }
        }

        /// <summary>
        /// adaug un nou produs pe comanda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            FormComenziOperatii fco = new FormComenziOperatii();
            fco.IdComanda = this.IdComanda;
            fco.TipOperatie = "Adaugare";
            fco.ShowDialog();
            FillGrid();
        }

        /// <summary>
        /// modific un produs de pe comanda
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
                    MessageBox.Show(u.SELECTATI_UN_DETALIU_COMANDA_DIN_LISTA, "Comenzi");
                }
            }

            else
            {
                MessageBox.Show(u.ADAUGATI_CEL_PUTIN_UN_DETALIU_PE_ACEASTA_COMANDA, "Comenzi");
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
        /// apelat la double click pe o linie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnModificare.PerformClick();
        }

        /// <summary>
        /// aplicat la formatarea coloanelor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dataGridView1.Columns["ID_DETALIU_COMANDA"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; // valorile intreg aliniate catre dreapta
            dataGridView1.Columns["CANTITATE"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; // valorile intreg aliniate catre dreapta
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
            int IdDetaliuComandaSelectat = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID_DETALIU_COMANDA"].Value);

            ArrayList alListaParametri = new ArrayList();
            alListaParametri.Add("@id_detaliu_comanda");

            ArrayList alValoriParametri = new ArrayList();
            alValoriParametri.Add(IdDetaliuComandaSelectat);

            u.DeleteSelectedRowGeneric(dataGridView1, "sp_ComenziDetaliu_Delete", "Comenzi_Detaliu", alListaParametri, alValoriParametri);
            FillGrid();
        }

        /// <summary>
        /// updateaza linia selectata
        /// </summary>
        private void UpdateSelectedRow()
        {
            FormComenziOperatii fco = new FormComenziOperatii();
            fco.IdDetaliuComanda = (int)dataGridView1.SelectedRows[0].Cells["ID_DETALIU_COMANDA"].Value;
            // fco.IdDetaliuComanda = this.IdDetaliuComanda;
            fco.IdComanda = this.IdComanda;
            fco.CodProdusSelectat = dataGridView1.SelectedRows[0].Cells["COD_PRODUS"].Value.ToString();
            fco.Cantitate = Convert.ToDecimal(dataGridView1.SelectedRows[0].Cells["CANTITATE"].Value);//;
            fco.TipOperatie = "Modificare";
            fco.ShowDialog();
            FillGrid();
        }
        #endregion data access methods

    }
}
