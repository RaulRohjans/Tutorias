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
            //Inserir itens na cbb
            ddl_sigla.Items.Clear();
            for (int i = 0; i < disciplinas.Count(); i++)
            {
                ddl_sigla.Items.Add(disciplinas[i].Sigla);
            }
        }
    }

    protected void btn_submit_Click(object sender, EventArgs e)
    {
        Regex dateRegex = new Regex(@"^(0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])[- /.](19|20)\d\d$");

        if (txt_apoioID.Text != "")
        {
            if (ddl_sigla.Text != "" && txt_reqDate.Text != "dd/mm/yyyy" && txt_reqDate.Text != "" && dateRegex.IsMatch(txt_reqDate.Text) && Convert.ToDateTime(txt_reqDate.Text) > System.DateTime.Now && txt_tutorID.Text != "" && txt_local.Text != "" && txt_alunoID.Text != "")
            {
                if (txt_alunoID.Text != txt_tutorID.Text)
                {
                    try
                    {
                        bool alunoExiste = false;
                        bool tutorExiste = false;
                        for (int i = 0; i < alunos.Count(); i++)
                        {
                            if (alunos[i].AlunoID == txt_alunoID.Text && alunos[i].Tipo == Alunos.enumTipo.Aluno)
                            {
                                alunoExiste = true;
                                break;
                            }
                        }

                        for (int i = 0; i < alunos.Count; i++)
                        {
                            if (alunos[i].AlunoID == txt_tutorID.Text && alunos[i].Tipo == Alunos.enumTipo.Tutor)
                            {
                                tutorExiste = true;
                                break;
                            }
                        }

                        if (alunoExiste == false)
                        {
                            ErrorOut.InnerHtml = "<br/>";
                            ErrorOut.InnerHtml += "<p style=\"color: red; \">Nome de utilizador do aluno n&#237o encontrado.</p>";
                        }
                        else
                        {
                            if (tutorExiste == false)
                            {
                                ErrorOut.InnerHtml = "<br/>";
                                ErrorOut.InnerHtml += "<p style=\"color: red; \">Nome de utilizador do tutor n&#237o encontrado.</p>";
                            }
                            else
                            {
                                Apoios apoio = new Apoios();

                                apoio.ApoioID = Convert.ToInt32(txt_apoioID.Text);

                                apoio.AlunoID = txt_alunoID.Text;
                                if (txt_desc.Text != "")
                                    apoio.Descricao = txt_desc.Text;
                                else
                                    apoio.Descricao = null;

                                apoio.Estado = Apoios.enumEstado.Aceite;
                                apoio.Local = txt_local.Text;
                                apoio.ReqDate = Convert.ToDateTime(txt_reqDate.Text);
                                apoio.Sigla = ddl_sigla.Text;
                                apoio.TutorID = txt_tutorID.Text;

                                if (txt_aval.Text != "")
                                    apoio.Avaliacao = txt_aval.Text;
                                else
                                    apoio.Avaliacao = txt_aval.Text;
                                apoio.Criado = null;

                                ws.EditAp(apoios, apoio);

                                ErrorOut.InnerHtml = "<br/>";
                                ErrorOut.InnerHtml += "<p style=\"color: green; \">Apoio editado com sucesso!</p>";
                                txt_alunoID.Text = "";
                                txt_desc.Text = "";
                                txt_local.Text = "";
                                txt_reqDate.Text = "";
                                txt_tutorID.Text = "";
                                txt_apoioID.Text = "";
                                txt_aval.Text = "";
                                ddl_sigla.SelectedIndex = 0;
                            }
                        }
                    }
                    catch (Exception)
                    {
                        ErrorOut.InnerHtml = "<br/>";
                        ErrorOut.InnerHtml += "<p style=\"color: red; \">Ocorreu um erro ao criar o apoio.</p>";
                    }
                }
                else
                {
                    ErrorOut.InnerHtml = "<br/>";
                    ErrorOut.InnerHtml += "<p style=\"color: red; \">Um aluno n&#227o pode dar apoios a s&#237 mesmo!</p>";
                }
            }
            else
            {
                ErrorOut.InnerHtml = "<br/>";
                ErrorOut.InnerHtml += "<p style=\"color: red; \">Por favor preencha todos os campos!</p>";
            }
        }
        else
        {
            ErrorOut.InnerHtml = "<br/>";
            ErrorOut.InnerHtml += "<p style=\"color: red; \">Por favor fa&#231a uma busca pelos dados antes de editar!</p>";
        }
    }

    protected void btn_buscar_Click(object sender, EventArgs e)
    {
        if (txt_apoioID.Text != "")
        {
            bool existe = false;
            for (int i = 0; i < apoios.Count(); i++)
            {
                if(apoios[i].ApoioID == Convert.ToInt32(txt_apoioID.Text))
                {
                    txt_alunoID.Text = apoios[i].AlunoID;
                    txt_tutorID.Text = apoios[i].TutorID;
                    txt_reqDate.Text = apoios[i].ReqDate.ToShortDateString();
                    txt_local.Text = apoios[i].Local;

                    if(apoios[i].Descricao == null || apoios[i].Descricao == "")
                    {
                        txt_desc.Text = "";
                    }
                    else
                    {
                        txt_desc.Text = apoios[i].Descricao;
                    }

                    if(apoios[i].Avaliacao == null || apoios[i].Avaliacao == "")
                    {
                        txt_aval.Text = "";
                    }
                    else
                    {
                        txt_aval.Text = apoios[i].Avaliacao;
                    }

                    switch(apoios[i].Sigla)
                    {
                        case "AC":
                            ddl_sigla.SelectedIndex = 0;
                            break;

                        case "AI":
                            ddl_sigla.SelectedIndex = 1;
                            break;

                        case "EF":
                            ddl_sigla.SelectedIndex = 2;
                            break;

                        case "FQ":
                            ddl_sigla.SelectedIndex = 3;
                            break;

                        case "ING":
                            ddl_sigla.SelectedIndex = 4;
                            break;

                        case "MAT":
                            ddl_sigla.SelectedIndex = 5;
                            break;

                        case "PSI":
                            ddl_sigla.SelectedIndex = 6;
                            break;

                        case "PT":
                            ddl_sigla.SelectedIndex = 7;
                            break;

                        case "RC":
                            ddl_sigla.SelectedIndex = 8;
                            break;

                        case "SO":
                            ddl_sigla.SelectedIndex = 9;
                            break;

                        case "TIC":
                            ddl_sigla.SelectedIndex = 10;
                            break;
                    }

                    errorBuscar.InnerHtml = "<br/>";
                    errorBuscar.InnerHtml += "<p style=\"color: green; \">Dados buscados com sucesso!</p>";

                    existe = true;
                    break;
                }

                if(existe == false)
                {
                    errorBuscar.InnerHtml = "<br/>";
                    errorBuscar.InnerHtml += "<p style=\"color: red; \">Esse ID de apoio n&#227o existe.</p>";
                }
            }

            if(existe == false)
            {
                errorBuscar.InnerHtml = "<br/>";
                errorBuscar.InnerHtml += "<p style=\"color: red; \">Por favor insira um ID!</p>";
            }
        }
        else
        {
            errorBuscar.InnerHtml = "<br/>";
            errorBuscar.InnerHtml += "<p style=\"color: red; \">Por favor preencha todos os campos!</p>";
        }
    }
}
