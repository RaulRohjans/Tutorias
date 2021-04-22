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
    public partial class Form_Create_Ap : Form
    {
        public Form_Create_Ap()
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
        
        private void Form_Create_Ap_Load(object sender, EventArgs e)
        {
            try
            {
                dal = new DAL(disciplinas, alunos, apoios);
                //Carregar disciplinas para a cbb
                cbb_disc.Items.Clear();
                for(int i = 0; i < disciplinas.Count(); i++)
                {
                    cbb_disc.Items.Add(disciplinas[i].Sigla);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Ocorreu um erro ao carregar as informações", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if(txt_alID.Text == "" && txt_desc.Text == "" && txt_local.Text == "" && txt_tutID.Text == "" && dtp_.Value == System.DateTime.Now && cbb_disc.Text == "")
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

        private void btn_create_Click(object sender, EventArgs e)
        {
            try
            {
                bool alExiste = false, tutExiste = false, tutDisp = true, alDisp = true;

                if (txt_alID.Text != "")
                {
                    //verificar se o aluno existe, esta disponivel e n e tutor
                    for (int i = 0; i < alunos.Count(); i++)
                    {
                        if (alunos[i].AlunoID == txt_alID.Text && alunos[i].Tipo == Alunos.enumTipo.Aluno && alunos[i].Aprovado == true)
                        {
                            alExiste = true;
                            for (int i1 = 0; i1 < apoios.Count(); i1++)
                            {
                                if(apoios[i1].AlunoID == alunos[i].AlunoID && apoios[i1].ReqDate == dtp_.Value)
                                {
                                    alDisp = false;
                                    break;
                                }
                            }                            
                            break;
                        }
                    }

                    if (alExiste == true && alDisp == true)
                    {                        
                        if (txt_tutID.Text != "")
                        {
                            //Verificar se o tutor existe, se esta disponivel e se e tutor
                            for (int i = 0; i < alunos.Count(); i++)
                            {
                                if (alunos[i].AlunoID == txt_tutID.Text && alunos[i].Tipo == Alunos.enumTipo.Tutor && alunos[i].Aprovado == true)
                                {
                                    tutExiste = true;
                                    for (int i1 = 0; i1 < apoios.Count(); i1++)
                                    {
                                        if(apoios[i1].TutorID == alunos[i].AlunoID && apoios[i1].ReqDate == dtp_.Value)
                                        {
                                            tutDisp = false;
                                            break;
                                        }
                                    }                                                                        
                                    break;
                                }
                            }

                            if (tutExiste == true && tutDisp == true)
                            {
                                
                                if (dtp_.Value > System.DateTime.Now)
                                {
                                    if (cbb_disc.Text != "")
                                    {
                                        Apoios ap = new Apoios();
                                        if (apoios.Count() > 0)
                                            ap.ApoioID = apoios[apoios.Count() - 1].ApoioID + 1;
                                        else
                                            ap.ApoioID = 1;

                                        ap.AlunoID = txt_alID.Text;
                                        ap.Avaliacao = null;

                                        if (txt_desc.Text != "")
                                            ap.Descricao = txt_desc.Text;
                                        else
                                            ap.Descricao = null;

                                        ap.Estado = Apoios.enumEstado.Aceite;
                                        ap.Local = txt_local.Text;
                                        ap.ReqDate = dtp_.Value;
                                        ap.Sigla = cbb_disc.Text;
                                        ap.TutorID = txt_tutID.Text;
                                        ap.Criado = mAlunoID;

                                        dal.AddAp(apoios, ap);
                                        this.Close();
                                    }
                                    else
                                    {
                                        ep_.SetError(cbb_disc, "Por favor selecione um registo!");
                                    }
                                }
                                else
                                {
                                    ep_.SetError(dtp_, "A data deve sair maior do que a atual!");
                                }
                            }
                            else
                            {
                                ep_.SetError(txt_tutID, "Esse Tutor não existe ou não está disponivel nessa data ou ainda não foi aprovado!");
                            }
                        }
                        else
                        {
                            ep_.SetError(txt_alID, "Por favor insira um tutor!");
                        }
                    }
                    else
                    {
                        ep_.SetError(txt_alID, "Esse aluno não existe ou não está disponivel nessa data ou ainda não foi aprovado!");
                    }
                }
                else
                {
                    ep_.SetError(txt_alID, "Por favor insira um aluno!");
                }
            }
            catch(Exception ee)
            {
                MessageBox.Show("Ocorreu um erro na criação do apoio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
