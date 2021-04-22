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
        for (int i = 0; i < apoios.Count(); i++)
        {

            OutUsers.InnerHtml += "<tr>";
            OutUsers.InnerHtml += "<td>" + apoios[i].ApoioID.ToString() + "</td>";
            OutUsers.InnerHtml += "<td>" + apoios[i].Sigla + "</td>";
            OutUsers.InnerHtml += "<td>" + apoios[i].AlunoID + "</td>";
            OutUsers.InnerHtml += "<td>" + apoios[i].TutorID + "</td>";
            OutUsers.InnerHtml += "<td>" + apoios[i].ReqDate.ToShortDateString() + "</td>";
            OutUsers.InnerHtml += "<td>" + apoios[i].Local + "</td>";

            if(apoios[i].Avaliacao == null || apoios[i].Avaliacao == "")
                OutUsers.InnerHtml += "<td> - </td>";
            else
                OutUsers.InnerHtml += "<td>" + apoios[i].Avaliacao + "</td>";

            if(apoios[i].Descricao == null || apoios[i].Descricao == "")
                OutUsers.InnerHtml += "<td> - </td>";
            else
                OutUsers.InnerHtml += "<td>" + apoios[i].Descricao + "</td>";

            switch (apoios[i].Estado)
            {
                case Apoios.enumEstado.Aceite:
                    OutUsers.InnerHtml += "<td>Aceite</td>";
                    break;

                case Apoios.enumEstado.Concluido:
                    OutUsers.InnerHtml += "<td>Concluido</td>";
                    break;

                case Apoios.enumEstado.Pendente:
                    OutUsers.InnerHtml += "<td>Pendente</td>";
                    break;

                case Apoios.enumEstado.NULL:
                    OutUsers.InnerHtml += "<td>ERRO</td>";
                    break;
            }
            OutUsers.InnerHtml += "</tr>";
        }
    }

    protected void btn_eliminar_Click(object sender, EventArgs e)
    {
        try
        {
            if (txt_apoioID.Text != "")
            {
                bool existe = false;
                int i2;
                //Verificar se existe
                for (i2 = 0; i2 < alunos.Count(); i2++)
                {
                    if (alunos[i2].AlunoID == txt_apoioID.Text)
                    {
                        existe = true;
                        break;
                    }
                }                

                if (existe == true)
                {
                    //Eliminar utilizador
                    ws.DelAp(apoios, apoios[i2]);

                    //Inserir itens na tabela
                    OutUsers.InnerHtml = "";
                    for (int i = 0; i < apoios.Count(); i++)
                    {

                        OutUsers.InnerHtml += "<tr>";
                        OutUsers.InnerHtml += "<td>" + apoios[i].ApoioID.ToString() + "</td>";
                        OutUsers.InnerHtml += "<td>" + apoios[i].Sigla + "</td>";
                        OutUsers.InnerHtml += "<td>" + apoios[i].AlunoID + "</td>";
                        OutUsers.InnerHtml += "<td>" + apoios[i].TutorID + "</td>";
                        OutUsers.InnerHtml += "<td>" + apoios[i].ReqDate.ToShortDateString() + "</td>";
                        OutUsers.InnerHtml += "<td>" + apoios[i].Local + "</td>";

                        if (apoios[i].Avaliacao == null || apoios[i].Avaliacao == "")
                            OutUsers.InnerHtml += "<td> - </td>";
                        else
                            OutUsers.InnerHtml += "<td>" + apoios[i].Avaliacao + "</td>";

                        if (apoios[i].Descricao == null || apoios[i].Descricao == "")
                            OutUsers.InnerHtml += "<td> - </td>";
                        else
                            OutUsers.InnerHtml += "<td>" + apoios[i].Descricao + "</td>";

                        switch (apoios[i].Estado)
                        {
                            case Apoios.enumEstado.Aceite:
                                OutUsers.InnerHtml += "<td>Aceite</td>";
                                break;

                            case Apoios.enumEstado.Concluido:
                                OutUsers.InnerHtml += "<td>Concluido</td>";
                                break;

                            case Apoios.enumEstado.Pendente:
                                OutUsers.InnerHtml += "<td>Pendente</td>";
                                break;

                            case Apoios.enumEstado.NULL:
                                OutUsers.InnerHtml += "<td>ERRO</td>";
                                break;
                        }
                        OutUsers.InnerHtml += "</tr>";
                    }

                    errorOut.InnerHtml = "<br/>";
                    errorOut.InnerHtml += "<p style=\"color: green; \">Apoio removido com sucesso!</p>";
                }
                else
                {
                    errorOut.InnerHtml = "<br/>";
                    errorOut.InnerHtml += "<p style=\"color: red; \">Apoio inexistente.</p>";
                }
            }
            else
            {
                errorOut.InnerHtml = "<br/>";
                errorOut.InnerHtml += "<p style=\"color: red; \">Por favor preencha o campo do ID do apoio!</p>";
            }
        }
        catch (Exception)
        {
            errorOut.InnerHtml = "<br/>";
            errorOut.InnerHtml += "<p style=\"color: red; \">Ocurreu um erro ao eliminar o apoio.</p>";
        }
    }
}
