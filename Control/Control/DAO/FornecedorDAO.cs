using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Control.Entidades;

namespace Control.DAO
{
    public class FornecedorDAO
    {

        private SqlConnection conexao;
        private SqlTransaction tx;

        public FornecedorDAO(SqlConnection con)
        {
            this.conexao = con;
        }

        public FornecedorDAO(SqlConnection con, SqlTransaction tx)
        {
            this.conexao = con;
            this.tx = tx;
        }

        public Boolean Insert(Fornecedor fornecedor)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandType = System.Data.CommandType.Text;
            if (tx != null)
            {
                comando.Transaction = tx;
            }
            StringBuilder sql = new StringBuilder();
            sql.Append("Insert into Fornecedor (nome) ");
            sql.Append(" values ");
            sql.Append(" (@nome); ");
            sql.Append(" select @@identity from fornecedor ");
            comando.CommandText = sql.ToString();

            comando.Parameters.AddWithValue("@nome", fornecedor.nome);

            decimal n = (decimal)comando.ExecuteScalar();
            fornecedor.id= Convert.ToInt32(n);
            return n >= 1;
        }

        public Boolean Delete(Fornecedor fornecedor)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandType = System.Data.CommandType.Text;
            if (tx != null)
            {
                comando.Transaction = tx;
            }
            StringBuilder sql = new StringBuilder();
            sql.Append("Delete from fornecedor ");
            sql.Append(" where id = @id ");
            comando.CommandText = sql.ToString();
            comando.Parameters.AddWithValue("@id", fornecedor.id);
            int n = comando.ExecuteNonQuery();
            return n == 1;
        }

        public Boolean Delete(Int32 id)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandType = System.Data.CommandType.Text;
            if (tx != null)
            {
                comando.Transaction = tx;
            }
            StringBuilder sql = new StringBuilder();
            sql.Append("Delete from Produto ");
            sql.Append(" where id = @id ");
            comando.CommandText = sql.ToString();
            comando.Parameters.AddWithValue("@id", id);
            int n = comando.ExecuteNonQuery();
            return n == 1;
        }

        public Boolean Update(Fornecedor fornecedor)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandType = System.Data.CommandType.Text;
            if (tx != null)
            {
                comando.Transaction = tx;
            }
            StringBuilder sql = new StringBuilder();
            sql.Append("Update Fornecedor set ");
            sql.Append(" nome = @nome, ");
            sql.Append(" where id = @id ");
            comando.CommandText = sql.ToString();
            comando.Parameters.AddWithValue("@id", fornecedor.id);
            comando.Parameters.AddWithValue("@nome", fornecedor.nome);

            int n = comando.ExecuteNonQuery();
            return n >= 1;
        }

        public Fornecedor GetById(Int32 id)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandType = System.Data.CommandType.Text;
            if (tx != null)
            {
                comando.Transaction = tx;
            }

            comando.CommandText = "select * from fornecedor where id = @id";
            comando.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = comando.ExecuteReader();
            Fornecedor fornecedor = null;
            if (reader.Read())
            {
                fornecedor = new Fornecedor();
                fornecedor.id = (Int32)reader["id"];
                fornecedor.nome = (string)reader["nome"];

            }
            reader.Close();
            return fornecedor;
        }

        public List<Fornecedor> ListAllBynome(String nome)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandType = System.Data.CommandType.Text;
            if (tx != null)
            {
                comando.Transaction = tx;
            }
            StringBuilder sql = new StringBuilder();
            sql.Append("Select * from fornecedor where 1 = 1 ");
            sql.Append("and nome like @nome ");
           comando.Parameters.AddWithValue("@nome", nome + "%");

            comando.CommandText = sql.ToString();
            SqlDataReader reader = comando.ExecuteReader();
            List<Fornecedor> fornecedores = new List<Fornecedor>();
            while (reader.Read())
            {
                Fornecedor forn = new Fornecedor();
                forn.id = (Int32)reader["id"];
                forn.nome = (String)reader["nome"];
                //forn.Preco = Convert.ToDecimal(reader["preco"]);
                fornecedores.Add(forn);

            }
            return fornecedores;


        }
    }

}


