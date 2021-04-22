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
    public partial class Form_Pedir_ApAL : Form
    {
        public Form_Pedir_ApAL()
        {
            InitializeComponent();
        }
        List<Alunos> alunos = new List<Alunos>();
        List<Apoios> apoios = new List<Apoios>();
        List<Disciplinas> disciplinas = new List<Disciplinas>();

        DAL dal;
        string mAlunoID;
        public void Passa(string AlunoID)
        {
            mAlunoID = AlunoID;
        }

        private void Form_Pedir_Ap_Load(object sender, EventArgs e)
        {
            try
            {
                dal = new DAL(disciplinas, alunos, apoios);
                //Carregar disciplinas para a cbb
                cbb_disc.Items.Clear();
                for (int i = 0; i < disciplinas.Count(); i++)
                {
                    cbb_disc.Items.Add(disciplinas[i].Sigla);
                }

                //Carregar tutores para a cbb tutores
                cbb_tutor.Items.Clear();
                for(int i = 0; i < alunos.Count(); i++)
                {
                    if(alunos[i].Tipo == Alunos.enumTipo.Tutor && alunos[i].Aprovado == true)
                    {
                        cbb_tutor.Items.Add(alunos[i].AlunoID);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao carregar as informações", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if (txt_desc.Text == "" && txt_local.Text == "" && cbb_tutor.Text == "" && dtp_.Value == System.DateTime.Now && cbb_disc.Text == "")
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

        private void btn_create_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_local.Text != "")
                {
                    if (cbb_disc.Text != "")
                    {
                        if (cbb_tutor.Text != "")
                        {
                            //ver se o tutor esta disponivel
                            bool disponivel = true;
                            for(int i = 0; i < apoios.Count(); i++)
                            {
                                if(apoios[i].TutorID == cbb_tutor.Text)
                                {
                                    if(dtp_.Value == apoios[i].ReqDate)
                                        disponivel = false;
                                }
                            }

                            if (disponivel == true)
                            {
                                if (dtp_.Value > System.DateTime.Now)
                                {
                                    Apoios ap = new Apoios();
                                    if (apoios.Count() > 0)
                                        ap.ApoioID = apoios[apoios.Count() - 1].ApoioID + 1;
                                    else
                                        ap.ApoioID = 1;

                                    ap.AlunoID = mAlunoID;
                                    ap.Avaliacao = null;

                                    if (txt_desc.Text != "")
                                        ap.Descricao = txt_desc.Text;
                                    else
                                        ap.Descricao = null;

                                    ap.Estado = Apoios.enumEstado.Pendente;
                                    ap.Local = txt_local.Text;
                                    ap.ReqDate = dtp_.Value;
                                    ap.Sigla = cbb_disc.Text;
                                    ap.TutorID = cbb_tutor.Text;
                                    ap.Criado = mAlunoID;

                                    dal.AddAp(apoios, ap);
                                    this.Close();
                                }
                                else
                                {
                                    ep_.SetError(dtp_, "Data Inválida!");
                                }
                            }
                            else
                            {
                                ep_.SetError(cbb_tutor, "Esse tutor não se encontra disponivel nesse dia!");
                            }
                        }
                        else
                        {
                            ep_.SetError(cbb_tutor, "Por favor selecione uma opção!");
                        }
                    }
                    else
                    {
                        ep_.SetError(cbb_disc, "Por favor selecione uma opção!");
                    }
                }
                else
                {
                    ep_.SetError(txt_local, "Por favor preencha este campo!");
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Ocorreu um erro ao efetuar o pedido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
