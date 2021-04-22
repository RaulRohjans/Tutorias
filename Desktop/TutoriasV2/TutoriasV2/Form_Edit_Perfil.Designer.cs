
namespace TutoriasV2
{
    partial class Form_Edit_Perfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Edit_Perfil));
            this.lbl_passNova = new System.Windows.Forms.Label();
            this.txt_passNova = new System.Windows.Forms.TextBox();
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
            this.txt_cont = new System.Windows.Forms.TextBox();
            this.ep_ = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbl_pass = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ep_)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_passNova
            // 
            this.lbl_passNova.AutoSize = true;
            this.lbl_passNova.Location = new System.Drawing.Point(15, 322);
            this.lbl_passNova.Name = "lbl_passNova";
            this.lbl_passNova.Size = new System.Drawing.Size(107, 13);
            this.lbl_passNova.TabIndex = 78;
            this.lbl_passNova.Text = "Palavra-Passe Nova:";
            // 
            // txt_passNova
            // 
            this.txt_passNova.Location = new System.Drawing.Point(137, 319);
            this.txt_passNova.Name = "txt_passNova";
            this.txt_passNova.PasswordChar = '*';
            this.txt_passNova.Size = new System.Drawing.Size(247, 20);
            this.txt_passNova.TabIndex = 7;
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(12, 355);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(150, 23);
            this.btn_cancel.TabIndex = 8;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(253, 355);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(150, 23);
            this.btn_edit.TabIndex = 9;
            this.btn_edit.Text = "Editar";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // dtp_
            // 
            this.dtp_.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_.Location = new System.Drawing.Point(137, 149);
            this.dtp_.Name = "dtp_";
            this.dtp_.Size = new System.Drawing.Size(247, 20);
            this.dtp_.TabIndex = 3;
            // 
            // cbb_tipo
            // 
            this.cbb_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_tipo.FormattingEnabled = true;
            this.cbb_tipo.Items.AddRange(new object[] {
            "Aluno",
            "Tutor"});
            this.cbb_tipo.Location = new System.Drawing.Point(137, 243);
            this.cbb_tipo.Name = "cbb_tipo";
            this.cbb_tipo.Size = new System.Drawing.Size(247, 21);
            this.cbb_tipo.TabIndex = 5;
            // 
            // txt_morada
            // 
            this.txt_morada.Location = new System.Drawing.Point(137, 111);
            this.txt_morada.Name = "txt_morada";
            this.txt_morada.Size = new System.Drawing.Size(247, 20);
            this.txt_morada.TabIndex = 2;
            // 
            // txt_turma
            // 
            this.txt_turma.Location = new System.Drawing.Point(137, 64);
            this.txt_turma.Name = "txt_turma";
            this.txt_turma.Size = new System.Drawing.Size(247, 20);
            this.txt_turma.TabIndex = 1;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(137, 17);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(247, 20);
            this.txt_nome.TabIndex = 0;
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.Location = new System.Drawing.Point(15, 246);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(35, 13);
            this.lbl_tipo.TabIndex = 77;
            this.lbl_tipo.Text = "Tipo:*";
            // 
            // lbl_cont
            // 
            this.lbl_cont.AutoSize = true;
            this.lbl_cont.Location = new System.Drawing.Point(15, 198);
            this.lbl_cont.Name = "lbl_cont";
            this.lbl_cont.Size = new System.Drawing.Size(52, 13);
            this.lbl_cont.TabIndex = 76;
            this.lbl_cont.Text = "Telefone:";
            // 
            // lbl_dataN
            // 
            this.lbl_dataN.AutoSize = true;
            this.lbl_dataN.Location = new System.Drawing.Point(15, 151);
            this.lbl_dataN.Name = "lbl_dataN";
            this.lbl_dataN.Size = new System.Drawing.Size(111, 13);
            this.lbl_dataN.TabIndex = 75;
            this.lbl_dataN.Text = "Data de Nascimento:*";
            // 
            // lbl_morada
            // 
            this.lbl_morada.AutoSize = true;
            this.lbl_morada.Location = new System.Drawing.Point(15, 113);
            this.lbl_morada.Name = "lbl_morada";
            this.lbl_morada.Size = new System.Drawing.Size(46, 13);
            this.lbl_morada.TabIndex = 74;
            this.lbl_morada.Text = "Morada:";
            // 
            // lbl_turma
            // 
            this.lbl_turma.AutoSize = true;
            this.lbl_turma.Location = new System.Drawing.Point(15, 66);
            this.lbl_turma.Name = "lbl_turma";
            this.lbl_turma.Size = new System.Drawing.Size(44, 13);
            this.lbl_turma.TabIndex = 73;
            this.lbl_turma.Text = "Turma:*";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(15, 19);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(42, 13);
            this.lbl_nome.TabIndex = 72;
            this.lbl_nome.Text = "Nome:*";
            // 
            // txt_cont
            // 
            this.txt_cont.Location = new System.Drawing.Point(137, 196);
            this.txt_cont.Name = "txt_cont";
            this.txt_cont.Size = new System.Drawing.Size(247, 20);
            this.txt_cont.TabIndex = 4;
            this.txt_cont.Text = "+351";
            // 
            // ep_
            // 
            this.ep_.ContainerControl = this;
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Location = new System.Drawing.Point(15, 287);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(109, 13);
            this.lbl_pass.TabIndex = 80;
            this.lbl_pass.Text = "Palavra-Passe Atual:*";
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(137, 284);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(247, 20);
            this.txt_pass.TabIndex = 6;
            // 
            // Form_Edit_Perfil
            // 
            this.AcceptButton = this.btn_edit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 390);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.lbl_passNova);
            this.Controls.Add(this.txt_passNova);
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
            this.Controls.Add(this.txt_cont);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Edit_Perfil";
            this.Text = "Editar Perfil";
            this.Load += new System.EventHandler(this.Form_Edit_Perfil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ep_)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_passNova;
        private System.Windows.Forms.TextBox txt_passNova;
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
        private System.Windows.Forms.TextBox txt_cont;
        private System.Windows.Forms.ErrorProvider ep_;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.TextBox txt_pass;
    }
}