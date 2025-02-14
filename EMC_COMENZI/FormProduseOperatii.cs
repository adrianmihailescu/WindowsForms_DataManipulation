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
    public partial class FormProduseOperatii : Form
    {
        #region properties
        public string TipOperatie { get; set; }
        public int IdLinie { get; set; }
        public string CodProdus { get; set; }
        public string Denumire { get; set; }
        public string UnitateMasura { get; set; }
        public double Pret { get; set; }
        public string CodBare { get; set; }
        #endregion properties
        
        public FormProduseOperatii()
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
            double strPretNou = Convert.ToDouble(txtPret.Text);
            double strPretVechi = this.Pret;

            return
                (
                    (txtCodProdus.Text != (this.CodProdus ?? ""))
                    || (txtDenumire.Text != (this.Denumire ?? ""))
                    || (txtUnitateMasura.Text != (this.UnitateMasura ?? ""))
                    || (strPretNou != strPretVechi)
                    || (txtCodBare.Text != (this.CodBare ?? ""))
                );
        }
        #endregion validation

        #region form methods
        private void FormClientiOperatii_Load(object sender, EventArgs e)
        {
            FillFormControls();
        }

        /// <summary>
        /// umple controalele la intrarea pe pagina, in functie de operatia de adaugare sau modificare
        /// </summary>
        public void FillFormControls()
        {
            lblTitle.Text = this.TipOperatie + " Detalii";
            // btnOperation.Text = this.TipOperatie;

            if (this.TipOperatie == "Modificare")
            {
                /*txtIDProdus.ReadOnly = */txtCodProdus.ReadOnly = true;
                // txtIDProdus.Text = IdLinie.ToString();
                txtCodProdus.Text = this.CodProdus;
                txtDenumire.Text = this.Denumire;
                txtUnitateMasura.Text = this.UnitateMasura;
                txtCodBare.Text = this.CodBare;
                txtPret.Value = (decimal)this.Pret; // aici 09062011

                txtDenumire.Select();
            }

            else if (this.TipOperatie == "Adaugare")
            {
                // txtIDProdus.ReadOnly = true;
                txtCodProdus.ReadOnly = false;

                txtCodProdus.Select();
            }
        }

        /// <summary>
        /// apelata pentru a face adaugare sau modificare
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperation_Click(object sender, EventArgs e)
        {
            // setez valorile parametrilor
            string strCodProdus = txtCodProdus.Text;
            string strDenumire = txtDenumire.Text;
            string strUnitateMasura = txtUnitateMasura.Text;
            decimal strPret = txtPret.Value;
            string strCodBare = txtCodBare.Text;

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

            string strProcedureNameProduse = "";

            if (TipOperatie == "Adaugare")
                strProcedureNameProduse = "sp_Produse_Insert";

            else if (TipOperatie == "Modificare")
                strProcedureNameProduse = "sp_Produse_Update";

            if (
            u.GenericOperation(TipOperatie, strProcedureNameProduse, "Produse", alListaParametri, alValoriParametri) == 0
            )
            this.Close();
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
                    DialogResult result = MessageBox.Show(u.EXISTA_MODIFICARI_NESALVATE_IN_PAGINA, "Produse", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
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
