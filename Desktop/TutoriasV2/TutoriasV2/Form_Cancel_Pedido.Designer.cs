
namespace TutoriasV2
{
    partial class Form_Cancel_Pedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Cancel_Pedido));
            this.lscb_ = new System.Windows.Forms.CheckedListBox();
            this.btn_anular = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lscb_
            // 
            this.lscb_.FormattingEnabled = true;
            this.lscb_.Location = new System.Drawing.Point(12, 12);
            this.lscb_.Name = "lscb_";
            this.lscb_.Size = new System.Drawing.Size(473, 439);
            this.lscb_.TabIndex = 0;
            // 
            // btn_anular
            // 
            this.btn_anular.Location = new System.Drawing.Point(347, 489);
            this.btn_anular.Name = "btn_anular";
            this.btn_anular.Size = new System.Drawing.Size(138, 23);
            this.btn_anular.TabIndex = 1;
            this.btn_anular.Text = "Anular Pedidos";
            this.btn_anular.UseVisualStyleBackColor = true;
            this.btn_anular.Click += new System.EventHandler(this.btn_anular_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(12, 489);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(138, 23);
            this.btn_sair.TabIndex = 2;
            this.btn_sair.Text = "Cancelar";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // Form_Cancel_Pedido
            // 
            this.AcceptButton = this.btn_anular;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 524);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_anular);
            this.Controls.Add(this.lscb_);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Cancel_Pedido";
            this.Text = "Anular Pedidos";
            this.Load += new System.EventHandler(this.Form_Cancel_Pedido_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox lscb_;
        private System.Windows.Forms.Button btn_anular;
        private System.Windows.Forms.Button btn_sair;
    }
}