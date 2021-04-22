
namespace TutoriasV2
{
    partial class Form_Edit_Al
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Edit_Al));
            this.ep_ = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.dtp_ = new System.Windows.Forms.DateTimePicker();
            this.cbb_tipo = new System.Windows.Forms.ComboBox();
            this.txt_morada = new System.Windows.Forms.TextBox();
            this.txt_turma = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.lbl_cont = new System.Windows.Forms.Label();
            this.lbl_dataN = new System.Windows.Forms.Label();
            this.lbl_morada = new System.Windows.Forms.Label();
            this.lbl_turma = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.lbl_user = new System.Windows.Forms.Label();
            this.txt_cont = new System.Windows.Forms.TextBox();
            this.btn_fetch = new System.Windows.Forms.Button();
            this.lbl_div = new System.Windows.Forms.Label();
            this.lbl_passNova = new System.Windows.Forms.Label();
            this.txt_passNova = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ep_)).BeginInit();
            this.SuspendLayout();
            // 
            // ep_
            // 
            this.ep_.ContainerControl = this;
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(12, 450);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(150, 23);
            this.btn_cancel.TabIndex = 10;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(253, 450);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(150, 23);
            this.btn_edit.TabIndex = 11;
            this.btn_edit.Text = "Editar";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // dtp_
            // 
            this.dtp_.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_.Location = new System.Drawing.Point(134, 275);
            this.dtp_.Name = "dtp_";
            this.dtp_.Size = new System.Drawing.Size(247, 20);
            this.dtp_.TabIndex = 5;
            // 
            // cbb_tipo
            // 
            this.cbb_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_tipo.FormattingEnabled = true;
            this.cbb_tipo.Items.AddRange(new object[] {
            "Aluno",
            "Tutor",
            "Admin"});
            this.cbb_tipo.Location = new System.Drawing.Point(134, 369);
            this.cbb_tipo.Name = "cbb_tipo";
            this.cbb_tipo.Size = new System.Drawing.Size(247, 21);
            this.cbb_tipo.TabIndex = 7;
            // 
            // txt_morada
            // 
            this.txt_morada.Location = new System.Drawing.Point(134, 237);
            this.txt_morada.Name = "txt_morada";
            this.txt_morada.Size = new System.Drawing.Size(247, 20);
            this.txt_morada.TabIndex = 4;
            // 
            // txt_turma
            // 
            this.txt_turma.Location = new System.Drawing.Point(134, 190);
            this.txt_turma.Name = "txt_turma";
            this.txt_turma.Size = new System.Drawing.Size(247, 20);
            this.txt_turma.TabIndex = 3;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(134, 143);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(247, 20);
            this.txt_nome.TabIndex = 2;
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.Location = new System.Drawing.Point(12, 372);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(35, 13);
            this.lbl_tipo.TabIndex = 45;
            this.lbl_tipo.Text = "Tipo:*";
            // 
            // lbl_cont
            // 
            this.lbl_cont.AutoSize = true;
            this.lbl_cont.Location = new System.Drawing.Point(12, 324);
            this.lbl_cont.Name = "lbl_cont";
            this.lbl_cont.Size = new System.Drawing.Size(52, 13);
            this.lbl_cont.TabIndex = 44;
            this.lbl_cont.Text = "Telefone:";
            // 
            // lbl_dataN
            // 
            this.lbl_dataN.AutoSize = true;
            this.lbl_dataN.Location = new System.Drawing.Point(12, 277);
            this.lbl_dataN.Name = "lbl_dataN";
            this.lbl_dataN.Size = new System.Drawing.Size(111, 13);
            this.lbl_dataN.TabIndex = 43;
            this.lbl_dataN.Text = "Data de Nascimento:*";
            // 
            // lbl_morada
            // 
            this.lbl_morada.AutoSize = true;
            this.lbl_morada.Location = new System.Drawing.Point(12, 239);
            this.lbl_morada.Name = "lbl_morada";
            this.lbl_morada.Size = new System.Drawing.Size(46, 13);
            this.lbl_morada.TabIndex = 42;
            this.lbl_morada.Text = "Morada:";
            // 
            // lbl_turma
            // 
            this.lbl_turma.AutoSize = true;
            this.lbl_turma.Location = new System.Drawing.Point(12, 192);
            this.lbl_turma.Name = "lbl_turma";
            this.lbl_turma.Size = new System.Drawing.Size(44, 13);
            this.lbl_turma.TabIndex = 41;
            this.lbl_turma.Text = "Turma:*";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(12, 145);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(42, 13);
            this.lbl_nome.TabIndex = 40;
            this.lbl_nome.Text = "Nome:*";
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(134, 12);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(247, 20);
            this.txt_user.TabIndex = 0;
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Location = new System.Drawing.Point(12, 14);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(103, 13);
            this.lbl_user.TabIndex = 38;
            this.lbl_user.Text = "Nome de Utilizador:*";
            // 
            // txt_cont
            // 
            this.txt_cont.Location = new System.Drawing.Point(134, 322);
            this.txt_cont.Name = "txt_cont";
            this.txt_cont.Size = new System.Drawing.Size(247, 20);
            this.txt_cont.TabIndex = 6;
            this.txt_cont.Text = "+351";
            // 
            // btn_fetch
            // 
            this.btn_fetch.Location = new System.Drawing.Point(12, 56);
            this.btn_fetch.Name = "btn_fetch";
            this.btn_fetch.Size = new System.Drawing.Size(150, 23);
            this.btn_fetch.TabIndex = 1;
            this.btn_fetch.Text = "Buscar Dados";
            this.btn_fetch.UseVisualStyleBackColor = true;
            this.btn_fetch.Click += new System.EventHandler(this.btn_fetch_Click);
            // 
            // lbl_div
            // 
            this.lbl_div.AutoSize = true;
            this.lbl_div.Location = new System.Drawing.Point(9, 103);
            this.lbl_div.Name = "lbl_div";
            this.lbl_div.Size = new System.Drawing.Size(400, 13);
            this.lbl_div.TabIndex = 59;
            this.lbl_div.Text = "---------------------------------------------------------------------------------" +
    "--------------------------------------------------";
            // 
            // lbl_passNova
            // 
            this.lbl_passNova.AutoSize = true;
            this.lbl_passNova.Location = new System.Drawing.Point(12, 416);
            this.lbl_passNova.Name = "lbl_passNova";
            this.lbl_passNova.Size = new System.Drawing.Size(107, 13);
            this.lbl_passNova.TabIndex = 62;
            this.lbl_passNova.Text = "Palavra-Passe Nova:";
            // 
            // txt_passNova
            // 
            this.txt_passNova.Location = new System.Drawing.Point(134, 413);
            this.txt_passNova.Name = "txt_passNova";
            this.txt_passNova.PasswordChar = '*';
            this.txt_passNova.Size = new System.Drawing.Size(247, 20);
            this.txt_passNova.TabIndex = 9;
            // 
            // Form_Edit_Al
            // 
            this.AcceptButton = this.btn_edit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 485);
            this.Controls.Add(this.lbl_passNova);
            this.Controls.Add(this.txt_passNova);
            this.Controls.Add(this.lbl_div);
            this.Controls.Add(this.btn_fetch);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.dtp_);
            this.Controls.Add(this.cbb_tipo);
            this.Controls.Add(this.txt_morada);
            this.Controls.Add(this.txt_turma);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_tipo);
            this.Controls.Add(this.lbl_cont);
            this.Controls.Add(this.lbl_dataN);
            this.Controls.Add(this.lbl_morada);
            this.Controls.Add(this.lbl_turma);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.txt_cont);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Edit_Al";
            this.Text = "Editar Utilizador";
            this.Load += new System.EventHandler(this.Form_Edit_Al_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ep_)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider ep_;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.DateTimePicker dtp_;
        private System.Windows.Forms.ComboBox cbb_tipo;
        private System.Windows.Forms.TextBox txt_morada;
        private System.Windows.Forms.TextBox txt_turma;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.Label lbl_cont;
        private System.Windows.Forms.Label lbl_dataN;
        private System.Windows.Forms.Label lbl_morada;
        private System.Windows.Forms.Label lbl_turma;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.TextBox txt_cont;
        private System.Windows.Forms.Label lbl_div;
        private System.Windows.Forms.Button btn_fetch;
        private System.Windows.Forms.Label lbl_passNova;
        private System.Windows.Forms.TextBox txt_passNova;
    }
}