using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EMC_COMENZI
{
    class Utils
    {
        #region connection string
        // public string connectionString = ConfigurationSettings.AppSettings["EMC_COMENZI.Properties.Settings.EMC_COMENZIConnectionString"].ToString();
        public string connectionString = Properties.Settings.Default.EMC_COMENZIConnectionString;

        // public string str = System.Configuration.ConfigurationSettings.AppSettings.Get("EMC_COMENZI.Properties.Settings.EMC_COMENZIConnectionString").ToString();
        // protected string connectionString = @"Data Source=AUTOID\SQL2008;Initial Catalog=EMC_COMENZI;Integrated Security=True";

        #endregion connection string

        #region messages
        /// <summary>
        /// arata un mesaj de informare la adaugare pe entitate
        /// </summary>
        /// <param name="strNumentitate"></param>
        protected void ShowOkOnAdd(string strNumeEntitate)
        {
            switch (strNumeEntitate)
            {
                case "Clienti":
                    {
                        MessageBox.Show(ADAUGAREA_CLIENTULUI_SA_REALIZAT_CU_SUCCES, strNumeEntitate);
                        break;
                    }

                case "Produse":
                    {
                        MessageBox.Show(ADAUGAREA_PRODUSULUI_SA_REALIZAT_CU_SUCCES, strNumeEntitate);
                        break;
                    }

                case "Comenzi":
                    {
                        MessageBox.Show(ADAUGAREA_COMENZII_SA_REALIZAT_CU_SUCCES, strNumeEntitate);
                        break;
                    }

                case "Comenzi_Detaliu":
                    {
                        MessageBox.Show(ADAUGAREA_DETALIILOR_PE_COMENZII_SA_REALIZAT_CU_SUCCES, "Comenzi");
                        break;
                    }
            }
        }

        /// <summary>
        /// arata un mesaj de informare la update pe entitate
        /// </summary>
        /// <param name="strNumeEntitate"></param>
        protected void ShowOkOnUpdate(string strNumeEntitate)
        {
            switch (strNumeEntitate)
            {
                case "Clienti":
                    {
                        MessageBox.Show(MODIFICAREA_CLIENTULUI_SA_REALIZAT_CU_SUCCES, strNumeEntitate);
                        break;
                    }

                case "Produse":
                    {
                        MessageBox.Show(MODIFICAREA_PRODUSULUI_SA_REALIZAT_CU_SUCCES, strNumeEntitate);
                        break;
                    }

                case "Comenzi":
                    {
                        MessageBox.Show(MODIFICAREA_DETALIILOR_COMENZII_SA_REALIZAT_CU_SUCCES, "Comenzi");
                        break;
                    }
            }
        }

        /// <summary>
        /// arata un mesaj de eroare la adaugare pe entitate
        /// </summary>
        /// <param name="strNumeEntitate"></param>
        /// <param name="strMessage"></param>
        protected void ShowErrorOnAdd(string strNumeEntitate, string strMessage)
        {
                    switch (strNumeEntitate)
                    {
                        case "Clienti":
                            {
                                MessageBox.Show(A_APARUT_O_EROARE_LA_ADAUGAREA_CLIENTULUI + strMessage, strNumeEntitate);
                                break;
                            }

                        case "Produse":
                            {
                                MessageBox.Show(A_APARUT_O_EROARE_LA_ADAUGAREA_PRODUSULUI + strMessage, strNumeEntitate);
                                break;
                            }

                        case "Comenzi":
                            {
                                MessageBox.Show(A_APARUT_O_EROARE_LA_ADAUGAREA_COMENZII + strMessage, strNumeEntitate);
                                break;
                            }

                        case "Comenzi_Detaliu":
                            {
                                MessageBox.Show(A_APARUT_O_EROARE_LA_ADAUGAREA_DETALIILOR_PE_COMANDA + strMessage, "Comenzi");
                                break;
                            }
                    }
        }

        /// <summary>
        /// arata un mesaj de eroare la update pe entitate
        /// </summary>
        /// <param name="strNumeEntitate"></param>
        /// <param name="strMessage"></param>
        protected void ShowErrorOnUpdate(string strNumeEntitate, string strMessage)
        {
            switch (strNumeEntitate)
            {
                case "Clienti":
                    {
                        MessageBox.Show(A_APARUT_O_EROARE_LA_MODIFICAREA_CLIENTULUI + strMessage, strNumeEntitate);
                        break;
                    }

                case "Produse":
                    {
                        MessageBox.Show(A_APARUT_O_EROARE_LA_MODIFICAREA_PRODUSULUI + strMessage, strNumeEntitate);
                        break;
                    }

                case "Comenzi_Detaliu":
                    {
                        MessageBox.Show(A_APARUT_O_EROARE_LA_MODIFICAREA_DETALIILOR_PE_COMANDA + strMessage, "Comenzi");
                        break;
                    }
            }
        }

        /// <summary>
        /// arata un mesaj de eroare la stergerea pe entitate
        /// </summary>
        /// <param name="strNumeEntitate"></param>
        /// <param name="strMessage"></param>
        protected void ShowErrorOnDelete(string strNumeEntitate, string strMessage)
        {
            switch (strNumeEntitate)
            {
                case "Clienti":
                    {
                        MessageBox.Show(A_APARUT_O_EROARE_LA_STERGEREA_CLIENTULUI + strMessage, strNumeEntitate);
                        break;
                    }

                case "Produse":
                    {
                        MessageBox.Show(A_APARUT_O_EROARE_LA_STERGEREA_PRODUSULUI + strMessage, strNumeEntitate);
                        break;
                    }

                case "Comenzi_Detaliu":
                    {
                        MessageBox.Show(A_APARUT_O_EROARE_LA_STERGEREA_DETALIULUI_PE_COMANDA + strMessage, "Comenzi");
                        break;
                    }
            }
        }
        #endregion messages

        #region validation

        /// <summary>
        /// verifica daca este selectata o linie in grid
        /// </summary>
        /// <returns></returns>
        public bool isOneRowSelectedInGrid(DataGridView dgv)
        {
            bool hasRows = (dgv.SelectedRows.Count > 0);
            bool rezultat = false;

            if (hasRows)
                if (dgv.SelectedRows[0].Cells[0].Value != null)
                    rezultat = true;

            return rezultat;
        }

        /// <summary>
        /// verifica daca am cel putin o linie in grid
        /// </summary>
        public bool isEmptyGrid(DataGridView dgv)
        {
            bool hasRows = (dgv.Rows.Count > 0);
            bool rezultat = false;

            if (!hasRows)
                rezultat = true;
           
            return rezultat;
        }
        #endregion validation

        #region format
        /// <summary>
        /// returneaza o data sub forma mm/dd/yyyy
        /// </summary>
        /// <param name="dtValue"></param>
        /// <returns></returns>
        public string FormatDateAsString(DateTime dtValue)
        {
            return
                (
                    dtValue.Month.ToString()
                    + '/' + dtValue.Day.ToString()
                    + '/' + dtValue.Year.ToString()
                );
        }
        #endregion format

        #region data methods

        /// <summary>
        /// intoarce o comanda generica de tip SqlCommand
        /// </summary>
        /// <param name="connectionString"></param>
        /// <param name="strNumeProcedura"></param>
        /// <returns></returns>
        protected SqlCommand GetSqlCommand(string connectionString, string strNumeProcedura)
        {
            /////////////////////////////////
            int? ERC = 0;
            string MESSAGE = "";

            // Create a new data adapter based on the specified query.
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand(strNumeProcedura, sqlConnection);

            // transmit valorile parametrilor
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = strNumeProcedura;

            sqlCommand.Parameters.AddWithValue("@ERC", ERC).Direction = ParameterDirection.InputOutput;
            sqlCommand.Parameters.AddWithValue("@MESSAGE", MESSAGE).Direction = ParameterDirection.InputOutput;
            sqlCommand.Parameters["@MESSAGE"].Size = 4000;
            /////////////////////////////

            return sqlCommand;
        }

        /// <summary>
        /// sterge o linie din grid
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="strNumeProcedura"></param>
        /// <param name="strNumeEntitate"></param>
        /// <param name="alListaParametri"></param>
        /// <param name="alValoriParametri"></param>
        public void DeleteSelectedRowGeneric(DataGridView dgv, string strNumeProcedura, string strNumeEntitate, ArrayList alListaParametri, ArrayList alValoriParametri)
        {
            SqlCommand sqlCommand = GetSqlCommand(connectionString, strNumeProcedura);

            // adaug parametrii si valorile
            for (int i = 0; i < alListaParametri.Count; i++)
            {
                sqlCommand.Parameters.AddWithValue(alListaParametri[i].ToString(), alValoriParametri[i]);
            }

            try
            {
                sqlCommand.ExecuteNonQuery();

                /////////////
                int ID_MESAJ_EROARE_PROCEDURA = (int)sqlCommand.Parameters["@ERC"].Value;
                string MESAJ_EROARE_PROCEDURA = sqlCommand.Parameters["@MESSAGE"].Value.ToString();

                if (ID_MESAJ_EROARE_PROCEDURA != 0)
                {
                    MessageBox.Show(MESAJ_EROARE_PROCEDURA);
                }
                //////////////////////////
            }

            catch (Exception ex)
            {
                ShowErrorOnDelete(strNumeEntitate, ex.Message);
            }

            finally
            {
                if (sqlCommand.Connection.State == ConnectionState.Open)
                    sqlCommand.Connection.Close();
            }
        }
        
        /// <summary>
        /// umple grid-ul din pagina
        /// </summary>
        public void FillGridGeneric(DataGridView dgv, string strNumeProcedura, string strNumeEntitate, ArrayList alListaParametri, ArrayList alValoriParametri)
        {
            int linieSelectata = 0;
            if (isOneRowSelectedInGrid(dgv))
                linieSelectata = dgv.SelectedRows[0].Index;

            SqlCommand sqlCommand = GetSqlCommand(connectionString, strNumeProcedura);
            

            // adaug parametrii si valorile
            for (int i = 0; i < alListaParametri.Count; i++)
            {
                // dataAdapter.SelectCommand.Parameters.AddWithValue(alListaParametri[i].ToString(), alValoriParametri[i]);
                sqlCommand.Parameters.AddWithValue(alListaParametri[i].ToString(), alValoriParametri[i]);
            }

            SqlDataReader sdrValues = sqlCommand.ExecuteReader();
            DataTable dtValues = new DataTable();

            try
            {
                dtValues.Load(sdrValues);
                dgv.DataSource = dtValues;

                // selectez linia care era selectata inainte
                if (linieSelectata > dgv.Rows.Count)
                {
                    dgv.Rows[0].Selected = true;
                }

                else
                {
                    if (!isEmptyGrid(dgv))
                        dgv.Rows[linieSelectata].Selected = true;
                }
            }

            catch (Exception ex)
            {
                // MessageBox.Show(dgv.Rows[numarLinieSelectata].Cells[0].Value.ToString());
                MessageBox.Show(A_APARUT_O_EROARE_LA_CONECTARE + ex.Message, strNumeEntitate); // aici 06/23/2011
            }

            finally
            {
                if (!sdrValues.IsClosed)
                    sdrValues.Close();

                if (sqlCommand.Connection.State == ConnectionState.Open)
                    sqlCommand.Connection.Close();
            }
        }

        /// <summary>
        /// o metoda generica pentru adaugare / modificare
        /// </summary>
        /// <param name="strTipOperatie"></param>
        /// <param name="strNumeProcedura"></param>
        /// <param name="strNumeEntitate"></param>
        /// <param name="alListaParametri"></param>
        /// <param name="alValoriParametri"></param>
        public int GenericOperation(string strTipOperatie, string strNumeProcedura, string strNumeEntitate, ArrayList alListaParametri, ArrayList alValoriParametri)
        {
            SqlCommand sqlCommand = GetSqlCommand(connectionString, strNumeProcedura);

            /////////////
            int ID_MESAJ_EROARE_PROCEDURA = 0;
            string MESAJ_EROARE_PROCEDURA = null;

            // adaug parametrii si valorile
            for (int i = 0; i < alListaParametri.Count; i++)
            {
                sqlCommand.Parameters.AddWithValue(alListaParametri[i].ToString(), (alValoriParametri[i].ToString() == "") ? null : alValoriParametri[i]);
            }

            try
            {
                sqlCommand.ExecuteNonQuery();
                
                ID_MESAJ_EROARE_PROCEDURA = (int)sqlCommand.Parameters["@ERC"].Value;
                MESAJ_EROARE_PROCEDURA = sqlCommand.Parameters["@MESSAGE"].Value.ToString();

                if (ID_MESAJ_EROARE_PROCEDURA == 0)
                {
                    if (strTipOperatie == "Adaugare")
                    {
                        ShowOkOnAdd(strNumeEntitate);
                    }

                    else if (strTipOperatie == "Modificare")
                    {
                        ShowOkOnUpdate(strNumeEntitate);
                    }

                    // this.Close();
                }

                else
                {
                    MessageBox.Show(MESAJ_EROARE_PROCEDURA);
                }
                //////////////////////////

                return ID_MESAJ_EROARE_PROCEDURA;
            }

            catch (Exception ex)
            {
                if (strTipOperatie == "Adaugare")
                {
                    ShowErrorOnAdd(strNumeEntitate, ex.Message);
                }

                else if (strTipOperatie == "Modificare")
                {
                    ShowErrorOnUpdate(strNumeEntitate, ex.Message);
                }

                return ID_MESAJ_EROARE_PROCEDURA;
            }

            finally
            {
                if (sqlCommand.Connection.State == ConnectionState.Open)
                    sqlCommand.Connection.Close();
            }
        }
        #endregion data methods

        #region mesaje
        // generale
        public string A_APARUT_O_EROARE_LA_CONECTARE = "A aparut o eroare la conectare : ";
        public string A_APARUT_O_EROARE_LA_STERGERE = "A aparut o eroare la stergere : ";
        public string EXISTA_MODIFICARI_NESALVATE_IN_PAGINA = "Exista modificari nesalvate ! Inchideti fereastra fara salvarea modificarilor ?";
        
        // clienti
        public string A_APARUT_O_EROARE_LA_ADAUGAREA_CLIENTULUI = "A aparut o eroare la adaugarea clientului : ";
        public string A_APARUT_O_EROARE_LA_MODIFICAREA_CLIENTULUI = "A aparut o eroare la modificarea clientului : ";
        public string A_APARUT_O_EROARE_LA_STERGEREA_CLIENTULUI = "A aparut o eroare la stergerea clientului : ";

        public string SELECTATI_UN_CLIENT_DIN_LISTA = "Selectati un client din lista !";
        public string ADAUGATI_CEL_PUTIN_UN_CLIENT_IN_LISTA = "Adaugati cel putin un client in lista !";
        public string DORITI_SA_STERGETI_ACEST_CLIENT = "Doriti sa stergeti acest client ?";
        public string STERGEREA_CLIENTULUI_SA_REALIZAT_CU_SUCCES = "Stergerea clientului s-a realizat cu succes !";
        public string ADAUGAREA_CLIENTULUI_SA_REALIZAT_CU_SUCCES = "Adaugarea clientului s-a realizat cu succes !";
        public string MODIFICAREA_CLIENTULUI_SA_REALIZAT_CU_SUCCES = "Modificarea clientului s-a realizat cu succes !";

        // produse
        public string A_APARUT_O_EROARE_LA_ADAUGAREA_PRODUSULUI = "A aparut o eroare la adaugarea produsului : ";
        public string A_APARUT_O_EROARE_LA_MODIFICAREA_PRODUSULUI = "A aparut o eroare la modificarea produsului : ";
        public string A_APARUT_O_EROARE_LA_STERGEREA_PRODUSULUI = "A aparut o eroare la stergerea produsului : ";

        public string SELECTATI_UN_PRODUS_DIN_LISTA = "Selectati un produs din lista !";
        public string ADAUGATI_CEL_PUTIN_UN_PRODUS_IN_LISTA = "Adaugati cel putin un produs in lista !";
        public string DORITI_SA_STERGETI_ACEST_PRODUS = "Doriti sa stergeti acest produs ?";
        public string STERGEREA_PRODUSULUI_SA_REALIZAT_CU_SUCCES = "Stergerea produsului s-a realizat cu succes !";
        public string ADAUGAREA_PRODUSULUI_SA_REALIZAT_CU_SUCCES = "Adaugarea produsului s-a realizat cu succes !";
        public string MODIFICAREA_PRODUSULUI_SA_REALIZAT_CU_SUCCES = "Modificarea produsului s-a realizat cu succes !";

        // comenzi
        public string A_APARUT_O_EROARE_LA_ADAUGAREA_COMENZII = "A aparut o eroare la adaugarea comenzii !";
        public string SELECTATI_O_COMANDA_DIN_LISTA_PENTRU_A_AFISA_DETALIILE = "Selectati o comanda din lista pentru a afisa detaliile !";
        public string ADAUGATI_CEL_PUTIN_O_COMANDA_IN_LISTA = "Adaugati cel putin o comanda in lista !";
        public string ADAUGAREA_COMENZII_SA_REALIZAT_CU_SUCCES = "Adaugarea comenzii s-a realizat cu succes !";
        public string DATA_DE_SFARSIT_A_INTERVALULUI_NU_POATE_FI_INAINTEA_DATEI_DE_INCEPUT = "Data de sfarsit a intervalului nu poate fi inaintea datei de inceput !";

        // detaliu comanda
        public string SELECTATI_UN_DETALIU_COMANDA_DIN_LISTA = "Selectati un detaliu comanda din lista !";
        public string ADAUGATI_CEL_PUTIN_UN_DETALIU_PE_ACEASTA_COMANDA = "Adaugati cel putin un detaliu pe aceasta comanda !";
        public string STERGEREA_DETALIILOR_COMENZII_SA_REALIZAT_CU_SUCCES = "Stergerea detaliilor comenzii s-a realizat cu succes !";
        public string ADAUGAREA_DETALIILOR_PE_COMENZII_SA_REALIZAT_CU_SUCCES = "Adaugarea detaliilor comenzii s-a realizat cu succes !";
        public string MODIFICAREA_DETALIILOR_COMENZII_SA_REALIZAT_CU_SUCCES = "Modificarea detaliilor comenzii s-a realizat cu succes !";
        public string A_APARUT_O_EROARE_LA_STERGEREA_DETALIULUI_PE_COMANDA = "A aparut o eroare la stergerea detaliului pe comanda : ";
        public string DORITI_SA_STERGETI_DETALIUL_DE_PE_ACEASTA_COMANDA = "Doriti sa stergeti detaliul de pe aceasta comanda ?";
        public string A_APARUT_O_EROARE_LA_ADAUGAREA_DETALIILOR_PE_COMANDA = "A aparut o eroare la adaugarea detaliilor pe comanda : ";
        public string A_APARUT_O_EROARE_LA_MODIFICAREA_DETALIILOR_PE_COMANDA = "A aparut o eroare la modificarea detaliilor pe comanda : ";

        #endregion mesaje

    }
}
