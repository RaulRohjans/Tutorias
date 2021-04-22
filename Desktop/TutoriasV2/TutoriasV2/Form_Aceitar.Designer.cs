
namespace TutoriasV2
{
    partial class Form_Aceitar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Aceitar));
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_aceitar = new System.Windows.Forms.Button();
            this.lsbc_ = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(12, 500);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(150, 23);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_aceitar
            // 
            this.btn_aceitar.Location = new System.Drawing.Point(253, 500);
            this.btn_aceitar.Name = "btn_aceitar";
            this.btn_aceitar.Size = new System.Drawing.Size(150, 23);
            this.btn_aceitar.TabIndex = 5;
            this.btn_aceitar.Text = "Aceitar";
            this.btn_aceitar.UseVisualStyleBackColor = true;
            this.btn_aceitar.Click += new System.EventHandler(this.btn_aceitar_Click);
            // 
            // lsbc_
            // 
            this.lsbc_.FormattingEnabled = true;
            this.lsbc_.Items.AddRange(new object[] {
            ""});
            this.lsbc_.Location = new System.Drawing.Point(12, 12);
            this.lsbc_.Name = "lsbc_";
            this.lsbc_.Size = new System.Drawing.Size(401, 469);
            this.lsbc_.TabIndex = 3;
            // 
            // Form_Aceitar
            // 
            this.AcceptButton = this.btn_aceitar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 535);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_aceitar);
            this.Controls.Add(this.lsbc_);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Aceitar";
            this.Text = "Aceitar Pedido de Apoio";
            this.Load += new System.EventHandler(this.Form_Aceitar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_aceitar;
        private System.Windows.Forms.CheckedListBox lsbc_;
    }
}