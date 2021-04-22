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
    public partial class Form_HistAval : Form
    {
        public Form_HistAval()
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

        private void Form_HistAval_Load(object sender, EventArgs e)
        {
            try
            {
                dal = new DAL(disciplinas, alunos, apoios);
                AtualizaLSV();               

            }
            catch(Exception)
            {
                MessageBox.Show("Ocorreu um erro ao carregar dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AtualizaLSV()
        {
            //Ober idx do aluno/tutor
            int idx;
            for (idx = 0; idx < alunos.Count(); idx++)
            {
                if (alunos[idx].AlunoID == mAlunoID)
                {
                    break;
                }
            }

            //Carregar itens para a listview
            lsv_.Items.Clear();
            if (alunos[idx].Tipo == Alunos.enumTipo.Aluno)
            {
                for (int i = 0; i < apoios.Count(); i++)
                {
                    if (apoios[i].AlunoID == mAlunoID && apoios[i].Estado == Apoios.enumEstado.Concluido)
                    {
                        ListViewItem lvi = new ListViewItem(apoios[i].ApoioID.ToString());
                        lvi.SubItems.Add(apoios[i].AlunoID);
                        lvi.SubItems.Add(apoios[i].TutorID);
                        lvi.SubItems.Add(apoios[i].Sigla);
                        lvi.SubItems.Add(apoios[i].Local);

                        if (apoios[i].Avaliacao == null || apoios[i].Avaliacao == "")
                        {
                            lvi.SubItems.Add(" - ");
                        }
                        else
                        {
                            lvi.SubItems.Add(apoios[i].Avaliacao);
                        }

                        if (apoios[i].Descricao == null || apoios[i].Descricao == "")
                        {
                            lvi.SubItems.Add(" - ");
                        }
                        else
                        {
                            lvi.SubItems.Add(apoios[i].Descricao);
                        }

                        lsv_.Items.Add(lvi);
                    }
                }
            }
            else
            {
                for (int i = 0; i < apoios.Count(); i++)
                {
                    if (apoios[i].TutorID == mAlunoID && apoios[i].Estado == Apoios.enumEstado.Concluido)
                    {
                        ListViewItem lvi = new ListViewItem(apoios[i].ApoioID.ToString());
                        lvi.SubItems.Add(apoios[i].AlunoID);
                        lvi.SubItems.Add(apoios[i].TutorID);
                        lvi.SubItems.Add(apoios[i].Sigla);
                        lvi.SubItems.Add(apoios[i].Local);

                        if (apoios[i].Avaliacao == null || apoios[i].Avaliacao == "")
                        {
                            lvi.SubItems.Add("-");
                        }
                        else
                        {
                            lvi.SubItems.Add(apoios[i].Avaliacao);
                        }

                        if (apoios[i].Descricao == null || apoios[i].Descricao == "")
                        {
                            lvi.SubItems.Add("- ");
                        }
                        else
                        {
                            lvi.SubItems.Add(apoios[i].Descricao);
                        }

                        lsv_.Items.Add(lvi);
                    }
                }
            }
        }

        private void lsv__SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lsv_.SelectedItems.Count > 0)
                {
                    if (lsv_.SelectedItems[0].SubItems[5].Text.Trim() == "-")
                    {
                        txt_aval.Text = "";
                    }
                    else
                    {
                        txt_aval.Text = lsv_.SelectedItems[0].SubItems[5].Text.Trim();
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

        private void txt_aval_TextChanged(object sender, EventArgs e)
        {
            if(txt_aval.Text != "")
            {
                btn_save.Enabled = true;
            }
            else
            {
                if(lsv_.SelectedItems.Count == 0)
                    btn_save.Enabled = false;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (lsv_.Items.Count > 0)
                {
                    int IDAp = Convert.ToInt32(lsv_.SelectedItems[0].SubItems[0].Text);
                    int idx;
                    for(idx = 0; idx < apoios.Count(); idx++)
                    {
                        if (apoios[idx].ApoioID == IDAp)
                            break;
                    }

                    if(txt_aval.Text != "" && txt_aval.Text != "NULL")
                    {
                        dal.EditAp(apoios, apoios[idx].ApoioID, null, null, null, null, null, null, txt_aval.Text, null);
                        txt_aval.Text = "";
                        AtualizaLSV();
                    }
                    else
                    {
                        if (txt_aval.Text != "NULL")
                        {
                            DialogResult result = MessageBox.Show("Tem a certeza que pretende deixar este registo em branco?", "Erro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (result == DialogResult.Yes)
                            {                                
                                dal.EditAp(apoios, apoios[idx].ApoioID, null, null, null, null, null, null, "NULL", null);
                                txt_aval.Text = "";
                                AtualizaLSV();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Text de avaliação inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Por favor selecione o registo que pretende avaliar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (IndexOutOfRangeException) { }
            catch (ArgumentOutOfRangeException) { }
            catch (Exception ee)
            {
                MessageBox.Show("Ocorreu um erro ao salvar os seus dados. " + ee, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if(lsv_.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("Tem a certeza que pretende cancelar a operação?\nTodas as alterações não guardadas serão perdidas.", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
    }
}
