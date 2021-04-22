using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TutoriasV2
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }
        List<Alunos> alunos = new List<Alunos>();
        List<Apoios> apoios = new List<Apoios>();
        List<Disciplinas> disciplinas = new List<Disciplinas>();

        DAL dal;

        private void Form_Login_Load(object sender, EventArgs e)
        {
            try
            {
                dal = new DAL(disciplinas, alunos, apoios);
            }
            catch(Exception)
            {
                MessageBox.Show("Ocorreu um erro ao aceder à BD.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btn_pass_Click(object sender, EventArgs e)
        {
            if (txt_pass.PasswordChar != '\0')
                txt_pass.PasswordChar = '\0';
            else
                txt_pass.PasswordChar = '•';
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Startup Startup = new Form_Startup();
            Startup.FormClosed += (s, args) => this.Close();
            Startup.Show();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            bool existe = false;
            //Verificar se o user existe
            int i;
            for (i = 0; i < alunos.Count(); i++)
            {
                if(alunos[i].AlunoID == txt_user.Text)
                {
                    existe = true;
                    break;
                }
            }

            if(existe == true)
            {
                if(alunos[i].Password == CreateMD5(txt_pass.Text))
                {
                    if (alunos[i].Aprovado == true)
                    {
                        switch (alunos[i].Tipo)
                        {
                            case Alunos.enumTipo.Admin:
                                MessageBox.Show("Bem-vindo de volta " + txt_user.Text + " !", "Login Efetuado com Sucesso");
                                this.Hide();
                                Dashboard_Admin admin = new Dashboard_Admin();
                                admin.Passa(txt_pass.Text);
                                admin.FormClosed += (s, args) => this.Close();
                                admin.Show();
                                break;

                            case Alunos.enumTipo.Aluno:
                                MessageBox.Show("Bem-vindo de volta " + txt_user.Text + " !", "Login Efetuado com Sucesso");
                                this.Hide();
                                Dashboard_Al al = new Dashboard_Al();
                                al.Passa(txt_user.Text);
                                al.FormClosed += (s, args) => this.Close();
                                al.Show();
                                break;

                            case Alunos.enumTipo.Tutor:
                                MessageBox.Show("Bem-vindo de volta " + txt_user.Text + " !", "Login Efetuado com Sucesso");
                                this.Hide();
                                Dashboard_Tut tut = new Dashboard_Tut();
                                tut.Passa(txt_user.Text);
                                tut.FormClosed += (s, args) => this.Close();
                                tut.Show();
                                break;

                            case Alunos.enumTipo.NULL:
                                MessageBox.Show("Erro de conta de utilizador. Por favor peça a um administrador para verificar os seus dados!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por favor aguarde que a sua conta seja aprovada por um administrador!", "Erro Conta não Aprovada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Palavra-Passe inválida", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Esse aluno não existe!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
