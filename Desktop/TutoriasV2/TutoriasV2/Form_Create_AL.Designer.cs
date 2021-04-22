
namespace TutoriasV2
{
    partial class Form_Create_AL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Create_AL));
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_create = new System.Windows.Forms.Button();
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
            this.ep_ = new System.Windows.Forms.ErrorProvider(this.components);
            this.txt_pass1 = new System.Windows.Forms.TextBox();
            this.lbl_pass1 = new System.Windows.Forms.Label();
            this.txt_pass2 = new System.Windows.Forms.TextBox();
            this.lbl_pass2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ep_)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(12, 400);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(150, 23);
            this.btn_cancel.TabIndex = 9;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(253, 400);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(150, 23);
            this.btn_create.TabIndex = 10;
            this.btn_create.Text = "Criar";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // dtp_
            // 
            this.dtp_.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_.Location = new System.Drawing.Point(134, 275);
            this.dtp_.Name = "dtp_";
            this.dtp_.Size = new System.Drawing.Size(247, 20);
            this.dtp_.TabIndex = 6;
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
            this.cbb_tipo.TabIndex = 8;
            // 
            // txt_morada
            // 
            this.txt_morada.Location = new System.Drawing.Point(134, 154);
            this.txt_morada.MaxLength = 50;
            this.txt_morada.Name = "txt_morada";
            this.txt_morada.Size = new System.Drawing.Size(247, 20);
            this.txt_morada.TabIndex = 3;
            // 
            // txt_turma
            // 
            this.txt_turma.Location = new System.Drawing.Point(134, 107);
            this.txt_turma.MaxLength = 50;
            this.txt_turma.Name = "txt_turma";
            this.txt_turma.Size = new System.Drawing.Size(247, 20);
            this.txt_turma.TabIndex = 2;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(134, 60);
            this.txt_nome.MaxLength = 500;
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(247, 20);
            this.txt_nome.TabIndex = 1;
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.Location = new System.Drawing.Point(12, 372);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(35, 13);
            this.lbl_tipo.TabIndex = 24;
            this.lbl_tipo.Text = "Tipo:*";
            // 
            // lbl_cont
            // 
            this.lbl_cont.AutoSize = true;
            this.lbl_cont.Location = new System.Drawing.Point(12, 324);
            this.lbl_cont.Name = "lbl_cont";
            this.lbl_cont.Size = new System.Drawing.Size(52, 13);
            this.lbl_cont.TabIndex = 23;
            this.lbl_cont.Text = "Telefone:";
            // 
            // lbl_dataN
            // 
            this.lbl_dataN.AutoSize = true;
            this.lbl_dataN.Location = new System.Drawing.Point(12, 277);
            this.lbl_dataN.Name = "lbl_dataN";
            this.lbl_dataN.Size = new System.Drawing.Size(111, 13);
            this.lbl_dataN.TabIndex = 22;
            this.lbl_dataN.Text = "Data de Nascimento:*";
            // 
            // lbl_morada
            // 
            this.lbl_morada.AutoSize = true;
            this.lbl_morada.Location = new System.Drawing.Point(12, 156);
            this.lbl_morada.Name = "lbl_morada";
            this.lbl_morada.Size = new System.Drawing.Size(46, 13);
            this.lbl_morada.TabIndex = 21;
            this.lbl_morada.Text = "Morada:";
            // 
            // lbl_turma
            // 
            this.lbl_turma.AutoSize = true;
            this.lbl_turma.Location = new System.Drawing.Point(12, 109);
            this.lbl_turma.Name = "lbl_turma";
            this.lbl_turma.Size = new System.Drawing.Size(44, 13);
            this.lbl_turma.TabIndex = 20;
            this.lbl_turma.Text = "Turma:*";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(12, 62);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(42, 13);
            this.lbl_nome.TabIndex = 19;
            this.lbl_nome.Text = "Nome:*";
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(134, 13);
            this.txt_user.MaxLength = 100;
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(247, 20);
            this.txt_user.TabIndex = 0;
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Location = new System.Drawing.Point(12, 15);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(103, 13);
            this.lbl_user.TabIndex = 17;
            this.lbl_user.Text = "Nome de Utilizador:*";
            // 
            // txt_cont
            // 
            this.txt_cont.Location = new System.Drawing.Point(134, 322);
            this.txt_cont.MaxLength = 9;
            this.txt_cont.Name = "txt_cont";
            this.txt_cont.Size = new System.Drawing.Size(247, 20);
            this.txt_cont.TabIndex = 7;
            this.txt_cont.Text = "+351";
            // 
            // ep_
            // 
            this.ep_.ContainerControl = this;
            // 
            // txt_pass1
            // 
            this.txt_pass1.Location = new System.Drawing.Point(134, 197);
            this.txt_pass1.MaxLength = 50;
            this.txt_pass1.Name = "txt_pass1";
            this.txt_pass1.PasswordChar = '*';
            this.txt_pass1.Size = new System.Drawing.Size(247, 20);
            this.txt_pass1.TabIndex = 4;
            // 
            // lbl_pass1
            // 
            this.lbl_pass1.AutoSize = true;
            this.lbl_pass1.Location = new System.Drawing.Point(12, 199);
            this.lbl_pass1.Name = "lbl_pass1";
            this.lbl_pass1.Size = new System.Drawing.Size(82, 13);
            this.lbl_pass1.TabIndex = 34;
            this.lbl_pass1.Text = "Palavra-Passe:*";
            // 
            // txt_pass2
            // 
            this.txt_pass2.Location = new System.Drawing.Point(134, 238);
            this.txt_pass2.MaxLength = 50;
            this.txt_pass2.Name = "txt_pass2";
            this.txt_pass2.PasswordChar = '*';
            this.txt_pass2.Size = new System.Drawing.Size(247, 20);
            this.txt_pass2.TabIndex = 5;
            // 
            // lbl_pass2
            // 
            this.lbl_pass2.AutoSize = true;
            this.lbl_pass2.Location = new System.Drawing.Point(12, 241);
            this.lbl_pass2.Name = "lbl_pass2";
            this.lbl_pass2.Size = new System.Drawing.Size(119, 13);
            this.lbl_pass2.TabIndex = 36;
            this.lbl_pass2.Text = "Repetir Palavra-Passe:*";
            // 
            // Form_Create_AL
            // 
            this.AcceptButton = this.btn_create;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 429);
            this.Controls.Add(this.txt_pass2);
            this.Controls.Add(this.lbl_pass2);
            this.Controls.Add(this.txt_pass1);
            this.Controls.Add(this.lbl_pass1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_create);
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
            this.MaximizeBox = false;
            this.Name = "Form_Create_AL";
            this.Text = "Criar Utilizador";
            this.Load += new System.EventHandler(this.Form_Create_AL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ep_)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_create;
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
        private System.Windows.Forms.ErrorProvider ep_;
        private System.Windows.Forms.TextBox txt_pass2;
        private System.Windows.Forms.Label lbl_pass2;
        private System.Windows.Forms.TextBox txt_pass1;
        private System.Windows.Forms.Label lbl_pass1;
    }
}