using System;
using MySql.Data.MySqlClient;

namespace Exercicio_GabrielCerruti.Connection
{
    public class Conexao
    {
        MySqlConnection conecta = new MySqlConnection("Server=localhost; Database=db_Melhores_Noticias;user=root;pwd=root");
        public static string msg;
        public MySqlConnection ConectarBD()
        {
            try
            {
                conecta.Open();
            }
            catch (Exception error)
            {
                msg = "Erro ao conectar o Banco de Dados" + error.Message;
            }
            return conecta;
        }

        public MySqlConnection DesconectarBD()
        {
            try
            {
                conecta.Close();
            }
            catch (Exception error)
            {
                msg = "Não foi possível desconectar o Banco de Dados" + error.Message;
            }
            return conecta;

        }
    }
}