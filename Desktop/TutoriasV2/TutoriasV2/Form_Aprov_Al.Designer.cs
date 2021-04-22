
namespace TutoriasV2
{
    partial class Form_Aprov_Al
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Aprov_Al));
            this.lsbc_ = new System.Windows.Forms.CheckedListBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_Aprovar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsbc_
            // 
            this.lsbc_.FormattingEnabled = true;
            this.lsbc_.Items.AddRange(new object[] {
            ""});
            this.lsbc_.Location = new System.Drawing.Point(12, 12);
            this.lsbc_.Name = "lsbc_";
            this.lsbc_.Size = new System.Drawing.Size(401, 469);
            this.lsbc_.TabIndex = 0;
            this.lsbc_.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lsbc__ItemCheck);
            this.lsbc_.SelectedIndexChanged += new System.EventHandler(this.lsbc__SelectedIndexChanged);
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(12, 500);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(150, 23);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_Aprovar
            // 
            this.btn_Aprovar.Location = new System.Drawing.Point(253, 500);
            this.btn_Aprovar.Name = "btn_Aprovar";
            this.btn_Aprovar.Size = new System.Drawing.Size(150, 23);
            this.btn_Aprovar.TabIndex = 2;
            this.btn_Aprovar.Text = "Aprovar/Desaprovar";
            this.btn_Aprovar.UseVisualStyleBackColor = true;
            this.btn_Aprovar.Click += new System.EventHandler(this.btn_Aprovar_Click);
            // 
            // Form_Aprov_Al
            // 
            this.AcceptButton = this.btn_Aprovar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 535);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_Aprovar);
            this.Controls.Add(this.lsbc_);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Aprov_Al";
            this.Text = "Aprovar Utilizador";
            this.Load += new System.EventHandler(this.Form_Aprov_Al_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox lsbc_;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_Aprovar;
    }
}