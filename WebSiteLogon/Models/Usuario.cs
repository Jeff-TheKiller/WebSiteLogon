using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSiteLogon.Models
{
    public class Usuario
    {
       public int idUsuario {get; set;}
       public string Nome { get; set; }
       public string Senha { get; set; }
       public int idUsuarioPefil { get; set; }

       public Usuario()
        {
            this.Nome = "";
            this.idUsuario = 0;
            this.Senha = "";
            this.idUsuarioPefil = 0;
        }
        public Usuario(int aidUsuario, string aNome, string aSenha, int aidUsuarioPerfil)
        {
            this.idUsuario = aidUsuario;
            this.Nome = aNome;
            this.Senha = aSenha;
            this.idUsuarioPefil = aidUsuarioPerfil;
        }
    }
}