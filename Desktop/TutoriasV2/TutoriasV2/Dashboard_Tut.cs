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
    public partial class Dashboard_Tut : Form
    {
        public Dashboard_Tut()
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

        private void Dashboard_Tut_Load(object sender, EventArgs e)
        {
            dal = new DAL(disciplinas, alunos, apoios);
            //Carregar itens para a lsv pedidos
            for (int i = 0; i < apoios.Count(); i++)
            {
                if (apoios[i].Estado != Apoios.enumEstado.Concluido && apoios[i].TutorID == mTutorID)
                {
                    ListViewItem lvi = new ListViewItem(apoios[i].ApoioID.ToString());
                    lvi.SubItems.Add(apoios[i].AlunoID);
                    lvi.SubItems.Add(apoios[i].TutorID);
                    lvi.SubItems.Add(apoios[i].Sigla);
                    lvi.SubItems.Add(apoios[i].ReqDate.ToShortDateString());

                    switch (apoios[i].Estado)
                    {
                        case Apoios.enumEstado.Aceite:
                            lvi.SubItems.Add("Aceite");
                            break;

                        case Apoios.enumEstado.Pendente:
                            lvi.SubItems.Add("Pendente");
                            break;
                    }
                    lvi.SubItems.Add(apoios[i].Local);

                    if (apoios[i].Descricao == null || apoios[i].Descricao == "")
                    {
                        lvi.SubItems.Add(" - ");
                    }
                    else
                    {
                        lvi.SubItems.Add(apoios[i].Descricao);
                    }

                    lvi.Tag = apoios[i].ApoioID;
                    lsv_pedidos.Items.Add(lvi);
                }
            }
        }

        private void btn_refresh_apoios_Click(object sender, EventArgs e)
        {
            try
            {
                RefreshAp();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro a atualizar a lista de apoios", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshAp()
        {
            lsv_pedidos.Items.Clear();
            dal.Refresh(apoios);
            //Carregar itens para a lsv pedidos
            for (int i = 0; i < apoios.Count(); i++)
            {
                if (apoios[i].Estado != Apoios.enumEstado.Concluido && apoios[i].AlunoID == mTutorID)
                {
                    ListViewItem lvi = new ListViewItem(apoios[i].ApoioID.ToString());
                    lvi.SubItems.Add(apoios[i].AlunoID);
                    lvi.SubItems.Add(apoios[i].TutorID);
                    lvi.SubItems.Add(apoios[i].Sigla);
                    lvi.SubItems.Add(apoios[i].ReqDate.ToShortDateString());

                    switch (apoios[i].Estado)
                    {
                        case Apoios.enumEstado.Aceite:
                            lvi.SubItems.Add("Aceite");
                            break;

                        case Apoios.enumEstado.Pendente:
                            lvi.SubItems.Add("Pendente");
                            break;
                    }
                    lvi.SubItems.Add(apoios[i].Local);

                    if (apoios[i].Descricao == null || apoios[i].Descricao == "")
                    {
                        lvi.SubItems.Add(" - ");
                    }
                    else
                    {
                        lvi.SubItems.Add(apoios[i].Descricao);
                    }

                    lvi.Tag = apoios[i].ApoioID;
                    lsv_pedidos.Items.Add(lvi);
                }
            }
        }

        private void lsv_pedidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //Mostrar info na groupbox

                for (int i = 0; i < apoios.Count(); i++)
                {
                    if (Convert.ToInt32(lsv_pedidos.SelectedItems[0].Tag) == apoios[i].ApoioID)
                    {
                        gpb_.Visible = true;
                        gpb_.Text = "Apoio:";
                        lbl_info1.Text = "Nome de Utilizador do Aluno: ";
                        lbl_info2.Text = "Nome de Utilizador do Tutor: ";
                        lbl_info3.Text = "Data do Apoio: ";
                        lbl_info4.Text = "Local: ";
                        lbl_info5.Text = "Avaliação: ";
                        lbl_info6.Text = "Descrição: ";

                        lbl_out1.Text = apoios[i].AlunoID;
                        lbl_out2.Text = apoios[i].TutorID;
                        lbl_out3.Text = apoios[i].ReqDate.ToShortDateString();
                        lbl_out4.Text = apoios[i].Local;

                        if (apoios[i].Avaliacao != "" && apoios[i].Avaliacao != null)
                            lbl_out5.Text = apoios[i].Avaliacao;
                        else
                            lbl_out5.Text = " - ";

                        if (apoios[i].Descricao != "" && apoios[i].Descricao != null)
                            lbl_out6.Text = apoios[i].Descricao;
                        else
                            lbl_out6.Text = " - ";

                        break;
                    }
                }
            }
            catch (IndexOutOfRangeException) { }
            catch (ArgumentOutOfRangeException) { }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao obter dados do Apoio", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lsv_pedidos_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void smi_logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem a certeza que pretende efetuar o logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                Form_Startup st = new Form_Startup();
                st.FormClosed += (s, args) => this.Close();
                st.Show();
            }
        }

        private void smi_edit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Edit_Perfil perfil = new Form_Edit_Perfil();
            perfil.Passa(mTutorID);
            perfil.FormClosed += (s, args) => this.Close();
            perfil.Show();
        }

        private void smi_ApPedir_Click(object sender, EventArgs e)
        {
            Form_Pedir_ApTUT PedAp = new Form_Pedir_ApTUT();
            PedAp.Passa(mTutorID);
            PedAp.Show();
        }

        private void smi_ApHist_Click(object sender, EventArgs e)
        {
            Form_HistAval histAval = new Form_HistAval();
            histAval.Passa(mTutorID);
            histAval.Show();
        }

        private void smi_ApCanc_Click(object sender, EventArgs e)
        {
            Form_Cancel_Pedido cancelPed = new Form_Cancel_Pedido();
            cancelPed.Passa(mTutorID);
            cancelPed.Show();
        }

        private void smi_ApAcei_Click(object sender, EventArgs e)
        {
            Form_Aceitar aceitar = new Form_Aceitar();
            aceitar.Passa(mTutorID);
            aceitar.Show();
        }
    }
}
