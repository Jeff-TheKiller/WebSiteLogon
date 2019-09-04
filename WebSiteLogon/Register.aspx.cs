using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebSiteLogon
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Apresenta mensagem de erro
            if ((Session["msgErro"] != null) && (Session["msgErro"].ToString() != ""))
            {
                LabelError.Text = Session["msgErro"].ToString();
            }

        }

        protected void btnConfirma_Click(object sender, EventArgs e)
        {
            // Valida senha
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                Session["msgErro"] = "Senha não confere";
                Response.Redirect("~\\Register.aspx");
            }
            Session["msgErro"] = "";
            // Instancia objeto DAL
            DAL.DALUsuario aDALUsuario = new DAL.DALUsuario();
            // Valida Usuario
            List<Models.Usuario> aListUsuario = aDALUsuario.Select(txtUser.Text);
            if (aListUsuario.Count > 0)
            {
                Session["msgErro"] = "Usuário já cadastrado";
                Response.Redirect("~\\Register.aspx");
            }

        }
    }
}