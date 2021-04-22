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
    public partial class Form_Edit_Al : Form
    {
        public Form_Edit_Al()
        {
            InitializeComponent();
        }
        List<Alunos> alunos = new List<Alunos>();
        List<Apoios> apoios = new List<Apoios>();
        List<Disciplinas> disciplinas = new List<Disciplinas>();

        DAL dal;

        bool buscado = false;
        int alunoID = -1;
        private void Form_Edit_Al_Load(object sender, EventArgs e)
        {
            try
            {
                dal = new DAL(disciplinas, alunos, apoios);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao carregar a informação dos alunos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            if (buscado == true)
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

                                        Regex regPhone = new Regex(@"^\+[1-9]{1}[0-9]{3,14}$");
                                        Alunos aluno = new Alunos();
                                        aluno.AlunoID = txt_user.Text;
                                        aluno.Aprovado = true;
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

                                        if (txt_passNova.Text != "")
                                        {
                                            aluno.Password = CreateMD5(txt_passNova.Text);
                                        }
                                        else
                                        {
                                            aluno.Password = alunos[alunoID].Password;
                                        }


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

                                            case "Admin":
                                                aluno.Tipo = Alunos.enumTipo.Admin;
                                                break;
                                        }

                                        aluno.Turma = txt_turma.Text;

                                        dal.EditAl(alunos, aluno);

                                        this.Close();

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
                catch (Exception ee)
                {
                    MessageBox.Show("Ocorreu um erro na edição do utilizador. " + ee, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Deve primeiro buscar os dados do utilizador!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btn_fetch_Click(object sender, EventArgs e)
        {
            bool existe = false;
            int i;
            if (txt_user.Text != "")
            {
                for (i = 0; i < alunos.Count(); i++)
                {
                    if (alunos[i].AlunoID == txt_user.Text)
                    {
                        existe = true;
                        alunoID = i;
                        break;
                    }
                }

                if (existe == true)
                {
                    if (alunos[i].Telefone == "" || alunos[i].Telefone == null)
                    {
                        txt_cont.Text = "";
                    }
                    else
                    {
                        txt_cont.Text = alunos[i].Telefone;
                    }

                    if (alunos[i].Morada == "" || alunos[i].Morada == null)
                    {
                        txt_morada.Text = "";
                    }
                    else
                    {
                        txt_morada.Text = alunos[i].Morada;
                    }

                    txt_nome.Text = alunos[i].Nome;
                    txt_turma.Text = alunos[i].Turma;
                    dtp_.Value = alunos[i].DataNasc;
                    switch (alunos[i].Tipo)
                    {
                        case Alunos.enumTipo.Admin:
                            cbb_tipo.SelectedItem = "Admin";
                            break;

                        case Alunos.enumTipo.Aluno:
                            cbb_tipo.SelectedItem = "Aluno";
                            break;

                        case Alunos.enumTipo.Tutor:
                            cbb_tipo.SelectedItem = "Tutor";
                            break;
                    }

                    buscado = true;
                }
                else
                {
                    MessageBox.Show("Esse utilizador não existe!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                ep_.SetError(txt_user, "Deve preencher esta caixa de texto!");
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if (txt_cont.Text == "+351" && txt_morada.Text == "" && txt_nome.Text == "" && txt_passNova.Text == "" && txt_turma.Text == "" && txt_user.Text == "" && dtp_.Value == System.DateTime.Now && cbb_tipo.Text == "" && buscado == false)
            {
                this.Close();
            }
            else
            {
                DialogResult result = MessageBox.Show("Tem a certeza que pretende cancelar a operação?\nTodas as alterações serão perdidas!", "Cancelar?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }
    }
}
