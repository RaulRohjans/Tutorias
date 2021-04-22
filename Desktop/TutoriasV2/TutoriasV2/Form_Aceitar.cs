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
    public partial class Form_Aceitar : Form
    {
        public Form_Aceitar()
        {
            InitializeComponent();
        }
        List<Alunos> alunos = new List<Alunos>();
        List<Apoios> apoios = new List<Apoios>();
        List<Disciplinas> disciplinas = new List<Disciplinas>();

        DAL dal;
        string mUserID;
        int idx;

        public void Passa(string UserID)
        {
            mUserID = UserID;
        }

        private void Form_Aceitar_Load(object sender, EventArgs e)
        {
            try
            {
                dal = new DAL(disciplinas, alunos, apoios);
                RefreshList();
            }
            catch(Exception)
            {
                MessageBox.Show("Ocorreu um erro ao carregar os dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if (lsbc_.CheckedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("Tem a certeza que pretende cancelar a operação?\nTodas as alterações serão perdidas!", "Cancelar?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void btn_aceitar_Click(object sender, EventArgs e)
        {
            try
            {
                if(lsbc_.CheckedItems.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Tem a certeza que pretende aceitar o(s) pedido(s) selecionado(s)?", "Anular Pedidos", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        for (int i = 0; i < lsbc_.CheckedItems.Count; i++)
                        {
                            for (int i2 = 0; i2 < apoios.Count(); i2++)
                            {                                
                                if (apoios[i2].ApoioID.ToString() == lsbc_.CheckedItems[i].ToString().Remove(lsbc_.CheckedItems[i].ToString().IndexOf('|')).Trim())
                                {
                                    dal.EditAp(apoios, apoios[i2].ApoioID, null, null, null, null, "Aceite", null, null, null);
                                    break;
                                }
                            }
                        }
                        RefreshList();
                        MessageBox.Show("Pedido(s) Aceite(s) com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor selecione pelo menos um registo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Ocorreu um erro ao aceitar o(s) pedido(s).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void RefreshList()
        {
            //obter idx do user
            for (idx = 0; idx < alunos.Count(); idx++)
            {
                if (alunos[idx].AlunoID == mUserID)
                {
                    break;
                }
            }

            //Carregar apoios para a lscb
            lsbc_.Items.Clear();
            if (alunos[idx].Tipo == Alunos.enumTipo.Aluno)
            {
                for (int i = 0; i < apoios.Count(); i++)
                {
                    if (apoios[i].AlunoID == mUserID && apoios[i].Estado == Apoios.enumEstado.Pendente && apoios[i].Criado != mUserID)
                    {
                        lsbc_.Items.Add(apoios[i].ApoioID + " | Tutor: " + apoios[i].TutorID + " | Disciplina: " + apoios[i].Sigla + " | Data: " + apoios[i].ReqDate.ToShortDateString());
                    }
                }
            }
            else
            {
                for (int i = 0; i < apoios.Count(); i++)
                {
                    if (apoios[i].TutorID == mUserID && apoios[i].Estado == Apoios.enumEstado.Pendente && apoios[i].Criado != mUserID)
                    {
                        lsbc_.Items.Add(apoios[i].ApoioID + " | Aluno: " + apoios[i].AlunoID + " | Disciplina: " + apoios[i].Sigla + " | Data: " + apoios[i].ReqDate.ToShortDateString());
                    }
                }
            }
        }
    }
}
