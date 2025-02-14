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
    public partial class FormComenziCreare : Form
    {
        #region properties
        public string IdClientSelectat { get; set; }
        public string CodClientSelectat { get; set; }
        public string TipOperatie { get; set; }
        #endregion properties


        #region form methods
        public FormComenziCreare()
        {
            InitializeComponent();
        }

        Utils u = new Utils();

        private void btnSelectareClient_Click(object sender, EventArgs e)
        {
            using (FormClientiLista fcl = new FormClientiLista())
            {
                fcl.ModPagina = "Selectare";
                fcl.ShowDialog();
                txtCodClient.Text = fcl.CodClientSelectat;
                this.IdClientSelectat = fcl.IdClientSelectat; // AICI 08062011
            }
        }

        /// <summary>
        /// apelat la creare comanda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOKComanda_Click(object sender, EventArgs e)
        {
            string strProcedureNameComenzi = "sp_Comenzi_Insert";

            if (txtCodClient.Text == "")
            {
                MessageBox.Show(u.SELECTATI_UN_CLIENT_DIN_LISTA, "Comenzi");
            }

            else
            {
                // setez valorile parametrilor
                string strIdClient = IdClientSelectat;
                string strDataComanda = dtDataComanda.Value.ToString();
                string strDataLivrare = dtDataLivrare.Value.ToString();

                strDataLivrare = u.FormatDateAsString(dtDataLivrare.Value);
                strDataComanda = u.FormatDateAsString(dtDataComanda.Value);


                ArrayList alListaParametri = new ArrayList();
                alListaParametri.Add("@id_client");
                alListaParametri.Add("@data_comanda");
                alListaParametri.Add("@data_livrare");

                ArrayList alValoriParametri = new ArrayList();
                alValoriParametri.Add(strIdClient);
                alValoriParametri.Add(strDataComanda);
                alValoriParametri.Add(strDataLivrare);

                u.GenericOperation("Adaugare", strProcedureNameComenzi, "Comenzi", alListaParametri, alValoriParametri);
                this.Close();
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
        #endregion form methods
    }
}
