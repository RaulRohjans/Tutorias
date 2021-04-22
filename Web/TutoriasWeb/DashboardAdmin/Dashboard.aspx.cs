using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Dashboard_Dashboard : System.Web.UI.Page
{
    List<Apoios> apoios = new List<Apoios>();
    List<Alunos> alunos = new List<Alunos>();
    List<Disciplinas> disciplinas = new List<Disciplinas>();

    TutoriasService ws;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["LoginUser"] == null || Session["LoginTipo"] == null)
        {            
            Response.Redirect("~/StartPage/Login.aspx");
        }
        ws = new TutoriasService(disciplinas, alunos, apoios);
        int i2 = 0;

        //Encontrar objeto do utilizador que fez login
        for(i2 = 0; i2 < alunos.Count(); i2++)
        {
            if (alunos[i2].AlunoID == Session["LoginUser"].ToString())
                break;
        }

        //Atualizar Nome de login
        LoginTextOut.InnerHtml = "<p>" + Session["LoginUser"].ToString() + "</p>";

        //Atualizar mensagem de boas vindas
        WelcomeTextLogin.InnerHtml += alunos[i2].Nome + ".";

        //Atualizar total de utilizadores
        TotalUtilizadores.InnerHtml = alunos.Count().ToString();

        //Atualizar quantidade de utilizadores por aprovar
        int qtdAl = 0;
        for(int i = 0; i < alunos.Count(); i++)
        {
            if (alunos[i].Aprovado == false)
                qtdAl++;
        }
        UtilizadoresPorAprovar.InnerHtml = qtdAl.ToString();

        //Atualizar Total de apoios 
        TotalApoios.InnerHtml = apoios.Count().ToString();

        //Atualizar quantidade de apoios por aprovar
        int qtdAp = 0;
        for(int i = 0; i < apoios.Count(); i++)
        {
            if (apoios[i].Estado == Apoios.enumEstado.Pendente)
                qtdAp++;
        }
        ApoiosPorAprovar.InnerHtml = qtdAp.ToString();
    }
}
