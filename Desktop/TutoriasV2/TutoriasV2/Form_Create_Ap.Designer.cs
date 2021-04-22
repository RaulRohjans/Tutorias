
namespace TutoriasV2
{
    partial class Form_Create_Ap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Create_Ap));
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.lbl_pass1 = new System.Windows.Forms.Label();
            this.ep_ = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_create = new System.Windows.Forms.Button();
            this.dtp_ = new System.Windows.Forms.DateTimePicker();
            this.txt_local = new System.Windows.Forms.TextBox();
            this.txt_tutID = new System.Windows.Forms.TextBox();
            this.lbl_dataN = new System.Windows.Forms.Label();
            this.lbl_local = new System.Windows.Forms.Label();
            this.lbl_tutID = new System.Windows.Forms.Label();
            this.txt_alID = new System.Windows.Forms.TextBox();
            this.lbl_alID = new System.Windows.Forms.Label();
            this.cbb_disc = new System.Windows.Forms.ComboBox();
            this.lbl_disc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ep_)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_desc
            // 
            this.txt_desc.Location = new System.Drawing.Point(134, 213);
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(247, 20);
            this.txt_desc.TabIndex = 5;
            // 
            // lbl_pass1
            // 
            this.lbl_pass1.AutoSize = true;
            this.lbl_pass1.Location = new System.Drawing.Point(12, 215);
            this.lbl_pass1.Name = "lbl_pass1";
            this.lbl_pass1.Size = new System.Drawing.Size(58, 13);
            this.lbl_pass1.TabIndex = 54;
            this.lbl_pass1.Text = "Descrição:";
            // 
            // ep_
            // 
            this.ep_.ContainerControl = this;
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(12, 257);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(150, 23);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(253, 257);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(150, 23);
            this.btn_create.TabIndex = 8;
            this.btn_create.Text = "Criar";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // dtp_
            // 
            this.dtp_.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_.Location = new System.Drawing.Point(134, 169);
            this.dtp_.Name = "dtp_";
            this.dtp_.Size = new System.Drawing.Size(247, 20);
            this.dtp_.TabIndex = 4;
            // 
            // txt_local
            // 
            this.txt_local.Location = new System.Drawing.Point(134, 126);
            this.txt_local.Name = "txt_local";
            this.txt_local.Size = new System.Drawing.Size(247, 20);
            this.txt_local.TabIndex = 3;
            // 
            // txt_tutID
            // 
            this.txt_tutID.Location = new System.Drawing.Point(134, 46);
            this.txt_tutID.Name = "txt_tutID";
            this.txt_tutID.Size = new System.Drawing.Size(247, 20);
            this.txt_tutID.TabIndex = 1;
            // 
            // lbl_dataN
            // 
            this.lbl_dataN.AutoSize = true;
            this.lbl_dataN.Location = new System.Drawing.Point(12, 171);
            this.lbl_dataN.Name = "lbl_dataN";
            this.lbl_dataN.Size = new System.Drawing.Size(82, 13);
            this.lbl_dataN.TabIndex = 43;
            this.lbl_dataN.Text = "Data do Apoio:*";
            // 
            // lbl_local
            // 
            this.lbl_local.AutoSize = true;
            this.lbl_local.Location = new System.Drawing.Point(12, 128);
            this.lbl_local.Name = "lbl_local";
            this.lbl_local.Size = new System.Drawing.Size(40, 13);
            this.lbl_local.TabIndex = 42;
            this.lbl_local.Text = "Local:*";
            // 
            // lbl_tutID
            // 
            this.lbl_tutID.AutoSize = true;
            this.lbl_tutID.Location = new System.Drawing.Point(12, 48);
            this.lbl_tutID.Name = "lbl_tutID";
            this.lbl_tutID.Size = new System.Drawing.Size(39, 13);
            this.lbl_tutID.TabIndex = 40;
            this.lbl_tutID.Text = "Tutor:*";
            // 
            // txt_alID
            // 
            this.txt_alID.Location = new System.Drawing.Point(134, 9);
            this.txt_alID.Name = "txt_alID";
            this.txt_alID.Size = new System.Drawing.Size(247, 20);
            this.txt_alID.TabIndex = 0;
            // 
            // lbl_alID
            // 
            this.lbl_alID.AutoSize = true;
            this.lbl_alID.Location = new System.Drawing.Point(12, 11);
            this.lbl_alID.Name = "lbl_alID";
            this.lbl_alID.Size = new System.Drawing.Size(41, 13);
            this.lbl_alID.TabIndex = 38;
            this.lbl_alID.Text = "Aluno:*";
            // 
            // cbb_disc
            // 
            this.cbb_disc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_disc.FormattingEnabled = true;
            this.cbb_disc.Location = new System.Drawing.Point(134, 84);
            this.cbb_disc.Name = "cbb_disc";
            this.cbb_disc.Size = new System.Drawing.Size(247, 21);
            this.cbb_disc.TabIndex = 2;
            // 
            // lbl_disc
            // 
            this.lbl_disc.AutoSize = true;
            this.lbl_disc.Location = new System.Drawing.Point(12, 87);
            this.lbl_disc.Name = "lbl_disc";
            this.lbl_disc.Size = new System.Drawing.Size(59, 13);
            this.lbl_disc.TabIndex = 58;
            this.lbl_disc.Text = "Disciplina:*";
            // 
            // Form_Create_Ap
            // 
            this.AcceptButton = this.btn_create;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 297);
            this.Controls.Add(this.cbb_disc);
            this.Controls.Add(this.lbl_disc);
            this.Controls.Add(this.txt_desc);
            this.Controls.Add(this.lbl_pass1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.dtp_);
            this.Controls.Add(this.txt_local);
            this.Controls.Add(this.txt_tutID);
            this.Controls.Add(this.lbl_dataN);
            this.Controls.Add(this.lbl_local);
            this.Controls.Add(this.lbl_tutID);
            this.Controls.Add(this.txt_alID);
            this.Controls.Add(this.lbl_alID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Create_Ap";
            this.Text = "Criar Apoio";
            this.Load += new System.EventHandler(this.Form_Create_Ap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ep_)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.Label lbl_pass1;
        private System.Windows.Forms.ErrorProvider ep_;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.DateTimePicker dtp_;
        private System.Windows.Forms.TextBox txt_local;
        private System.Windows.Forms.TextBox txt_tutID;
        private System.Windows.Forms.Label lbl_dataN;
        private System.Windows.Forms.Label lbl_local;
        private System.Windows.Forms.Label lbl_tutID;
        private System.Windows.Forms.TextBox txt_alID;
        private System.Windows.Forms.Label lbl_alID;
        private System.Windows.Forms.ComboBox cbb_disc;
        private System.Windows.Forms.Label lbl_disc;
    }
}