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

                    for(int i = 0; i < alunos.Count; i++)
                    {
                        if(alunos[i].AlunoID == txt_tutorID.Text && alunos[i].Tipo == Alunos.enumTipo.Tutor)
                        {
                            tutorExiste = true;
                            break;
                        }
                    }

                    if (alunoExiste == false)
                    {
                        ErrorOut.InnerHtml = "<br/>";
                        ErrorOut.InnerHtml += "<p style=\"color: red; \">Aluno n&#237o encontrado.</p>";
                    }
                    else
                    {
                        if (tutorExiste == false)
                        {
                            ErrorOut.InnerHtml = "<br/>";
                            ErrorOut.InnerHtml += "<p style=\"color: red; \">Tutor n&#227o encontrado.</p>";
                        }
                        else
                        {
                            Apoios apoio = new Apoios();

                            if (apoios.Count() > 0)
                                apoio.ApoioID = apoios[apoios.Count() - 1].ApoioID + 1;
                            else
                                apoio.ApoioID = 1;

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
                            apoio.Avaliacao = null;
                            apoio.Criado = Session["LoginUser"].ToString();

                            ws.AddAp(apoios, apoio);

                            ErrorOut.InnerHtml = "<br/>";
                            ErrorOut.InnerHtml += "<p style=\"color: green; \">Apoio criado com sucesso!</p>";
                            txt_alunoID.Text = "";
                            txt_desc.Text = "";
                            txt_local.Text = "";
                            txt_reqDate.Text = "";
                            txt_tutorID.Text = "";
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
}
