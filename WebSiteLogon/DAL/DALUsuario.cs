using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebSiteLogon.DAL
{
    public class DALUsuario
    {
        string connectionString = "";

        public DALUsuario()
        {
            connectionString = ConfigurationManager.ConnectionStrings
                         ["PubsConnectionString"].ConnectionString;
        }
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void Insert(Models.Usuario obj)
        {
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand com = conn.CreateCommand();
            // Define comando de exclusão
            SqlCommand cmd = new SqlCommand("INSERT INTO Usuario (Usuario,Senha, idUsuarioPerfil) VALUES(@Usuario, @Senha,@idUsuarioPerfil)", conn); cmd.Parameters.AddWithValue("@title", obj.Nome);
            cmd.Parameters.AddWithValue("@pub_id", obj.Senha);
            cmd.Parameters.AddWithValue("@title_id", obj.idUsuarioPefil);

            // Executa Comando
            cmd.ExecuteNonQuery();
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Models.Usuario> Select(string usuario)
        {
            // Variavel para armazenar um livro
            Models.Usuario aUsuario;
            // Cria Lista Vazia
            List<Models.Usuario> aListUsuario = new List<Models.Usuario>();
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand cmd = conn.CreateCommand();
            // define SQL do comando
            cmd.CommandText = "Select * from Usuario Where Usuario = @Usuario";
            cmd.Parameters.AddWithValue("@Usuario", usuario);
            // Executa comando, gerando objeto DbDataReader
            SqlDataReader dr = cmd.ExecuteReader();
            // Le titulo do livro do resultado e apresenta no segundo rótulo
            if (dr.HasRows)
            {
                while (dr.Read()) // Le o proximo registro
                {




                    // Cria objeto com dados lidos do banco de dados
                    aUsuario = new Models.Usuario(
                        Convert.ToInt32(dr["idUsuario"].ToString()),
                        dr["Usuario"].ToString(),
                        dr["Senha"].ToString(),
                        Convert.ToInt32(dr["idUsuarioPerfil"].ToString())
                        );
                    // Adiciona o livro lido à lista
                    aListUsuario.Add(aUsuario);
                }
            }
            // Fecha DataReader
            dr.Close();
            // Fecha Conexão
            conn.Close();

            return aListUsuario;
        }


        }
    }