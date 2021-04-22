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
        if (!IsPostBack)
        {
            if (Session["LoginTipo"].ToString() == "Aluno")
            {
                OutUsers.InnerHtml = "";
                for (int i = 0; i < apoios.Count(); i++)
                {
                    if (apoios[i].Criado == Session["LoginUser"].ToString() && apoios[i].Estado == Apoios.enumEstado.Pendente && apoios[i].AlunoID == Session["LoginUser"].ToString())
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

                        OutUsers.InnerHtml += "<td><input name=\"chk_aprovAp\" type=\"checkbox\" value=\"" + apoios[i].ApoioID + "\"/></td>";

                        OutUsers.InnerHtml += "</tr>";
                    }
                }
            }
            else
            {
                OutUsers.InnerHtml = "";
                for (int i = 0; i < apoios.Count(); i++)
                {
                    if (apoios[i].Criado == Session["LoginUser"].ToString() && apoios[i].Estado == Apoios.enumEstado.Pendente && apoios[i].TutorID == Session["LoginUser"].ToString())
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

                        OutUsers.InnerHtml += "<td><input name=\"chk_aprovAp\" type=\"checkbox\" value=\"" + apoios[i].ApoioID + "\"/></td>";

                        OutUsers.InnerHtml += "</tr>";
                    }
                }
            }
        }

    }

    protected void btn_atualizar_Click(object sender, EventArgs e)
    {

        if (Session["LoginTipo"].ToString() == "Aluno")
        {
            OutUsers.InnerHtml = "";
            for (int i = 0; i < apoios.Count(); i++)
            {
                if (apoios[i].Criado == Session["LoginUser"].ToString() && apoios[i].Estado == Apoios.enumEstado.Pendente && apoios[i].AlunoID == Session["LoginUser"].ToString())
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

                    OutUsers.InnerHtml += "<td><input name=\"chk_aprovAp\" type=\"checkbox\" value=\"" + apoios[i].ApoioID + "\"/></td>";

                    OutUsers.InnerHtml += "</tr>";
                }
            }
        }
        else
        {
            OutUsers.InnerHtml = "";
            for (int i = 0; i < apoios.Count(); i++)
            {
                if (apoios[i].Criado == Session["LoginUser"].ToString() && apoios[i].Estado == Apoios.enumEstado.Pendente && apoios[i].TutorID == Session["LoginUser"].ToString())
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

                    OutUsers.InnerHtml += "<td><input name=\"chk_aprovAp\" type=\"checkbox\" value=\"" + apoios[i].ApoioID + "\"/></td>";

                    OutUsers.InnerHtml += "</tr>";
                }
            }
        }
    }
}
