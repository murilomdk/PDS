using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Control.DAO;
using Control.Entidades;
using Control.Util;
using System.Data.SqlClient;

namespace Control
{
    public partial class FormFornecedor : Form
    {
        public FormFornecedor()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void fornecedores_Load(object sender, EventArgs e)
        {
            MostrarFornecedores();
        }


        private void MostrarFornecedores()
        {

            SqlConnection conexao = FabricaConexao.GetConexao();
            FornecedorDAO fornecedorDAO = new FornecedorDAO(conexao);

            fornecedorBindingSource.DataSource = null;
            fornecedorBindingSource.DataSource = fornecedorDAO.ListAllBynome("");

            FabricaConexao.CloseConexao(conexao);
        
        }

    }

}
