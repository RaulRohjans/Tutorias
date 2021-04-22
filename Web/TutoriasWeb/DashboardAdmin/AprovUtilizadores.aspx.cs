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

        int rowCnt = 0;
        //Inserir itens na tabela
        for(int i = 0; i < alunos.Count(); i++)
        {
            if (alunos[i].Tipo != Alunos.enumTipo.Admin)
            {
                OutUsers.InnerHtml += "<tr>";
                OutUsers.InnerHtml += "<th scope=\"row\">" + (rowCnt+1) + "</th>";
                OutUsers.InnerHtml += "<td>" + alunos[i].AlunoID + "</td>";
                OutUsers.InnerHtml += "<td>" + alunos[i].Nome + "</td>";
                OutUsers.InnerHtml += "<td>" + alunos[i].Turma + "</td>";
                OutUsers.InnerHtml += "<td>" + alunos[i].DataNasc.ToShortDateString() + "</td>";

                if(alunos[i].Telefone == null || alunos[i].Telefone == "")
                    OutUsers.InnerHtml += "<td> - </td>";
                else
                    OutUsers.InnerHtml += "<td>" + alunos[i].Telefone + "</td>";

                if(alunos[i].Morada == null || alunos[i].Morada == "")
                    OutUsers.InnerHtml += "<td> - </td>";
                else
                    OutUsers.InnerHtml += "<td>" + alunos[i].Morada + "</td>";

                switch (alunos[i].Tipo)
                {
                    case Alunos.enumTipo.Aluno:
                        OutUsers.InnerHtml += "<td>Aluno</td>";
                        break;

                    case Alunos.enumTipo.Tutor:
                        OutUsers.InnerHtml += "<td>Tutor</td>";
                        break;

                        //Nao e necessario estar aqui mas facilita se algum dia for preciso incluir
                    case Alunos.enumTipo.Admin:
                        OutUsers.InnerHtml += "<td>Admin</td>";
                        break;
                }

                if(alunos[i].Aprovado == true)
                    OutUsers.InnerHtml += "<td><input name=\"chk_aprovado\" type=\"checkbox\" value=\"" + alunos[i].AlunoID + "\" checked /></td>";
                else
                    OutUsers.InnerHtml += "<td><input name=\"chk_aprovado\" type=\"checkbox\" value=\"" + alunos[i].AlunoID + "\" /></td>";

                OutUsers.InnerHtml += "</tr>";

                rowCnt++;
            }
        }
    }

    protected void btn_atualizar_Click(object sender, EventArgs e)
    {
        //Inserir itens na tabela
        for (int i = 0; i < alunos.Count(); i++)
        {
            if (alunos[i].Tipo != Alunos.enumTipo.Admin)
            {
                OutUsers.InnerHtml += "<tr>";
                OutUsers.InnerHtml += "<th scope=\"row\">" + (i + 1) + "</th>";
                OutUsers.InnerHtml += "<td>" + alunos[i].AlunoID + "</td>";
                OutUsers.InnerHtml += "<td>" + alunos[i].Nome + "</td>";
                OutUsers.InnerHtml += "<td>" + alunos[i].Turma + "</td>";
                OutUsers.InnerHtml += "<td>" + alunos[i].DataNasc.ToShortDateString() + "</td>";

                if (alunos[i].Telefone == null || alunos[i].Morada == "")
                    OutUsers.InnerHtml += "<td> - </td>";
                else
                    OutUsers.InnerHtml += "<td>" + alunos[i].Telefone + "</td>";

                if (alunos[i].Morada == null || alunos[i].Morada == "")
                    OutUsers.InnerHtml += "<td> - </td>";
                else
                    OutUsers.InnerHtml += "<td>" + alunos[i].Morada + "</td>";

                switch (alunos[i].Tipo)
                {
                    case Alunos.enumTipo.Aluno:
                        OutUsers.InnerHtml += "<td>Aluno</td>";
                        break;

                    case Alunos.enumTipo.Tutor:
                        OutUsers.InnerHtml += "<td>Tutor</td>";
                        break;

                    //Nao e necessario estar aqui mas facilita se algum dia for preciso incluir
                    case Alunos.enumTipo.Admin:
                        OutUsers.InnerHtml += "<td>Admin</td>";
                        break;
                }

                if (alunos[i].Aprovado == true)
                    OutUsers.InnerHtml += "<td><input name=\"chk_aprovado\" type=\"checkbox\" value=\"" + alunos[i].AlunoID + "\" checked /></td>";
                else
                    OutUsers.InnerHtml += "<td><input name=\"chk_aprovado\" type=\"checkbox\" value=\"" + alunos[i].AlunoID + "\" /></td>";

                OutUsers.InnerHtml += "</tr>";

            }
        }
    }
}
