using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TutoriasV2
{
    public partial class Form_Register_Al : Form
    {
        public Form_Register_Al()
        {
            InitializeComponent();
        }
        List<Alunos> alunos = new List<Alunos>();
        List<Apoios> apoios = new List<Apoios>();
        List<Disciplinas> disciplinas = new List<Disciplinas>();

        DAL dal;

        private void Form_Register_Al_Load(object sender, EventArgs e)
        {
            try
            {
                dal = new DAL(disciplinas, alunos, apoios);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao carregar a informação dos Utilizadores.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if(txt_cont.Text == "" && txt_morada.Text == "" && txt_nome.Text == "" && txt_pass1.Text == "" && txt_pass2.Text == "" && txt_turma.Text == "" && txt_user.Text == "" && dtp_.Value == System.DateTime.Now && cbb_tipo.Text == "")
            {
                this.Hide();
                Form_Startup start = new Form_Startup();
                start.FormClosed += (s, args) => this.Close();
                start.Show();
            }
            else
            {
                DialogResult result = MessageBox.Show("Tem a certeza que pretende cancelar a operação?\nTodas as alterações serão perdidas!", "Cancelar?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if(result == DialogResult.Yes)
                {
                    this.Hide();
                    Form_Startup start = new Form_Startup();
                    start.FormClosed += (s, args) => this.Close();
                    start.Show();
                }
            }

        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_user.Text != "")
                {
                    if (txt_nome.Text != "")
                    {
                        if (txt_turma.Text != "")
                        {
                            if (dtp_.Value < System.DateTime.Now)
                            {
                                if (cbb_tipo.Text != "")
                                {
                                    if (txt_pass1.Text != "" && txt_pass2.Text != "" && txt_pass1.Text == txt_pass2.Text)
                                    {
                                        Regex regPhone = new Regex(@"^\+[1-9]{1}[0-9]{3,14}$");
                                        Alunos aluno = new Alunos();
                                        aluno.AlunoID = txt_user.Text;
                                        aluno.Aprovado = false;
                                        aluno.DataNasc = dtp_.Value;

                                        if (txt_morada.Text != "")
                                        {
                                            aluno.Morada = txt_morada.Text;
                                        }
                                        else
                                        {
                                            aluno.Morada = null;
                                        }

                                        aluno.Nome = txt_nome.Text;
                                        aluno.Password = CreateMD5(txt_pass1.Text);

                                        if (txt_cont.Text != "" && txt_cont.TextLength > 12)
                                        {
                                            if (regPhone.IsMatch(txt_cont.Text))
                                            {
                                                aluno.Telefone = txt_cont.Text;
                                            }
                                            else
                                            {
                                                ep_.SetError(txt_cont, "Formato do numero invalido! Por favor inclua o codigo do país.");
                                            }
                                        }
                                        else
                                        {
                                            aluno.Telefone = null;
                                        }

                                        switch (cbb_tipo.Text)
                                        {
                                            case "Aluno":
                                                aluno.Tipo = Alunos.enumTipo.Aluno;
                                                break;

                                            case "Tutor":
                                                aluno.Tipo = Alunos.enumTipo.Tutor;
                                                break;
                                        }

                                        aluno.Turma = txt_turma.Text;

                                        dal.AddAl(alunos, aluno);

                                        this.Hide();
                                        Form_Login Login = new Form_Login();
                                        Login.FormClosed += (s, args) => this.Close();
                                        Login.Show();
                                    }
                                    else
                                    {
                                        ep_.SetError(txt_pass1, "Palavras-Passe diferentes!");
                                        ep_.SetError(txt_pass2, "Palavras-Passe diferentes!");
                                    }
                                }
                                else
                                {
                                    ep_.SetError(dtp_, "Escolha uma opção!");
                                }
                            }
                            else
                            {
                                ep_.SetError(dtp_, "Data de nascimento invalida!");
                            }
                        }
                        else
                        {
                            ep_.SetError(txt_turma, "Deve preencher esta caixa de texto!");
                        }
                    }
                    else
                    {
                        ep_.SetError(txt_nome, "Deve preencher esta caixa de texto!");
                    }
                }
                else
                {
                    ep_.SetError(txt_user, "Deve preencher esta caixa de texto!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro na adição do aluno.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
}
