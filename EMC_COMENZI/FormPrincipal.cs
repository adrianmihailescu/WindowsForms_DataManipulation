using System;
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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        #region connection string
        string connectionString = ConfigurationSettings.AppSettings["conStringApplicatie"];
        FormClientiLista fcl;
        FormClientiOperatii fco;
        FormProduseLista fpl;
        FormProduseOperatii fpo;
        FormComenziLista fcls;
        FormComenziOperatii fclo;

        #endregion connection string

        #region menu methods
        /// <summary>
        /// iesirea din aplicatie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion menu methods


        #region operatii meniu

        /// <summary>
        /// vizualizare clienti
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void vizualizareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fcl = new FormClientiLista();
            fcl.ShowDialog();
        }

        /// <summary>
        /// vizualizare produse
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void vizualizareToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fpl = new FormProduseLista();
            fpl.ShowDialog();
        }

        /// <summary>
        /// lista comenzi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void vizualizareToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            fcls = new FormComenziLista();
            fcls.ShowDialog();
        }
        #endregion operatii meniu
    }
}
