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
        OutUsers.InnerHtml = "";
        for (int i = 0; i < alunos.Count(); i++)
        {

            OutUsers.InnerHtml += "<tr>";
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

                case Alunos.enumTipo.Admin:
                    OutUsers.InnerHtml += "<td>Admin</td>";
                    break;                  

            }
            OutUsers.InnerHtml += "</tr>";
        }
    }

    protected void btn_eliminar_Click(object sender, EventArgs e)
    {
        try
        {
            if (txt_alunoID.Text != "")
            {
                bool existe = false;
                int i2;
                //Verificar se existe
                for (i2 = 0; i2 < alunos.Count(); i2++)
                {
                    if (alunos[i2].AlunoID == txt_alunoID.Text)
                    {
                        existe = true;
                        break;
                    }
                }                

                if (existe == true)
                {
                    //Eliminar utilizador
                    ws.DelAl(alunos, alunos[i2]);

                    //Inserir itens na tabela
                    OutUsers.InnerHtml = "";
                    for (int i = 0; i < alunos.Count(); i++)
                    {

                        OutUsers.InnerHtml += "<tr>";
                        OutUsers.InnerHtml += "<td>" + alunos[i].AlunoID + "</td>";
                        OutUsers.InnerHtml += "<td>" + alunos[i].Nome + "</td>";
                        OutUsers.InnerHtml += "<td>" + alunos[i].Turma + "</td>";
                        OutUsers.InnerHtml += "<td>" + alunos[i].DataNasc.ToShortDateString() + "</td>";

                        if (alunos[i].Telefone == null || alunos[i].Telefone == "")
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

                            case Alunos.enumTipo.Admin:
                                OutUsers.InnerHtml += "<td>Admin</td>";
                                break;

                        }
                        OutUsers.InnerHtml += "</tr>";
                    }

                    errorOut.InnerHtml = "<br/>";
                    errorOut.InnerHtml += "<p style=\"color: green; \">Utilizador removido com sucesso!</p>";
                }
                else
                {
                    errorOut.InnerHtml = "<br/>";
                    errorOut.InnerHtml += "<p style=\"color: red; \">Utilizador inexistente.</p>";
                }
            }
            else
            {
                errorOut.InnerHtml = "<br/>";
                errorOut.InnerHtml += "<p style=\"color: red; \">Por favor preencha o campo do utilizador!</p>";
            }
        }
        catch (Exception)
        {
            errorOut.InnerHtml = "<br/>";
            errorOut.InnerHtml += "<p style=\"color: red; \">Ocurreu um erro ao eliminar o utilizador.</p>";
        }
    }
}
