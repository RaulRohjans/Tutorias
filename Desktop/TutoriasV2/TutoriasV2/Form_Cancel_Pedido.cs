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
    public partial class Form_Cancel_Pedido : Form
    {
        public Form_Cancel_Pedido()
        {
            InitializeComponent();
        }
        List<Alunos> alunos = new List<Alunos>();
        List<Apoios> apoios = new List<Apoios>();
        List<Disciplinas> disciplinas = new List<Disciplinas>();

        DAL dal;
        string mTutorID;

        public void Passa(string TutorID)
        {
            mTutorID = TutorID;
        }

        private void Form_Cancel_Pedido_Load(object sender, EventArgs e)
        {
            try
            {                
                dal = new DAL(disciplinas, alunos, apoios);
                RefreshList(); 
                
            }
            catch(Exception)
            {
                MessageBox.Show("Ocorreu um erro ao obter os dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshList()
        {
            int idx;
            //obter idx do user
            for (idx = 0; idx < alunos.Count(); idx++)
            {
                if (alunos[idx].AlunoID == mTutorID)
                {
                    break;
                }
            }

            //carregar itens para a lscb
            lscb_.Items.Clear();
            if (alunos[idx].Tipo == Alunos.enumTipo.Tutor)
            {
                for (int i = 0; i < apoios.Count(); i++)
                {
                    if (apoios[i].Criado == mTutorID && apoios[i].Estado == Apoios.enumEstado.Pendente)
                    {
                        lscb_.Items.Add(apoios[i].ApoioID + " | Tutor: " + apoios[i].TutorID + " | Disciplina: " + apoios[i].Sigla + " | Data:" + apoios[i].ReqDate.ToShortDateString());
                    }
                }
            }
            else
            {
                for (int i = 0; i < apoios.Count(); i++)
                {
                    if (apoios[i].Criado == mTutorID && apoios[i].Estado == Apoios.enumEstado.Pendente)
                    {
                        lscb_.Items.Add(apoios[i].ApoioID + " | Aluno: " + apoios[i].AlunoID + " | Disciplina: " + apoios[i].Sigla + " | Data:" + apoios[i].ReqDate.ToShortDateString());
                    }
                }
            }
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            if(lscb_.CheckedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("Tem a certeza que pretende cancelar a operação?\nTodos os dados não guardados serão perdidos!", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(result == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void btn_anular_Click(object sender, EventArgs e)
        {
            try
            {
                if (lscb_.CheckedItems.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Tem a certeza que pretende anular o(s) pedido(s) selecionado(s)?", "Anular Pedidos", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        for (int i = 0; i < lscb_.CheckedItems.Count; i++)
                        {
                            for (int i2 = 0; i2 < apoios.Count(); i2++)
                            {
                                if (apoios[i2].ApoioID.ToString() == lscb_.CheckedItems[i].ToString().Remove(lscb_.CheckedItems[i].ToString().IndexOf('|')).Trim())
                                {
                                    dal.DelAp(apoios, apoios[i2]);
                                    break;
                                }
                            }
                        }
                        RefreshList();
                        MessageBox.Show("Registo(s) eliminado(s) com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }                    
                }
                else
                {
                    MessageBox.Show("Deve selecionar pelo menos um registo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception)
            {
                if(lscb_.CheckedItems.Count > 1)
                {
                    MessageBox.Show("Ocorreu um erro ao anular os pedidos de apoio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro ao anular o pedido de apoio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
