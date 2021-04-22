using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Index : System.Web.UI.Page
{
    List<Apoios> apoios = new List<Apoios>();
    List<Alunos> alunos = new List<Alunos>();
    List<Disciplinas> disciplinas = new List<Disciplinas>();

    TutoriasService ws;
    protected void Page_Load(object sender, EventArgs e)
    {
        Session["LoginUser"] = null;
        Session["LoginTipo"] = null;       
        ws = new TutoriasService(disciplinas, alunos, apoios);

        if (!IsPostBack)
        {
            ddl_tipo.Items.Clear();
            ddl_tipo.Items.Add("Aluno");
            ddl_tipo.Items.Add("Tutor");
        }
    }

    protected void btn_register_Click(object sender, EventArgs e)
    {
        Regex dateRegex = new Regex(@"^(0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])[- /.](19|20)\d\d$");
        Regex phoneRegex = new Regex(@"^\+[1-9]{1}[0-9]{3,14}$");
        if(ddl_tipo.Text != "" && txt_dataNasc.Text != "yyyy-mm-dd" && txt_dataNasc.Text != "" && dateRegex.IsMatch(txt_dataNasc.Text) && txt_nome.Text != "" && txt_pass.Text != "" && txt_turma.Text != "" && txt_username.Text != "")
        {
            try
            {
                bool userRepete = false;
                for (int i = 0; i < alunos.Count(); i++)
                {
                    if (alunos[i].AlunoID == txt_username.Text)
                    {
                        userRepete = true;
                        break;
                    }
                }

                if (userRepete == true)
                    errorOut.InnerHtml = "<p style=\"color: red; \">Esse utilizador já existe!</p>";
                else
                {
                    Alunos aluno = new Alunos();
                    aluno.AlunoID = txt_username.Text;
                    aluno.DataNasc = Convert.ToDateTime(txt_dataNasc.Text);

                    if (txt_morada.Text == "")
                        aluno.Morada = null;
                    else
                        aluno.Morada = txt_morada.Text;

                    aluno.Nome = txt_nome.Text;
                    aluno.Password = CreateMD5(txt_pass.Text);

                    bool badInput = false;
                    if (txt_movel.Text == "" || txt_movel.Text == "+351")
                    {
                        aluno.Telefone = null;
                    }
                    else
                    {
                        if (phoneRegex.IsMatch(txt_movel.Text))
                        {
                            aluno.Telefone = txt_movel.Text;
                        }
                        else
                        {
                            badInput = true;
                        }
                    }

                    if (ddl_tipo.SelectedIndex == 0)
                        aluno.Tipo = Alunos.enumTipo.Aluno;
                    else
                        aluno.Tipo = Alunos.enumTipo.Tutor;
                    aluno.Turma = txt_turma.Text;

                    if(badInput == false)
                    {                     
                        ws.AddAl(alunos, aluno);
                        Response.Redirect("Login.aspx");
                    }
                    else
                    {
                        errorOut.InnerHtml = "<p style=\"color: red; \">Por favor verifique os seus dados.</p>";
                    }
                }
            }
            catch(Exception)
            {
                errorOut.InnerHtml = "<p style=\"color: red; \">Ocorreu um erro ao registrar o utilizador.</p>";
            }
        }
        else
            errorOut.InnerHtml = "<p style=\"color: red; \">Por favor preencha todos os campos!</p>";

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