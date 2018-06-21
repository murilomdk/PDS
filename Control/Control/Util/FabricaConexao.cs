using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Control.Util
{
    public class FabricaConexao
    {
        private static String stringCon = Properties.Settings.Default.StringCon;

        public static SqlConnection GetConexao()
        {
            SqlConnection con = new SqlConnection(stringCon);
            con.Open();
            return con;
        }

        public static void CloseConexao(SqlConnection con)
        {
            try
            {
                con.Close();
            }
            catch (Exception ex)
            {
                //nada aqui!!
            }
        }
    }

}
