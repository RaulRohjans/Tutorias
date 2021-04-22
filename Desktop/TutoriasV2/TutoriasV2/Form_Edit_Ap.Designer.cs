
namespace TutoriasV2
{
    partial class Form_Edit_Ap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Edit_Ap));
            this.lbl_div = new System.Windows.Forms.Label();
            this.btn_fetch = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.txt_apoio = new System.Windows.Forms.TextBox();
            this.lbl_apoio = new System.Windows.Forms.Label();
            this.ep_ = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbb_disc = new System.Windows.Forms.ComboBox();
            this.lbl_disc = new System.Windows.Forms.Label();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.lbl_pass1 = new System.Windows.Forms.Label();
            this.dtp_ = new System.Windows.Forms.DateTimePicker();
            this.txt_local = new System.Windows.Forms.TextBox();
            this.txt_tutID = new System.Windows.Forms.TextBox();
            this.lbl_dataN = new System.Windows.Forms.Label();
            this.lbl_local = new System.Windows.Forms.Label();
            this.lbl_tutID = new System.Windows.Forms.Label();
            this.txt_alID = new System.Windows.Forms.TextBox();
            this.lbl_alID = new System.Windows.Forms.Label();
            this.txt_aval = new System.Windows.Forms.TextBox();
            this.lbl_aval = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ep_)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_div
            // 
            this.lbl_div.AutoSize = true;
            this.lbl_div.Location = new System.Drawing.Point(7, 101);
            this.lbl_div.Name = "lbl_div";
            this.lbl_div.Size = new System.Drawing.Size(400, 13);
            this.lbl_div.TabIndex = 81;
            this.lbl_div.Text = "---------------------------------------------------------------------------------" +
    "--------------------------------------------------";
            // 
            // btn_fetch
            // 
            this.btn_fetch.Location = new System.Drawing.Point(10, 57);
            this.btn_fetch.Name = "btn_fetch";
            this.btn_fetch.Size = new System.Drawing.Size(150, 23);
            this.btn_fetch.TabIndex = 1;
            this.btn_fetch.Text = "Buscar Dados";
            this.btn_fetch.UseVisualStyleBackColor = true;
            this.btn_fetch.Click += new System.EventHandler(this.btn_fetch_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(12, 425);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(150, 23);
            this.btn_cancel.TabIndex = 9;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(253, 425);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(150, 23);
            this.btn_edit.TabIndex = 10;
            this.btn_edit.Text = "Editar";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // txt_apoio
            // 
            this.txt_apoio.Location = new System.Drawing.Point(132, 13);
            this.txt_apoio.Name = "txt_apoio";
            this.txt_apoio.Size = new System.Drawing.Size(247, 20);
            this.txt_apoio.TabIndex = 0;
            // 
            // lbl_apoio
            // 
            this.lbl_apoio.AutoSize = true;
            this.lbl_apoio.Location = new System.Drawing.Point(10, 15);
            this.lbl_apoio.Name = "lbl_apoio";
            this.lbl_apoio.Size = new System.Drawing.Size(70, 13);
            this.lbl_apoio.TabIndex = 64;
            this.lbl_apoio.Text = "ID do Apoio:*";
            // 
            // ep_
            // 
            this.ep_.ContainerControl = this;
            // 
            // cbb_disc
            // 
            this.cbb_disc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_disc.FormattingEnabled = true;
            this.cbb_disc.Location = new System.Drawing.Point(132, 206);
            this.cbb_disc.Name = "cbb_disc";
            this.cbb_disc.Size = new System.Drawing.Size(247, 21);
            this.cbb_disc.TabIndex = 4;
            // 
            // lbl_disc
            // 
            this.lbl_disc.AutoSize = true;
            this.lbl_disc.Location = new System.Drawing.Point(10, 209);
            this.lbl_disc.Name = "lbl_disc";
            this.lbl_disc.Size = new System.Drawing.Size(59, 13);
            this.lbl_disc.TabIndex = 92;
            this.lbl_disc.Text = "Disciplina:*";
            // 
            // txt_desc
            // 
            this.txt_desc.Location = new System.Drawing.Point(132, 335);
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(247, 20);
            this.txt_desc.TabIndex = 7;
            // 
            // lbl_pass1
            // 
            this.lbl_pass1.AutoSize = true;
            this.lbl_pass1.Location = new System.Drawing.Point(10, 337);
            this.lbl_pass1.Name = "lbl_pass1";
            this.lbl_pass1.Size = new System.Drawing.Size(58, 13);
            this.lbl_pass1.TabIndex = 90;
            this.lbl_pass1.Text = "Descrição:";
            // 
            // dtp_
            // 
            this.dtp_.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_.Location = new System.Drawing.Point(132, 291);
            this.dtp_.Name = "dtp_";
            this.dtp_.Size = new System.Drawing.Size(247, 20);
            this.dtp_.TabIndex = 6;
            // 
            // txt_local
            // 
            this.txt_local.Location = new System.Drawing.Point(132, 248);
            this.txt_local.Name = "txt_local";
            this.txt_local.Size = new System.Drawing.Size(247, 20);
            this.txt_local.TabIndex = 5;
            // 
            // txt_tutID
            // 
            this.txt_tutID.Location = new System.Drawing.Point(132, 168);
            this.txt_tutID.Name = "txt_tutID";
            this.txt_tutID.Size = new System.Drawing.Size(247, 20);
            this.txt_tutID.TabIndex = 3;
            // 
            // lbl_dataN
            // 
            this.lbl_dataN.AutoSize = true;
            this.lbl_dataN.Location = new System.Drawing.Point(10, 293);
            this.lbl_dataN.Name = "lbl_dataN";
            this.lbl_dataN.Size = new System.Drawing.Size(82, 13);
            this.lbl_dataN.TabIndex = 86;
            this.lbl_dataN.Text = "Data do Apoio:*";
            // 
            // lbl_local
            // 
            this.lbl_local.AutoSize = true;
            this.lbl_local.Location = new System.Drawing.Point(10, 250);
            this.lbl_local.Name = "lbl_local";
            this.lbl_local.Size = new System.Drawing.Size(40, 13);
            this.lbl_local.TabIndex = 85;
            this.lbl_local.Text = "Local:*";
            // 
            // lbl_tutID
            // 
            this.lbl_tutID.AutoSize = true;
            this.lbl_tutID.Location = new System.Drawing.Point(10, 170);
            this.lbl_tutID.Name = "lbl_tutID";
            this.lbl_tutID.Size = new System.Drawing.Size(39, 13);
            this.lbl_tutID.TabIndex = 84;
            this.lbl_tutID.Text = "Tutor:*";
            // 
            // txt_alID
            // 
            this.txt_alID.Location = new System.Drawing.Point(132, 131);
            this.txt_alID.Name = "txt_alID";
            this.txt_alID.Size = new System.Drawing.Size(247, 20);
            this.txt_alID.TabIndex = 2;
            // 
            // lbl_alID
            // 
            this.lbl_alID.AutoSize = true;
            this.lbl_alID.Location = new System.Drawing.Point(10, 133);
            this.lbl_alID.Name = "lbl_alID";
            this.lbl_alID.Size = new System.Drawing.Size(41, 13);
            this.lbl_alID.TabIndex = 82;
            this.lbl_alID.Text = "Aluno:*";
            // 
            // txt_aval
            // 
            this.txt_aval.Location = new System.Drawing.Point(132, 382);
            this.txt_aval.Name = "txt_aval";
            this.txt_aval.Size = new System.Drawing.Size(247, 20);
            this.txt_aval.TabIndex = 8;
            // 
            // lbl_aval
            // 
            this.lbl_aval.AutoSize = true;
            this.lbl_aval.Location = new System.Drawing.Point(10, 384);
            this.lbl_aval.Name = "lbl_aval";
            this.lbl_aval.Size = new System.Drawing.Size(57, 13);
            this.lbl_aval.TabIndex = 94;
            this.lbl_aval.Text = "Avaliação:";
            // 
            // Form_Edit_Ap
            // 
            this.AcceptButton = this.btn_edit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 458);
            this.Controls.Add(this.txt_aval);
            this.Controls.Add(this.lbl_aval);
            this.Controls.Add(this.cbb_disc);
            this.Controls.Add(this.lbl_disc);
            this.Controls.Add(this.txt_desc);
            this.Controls.Add(this.lbl_pass1);
            this.Controls.Add(this.dtp_);
            this.Controls.Add(this.txt_local);
            this.Controls.Add(this.txt_tutID);
            this.Controls.Add(this.lbl_dataN);
            this.Controls.Add(this.lbl_local);
            this.Controls.Add(this.lbl_tutID);
            this.Controls.Add(this.txt_alID);
            this.Controls.Add(this.lbl_alID);
            this.Controls.Add(this.lbl_div);
            this.Controls.Add(this.btn_fetch);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.txt_apoio);
            this.Controls.Add(this.lbl_apoio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Edit_Ap";
            this.Text = "Editar Apoio";
            this.Load += new System.EventHandler(this.Form_Edit_Ap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ep_)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_div;
        private System.Windows.Forms.Button btn_fetch;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.TextBox txt_apoio;
        private System.Windows.Forms.Label lbl_apoio;
        private System.Windows.Forms.ErrorProvider ep_;
        private System.Windows.Forms.TextBox txt_aval;
        private System.Windows.Forms.Label lbl_aval;
        private System.Windows.Forms.ComboBox cbb_disc;
        private System.Windows.Forms.Label lbl_disc;
        private System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.Label lbl_pass1;
        private System.Windows.Forms.DateTimePicker dtp_;
        private System.Windows.Forms.TextBox txt_local;
        private System.Windows.Forms.TextBox txt_tutID;
        private System.Windows.Forms.Label lbl_dataN;
        private System.Windows.Forms.Label lbl_local;
        private System.Windows.Forms.Label lbl_tutID;
        private System.Windows.Forms.TextBox txt_alID;
        private System.Windows.Forms.Label lbl_alID;
    }
}