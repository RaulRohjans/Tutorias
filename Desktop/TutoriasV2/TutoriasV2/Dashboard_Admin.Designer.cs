
namespace TutoriasV2
{
    partial class Dashboard_Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard_Admin));
            this.ms_admin = new System.Windows.Forms.MenuStrip();
            this.mi_alunos = new System.Windows.Forms.ToolStripMenuItem();
            this.smi_criar = new System.Windows.Forms.ToolStripMenuItem();
            this.smi_editar = new System.Windows.Forms.ToolStripMenuItem();
            this.smi_aprovar = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_apoios = new System.Windows.Forms.ToolStripMenuItem();
            this.smi_ApCriar = new System.Windows.Forms.ToolStripMenuItem();
            this.smi_ApEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.smi_ApAprov = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_ferr = new System.Windows.Forms.ToolStripMenuItem();
            this.smi_tP = new System.Windows.Forms.ToolStripMenuItem();
            this.smi_tS = new System.Windows.Forms.ToolStripMenuItem();
            this.smi_tU = new System.Windows.Forms.ToolStripMenuItem();
            this.gpb_ = new System.Windows.Forms.GroupBox();
            this.lbl_out6 = new System.Windows.Forms.Label();
            this.lbl_info6 = new System.Windows.Forms.Label();
            this.lbl_out5 = new System.Windows.Forms.Label();
            this.lbl_info5 = new System.Windows.Forms.Label();
            this.lbl_out4 = new System.Windows.Forms.Label();
            this.lbl_out3 = new System.Windows.Forms.Label();
            this.lbl_out2 = new System.Windows.Forms.Label();
            this.lbl_out1 = new System.Windows.Forms.Label();
            this.lbl_info4 = new System.Windows.Forms.Label();
            this.lbl_info3 = new System.Windows.Forms.Label();
            this.lbl_info2 = new System.Windows.Forms.Label();
            this.lbl_info1 = new System.Windows.Forms.Label();
            this.lbltxt_lvw_ped = new System.Windows.Forms.TextBox();
            this.txtlbl_lvw_ut = new System.Windows.Forms.TextBox();
            this.lsv_pedidos = new System.Windows.Forms.ListView();
            this.apoio_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nome_al = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nome_tut = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sigla_disc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.req_date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.estado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsv_users = new System.Windows.Forms.ListView();
            this.id_tr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nome_tr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tipo_tr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.estado_tr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl_delTip = new System.Windows.Forms.Label();
            this.btn_refresh_apoios = new System.Windows.Forms.Button();
            this.btn_refresh_users = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.ms_admin.SuspendLayout();
            this.gpb_.SuspendLayout();
            this.SuspendLayout();
            // 
            // ms_admin
            // 
            this.ms_admin.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ms_admin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_alunos,
            this.mi_apoios,
            this.mi_ferr});
            this.ms_admin.Location = new System.Drawing.Point(0, 0);
            this.ms_admin.Name = "ms_admin";
            this.ms_admin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ms_admin.Size = new System.Drawing.Size(1264, 24);
            this.ms_admin.TabIndex = 1;
            this.ms_admin.Text = "Menu";
            // 
            // mi_alunos
            // 
            this.mi_alunos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smi_criar,
            this.smi_editar,
            this.smi_aprovar});
            this.mi_alunos.Name = "mi_alunos";
            this.mi_alunos.Size = new System.Drawing.Size(80, 20);
            this.mi_alunos.Text = "Utilizadores";
            this.mi_alunos.Click += new System.EventHandler(this.mi_alunos_Click);
            // 
            // smi_criar
            // 
            this.smi_criar.Name = "smi_criar";
            this.smi_criar.Size = new System.Drawing.Size(116, 22);
            this.smi_criar.Text = "Criar";
            this.smi_criar.Click += new System.EventHandler(this.smi_criar_Click);
            // 
            // smi_editar
            // 
            this.smi_editar.Name = "smi_editar";
            this.smi_editar.Size = new System.Drawing.Size(116, 22);
            this.smi_editar.Text = "Editar";
            this.smi_editar.Click += new System.EventHandler(this.smi_editar_Click);
            // 
            // smi_aprovar
            // 
            this.smi_aprovar.Name = "smi_aprovar";
            this.smi_aprovar.Size = new System.Drawing.Size(116, 22);
            this.smi_aprovar.Text = "Aprovar";
            this.smi_aprovar.Click += new System.EventHandler(this.smi_aprovar_Click);
            // 
            // mi_apoios
            // 
            this.mi_apoios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smi_ApCriar,
            this.smi_ApEditar,
            this.smi_ApAprov});
            this.mi_apoios.Name = "mi_apoios";
            this.mi_apoios.Size = new System.Drawing.Size(56, 20);
            this.mi_apoios.Text = "Apoios";
            // 
            // smi_ApCriar
            // 
            this.smi_ApCriar.Name = "smi_ApCriar";
            this.smi_ApCriar.Size = new System.Drawing.Size(116, 22);
            this.smi_ApCriar.Text = "Criar";
            this.smi_ApCriar.Click += new System.EventHandler(this.smi_pAL_Click);
            // 
            // smi_ApEditar
            // 
            this.smi_ApEditar.Name = "smi_ApEditar";
            this.smi_ApEditar.Size = new System.Drawing.Size(116, 22);
            this.smi_ApEditar.Text = "Editar";
            this.smi_ApEditar.Click += new System.EventHandler(this.smi_ApEditar_Click);
            // 
            // smi_ApAprov
            // 
            this.smi_ApAprov.Name = "smi_ApAprov";
            this.smi_ApAprov.Size = new System.Drawing.Size(116, 22);
            this.smi_ApAprov.Text = "Aprovar";
            this.smi_ApAprov.Click += new System.EventHandler(this.smi_ApAprov_Click);
            // 
            // mi_ferr
            // 
            this.mi_ferr.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smi_tP,
            this.smi_tS,
            this.smi_tU});
            this.mi_ferr.Name = "mi_ferr";
            this.mi_ferr.Size = new System.Drawing.Size(84, 20);
            this.mi_ferr.Text = "Ferramentas";
            // 
            // smi_tP
            // 
            this.smi_tP.Name = "smi_tP";
            this.smi_tP.Size = new System.Drawing.Size(179, 22);
            this.smi_tP.Text = "Total Pedidos";
            this.smi_tP.Click += new System.EventHandler(this.smi_tP_Click);
            // 
            // smi_tS
            // 
            this.smi_tS.Name = "smi_tS";
            this.smi_tS.Size = new System.Drawing.Size(179, 22);
            this.smi_tS.Text = "Total Sessões";
            this.smi_tS.Click += new System.EventHandler(this.smi_tS_Click);
            // 
            // smi_tU
            // 
            this.smi_tU.Name = "smi_tU";
            this.smi_tU.Size = new System.Drawing.Size(179, 22);
            this.smi_tU.Text = "Total de Utilizadores";
            this.smi_tU.Click += new System.EventHandler(this.smi_tU_Click);
            // 
            // gpb_
            // 
            this.gpb_.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gpb_.BackColor = System.Drawing.Color.Transparent;
            this.gpb_.Controls.Add(this.lbl_out6);
            this.gpb_.Controls.Add(this.lbl_info6);
            this.gpb_.Controls.Add(this.lbl_out5);
            this.gpb_.Controls.Add(this.lbl_info5);
            this.gpb_.Controls.Add(this.lbl_out4);
            this.gpb_.Controls.Add(this.lbl_out3);
            this.gpb_.Controls.Add(this.lbl_out2);
            this.gpb_.Controls.Add(this.lbl_out1);
            this.gpb_.Controls.Add(this.lbl_info4);
            this.gpb_.Controls.Add(this.lbl_info3);
            this.gpb_.Controls.Add(this.lbl_info2);
            this.gpb_.Controls.Add(this.lbl_info1);
            this.gpb_.Location = new System.Drawing.Point(12, 59);
            this.gpb_.Name = "gpb_";
            this.gpb_.Size = new System.Drawing.Size(188, 565);
            this.gpb_.TabIndex = 7;
            this.gpb_.TabStop = false;
            this.gpb_.Text = "Utilizador:";
            this.gpb_.Visible = false;
            // 
            // lbl_out6
            // 
            this.lbl_out6.AutoSize = true;
            this.lbl_out6.Location = new System.Drawing.Point(19, 248);
            this.lbl_out6.Name = "lbl_out6";
            this.lbl_out6.Size = new System.Drawing.Size(10, 13);
            this.lbl_out6.TabIndex = 21;
            this.lbl_out6.Text = "-";
            // 
            // lbl_info6
            // 
            this.lbl_info6.AutoSize = true;
            this.lbl_info6.Location = new System.Drawing.Point(6, 235);
            this.lbl_info6.Name = "lbl_info6";
            this.lbl_info6.Size = new System.Drawing.Size(60, 13);
            this.lbl_info6.TabIndex = 20;
            this.lbl_info6.Text = "Outra Info: ";
            // 
            // lbl_out5
            // 
            this.lbl_out5.AutoSize = true;
            this.lbl_out5.Location = new System.Drawing.Point(19, 209);
            this.lbl_out5.Name = "lbl_out5";
            this.lbl_out5.Size = new System.Drawing.Size(10, 13);
            this.lbl_out5.TabIndex = 19;
            this.lbl_out5.Text = "-";
            // 
            // lbl_info5
            // 
            this.lbl_info5.AutoSize = true;
            this.lbl_info5.Location = new System.Drawing.Point(6, 196);
            this.lbl_info5.Name = "lbl_info5";
            this.lbl_info5.Size = new System.Drawing.Size(110, 13);
            this.lbl_info5.TabIndex = 17;
            this.lbl_info5.Text = "Morada do Utilizador: ";
            // 
            // lbl_out4
            // 
            this.lbl_out4.AutoSize = true;
            this.lbl_out4.Location = new System.Drawing.Point(21, 163);
            this.lbl_out4.Name = "lbl_out4";
            this.lbl_out4.Size = new System.Drawing.Size(10, 13);
            this.lbl_out4.TabIndex = 16;
            this.lbl_out4.Text = "-";
            // 
            // lbl_out3
            // 
            this.lbl_out3.AutoSize = true;
            this.lbl_out3.Location = new System.Drawing.Point(19, 124);
            this.lbl_out3.Name = "lbl_out3";
            this.lbl_out3.Size = new System.Drawing.Size(10, 13);
            this.lbl_out3.TabIndex = 15;
            this.lbl_out3.Text = "-";
            // 
            // lbl_out2
            // 
            this.lbl_out2.AutoSize = true;
            this.lbl_out2.Location = new System.Drawing.Point(21, 85);
            this.lbl_out2.Name = "lbl_out2";
            this.lbl_out2.Size = new System.Drawing.Size(10, 13);
            this.lbl_out2.TabIndex = 14;
            this.lbl_out2.Text = "-";
            // 
            // lbl_out1
            // 
            this.lbl_out1.AutoSize = true;
            this.lbl_out1.Location = new System.Drawing.Point(21, 45);
            this.lbl_out1.Name = "lbl_out1";
            this.lbl_out1.Size = new System.Drawing.Size(10, 13);
            this.lbl_out1.TabIndex = 13;
            this.lbl_out1.Text = "-";
            // 
            // lbl_info4
            // 
            this.lbl_info4.AutoSize = true;
            this.lbl_info4.Location = new System.Drawing.Point(6, 150);
            this.lbl_info4.Name = "lbl_info4";
            this.lbl_info4.Size = new System.Drawing.Size(116, 13);
            this.lbl_info4.TabIndex = 12;
            this.lbl_info4.Text = "Telefone do Utilizador: ";
            // 
            // lbl_info3
            // 
            this.lbl_info3.AutoSize = true;
            this.lbl_info3.Location = new System.Drawing.Point(6, 111);
            this.lbl_info3.Name = "lbl_info3";
            this.lbl_info3.Size = new System.Drawing.Size(171, 13);
            this.lbl_info3.TabIndex = 11;
            this.lbl_info3.Text = "Data de Nascimento do Utilizador: ";
            // 
            // lbl_info2
            // 
            this.lbl_info2.AutoSize = true;
            this.lbl_info2.Location = new System.Drawing.Point(6, 72);
            this.lbl_info2.Name = "lbl_info2";
            this.lbl_info2.Size = new System.Drawing.Size(104, 13);
            this.lbl_info2.TabIndex = 10;
            this.lbl_info2.Text = "Turma do Utilizador: ";
            // 
            // lbl_info1
            // 
            this.lbl_info1.AutoSize = true;
            this.lbl_info1.Location = new System.Drawing.Point(6, 32);
            this.lbl_info1.Name = "lbl_info1";
            this.lbl_info1.Size = new System.Drawing.Size(102, 13);
            this.lbl_info1.TabIndex = 8;
            this.lbl_info1.Text = "Nome do Utilizador: ";
            // 
            // lbltxt_lvw_ped
            // 
            this.lbltxt_lvw_ped.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltxt_lvw_ped.BackColor = System.Drawing.Color.Gray;
            this.lbltxt_lvw_ped.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbltxt_lvw_ped.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltxt_lvw_ped.ForeColor = System.Drawing.Color.White;
            this.lbltxt_lvw_ped.Location = new System.Drawing.Point(243, 27);
            this.lbltxt_lvw_ped.Name = "lbltxt_lvw_ped";
            this.lbltxt_lvw_ped.ReadOnly = true;
            this.lbltxt_lvw_ped.Size = new System.Drawing.Size(461, 26);
            this.lbltxt_lvw_ped.TabIndex = 9;
            this.lbltxt_lvw_ped.Text = "Lista de Apoios";
            this.lbltxt_lvw_ped.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtlbl_lvw_ut
            // 
            this.txtlbl_lvw_ut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtlbl_lvw_ut.BackColor = System.Drawing.Color.Gray;
            this.txtlbl_lvw_ut.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtlbl_lvw_ut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlbl_lvw_ut.ForeColor = System.Drawing.Color.White;
            this.txtlbl_lvw_ut.Location = new System.Drawing.Point(747, 27);
            this.txtlbl_lvw_ut.Name = "txtlbl_lvw_ut";
            this.txtlbl_lvw_ut.ReadOnly = true;
            this.txtlbl_lvw_ut.Size = new System.Drawing.Size(505, 26);
            this.txtlbl_lvw_ut.TabIndex = 10;
            this.txtlbl_lvw_ut.Text = "Lista de Utilizadores";
            this.txtlbl_lvw_ut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lsv_pedidos
            // 
            this.lsv_pedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsv_pedidos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.apoio_id,
            this.nome_al,
            this.nome_tut,
            this.sigla_disc,
            this.req_date,
            this.estado});
            this.lsv_pedidos.FullRowSelect = true;
            this.lsv_pedidos.HideSelection = false;
            this.lsv_pedidos.Location = new System.Drawing.Point(206, 59);
            this.lsv_pedidos.MultiSelect = false;
            this.lsv_pedidos.Name = "lsv_pedidos";
            this.lsv_pedidos.Size = new System.Drawing.Size(498, 565);
            this.lsv_pedidos.TabIndex = 2;
            this.lsv_pedidos.UseCompatibleStateImageBehavior = false;
            this.lsv_pedidos.View = System.Windows.Forms.View.Details;
            this.lsv_pedidos.SelectedIndexChanged += new System.EventHandler(this.lsv_pedidos_SelectedIndexChanged);
            this.lsv_pedidos.DoubleClick += new System.EventHandler(this.lsv_pedidos_DoubleClick);
            // 
            // apoio_id
            // 
            this.apoio_id.Text = "ID";
            this.apoio_id.Width = 30;
            // 
            // nome_al
            // 
            this.nome_al.Text = "Aluno";
            this.nome_al.Width = 115;
            // 
            // nome_tut
            // 
            this.nome_tut.Text = "Tutor";
            this.nome_tut.Width = 115;
            // 
            // sigla_disc
            // 
            this.sigla_disc.Text = "Disciplina";
            this.sigla_disc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // req_date
            // 
            this.req_date.Text = "Data do Pedido";
            this.req_date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.req_date.Width = 100;
            // 
            // estado
            // 
            this.estado.Text = "Estado";
            this.estado.Width = 75;
            // 
            // lsv_users
            // 
            this.lsv_users.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsv_users.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id_tr,
            this.nome_tr,
            this.tipo_tr,
            this.estado_tr});
            this.lsv_users.FullRowSelect = true;
            this.lsv_users.HideSelection = false;
            this.lsv_users.Location = new System.Drawing.Point(710, 59);
            this.lsv_users.MultiSelect = false;
            this.lsv_users.Name = "lsv_users";
            this.lsv_users.Size = new System.Drawing.Size(542, 565);
            this.lsv_users.TabIndex = 3;
            this.lsv_users.UseCompatibleStateImageBehavior = false;
            this.lsv_users.View = System.Windows.Forms.View.Details;
            this.lsv_users.SelectedIndexChanged += new System.EventHandler(this.lsv_users_SelectedIndexChanged);
            this.lsv_users.DoubleClick += new System.EventHandler(this.lsv_users_DoubleClick);
            // 
            // id_tr
            // 
            this.id_tr.Text = "Nome de Utilizador";
            this.id_tr.Width = 150;
            // 
            // nome_tr
            // 
            this.nome_tr.Text = "Nome";
            this.nome_tr.Width = 185;
            // 
            // tipo_tr
            // 
            this.tipo_tr.Text = "Tipo";
            this.tipo_tr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tipo_tr.Width = 100;
            // 
            // estado_tr
            // 
            this.estado_tr.Text = "Estado";
            this.estado_tr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.estado_tr.Width = 100;
            // 
            // lbl_delTip
            // 
            this.lbl_delTip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_delTip.AutoSize = true;
            this.lbl_delTip.Location = new System.Drawing.Point(203, 627);
            this.lbl_delTip.Name = "lbl_delTip";
            this.lbl_delTip.Size = new System.Drawing.Size(501, 13);
            this.lbl_delTip.TabIndex = 13;
            this.lbl_delTip.Text = "*Para eliminar um item, faça duplo clique sobre o mesmo, tanto para os utilizador" +
    "es, como para os apoios.";
            // 
            // btn_refresh_apoios
            // 
            this.btn_refresh_apoios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh_apoios.Location = new System.Drawing.Point(206, 27);
            this.btn_refresh_apoios.Name = "btn_refresh_apoios";
            this.btn_refresh_apoios.Size = new System.Drawing.Size(31, 26);
            this.btn_refresh_apoios.TabIndex = 0;
            this.btn_refresh_apoios.Text = "↺";
            this.btn_refresh_apoios.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_refresh_apoios.UseVisualStyleBackColor = true;
            this.btn_refresh_apoios.Click += new System.EventHandler(this.btn_refresh_apoios_Click);
            // 
            // btn_refresh_users
            // 
            this.btn_refresh_users.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_refresh_users.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh_users.Location = new System.Drawing.Point(710, 26);
            this.btn_refresh_users.Name = "btn_refresh_users";
            this.btn_refresh_users.Size = new System.Drawing.Size(31, 26);
            this.btn_refresh_users.TabIndex = 1;
            this.btn_refresh_users.Text = "↺";
            this.btn_refresh_users.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_refresh_users.UseVisualStyleBackColor = true;
            this.btn_refresh_users.Click += new System.EventHandler(this.btn_refresh_users_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_logout.Location = new System.Drawing.Point(1073, 644);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(179, 25);
            this.btn_logout.TabIndex = 4;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // Dashboard_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_refresh_users);
            this.Controls.Add(this.btn_refresh_apoios);
            this.Controls.Add(this.lbl_delTip);
            this.Controls.Add(this.lsv_users);
            this.Controls.Add(this.lsv_pedidos);
            this.Controls.Add(this.txtlbl_lvw_ut);
            this.Controls.Add(this.lbltxt_lvw_ped);
            this.Controls.Add(this.gpb_);
            this.Controls.Add(this.ms_admin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "Dashboard_Admin";
            this.Text = "Dashboard: Admin";
            this.Load += new System.EventHandler(this.Dashboard_Admin_Load);
            this.ms_admin.ResumeLayout(false);
            this.ms_admin.PerformLayout();
            this.gpb_.ResumeLayout(false);
            this.gpb_.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms_admin;
        private System.Windows.Forms.ToolStripMenuItem mi_alunos;
        private System.Windows.Forms.ToolStripMenuItem smi_criar;
        private System.Windows.Forms.ToolStripMenuItem smi_editar;
        private System.Windows.Forms.ToolStripMenuItem mi_apoios;
        private System.Windows.Forms.ToolStripMenuItem smi_ApCriar;
        private System.Windows.Forms.ToolStripMenuItem smi_ApEditar;
        private System.Windows.Forms.ToolStripMenuItem mi_ferr;
        private System.Windows.Forms.ToolStripMenuItem smi_tP;
        private System.Windows.Forms.ToolStripMenuItem smi_tS;
        private System.Windows.Forms.GroupBox gpb_;
        private System.Windows.Forms.Label lbl_out5;
        private System.Windows.Forms.Label lbl_info5;
        private System.Windows.Forms.Label lbl_out4;
        private System.Windows.Forms.Label lbl_out3;
        private System.Windows.Forms.Label lbl_out2;
        private System.Windows.Forms.Label lbl_out1;
        private System.Windows.Forms.Label lbl_info4;
        private System.Windows.Forms.Label lbl_info3;
        private System.Windows.Forms.Label lbl_info2;
        private System.Windows.Forms.Label lbl_info1;
        private System.Windows.Forms.TextBox lbltxt_lvw_ped;
        private System.Windows.Forms.TextBox txtlbl_lvw_ut;
        private System.Windows.Forms.ListView lsv_pedidos;
        private System.Windows.Forms.ColumnHeader nome_al;
        private System.Windows.Forms.ColumnHeader nome_tut;
        private System.Windows.Forms.ColumnHeader sigla_disc;
        private System.Windows.Forms.ColumnHeader req_date;
        private System.Windows.Forms.ColumnHeader estado;
        private System.Windows.Forms.ListView lsv_users;
        private System.Windows.Forms.ColumnHeader id_tr;
        private System.Windows.Forms.ColumnHeader nome_tr;
        private System.Windows.Forms.ColumnHeader tipo_tr;
        private System.Windows.Forms.ColumnHeader estado_tr;
        private System.Windows.Forms.Label lbl_out6;
        private System.Windows.Forms.Label lbl_info6;
        private System.Windows.Forms.Label lbl_delTip;
        private System.Windows.Forms.Button btn_refresh_apoios;
        private System.Windows.Forms.Button btn_refresh_users;
        private System.Windows.Forms.ToolStripMenuItem smi_aprovar;
        private System.Windows.Forms.ToolStripMenuItem smi_ApAprov;
        private System.Windows.Forms.ColumnHeader apoio_id;
        private System.Windows.Forms.ToolStripMenuItem smi_tU;
        private System.Windows.Forms.Button btn_logout;
    }
}