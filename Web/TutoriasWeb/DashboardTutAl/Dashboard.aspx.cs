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
        int i = 0;

        //Encontrar objeto do utilizador que fez login
        for (i = 0; i < alunos.Count(); i++)
        {
            if (alunos[i].AlunoID == Session["LoginUser"].ToString())
                break;
        }

        LoginTextOut.InnerHtml = "<p>" + Session["LoginUser"].ToString() + "</p>";
        WelcomeTextLogin.InnerHtml += alunos[i].Nome + ".";
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("PedirApoio.aspx");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("HistoricoApoios.aspx");
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("AnularPedido.aspx");
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("AceitarApoio.aspx");
    }
}
