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

        string temp = Request.Form["chk_aprovAp"];
        //Desaprovar toda a gente para aprovar apenas aqueles que estao marcados
        for (int i = 0; i < apoios.Count(); i++)
        {
            if (apoios[i].Estado != Apoios.enumEstado.Concluido)
                ws.EditAp(apoios, apoios[i].ApoioID, null, null, null, null, "Pendente", null, null, null);
        }


        if (temp != "" && temp != null)
        {
            string[] Aprov = temp.Split(',');

            for (int i = 0; i < Aprov.Count(); i++)
            {
                for (int i2 = 0; i2 < apoios.Count(); i2++)
                {
                    if (Convert.ToInt32(Aprov[i]) == apoios[i2].ApoioID)
                    {
                        ws.EditAp(apoios, apoios[i2].ApoioID, null, null, null, null, "Aceite", null, null, null);
                        break;
                    }
                }
            }
        }
        Response.Redirect("AprovApoio.aspx");
    }
}

