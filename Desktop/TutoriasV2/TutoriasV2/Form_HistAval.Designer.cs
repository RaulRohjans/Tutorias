
namespace TutoriasV2
{
    partial class Form_HistAval
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_HistAval));
            this.lsv_ = new System.Windows.Forms.ListView();
            this.apoioID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Aluno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tutor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Disc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Local = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Aval = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Desc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl_aval = new System.Windows.Forms.Label();
            this.txt_aval = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsv_
            // 
            this.lsv_.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.apoioID,
            this.Aluno,
            this.Tutor,
            this.Disc,
            this.Local,
            this.Aval,
            this.Desc});
            this.lsv_.FullRowSelect = true;
            this.lsv_.HideSelection = false;
            this.lsv_.Location = new System.Drawing.Point(12, 12);
            this.lsv_.Name = "lsv_";
            this.lsv_.Size = new System.Drawing.Size(554, 283);
            this.lsv_.TabIndex = 0;
            this.lsv_.UseCompatibleStateImageBehavior = false;
            this.lsv_.View = System.Windows.Forms.View.Details;
            this.lsv_.SelectedIndexChanged += new System.EventHandler(this.lsv__SelectedIndexChanged);
            // 
            // apoioID
            // 
            this.apoioID.Text = "ID";
            this.apoioID.Width = 30;
            // 
            // Aluno
            // 
            this.Aluno.Text = "Aluno";
            this.Aluno.Width = 80;
            // 
            // Tutor
            // 
            this.Tutor.Text = "Tutor";
            this.Tutor.Width = 80;
            // 
            // Disc
            // 
            this.Disc.Text = "Disciplina";
            // 
            // Local
            // 
            this.Local.Text = "Local";
            this.Local.Width = 70;
            // 
            // Aval
            // 
            this.Aval.Text = "Avaliação";
            this.Aval.Width = 90;
            // 
            // Desc
            // 
            this.Desc.Text = "Descrição";
            this.Desc.Width = 200;
            // 
            // lbl_aval
            // 
            this.lbl_aval.AutoSize = true;
            this.lbl_aval.Location = new System.Drawing.Point(9, 308);
            this.lbl_aval.Name = "lbl_aval";
            this.lbl_aval.Size = new System.Drawing.Size(57, 13);
            this.lbl_aval.TabIndex = 1;
            this.lbl_aval.Text = "Avaliação:";
            // 
            // txt_aval
            // 
            this.txt_aval.Location = new System.Drawing.Point(12, 324);
            this.txt_aval.Name = "txt_aval";
            this.txt_aval.Size = new System.Drawing.Size(273, 20);
            this.txt_aval.TabIndex = 2;
            this.txt_aval.TextChanged += new System.EventHandler(this.txt_aval_TextChanged);
            // 
            // btn_save
            // 
            this.btn_save.Enabled = false;
            this.btn_save.Location = new System.Drawing.Point(398, 398);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(168, 23);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "Guardar Alterações";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(12, 398);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(168, 23);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // Form_HistAval
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 435);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_aval);
            this.Controls.Add(this.lbl_aval);
            this.Controls.Add(this.lsv_);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_HistAval";
            this.Text = "Histórico/Avaliar Apoio";
            this.Load += new System.EventHandler(this.Form_HistAval_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsv_;
        private System.Windows.Forms.ColumnHeader apoioID;
        private System.Windows.Forms.ColumnHeader Aluno;
        private System.Windows.Forms.ColumnHeader Tutor;
        private System.Windows.Forms.ColumnHeader Disc;
        private System.Windows.Forms.ColumnHeader Local;
        private System.Windows.Forms.ColumnHeader Aval;
        private System.Windows.Forms.ColumnHeader Desc;
        private System.Windows.Forms.Label lbl_aval;
        private System.Windows.Forms.TextBox txt_aval;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
    }
}