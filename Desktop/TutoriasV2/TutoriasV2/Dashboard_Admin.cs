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
    public partial class Dashboard_Admin : Form
    {
        public Dashboard_Admin()
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

        private void Dashboard_Admin_Load(object sender, EventArgs e)
        {
            try
            {
                dal = new DAL(disciplinas, alunos, apoios);

                //Carregar itens para a lsv pedidos
                for (int i = 0; i < apoios.Count(); i++)
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

                        case Apoios.enumEstado.Concluido:
                            lvi.SubItems.Add("Concluido");
                            break;

                        case Apoios.enumEstado.Pendente:
                            lvi.SubItems.Add("Pendente");
                            break;
                    }

                    lvi.Tag = apoios[i].ApoioID;
                    lsv_pedidos.Items.Add(lvi);
                }

                //Carregar itens para a lsv users
                for (int i = 0; i < alunos.Count(); i++)
                {
                    ListViewItem lvi = new ListViewItem(alunos[i].AlunoID);
                    lvi.SubItems.Add(alunos[i].Nome);

                    switch (alunos[i].Tipo)
                    {
                        case Alunos.enumTipo.Admin:
                            lvi.SubItems.Add("Admin");
                            break;

                        case Alunos.enumTipo.Aluno:
                            lvi.SubItems.Add("Aluno");
                            break;

                        case Alunos.enumTipo.Tutor:
                            lvi.SubItems.Add("Tutor");
                            break;
                    }

                    if (alunos[i].Aprovado == true)
                        lvi.SubItems.Add("Aprovado");
                    else
                        lvi.SubItems.Add("Não Aprovado");

                    lvi.Tag = alunos[i].AlunoID;
                    lsv_users.Items.Add(lvi);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Ocorreu um erro ao aceder à BD.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lsv_pedidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //Deselecionar item da outra lsv se houver
                if (lsv_users.SelectedItems.Count > 0)
                {
                    lsv_users.SelectedItems[0].Selected = false;
                }

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

        private void lsv_users_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //Desselecionar item da outra lsv se houver
                if (lsv_pedidos.SelectedItems.Count > 0)
                {
                    lsv_pedidos.SelectedItems[0].Selected = false;
                }

                //Mostrar info na groupbox
                
                for (int i = 0; i < alunos.Count(); i++)
                {
                    if (lsv_users.SelectedItems[0].Tag.ToString() == alunos[i].AlunoID)
                    {
                        gpb_.Visible = true;
                        gpb_.Text = "Utilizador:";
                        lbl_info1.Text = "Nome do Utilizador: ";
                        lbl_info2.Text = "Turma do Utilizador: ";
                        lbl_info3.Text = "Data de Nascimento do Utilizador: ";
                        lbl_info4.Text = "Telefone do Utilizador: ";
                        lbl_info5.Text = "Morada do Utilizador: ";
                        lbl_info6.Text = "";

                        lbl_out1.Text = alunos[i].AlunoID;
                        lbl_out2.Text = alunos[i].Turma;
                        lbl_out3.Text = alunos[i].DataNasc.ToShortDateString();

                        if (alunos[i].Telefone != "" && alunos[i].Telefone != null)
                            lbl_out4.Text = alunos[i].Telefone;
                        else
                            lbl_out4.Text = " - ";

                        if (alunos[i].Morada != "" && alunos[i].Morada != null)
                            lbl_out5.Text = alunos[i].Morada;
                        else
                            lbl_out5.Text = " - ";

                        lbl_out6.Text = "";
                        break;
                    }
                }
            }
            catch (IndexOutOfRangeException) { }
            catch (ArgumentOutOfRangeException) { }
            catch (Exception ee)
            {
                MessageBox.Show("Ocorreu um erro ao obter dados do Aluno " + ee, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lsv_users_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                //Eliminar o aluno
                for (int i = 0; i < alunos.Count(); i++)
                {
                    if (alunos[i].AlunoID == lsv_users.SelectedItems[0].Tag.ToString())
                    {
                        DialogResult result = MessageBox.Show("Tem a certeza que pretende eliminar o aluno " + alunos[i].AlunoID + "?", "Eliminar Aluno", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            dal.DelAl(alunos, alunos[i]);
                            RefreshAl();
                        }
                        else
                            break;
                    }
                }
            }
            catch (IndexOutOfRangeException) { }
            catch (ArgumentOutOfRangeException) { }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao eliminar o aluno", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lsv_pedidos_DoubleClick(object sender, EventArgs e)
        {
            //Eliminar o pedido
            try
            {
                for (int i = 0; i < apoios.Count(); i++)
                {
                    if (apoios[i].ApoioID == Convert.ToInt32(lsv_pedidos.SelectedItems[0].Tag))
                    {
                        DialogResult result = MessageBox.Show("Tem a certeza que pretende eliminar o apoio nº " + apoios[i].ApoioID + "?", "Eliminar Apoio", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            dal.DelAp(apoios, apoios[i]);
                            RefreshAp();
                        }
                        else
                            break;
                    }
                }
            }
            catch (IndexOutOfRangeException) { }
            catch (ArgumentOutOfRangeException) { }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao eliminar o apoio", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void smi_criar_Click(object sender, EventArgs e)
        {
            Form_Create_AL al = new Form_Create_AL();
            al.Show();
        }

        private void btn_refresh_apoios_Click(object sender, EventArgs e)
        {
            try
            {
                RefreshAp();
            }
            catch(Exception)
            {
                MessageBox.Show("Ocorreu um erro a atualizar a lista de apoios", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_refresh_users_Click(object sender, EventArgs e)
        {
            try
            {
                RefreshAl();
            }
            catch(Exception)
            {
                MessageBox.Show("Ocorreu um erro a atualizar a lista de alunos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshAl()
        {
            lsv_users.Items.Clear();
            dal.Refresh(alunos);
            //Carregar itens para a lsv users
            for (int i = 0; i < alunos.Count(); i++)
            {
                ListViewItem lvi = new ListViewItem(alunos[i].AlunoID);
                lvi.SubItems.Add(alunos[i].Nome);

                switch (alunos[i].Tipo)
                {
                    case Alunos.enumTipo.Admin:
                        lvi.SubItems.Add("Admin");
                        break;

                    case Alunos.enumTipo.Aluno:
                        lvi.SubItems.Add("Aluno");
                        break;

                    case Alunos.enumTipo.Tutor:
                        lvi.SubItems.Add("Tutor");
                        break;
                }

                if (alunos[i].Aprovado == true)
                    lvi.SubItems.Add("Aprovado");
                else
                    lvi.SubItems.Add("Não Aprovado");

                lvi.Tag = alunos[i].AlunoID;
                lsv_users.Items.Add(lvi);
            }
        }

        private void RefreshAp()
        {
            lsv_pedidos.Items.Clear();
            dal.Refresh(apoios);
            //Carregar itens para a lsv pedidos
            for (int i = 0; i < apoios.Count(); i++)
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

                    case Apoios.enumEstado.Concluido:
                        lvi.SubItems.Add("Concluido");
                        break;

                    case Apoios.enumEstado.Pendente:
                        lvi.SubItems.Add("Pendente");
                        break;
                }

                lvi.Tag = apoios[i].ApoioID;
                lsv_pedidos.Items.Add(lvi);
            }
        }

        private void mi_alunos_Click(object sender, EventArgs e)
        {

        }

        private void smi_editar_Click(object sender, EventArgs e)
        {
            Form_Edit_Al Edital = new Form_Edit_Al();
            Edital.Show();
        }

        private void smi_aprovar_Click(object sender, EventArgs e)
        {
            Form_Aprov_Al Aprov = new Form_Aprov_Al();
            Aprov.Show();
        }

        private void smi_pAL_Click(object sender, EventArgs e)
        {
            Form_Create_Ap CriarAp = new Form_Create_Ap();
            CriarAp.Passa(mAlunoID);
            CriarAp.Show();
        }

        private void smi_ApAprov_Click(object sender, EventArgs e)
        {
            Form_Aprov_Ap AprovAp = new Form_Aprov_Ap();
            AprovAp.Show();
        }

        private void smi_ApEditar_Click(object sender, EventArgs e)
        {
            Form_Edit_Ap EditAp = new Form_Edit_Ap();
            EditAp.Passa(mAlunoID);
            EditAp.Show();
        }

        private void smi_tP_Click(object sender, EventArgs e)
        {
            try
            {
                int qtd = 0;
                RefreshAp();
                //Obter quantidade de pedidos
                for(int i = 0; i < apoios.Count(); i++)
                {
                    if(apoios[i].Estado == Apoios.enumEstado.Pendente)
                    {
                        qtd++;
                    }
                }

                MessageBox.Show("Total de Pedidos de Apoios: " + qtd.ToString(), "Quantidade de Pedidos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception)
            {
                MessageBox.Show("Ocorreu um erro ao carregar os totais.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void smi_tS_Click(object sender, EventArgs e)
        {
            try
            {
                int qtd = 0;
                RefreshAp();
                //Obter quantidade de apoios
                for (int i = 0; i < apoios.Count(); i++)
                {
                    if (apoios[i].Estado != Apoios.enumEstado.Pendente)
                    {
                        qtd++;
                    }
                }

                MessageBox.Show("Total de Apoios (concluidos e aceites): " + qtd.ToString(), "Quantidade de Apoios", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception)
            {
                MessageBox.Show("Ocorreu um erro ao carregar os totais.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void smi_tU_Click(object sender, EventArgs e)
        {
            try
            {
                RefreshAl();
                MessageBox.Show("Total de Utilizadores (aprovados e não aprovados): " + alunos.Count().ToString(), "Quantidade de Utilizadores", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception)
            {
                MessageBox.Show("Ocorreu um erro ao carregar os totais.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_logout_Click(object sender, EventArgs e)
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
    }
}
