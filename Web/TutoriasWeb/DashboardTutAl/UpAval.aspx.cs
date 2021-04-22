using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DashboardAdmin_UpAprovAp : System.Web.UI.Page
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



        //Inserir texto das txt num array string
        string[] text = new string[apoios.Count()];
        int qtd = 0;
        int[] ids = new int[apoios.Count()];

        for(int i = 0; i < apoios.Count(); i++)
        {
            if (apoios[i].Estado == Apoios.enumEstado.Concluido && (apoios[i].Avaliacao == "" || apoios[i].Avaliacao == null))
            {
                if (Request.Form[apoios[i].ApoioID.ToString()] != "" && Request.Form[apoios[i].ApoioID.ToString()] != null)
                {
                    text[qtd] = Request.Form[apoios[i].ApoioID.ToString()];
                    ids[qtd] = apoios[i].ApoioID;
                    qtd++;
                }
            }
        }


        if (qtd != 0)
        {
            for (int i = 0; i < qtd; i++)
            {
                ws.EditAp(apoios, ids[i], null, null, null, null, null, null, text[i], null);
            }
        }
        Response.Redirect("HistoricoApoios.aspx");
    }
}

