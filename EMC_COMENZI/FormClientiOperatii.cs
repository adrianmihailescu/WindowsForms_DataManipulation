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
    public partial class FormClientiOperatii : Form
    {
        public FormClientiOperatii()
        {
            InitializeComponent();
        }

        Utils u = new Utils();

        #region properties
        public string TipOperatie { get; set; }
        public int IdLinie { get; set; }
        public string CodClient { get; set; }
        public string Nume { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        #endregion properties


        #region validation
        /// <summary>
        /// verifica daca exista modificari nesalvate pe pagina la apasarea tastei esc.
        /// </summary>
        /// <returns></returns>
        protected bool ExistaModificariNesalvate()
        {
            return
                (
                    (txtAdresa.Text != (this.Adresa ?? ""))
                    || (txtNume.Text != (this.Nume ?? ""))
                    || (txtTelefon.Text != (this.Telefon ?? ""))
                    || (txtEmail.Text != (this.Email ?? ""))
                    || (txtFax.Text != (this.Fax ?? ""))
                    || (txtCodClient.Text != (this.CodClient ?? ""))
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
                txtCodClient.ReadOnly = true;
                // txtIDProdus.Text = this.IdLinie.ToString();
                txtCodClient.Text = this.CodClient;
                txtNume.Text = this.Nume;
                txtAdresa.Text = this.Adresa;
                txtTelefon.Text = this.Telefon;
                txtFax.Text = this.Fax;
                txtEmail.Text = this.Email;

                txtNume.Select();
            }

            else if (this.TipOperatie == "Adaugare")
            {
                // txtIDProdus.ReadOnly = true;
                txtCodClient.ReadOnly = false;

                txtCodClient.Select();
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
            string strCod = txtCodClient.Text;
            string strNume = txtNume.Text;
            string strAdresa = txtAdresa.Text;
            string strTelefon = txtTelefon.Text;
            string strFax = txtFax.Text;
            string strEmail = txtEmail.Text;

            ArrayList alListaParametri = new ArrayList();
            alListaParametri.Add("@cod_client");
            alListaParametri.Add("@nume");
            alListaParametri.Add("@adresa");
            alListaParametri.Add("@telefon");
            alListaParametri.Add("@fax");
            alListaParametri.Add("@email");

            ArrayList alValoriParametri = new ArrayList();
            alValoriParametri.Add(strCod);
            alValoriParametri.Add(strNume);
            alValoriParametri.Add(strAdresa);
            alValoriParametri.Add(strTelefon);
            alValoriParametri.Add(strFax);
            alValoriParametri.Add(strEmail);

            string strProcedureNameClienti = "";

            if (TipOperatie == "Adaugare")
                strProcedureNameClienti = "sp_Clienti_Insert";

            else if (TipOperatie == "Modificare")
                strProcedureNameClienti = "sp_Clienti_Update";

            if (u.GenericOperation(TipOperatie, strProcedureNameClienti, "Clienti", alListaParametri, alValoriParametri) == 0)
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
                    DialogResult result = MessageBox.Show(u.EXISTA_MODIFICARI_NESALVATE_IN_PAGINA, "Clienti", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
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
