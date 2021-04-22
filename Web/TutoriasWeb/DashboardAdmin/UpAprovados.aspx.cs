using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DashboardAdmin_UpAprovados : System.Web.UI.Page
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

        string temp = Request.Form["chk_aprovado"];
        //Desaprovar toda a gente para aprovar apenas aqueles que estao marcados
        for(int i = 0; i < alunos.Count(); i++)
        {
            if (alunos[i].Tipo != Alunos.enumTipo.Admin)
                ws.EditAl(alunos, alunos[i].AlunoID, false);
        }
            

        if (temp != "" && temp != null)
        {
            string[] Aprov = temp.Split(',');

            for (int i = 0; i < Aprov.Count(); i++)
            {
                for (int i2 = 0; i < alunos.Count(); i2++)
                {
                    if (Aprov[i] == alunos[i2].AlunoID)
                    {
                        ws.EditAl(alunos, alunos[i2].AlunoID, true);
                        break;
                    }
                }
            }
        }
        Response.Redirect("AprovUtilizadores.aspx");
    }
}
