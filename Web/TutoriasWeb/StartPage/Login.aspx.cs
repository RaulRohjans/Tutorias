using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Index : System.Web.UI.Page
{
    List<Apoios> apoios = new List<Apoios>();
    List<Alunos> alunos = new List<Alunos>();
    List<Disciplinas> disciplinas = new List<Disciplinas>();

    TutoriasService ws;
    protected void Page_Load(object sender, EventArgs e)
    {
        Session["LoginUser"] = null;
        Session["LoginTipo"] = null;
        ws = new TutoriasService(disciplinas, alunos, apoios);

        try
        {
            //Atualizar Apoios q foram completados            
            for (int i = 0; i < apoios.Count(); i++)
            {
                if (apoios[i].ReqDate < System.DateTime.Now)
                {
                    ws.EditAp(apoios, apoios[i].ApoioID, null, null, null, null, "Concluido", null, null, null);
                }
            }
        }
        catch(Exception)
        {
            errorOut.InnerHtml = "<p style=\"color: red; \">Ocorreu um erro ao obter informação da Base de Dados!</p>";
        }
    }

    protected void btn_login_Click(object sender, EventArgs e)
    {
        if (txt_pass.Text != "" && txt_username.Text != "")
        {
            bool PassError = false, aprove = false;
            for (int i = 0; i < alunos.Count(); i++)
            {
                if (alunos[i].AlunoID == txt_username.Text)
                {
                    string pwHash = CreateMD5(txt_pass.Text);
                    if (alunos[i].Password == pwHash)
                    {
                        if(alunos[i].Aprovado == true)
                        {
                            Session["LoginUser"] = alunos[i].AlunoID;
                            if (alunos[i].Tipo == Alunos.enumTipo.Admin)
                            {
                                Session["LoginTipo"] = "Admin";
                                Response.Redirect("~/DashboardAdmin/Dashboard.aspx");                                
                            }

                            if(alunos[i].Tipo == Alunos.enumTipo.Aluno)
                            {
                                Session["LoginTipo"] = "Aluno";
                                Response.Redirect("~/DashboardTutAl/Dashboard.aspx");
                            }

                            if(alunos[i].Tipo == Alunos.enumTipo.Tutor)
                            {
                                Session["LoginTipo"] = "Tutor";
                                Response.Redirect("~/DashboardTutAl/Dashboard.aspx");
                            }
                        }
                        else
                        {
                            errorOut.InnerHtml = "<p style=\"color: red; \">Por favor aguarde que um admin aprove a sua conta!</p>";
                            aprove = true;
                        }
                    }
                    else
                    {
                        errorOut.InnerHtml = "<p style=\"color: red; \">Palavra passe incorreta!</p>";
                        PassError = true;
                    }
                }
            }
            if (PassError == false && aprove == false)
                errorOut.InnerHtml = "<p style=\"color: red; \">Conta inexistente!</p>";
        }
        else
            errorOut.InnerHtml = "<p style=\"color: red; \">Por favor preencha todos os campos!</p>";
    }

    public static string CreateMD5(string input)
    {
        // Use input string to calculate MD5 hash
        using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
        {
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hashBytes = md5.ComputeHash(inputBytes);

            // Convert the byte array to hexadecimal string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("X2"));
            }
            return sb.ToString();
        }
    }
}