
namespace TutoriasV2
{
    partial class Form_Startup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Startup));
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_regist = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.pb = new System.Windows.Forms.PictureBox();
            this.il = new System.Windows.Forms.ImageList(this.components);
            this.lbl_state = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(12, 115);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(160, 35);
            this.btn_cancel.TabIndex = 5;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_regist
            // 
            this.btn_regist.Enabled = false;
            this.btn_regist.Location = new System.Drawing.Point(12, 53);
            this.btn_regist.Name = "btn_regist";
            this.btn_regist.Size = new System.Drawing.Size(160, 35);
            this.btn_regist.TabIndex = 4;
            this.btn_regist.Text = "Registar";
            this.btn_regist.UseVisualStyleBackColor = true;
            this.btn_regist.Click += new System.EventHandler(this.btn_regist_Click);
            // 
            // btn_login
            // 
            this.btn_login.Enabled = false;
            this.btn_login.Location = new System.Drawing.Point(12, 12);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(160, 35);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(12, 94);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(16, 16);
            this.pb.TabIndex = 6;
            this.pb.TabStop = false;
            this.pb.Click += new System.EventHandler(this.pb_Click);
            this.pb.DoubleClick += new System.EventHandler(this.pb_DoubleClick);
            // 
            // il
            // 
            this.il.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("il.ImageStream")));
            this.il.TransparentColor = System.Drawing.Color.Transparent;
            this.il.Images.SetKeyName(0, "State-Green.ico");
            this.il.Images.SetKeyName(1, "State-Red.ico");
            // 
            // lbl_state
            // 
            this.lbl_state.AutoSize = true;
            this.lbl_state.Location = new System.Drawing.Point(33, 96);
            this.lbl_state.Name = "lbl_state";
            this.lbl_state.Size = new System.Drawing.Size(126, 13);
            this.lbl_state.TabIndex = 7;
            this.lbl_state.Text = "#CONNECTION_STATE";
            this.lbl_state.Visible = false;
            // 
            // Form_Startup
            // 
            this.AcceptButton = this.btn_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(184, 162);
            this.Controls.Add(this.lbl_state);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_regist);
            this.Controls.Add(this.btn_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Startup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Startup";
            this.Load += new System.EventHandler(this.Form_Startup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_regist;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.ErrorProvider ep;
        private System.Windows.Forms.Label lbl_state;
        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.ImageList il;
    }
}

