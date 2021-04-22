using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DashboardAdmin_CriarUtilizador : System.Web.UI.Page
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

        if (!IsPostBack)
        {
            //Inserir itens nas cbb
            ddl_disc.Items.Clear();
            for (int i = 0; i < disciplinas.Count(); i++)
            {
                ddl_disc.Items.Add(disciplinas[i].Sigla);
            }

            if (Session["LoginTipo"].ToString() == "Aluno")
            {
                OutNomeDDL.InnerHtml = "<label class=\" form - control - label\">Tutor<a style=\"color: red\">*</a></label>";
                ddl_user.Items.Clear();
                for (int i = 0; i < alunos.Count(); i++)
                {
                    if (alunos[i].Tipo == Alunos.enumTipo.Tutor && alunos[i].Aprovado == true)
                        ddl_user.Items.Add(alunos[i].AlunoID);
                }

            }
            else
            {
                OutNomeDDL.InnerHtml = "<label class=\" form - control - label\">Aluno<a style=\"color: red\">*</a></label>";
                ddl_user.Items.Clear();
                for (int i = 0; i < alunos.Count(); i++)
                {
                    if (alunos[i].Tipo == Alunos.enumTipo.Aluno && alunos[i].Aprovado == true)
                        ddl_user.Items.Add(alunos[i].AlunoID);
                }
            }

        }
    }

    protected void btn_submit_Click(object sender, EventArgs e)
    {
        Regex dateRegex = new Regex(@"^(0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])[- /.](19|20)\d\d$");

        try
        {
            if (txt_local.Text != "")
            {
                if (ddl_disc.Text != "")
                {
                    if (ddl_user.Text != "")
                    {
                        if (dateRegex.IsMatch(txt_reqDate.Text))
                        {
                            if (Convert.ToDateTime(txt_reqDate.Text) > System.DateTime.Now)
                            {
                                if (Session["LoginTipo"].ToString() == "Aluno")
                                {
                                    //ver se o tutor esta disponivel
                                    bool disponivel = true;
                                    for (int i = 0; i < apoios.Count(); i++)
                                    {
                                        if (apoios[i].TutorID == ddl_user.Text)
                                        {
                                            if (Convert.ToDateTime(txt_reqDate.Text) == apoios[i].ReqDate)
                                                disponivel = false;
                                        }
                                    }

                                    if (disponivel == true)
                                    {
                                        Apoios ap = new Apoios();
                                        if (apoios.Count() > 0)
                                            ap.ApoioID = apoios[apoios.Count() - 1].ApoioID + 1;
                                        else
                                            ap.ApoioID = 1;

                                        ap.AlunoID = Session["LoginUser"].ToString();
                                        ap.Avaliacao = null;

                                        if (txt_desc.Text != "")
                                            ap.Descricao = txt_desc.Text;
                                        else
                                            ap.Descricao = null;

                                        ap.Estado = Apoios.enumEstado.Pendente;
                                        ap.Local = txt_local.Text;
                                        ap.ReqDate = Convert.ToDateTime(txt_reqDate.Text);
                                        ap.Sigla = ddl_disc.Text;
                                        ap.TutorID = ddl_user.Text;
                                        ap.Criado = Session["LoginUser"].ToString();

                                        ws.AddAp(apoios, ap);
                                        ErrorOut.InnerHtml = "<br/>";
                                        ErrorOut.InnerHtml += "<p style=\"color: green; \">Apoio criado com sucesso!</p>";

                                    }
                                }
                                else
                                {
                                    //ver se o aluno esta disponivel
                                    bool disponivel = true;
                                    for (int i = 0; i < apoios.Count(); i++)
                                    {
                                        if (apoios[i].AlunoID == ddl_user.Text)
                                        {
                                            if (Convert.ToDateTime(txt_reqDate.Text) == apoios[i].ReqDate)
                                                disponivel = false;
                                        }
                                    }

                                    if (disponivel == true)
                                    {

                                        Apoios ap = new Apoios();
                                        if (apoios.Count() > 0)
                                            ap.ApoioID = apoios[apoios.Count() - 1].ApoioID + 1;
                                        else
                                            ap.ApoioID = 1;

                                        ap.AlunoID = ddl_user.Text;
                                        ap.Avaliacao = null;

                                        if (txt_desc.Text != "")
                                            ap.Descricao = txt_desc.Text;
                                        else
                                            ap.Descricao = null;

                                        ap.Estado = Apoios.enumEstado.Pendente;
                                        ap.Local = txt_local.Text;
                                        ap.ReqDate = Convert.ToDateTime(txt_reqDate.Text);
                                        ap.Sigla = ddl_disc.Text;
                                        ap.TutorID = Session["LoginUser"].ToString();
                                        ap.Criado = Session["LoginUser"].ToString();

                                        ws.AddAp(apoios, ap);
                                        ErrorOut.InnerHtml = "<br/>";
                                        ErrorOut.InnerHtml += "<p style=\"color: green; \">Apoio criado com sucesso!</p>";

                                    }
                                }
                            }
                            else
                            {
                                ErrorOut.InnerHtml = "<br/>";
                                ErrorOut.InnerHtml += "<p style=\"color: red; \">Data deve ser maior que a data atual!</p>";
                            }
                        }
                        else
                        {
                            ErrorOut.InnerHtml = "<br/>";
                            ErrorOut.InnerHtml += "<p style=\"color: red; \">Formato de data invalida!</p>";
                        }
                    }
                    else
                    {
                        ErrorOut.InnerHtml = "<br/>";
                        ErrorOut.InnerHtml += "<p style=\"color: red; \">Por favor selecione um registo!</p>";
                    }
                }
                else
                {
                    ErrorOut.InnerHtml = "<br/>";
                    ErrorOut.InnerHtml += "<p style=\"color: red; \">Por favor selecione um registo!</p>";
                }
            }
            else
            {
                ErrorOut.InnerHtml = "<br/>";
                ErrorOut.InnerHtml += "<p style=\"color: red; \">Por favor preencha este campo!</p>";
            }
        }
        catch (Exception)
        {
            ErrorOut.InnerHtml = "<br/>";
            ErrorOut.InnerHtml += "<p style=\"color: red; \">Ocorreu um erro ao efetuar o pedido.</p>";
        }

    }
    }

