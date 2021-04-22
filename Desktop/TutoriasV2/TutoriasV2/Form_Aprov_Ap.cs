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
    public partial class Form_Aprov_Ap : Form
    {
        public Form_Aprov_Ap()
        {
            InitializeComponent();
        }
        List<Alunos> alunos = new List<Alunos>();
        List<Apoios> apoios = new List<Apoios>();
        List<Disciplinas> disciplinas = new List<Disciplinas>();

        DAL dal;

        bool changes = false;
        private void Form_Aprov_Ap_Load(object sender, EventArgs e)
        {
            lsbc_.Items.Clear();
            try
            {
                dal = new DAL(disciplinas, alunos, apoios);

                //Carregar coisas para a lista
                int i2 = 0;
                for (int i = 0; i < apoios.Count(); i++)
                {
                    if (apoios[i].Estado != Apoios.enumEstado.Concluido && apoios[i].Estado != Apoios.enumEstado.NULL)
                    {
                        lsbc_.Items.Add(apoios[i].ApoioID + " - " + apoios[i].Sigla);
                        if (apoios[i].Estado == Apoios.enumEstado.Pendente)
                            lsbc_.SetItemChecked(i2, false);
                        else
                            lsbc_.SetItemChecked(i2, true);
                        i2++;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao carregar a informação dos alunos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Aprovar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lsbc_.Items.Count; i++)
            {
                if (lsbc_.GetItemCheckState(i) == CheckState.Checked)
                {
                    dal.EditAp(apoios, apoios[i].ApoioID, null, null, null, null, "Aceite", null, null, null);
                }
                else
                {
                    dal.EditAp(apoios, apoios[i].ApoioID, null, null, null, null, "Pendente", null, null, null);
                }                
            }
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if (changes == true)
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

        private void lsbc__ItemCheck(object sender, ItemCheckEventArgs e)
        {
            changes = true;    
        }

        private void lsbc__SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
