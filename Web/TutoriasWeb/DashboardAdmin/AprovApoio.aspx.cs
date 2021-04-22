using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DashboardAdmin_Utilizadores : System.Web.UI.Page
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
        LoginTextOut.InnerHtml = "<p>" + Session["LoginUser"].ToString() + "</p>";
        ws = new TutoriasService(disciplinas, alunos, apoios);

        //Inserir itens na tabela
        for (int i = 0; i < apoios.Count(); i++)
        {

            OutUsers.InnerHtml += "<tr>";
            OutUsers.InnerHtml += "<th scope=\"row\">" + apoios[i].ApoioID.ToString() + "</th>";
            OutUsers.InnerHtml += "<td>" + apoios[i].AlunoID + "</td>";
            OutUsers.InnerHtml += "<td>" + apoios[i].TutorID + "</td>";
            OutUsers.InnerHtml += "<td>" + apoios[i].Sigla + "</td>";
            OutUsers.InnerHtml += "<td>" + apoios[i].ReqDate.ToShortDateString() + "</td>";
            OutUsers.InnerHtml += "<td>" + apoios[i].Local + "</td>";

            if (apoios[i].Descricao == null || apoios[i].Descricao == "")
                OutUsers.InnerHtml += "<td> - </td>";
            else
                OutUsers.InnerHtml += "<td>" + apoios[i].Descricao + "</td>";

            switch (apoios[i].Estado)
            {
                case Apoios.enumEstado.Pendente:
                    OutUsers.InnerHtml += "<td><input name=\"chk_aprovAp\" type=\"checkbox\" value=\"" + apoios[i].ApoioID + "\"/></td>";
                    break;

                case Apoios.enumEstado.Aceite:
                    OutUsers.InnerHtml += "<td><input name=\"chk_aprovAp\" type=\"checkbox\" value=\"" + apoios[i].ApoioID + "\" checked /></td>";
                    break;

                //Nao e necessario estar aqui mas facilita se algum dia for preciso incluir
                case Apoios.enumEstado.Concluido:
                    OutUsers.InnerHtml += "<td>Concluido</td>";
                    break;
            }
            OutUsers.InnerHtml += "</tr>";
        }

    }

    protected void btn_atualizar_Click(object sender, EventArgs e)
    {
        //Inserir itens na tabela
        for (int i = 0; i < apoios.Count(); i++)
        {

            OutUsers.InnerHtml += "<tr>";
            OutUsers.InnerHtml += "<th scope=\"row\">" + apoios[i].ApoioID.ToString() + "</th>";
            OutUsers.InnerHtml += "<td>" + apoios[i].AlunoID + "</td>";
            OutUsers.InnerHtml += "<td>" + apoios[i].TutorID + "</td>";
            OutUsers.InnerHtml += "<td>" + apoios[i].Sigla + "</td>";
            OutUsers.InnerHtml += "<td>" + apoios[i].ReqDate.ToShortDateString() + "</td>";
            OutUsers.InnerHtml += "<td>" + apoios[i].Local + "</td>";

            if (apoios[i].Descricao == null || apoios[i].Descricao == "")
                OutUsers.InnerHtml += "<td> - </td>";
            else
                OutUsers.InnerHtml += "<td>" + apoios[i].Descricao + "</td>";

            switch (apoios[i].Estado)
            {
                case Apoios.enumEstado.Pendente:
                    OutUsers.InnerHtml += "<td><input name=\"chk_aprovAp\" type=\"checkbox\" value=\"" + apoios[i].ApoioID + "\"/></td>";
                    break;

                case Apoios.enumEstado.Aceite:
                    OutUsers.InnerHtml += "<td><input name=\"chk_aprovAp\" type=\"checkbox\" value=\"" + apoios[i].ApoioID + "\" checked /></td>";
                    break;

                //Nao e necessario estar aqui mas facilita se algum dia for preciso incluir
                case Apoios.enumEstado.Concluido:
                    OutUsers.InnerHtml += "<td>Concluido</td>";
                    break;
            }
            OutUsers.InnerHtml += "</tr>";
        }
    }
}
