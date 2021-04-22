using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TutoriasV2
{
    public partial class Form_Startup : Form
    {
        public Form_Startup()
        {
            InitializeComponent();
        }
        List<Alunos> alunos = new List<Alunos>();
        List<Apoios> apoios = new List<Apoios>();
        List<Disciplinas> disciplinas = new List<Disciplinas>();

        DAL dal;

        SqlConnection DB_CONNECTION = new SqlConnection(Properties.Settings.Default.DB_CONNECTION);

        private void Form_Startup_Load(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            try
            {
                /*Fazer verificação da conexão*/
                DB_CONNECTION.Open();

                if (DB_CONNECTION.State == ConnectionState.Open)
                {
                    pb.Image = il.Images[0];
                    lbl_state.Visible = true;
                    lbl_state.Text = "Connection Successful!";
                    btn_login.Enabled = true;
                    btn_regist.Enabled = true;

                    //Atualizar Apoios q foram completados
                    dal = new DAL(disciplinas, alunos, apoios);
                    for(int i = 0; i < apoios.Count(); i++)
                    {
                        if(apoios[i].ReqDate < System.DateTime.Now)
                        {
                            dal.EditAp(apoios, apoios[i].ApoioID, null, null, null, null, "Concluido", null, null, null);
                        }
                    }
                }
                else
                {
                    pb.Image = il.Images[1];
                    lbl_state.Visible = true;
                    lbl_state.Text = "Connection Failed!";
                    btn_login.Enabled = false;
                    btn_regist.Enabled = false;
                }
                DB_CONNECTION.Close();
                /*Fim da verificação*/                
            }
            catch (SqlException)
            {
                pb.Image = il.Images[1];
                lbl_state.Visible = true;
                lbl_state.Text = "Connection Failed!";
                btn_login.Enabled = false;
                btn_regist.Enabled = false;
                ep.SetError(lbl_state, "Erro durante a connexão à base de dados!\nFaça duplo click no Icon à esquerda para ver a mensagem detalhada do erro!");
            }
            catch (Exception)
            {
                pb.Image = il.Images[1];
                lbl_state.Visible = true;
                lbl_state.Text = "Connection Failed!";
                btn_login.Enabled = false;
                btn_regist.Enabled = false;
                ep.SetError(lbl_state, "Mensagem de erro temporária!\nFaça duplo click no Icon à esquerda para ver a mensagem detalhada do erro!");
            }
            finally
            {
                UseWaitCursor = false;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pb_DoubleClick(object sender, EventArgs e)
        {

            UseWaitCursor = true;
            try
            {
                DB_CONNECTION.Open();
                DB_CONNECTION.Close();
            }
            catch (SqlException SqlEx)
            {
                MessageBox.Show(SqlEx.Message + "\n\nSugestão: Verificar ConnectionString.", "Erro relacionado à base de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message + "\n\nSugestão: Debug.", "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                UseWaitCursor = false;
            }

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Login Login = new Form_Login();
            Login.FormClosed += (s, args) => this.Close();
            Login.Show();
        }

        private void btn_regist_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Register_Al register_Al = new Form_Register_Al();
            register_Al.FormClosed += (s, args) => this.Close();
            register_Al.Show();
        }

        private void pb_Click(object sender, EventArgs e)
        {

        }
    }
}
