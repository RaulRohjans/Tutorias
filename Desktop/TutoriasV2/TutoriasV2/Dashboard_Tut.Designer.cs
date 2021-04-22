
namespace TutoriasV2
{
    partial class Dashboard_Tut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard_Tut));
            this.local = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.smi_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.smi_logout = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_apoios = new System.Windows.Forms.ToolStripMenuItem();
            this.smi_ApPedir = new System.Windows.Forms.ToolStripMenuItem();
            this.smi_ApHist = new System.Windows.Forms.ToolStripMenuItem();
            this.smi_ApCanc = new System.Windows.Forms.ToolStripMenuItem();
            this.smi_ApAcei = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_al = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_info4 = new System.Windows.Forms.Label();
            this.lbl_info3 = new System.Windows.Forms.Label();
            this.lbl_info2 = new System.Windows.Forms.Label();
            this.lbl_info1 = new System.Windows.Forms.Label();
            this.Desc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsv_pedidos = new System.Windows.Forms.ListView();
            this.apoio_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nome_al = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nome_tut = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sigla_disc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.req_date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.estado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbltxt_lvw_ped = new System.Windows.Forms.TextBox();
            this.btn_refresh_apoios = new System.Windows.Forms.Button();
            this.lbl_out1 = new System.Windows.Forms.Label();
            this.lbl_info6 = new System.Windows.Forms.Label();
            this.lbl_out5 = new System.Windows.Forms.Label();
            this.lbl_info5 = new System.Windows.Forms.Label();
            this.gpb_ = new System.Windows.Forms.GroupBox();
            this.lbl_out6 = new System.Windows.Forms.Label();
            this.lbl_out4 = new System.Windows.Forms.Label();
            this.lbl_out3 = new System.Windows.Forms.Label();
            this.lbl_out2 = new System.Windows.Forms.Label();
            this.ms_admin = new System.Windows.Forms.MenuStrip();
            this.gpb_.SuspendLayout();
            this.ms_admin.SuspendLayout();
            this.SuspendLayout();
            // 
            // local
            // 
            this.local.Text = "Local";
            this.local.Width = 100;
            // 
            // smi_edit
            // 
            this.smi_edit.Name = "smi_edit";
            this.smi_edit.Size = new System.Drawing.Size(134, 22);
            this.smi_edit.Text = "Editar Perfil";
            this.smi_edit.Click += new System.EventHandler(this.smi_edit_Click);
            // 
            // smi_logout
            // 
            this.smi_logout.Name = "smi_logout";
            this.smi_logout.Size = new System.Drawing.Size(134, 22);
            this.smi_logout.Text = "Logout";
            this.smi_logout.Click += new System.EventHandler(this.smi_logout_Click);
            // 
            // mi_apoios
            // 
            this.mi_apoios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smi_ApPedir,
            this.smi_ApHist,
            this.smi_ApCanc,
            this.smi_ApAcei});
            this.mi_apoios.Name = "mi_apoios";
            this.mi_apoios.Size = new System.Drawing.Size(56, 20);
            this.mi_apoios.Text = "Apoios";
            // 
            // smi_ApPedir
            // 
            this.smi_ApPedir.Name = "smi_ApPedir";
            this.smi_ApPedir.Size = new System.Drawing.Size(163, 22);
            this.smi_ApPedir.Text = "Pedir";
            this.smi_ApPedir.Click += new System.EventHandler(this.smi_ApPedir_Click);
            // 
            // smi_ApHist
            // 
            this.smi_ApHist.Name = "smi_ApHist";
            this.smi_ApHist.Size = new System.Drawing.Size(163, 22);
            this.smi_ApHist.Text = "Histórico/Avaliar";
            this.smi_ApHist.Click += new System.EventHandler(this.smi_ApHist_Click);
            // 
            // smi_ApCanc
            // 
            this.smi_ApCanc.Name = "smi_ApCanc";
            this.smi_ApCanc.Size = new System.Drawing.Size(163, 22);
            this.smi_ApCanc.Text = "Anular";
            this.smi_ApCanc.Click += new System.EventHandler(this.smi_ApCanc_Click);
            // 
            // smi_ApAcei
            // 
            this.smi_ApAcei.Name = "smi_ApAcei";
            this.smi_ApAcei.Size = new System.Drawing.Size(163, 22);
            this.smi_ApAcei.Text = "Aceitar";
            this.smi_ApAcei.Click += new System.EventHandler(this.smi_ApAcei_Click);
            // 
            // mi_al
            // 
            this.mi_al.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smi_edit,
            this.smi_logout});
            this.mi_al.Name = "mi_al";
            this.mi_al.Size = new System.Drawing.Size(51, 20);
            this.mi_al.Text = "Aluno";
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
            // Desc
            // 
            this.Desc.Text = "Descrição";
            this.Desc.Width = 445;
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
            this.estado,
            this.local,
            this.Desc});
            this.lsv_pedidos.FullRowSelect = true;
            this.lsv_pedidos.HideSelection = false;
            this.lsv_pedidos.Location = new System.Drawing.Point(206, 64);
            this.lsv_pedidos.MultiSelect = false;
            this.lsv_pedidos.Name = "lsv_pedidos";
            this.lsv_pedidos.Size = new System.Drawing.Size(1046, 565);
            this.lsv_pedidos.TabIndex = 26;
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
            // lbltxt_lvw_ped
            // 
            this.lbltxt_lvw_ped.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltxt_lvw_ped.BackColor = System.Drawing.Color.Gray;
            this.lbltxt_lvw_ped.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbltxt_lvw_ped.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltxt_lvw_ped.ForeColor = System.Drawing.Color.White;
            this.lbltxt_lvw_ped.Location = new System.Drawing.Point(243, 32);
            this.lbltxt_lvw_ped.Name = "lbltxt_lvw_ped";
            this.lbltxt_lvw_ped.ReadOnly = true;
            this.lbltxt_lvw_ped.Size = new System.Drawing.Size(1009, 26);
            this.lbltxt_lvw_ped.TabIndex = 28;
            this.lbltxt_lvw_ped.Text = "Lista de Apoios Por Completar";
            this.lbltxt_lvw_ped.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_refresh_apoios
            // 
            this.btn_refresh_apoios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh_apoios.Location = new System.Drawing.Point(206, 32);
            this.btn_refresh_apoios.Name = "btn_refresh_apoios";
            this.btn_refresh_apoios.Size = new System.Drawing.Size(31, 26);
            this.btn_refresh_apoios.TabIndex = 24;
            this.btn_refresh_apoios.Text = "↺";
            this.btn_refresh_apoios.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_refresh_apoios.UseVisualStyleBackColor = true;
            this.btn_refresh_apoios.Click += new System.EventHandler(this.btn_refresh_apoios_Click);
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
            this.gpb_.Location = new System.Drawing.Point(12, 64);
            this.gpb_.Name = "gpb_";
            this.gpb_.Size = new System.Drawing.Size(188, 565);
            this.gpb_.TabIndex = 27;
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
            // ms_admin
            // 
            this.ms_admin.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ms_admin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_al,
            this.mi_apoios});
            this.ms_admin.Location = new System.Drawing.Point(0, 0);
            this.ms_admin.Name = "ms_admin";
            this.ms_admin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ms_admin.Size = new System.Drawing.Size(1264, 24);
            this.ms_admin.TabIndex = 25;
            this.ms_admin.Text = "Menu";
            // 
            // Dashboard_Tut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.lsv_pedidos);
            this.Controls.Add(this.lbltxt_lvw_ped);
            this.Controls.Add(this.btn_refresh_apoios);
            this.Controls.Add(this.gpb_);
            this.Controls.Add(this.ms_admin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "Dashboard_Tut";
            this.Text = "Dashboard: Tutor";
            this.Load += new System.EventHandler(this.Dashboard_Tut_Load);
            this.gpb_.ResumeLayout(false);
            this.gpb_.PerformLayout();
            this.ms_admin.ResumeLayout(false);
            this.ms_admin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader local;
        private System.Windows.Forms.ToolStripMenuItem smi_edit;
        private System.Windows.Forms.ToolStripMenuItem smi_logout;
        private System.Windows.Forms.ToolStripMenuItem mi_apoios;
        private System.Windows.Forms.ToolStripMenuItem smi_ApPedir;
        private System.Windows.Forms.ToolStripMenuItem smi_ApHist;
        private System.Windows.Forms.ToolStripMenuItem smi_ApCanc;
        private System.Windows.Forms.ToolStripMenuItem mi_al;
        private System.Windows.Forms.Label lbl_info4;
        private System.Windows.Forms.Label lbl_info3;
        private System.Windows.Forms.Label lbl_info2;
        private System.Windows.Forms.Label lbl_info1;
        private System.Windows.Forms.ColumnHeader Desc;
        private System.Windows.Forms.ListView lsv_pedidos;
        private System.Windows.Forms.ColumnHeader apoio_id;
        private System.Windows.Forms.ColumnHeader nome_al;
        private System.Windows.Forms.ColumnHeader nome_tut;
        private System.Windows.Forms.ColumnHeader sigla_disc;
        private System.Windows.Forms.ColumnHeader req_date;
        private System.Windows.Forms.ColumnHeader estado;
        private System.Windows.Forms.TextBox lbltxt_lvw_ped;
        private System.Windows.Forms.Button btn_refresh_apoios;
        private System.Windows.Forms.Label lbl_out1;
        private System.Windows.Forms.Label lbl_info6;
        private System.Windows.Forms.Label lbl_out5;
        private System.Windows.Forms.Label lbl_info5;
        private System.Windows.Forms.GroupBox gpb_;
        private System.Windows.Forms.Label lbl_out6;
        private System.Windows.Forms.Label lbl_out4;
        private System.Windows.Forms.Label lbl_out3;
        private System.Windows.Forms.Label lbl_out2;
        private System.Windows.Forms.MenuStrip ms_admin;
        private System.Windows.Forms.ToolStripMenuItem smi_ApAcei;
    }
}