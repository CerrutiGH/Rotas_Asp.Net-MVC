using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using Exercicio_GabrielCerruti.Models;
using System.Web.Mvc;

namespace Exercicio_GabrielCerruti.Connection
{
    public class AcoesNoticias
    {
        Conexao connection = new Conexao();

        public Noticias ListarNoticia(int noint)
        {
            MySqlCommand cmd = new MySqlCommand($"SELECT * FROM tb_Noticias WHERE COD_NOTICIA = {noint}", connection.ConectarBD());
            var DadosNoticia = cmd.ExecuteReader(); 
            var listNot = ListarTodasNoticias(DadosNoticia).FirstOrDefault();
            
            
            return new Noticias()
            {
                COD_NOTICIA = listNot.COD_NOTICIA,
                TITULO_NOTICIA = listNot.TITULO_NOTICIA,
                CATEGORIA_NOTICIA = listNot.CATEGORIA_NOTICIA,
                DATA_NOTICIA = listNot.DATA_NOTICIA,
                DESCRICAO_NOTICIA = listNot.DESCRICAO_NOTICIA
            }; 
        }

        public Noticias ListarCategoriasNoticias(string CAT)
        {
            MySqlCommand cmd = new MySqlCommand($"SELECT * FROM tb_Noticias WHERE CATEGORIA_NOTICIA = '{CAT}'", connection.ConectarBD());
            var DadosCat = cmd.ExecuteReader();
            var listCat = ListarTodasNoticias(DadosCat).FirstOrDefault();


            return new Noticias()
            {
                COD_NOTICIA = listCat.COD_NOTICIA,
                TITULO_NOTICIA = listCat.TITULO_NOTICIA,
                CATEGORIA_NOTICIA = listCat.CATEGORIA_NOTICIA,
                DATA_NOTICIA = listCat.DATA_NOTICIA,
                DESCRICAO_NOTICIA = listCat.DESCRICAO_NOTICIA
            };
        }





        public List<Noticias> ListarTodasNoticias(MySqlDataReader dt)
        {
            var AltAL = new List<Noticias>();
            while (dt.Read())
            {

                
                var AlTemp = new Noticias()
                {
                   COD_NOTICIA = Convert.ToInt32(dt["COD_NOTICIA"]),
                   TITULO_NOTICIA = dt["TITULO_NOTICIA"].ToString(),
                   CATEGORIA_NOTICIA = dt["CATEGORIA_NOTICIA"].ToString(),
                   DESCRICAO_NOTICIA = dt["DESCRICAO_NOTICIA"].ToString(),
                   DATA_NOTICIA = Convert.ToDateTime(dt["DATA_NOTICIA"]),
                };
                AltAL.Add(AlTemp);
            }
            dt.Close();
            return AltAL;
        }





        public List<Noticias> ListarAllNoticia()
        {
            MySqlCommand cmd = new MySqlCommand("select * from tb_Noticias", connection.ConectarBD());
            var DadosNoticia = cmd.ExecuteReader();
            return ListarTodasNoticias(DadosNoticia);
        }



      
        public List<Noticias> ListarCategorias()
        {
            MySqlCommand cmd = new MySqlCommand("select * from tb_Noticias group by CATEGORIA_NOTICIA", connection.ConectarBD());
            var DadosNoticia = cmd.ExecuteReader();
            return ListarTodasNoticias(DadosNoticia);
        }

        
        public List<Noticias> ListarCat(string CAT)
        {
            MySqlCommand cmd = new MySqlCommand($"SELECT * FROM tb_Noticias WHERE CATEGORIA_NOTICIA = '{CAT}'", connection.ConectarBD());
            var DadosNoticia = cmd.ExecuteReader();
            return ListarTodasNoticias(DadosNoticia);
        } 
        
        
        public List<Noticias> ListarTresUltimos()
        {
            MySqlCommand cmd = new MySqlCommand($"SELECT * FROM tb_Noticias ORDER BY COD_NOTICIA DESC LIMIT 3;", connection.ConectarBD());
            var DadosNoticia = cmd.ExecuteReader();
            return ListarTodasNoticias(DadosNoticia);
        }


    }
}