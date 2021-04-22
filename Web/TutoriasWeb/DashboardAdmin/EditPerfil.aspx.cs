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

    string alunoID;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["LoginUser"] == null || Session["LoginTipo"] == null)
        {
            Response.Redirect("~/StartPage/Login.aspx");
        }
        alunoID = Session["LoginUser"].ToString();
        LoginTextOut.InnerHtml = "<p>" + alunoID + "</p>";
        ws = new TutoriasService(disciplinas, alunos, apoios);
               

        if (!IsPostBack)
        {
            //Inserir itens na cbb
            ddl_tipo.Items.Clear();
            ddl_tipo.Items.Add("Aluno");
            ddl_tipo.Items.Add("Tutor");
            ddl_tipo.Items.Add("Admin");

            //Meter o nome da pessoa no Titulo e atualizar txt
            for (int i = 0; i < alunos.Count(); i++)
            {
                if (alunos[i].AlunoID == alunoID)
                {
                    outTitulo.InnerHtml = alunos[i].Nome;
                    txt_DataNasc.Text = alunos[i].DataNasc.ToShortDateString();
                    txt_morada.Text = alunos[i].Morada;
                    txt_nome.Text = alunos[i].Nome;
                    txt_telefone.Text = alunos[i].Telefone;
                    txt_turma.Text = alunos[i].Turma;
                    ddl_tipo.SelectedIndex = 2;
                }
            }            
        }
    }

    protected void btn_submit_Click(object sender, EventArgs e)
    {
        Regex dateRegex = new Regex(@"^(0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])[- /.](19|20)\d\d$");
        Regex phoneRegex = new Regex(@"^\+[1-9]{1}[0-9]{3,14}$");


        if (ddl_tipo.Text != "" && txt_DataNasc.Text != "dd/mm/yyyy" && txt_DataNasc.Text != "" && dateRegex.IsMatch(txt_DataNasc.Text) && Convert.ToDateTime(txt_DataNasc.Text) < System.DateTime.Now && txt_nome.Text != "" && txt_pass.Text != "" && txt_turma.Text != "")
        {
            if (txt_newPass.Text == txt_newPass2.Text)
            {
                int i3;
                for (i3 = 0; i3 < alunos.Count(); i3++)
                    if (alunos[i3].AlunoID == alunoID)
                        break;

                if (CreateMD5(txt_pass.Text) == alunos[i3].Password)
                {
                    try
                    {
                        bool badInput = false;
                        Alunos aluno = new Alunos();

                        aluno.AlunoID = alunoID;
                        aluno.Aprovado = true;
                        aluno.DataNasc = Convert.ToDateTime(txt_DataNasc.Text);
                        aluno.Nome = txt_nome.Text;
                        aluno.Turma = txt_turma.Text;


                        if (txt_newPass.Text != "" && txt_newPass2.Text != "")
                            aluno.Password = CreateMD5(txt_newPass.Text);
                        else
                            aluno.Password = null;

                        if (txt_morada.Text == "")
                        {
                            aluno.Morada = null;
                        }
                        else
                        {
                            aluno.Morada = txt_morada.Text;
                        }

                        if (txt_telefone.Text == "")
                        {
                            aluno.Telefone = null;
                        }
                        else
                        {
                            if (phoneRegex.IsMatch(txt_telefone.Text))
                                aluno.Telefone = txt_telefone.Text;
                            else
                                badInput = true;
                        }

                        switch (ddl_tipo.Text)
                        {
                            case "Aluno":
                                aluno.Tipo = Alunos.enumTipo.Aluno;
                                break;

                            case "Tutor":
                                aluno.Tipo = Alunos.enumTipo.Tutor;
                                break;

                            case "Admin":
                                aluno.Tipo = Alunos.enumTipo.Admin;
                                break;
                        }

                        if (badInput == false)
                        {
                            ws.EditAl(alunos, aluno);
                            ErrorOut.InnerHtml = "<br/>";
                            ErrorOut.InnerHtml += "<p style=\"color: green; \">Perfil editado com sucesso!</p>";
                        }
                        else
                        {
                            ErrorOut.InnerHtml = "<br/>";
                            ErrorOut.InnerHtml += "<p style=\"color: red; \">Erro, por favor verifique os seus dados.</p>";
                        }


                    }
                    catch (Exception)
                    {
                        ErrorOut.InnerHtml = "<br/>";
                        ErrorOut.InnerHtml += "<p style=\"color: red; \">Ocorreu um erro ao editar o perfil.</p>";
                    }
                }
                else
                {
                    ErrorOut.InnerHtml = "<br/>";
                    ErrorOut.InnerHtml += "<p style=\"color: red; \">Palavra-Passe incorreta!</p>";
                }
            }
            else
            {
                ErrorOut.InnerHtml = "<br/>";
                ErrorOut.InnerHtml += "<p style=\"color: red; \">As palavras-passe novas devem ser iguais!</p>";
            }
        }
        else
        {
            ErrorOut.InnerHtml = "<br/>";
            ErrorOut.InnerHtml += "<p style=\"color: red; \">Por favor preencha todos os campos obrigat&#243rios!</p>";
        }

    }

    public static string CreateMD5(string input)
    {
        // Use input string to calculate MD5 hash
        using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
        {
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hashBytes = md5.ComputeHash(inputBytes);

            // Convert the byte array to hexadecimal string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("X2"));
            }
            return sb.ToString();
        }
    }


}
