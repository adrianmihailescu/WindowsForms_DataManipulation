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
    public partial class FormComenziOperatii : Form
    {
        public FormComenziOperatii()
        {
            InitializeComponent();
        }

        Utils u = new Utils();

        #region validation
        /// <summary>
        /// verifica daca exista modificari nesalvate pe pagina la apasarea tastei esc.
        /// </summary>
        /// <returns></returns>
        protected bool ExistaModificariNesalvate()
        {
            double strCantitateNoua = Convert.ToDouble(txtCantitate.Text);
            double strCantitateVeche = Convert.ToDouble(this.Cantitate);

            return
                (
                    (txtProdus.Text != (this.CodProdusSelectat ?? ""))
                    || (strCantitateNoua != strCantitateVeche)
                );
        }
        #endregion validation

        #region properties
        public string TipOperatie { get; set; }
        public int IdDetaliuComanda { get; set; }
        public int IdComanda { get; set; }
        public int IdProdusSelectat { get; set; }
        public string CodProdusSelectat { get; set; }
        public decimal Cantitate { get; set; }
        #endregion properties

        #region form methods
        private void btnSelectareProdus_Click(object sender, EventArgs e)
        {
            using (FormProduseLista fpl = new FormProduseLista())
            {
                fpl.ModPagina = "Selectare";
                fpl.ShowDialog();
                txtProdus.Text = fpl.CodProdusSelectat;
                this.IdProdusSelectat = fpl.IdProdusSelectat;
            }
        }

        /// <summary>
        /// umple controalele paginii
        /// </summary>
        protected void FillFormControls()
        {
            // txtComanda.Text = IdComanda.ToString();
            txtProdus.Text = CodProdusSelectat;
            txtCantitate.Value = this.Cantitate;

            label4.Text = this.TipOperatie + " Detalii";
            // btnOperation.Text = this.TipOperatie;

            btnSelectieProdus.Visible = (this.TipOperatie == "Adaugare");
        }

        /// <summary>
        /// folosita la incarcarea paginii
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormComenziOperatii_Load(object sender, EventArgs e)
        {
            FillFormControls();

            if (this.TipOperatie == "Adaugare")
                txtProdus.Select();

            else if (this.TipOperatie == "Modificare")
                txtCantitate.Select();
        }

        /// <summary>
        /// apelata pentru a face adaugare sau modificare
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperation_Click(object sender, EventArgs e)
        {
            // setez valorile parametrilor
            int strIdComanda = IdComanda;
            int strIdProdus = IdProdusSelectat; // aici
            decimal strCantitate = txtCantitate.Value;

            ArrayList alListaParametri = new ArrayList();
            ArrayList alValoriParametri = new ArrayList();

            if (TipOperatie == "Adaugare")
            {
                alListaParametri.Add("@id_comanda");
                alListaParametri.Add("@id_produs");
                alListaParametri.Add("@cantitate");

                alValoriParametri.Add(strIdComanda);
                alValoriParametri.Add(strIdProdus);
                alValoriParametri.Add(strCantitate);
            }

            else if (TipOperatie == "Modificare")
            {
                alListaParametri.Add("@id_detaliu_comanda");
                alListaParametri.Add("@cantitate");

                alValoriParametri.Add(IdDetaliuComanda);
                alValoriParametri.Add(strCantitate);
            }

            string strProcedureNameComenzi = "";

            if (TipOperatie == "Adaugare")
                strProcedureNameComenzi = "sp_ComenziDetaliu_Insert";

            else if (TipOperatie == "Modificare")
                strProcedureNameComenzi = "sp_ComenziDetaliu_Update";

            // MessageBox.Show("inainte: " + alValoriParametri[0].ToString());
            if (
            u.GenericOperation(TipOperatie, strProcedureNameComenzi, "Comenzi", alListaParametri, alValoriParametri) == 0
            )
            // MessageBox.Show("dupa: " + alValoriParametri[0].ToString());
            this.Close();
        }

        /// <summary>
        /// apelat la selectarea produsului
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectieProdus_Click(object sender, EventArgs e)
        {
            using (FormProduseLista fpl = new FormProduseLista())
            {
                fpl.ModPagina = "Selectare";
                fpl.ShowDialog();
                txtProdus.Text = fpl.CodProdusSelectat;
                this.IdProdusSelectat = fpl.IdProdusSelectat;
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
                if (ExistaModificariNesalvate())
                {
                    DialogResult result = MessageBox.Show(u.EXISTA_MODIFICARI_NESALVATE_IN_PAGINA, "Comenzi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (result.Equals(DialogResult.OK))
                    {
                        this.Close();
                        return true;
                    }
                }

                else
                {
                    this.Close();
                    return true;
                }
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        #endregion form methods
    }
}
