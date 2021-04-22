using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TutoriasV2
{
    public partial class Form_Edit_Ap : Form
    {
        public Form_Edit_Ap()
        {
            InitializeComponent();
        }
        List<Alunos> alunos = new List<Alunos>();
        List<Apoios> apoios = new List<Apoios>();
        List<Disciplinas> disciplinas = new List<Disciplinas>();

        DAL dal;

        bool fetch = false;
        string mAlunoID;
        public void Passa(string AlunoID)
        {
            AlunoID = mAlunoID;
        }

        private void Form_Edit_Ap_Load(object sender, EventArgs e)
        {
            try
            {
                dal = new DAL(disciplinas, alunos, apoios);

                //Inserir itens na cbb disc
                for (int i = 0; i < disciplinas.Count(); i++)
                {
                    cbb_disc.Items.Add(disciplinas[i].Sigla);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao carregar os dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if(txt_alID.Text == "" && txt_apoio.Text == "" && txt_aval.Text == "" && txt_desc.Text == "" && txt_local.Text == "" && txt_tutID.Text == "" && dtp_.Value == System.DateTime.Now && cbb_disc.Text == "" && fetch == false)
            {
                this.Close();
            }
            else
            {
                DialogResult result = MessageBox.Show("Tem a certeza que pretende cancelar a operação?\nTodas as alterações serão perdidas!", "Cancelar?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if(result == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        private void btn_fetch_Click(object sender, EventArgs e)
        {
            try
            {
                bool existe = false;
                int i;
                if (txt_apoio.Text != "")
                {
                    //ver se existe e se ainda n foi concluido
                    for (i = 0; i < apoios.Count(); i++)
                    {
                        if (apoios[i].ApoioID == Convert.ToInt32(txt_apoio.Text) && apoios[i].Estado != Apoios.enumEstado.Concluido)
                        {
                            existe = true;
                            break;
                        }
                    }

                    if (existe == true)
                    {
                        txt_alID.Text = apoios[i].AlunoID;

                        if (apoios[i].Avaliacao != "" && apoios[i].Avaliacao != null)
                        {
                            txt_aval.Text = apoios[i].Avaliacao;
                        }
                        else
                        {
                            txt_aval.Text = "";
                        }

                        if (apoios[i].Descricao != "" && apoios[i].Descricao != null)
                        {
                            txt_desc.Text = apoios[i].Descricao;
                        }
                        else
                        {
                            txt_desc.Text = "";
                        }

                        txt_local.Text = apoios[i].Local;
                        txt_tutID.Text = apoios[i].TutorID;
                        dtp_.Value = apoios[i].ReqDate;
                        cbb_disc.SelectedItem = apoios[i].Sigla;

                        fetch = true;
                    }
                    else
                    {
                        ep_.SetError(txt_apoio, "Esse apoio não existe ou já foi concluido!");
                    }
                }
                else
                {
                    ep_.SetError(txt_apoio, "Por favor insira um ID de um apoio.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro a obter os dados do apoio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            try
            {
                bool existeAl = false, existeTut = false;
                if (fetch == true)
                {
                    if (txt_apoio.Text != "")
                    {
                        if (cbb_disc.Text != "")
                        {
                            if (txt_alID.Text != "")
                            {
                                //Ver se o aluno existe e se esta aprovado
                                for (int i = 0; i < alunos.Count(); i++)
                                {
                                    if (alunos[i].AlunoID == txt_alID.Text && alunos[i].Tipo == Alunos.enumTipo.Aluno && alunos[i].Aprovado == true)
                                    {

                                        existeAl = true;
                                        break;


                                    }
                                }

                                if (existeAl == true)
                                {
                                    //Ver se o tutor existe
                                    for (int i = 0; i < alunos.Count(); i++)
                                    {
                                        if (alunos[i].AlunoID == txt_tutID.Text && alunos[i].Tipo == Alunos.enumTipo.Tutor && alunos[i].Aprovado == true)
                                        {

                                            existeTut = true;
                                            break;

                                        }
                                    }

                                    if (existeTut == true)
                                    {
                                        if (txt_local.Text != "")
                                        {
                                            Apoios apoio = new Apoios();
                                            apoio.ApoioID = Convert.ToInt32(txt_apoio.Text);
                                            apoio.AlunoID = txt_alID.Text;

                                            if (txt_aval.Text != "")
                                            {
                                                apoio.Avaliacao = txt_aval.Text;
                                            }
                                            else
                                            {
                                                apoio.Avaliacao = null;
                                            }

                                            if (txt_desc.Text != "")
                                            {
                                                apoio.Descricao = txt_desc.Text;
                                            }
                                            else
                                            {
                                                apoio.Descricao = null;
                                            }

                                            if (dtp_.Value > System.DateTime.Now)
                                            {
                                                apoio.Estado = Apoios.enumEstado.Aceite;
                                            }
                                            else
                                            {
                                                apoio.Estado = Apoios.enumEstado.Concluido;
                                            }

                                            apoio.Local = txt_local.Text;
                                            apoio.ReqDate = dtp_.Value;
                                            apoio.Sigla = cbb_disc.Text;
                                            apoio.TutorID = txt_tutID.Text;
                                            apoio.Criado = mAlunoID;

                                            dal.EditAp(apoios, apoio);
                                            this.Close();
                                        }
                                        else
                                        {
                                            ep_.SetError(txt_local, "Por favor preencha este campo.");
                                        }
                                    }
                                    else
                                    {
                                        ep_.SetError(txt_tutID, "Esse tutor não existe ou não está disponivel ou ainda não foi aprovado!");
                                    }
                                }
                                else
                                {
                                    ep_.SetError(txt_alID, "Esse aluno não existe ou não está disponivel ou ainda não foi aprovado!");
                                }

                            }
                            else
                            {
                                ep_.SetError(txt_alID, "Por favor preencha este campo.");
                            }
                        }
                        else
                        {
                            ep_.SetError(txt_alID, "Por selecione uma opção.");
                        }
                    }
                    else
                    {
                        ep_.SetError(txt_apoio, "Por favor não elimine o ID do apoio!");
                    }
                }
                else
                {
                    MessageBox.Show("Deve buscar os dados antes de poder editar os mesmos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show("Ocorreu um erro ao editar o apoio." + ee, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
