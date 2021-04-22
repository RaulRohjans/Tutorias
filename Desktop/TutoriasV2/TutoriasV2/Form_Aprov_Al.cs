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
    public partial class Form_Aprov_Al : Form
    {
        public Form_Aprov_Al()
        {
            InitializeComponent();
        }
        List<Alunos> alunos = new List<Alunos>();
        List<Apoios> apoios = new List<Apoios>();
        List<Disciplinas> disciplinas = new List<Disciplinas>();

        DAL dal;

        bool changed = false;

        private void Form_Aprov_Al_Load(object sender, EventArgs e)
        {
            lsbc_.Items.Clear();
            try
            {
                dal = new DAL(disciplinas, alunos, apoios);

                //Carregar coisas para a lista
                for(int i = 0; i < alunos.Count(); i++)
                {
                    lsbc_.Items.Add(alunos[i].AlunoID + " - " + alunos[i].Nome);
                    lsbc_.SetItemChecked(i, alunos[i].Aprovado);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao carregar a informação dos alunos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if(changed == true)
            {
                DialogResult result = MessageBox.Show("Tem a certeza que pretende cancelar a operação?\nTodas as alterações serão perdidas!", "Cancelar?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                
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

        private void btn_Aprovar_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < lsbc_.Items.Count; i++)
                {
                    if (lsbc_.GetItemCheckState(i) == CheckState.Checked)
                    {
                        dal.EditAl(alunos, alunos[i].AlunoID, true);
                    }
                    else
                    {
                        dal.EditAl(alunos, alunos[i].AlunoID, false);
                    }
                }
                this.Close();
            }
            catch(Exception)
            {
                MessageBox.Show("Ocorreu um erro ao aprovar/desaprovar os alunos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lsbc__SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lsbc__ItemCheck(object sender, ItemCheckEventArgs e)
        {
            changed = true;
        }
    }
}
