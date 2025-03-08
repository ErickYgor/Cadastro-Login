namespace Cadastro_e_Login.Apresentação
{
    partial class Cadastrar
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
            this.lbl_login_cadastrar = new System.Windows.Forms.Label();
            this.lbl_senha_cadastrar = new System.Windows.Forms.Label();
            this.lbl_confirmar_senha_cadastrar = new System.Windows.Forms.Label();
            this.txt_login_cadastrar = new System.Windows.Forms.TextBox();
            this.txt_confirmar_senha_cadastrar = new System.Windows.Forms.TextBox();
            this.txt_senha_cadastrar = new System.Windows.Forms.TextBox();
            this.btn_entrar_cadastrar = new System.Windows.Forms.Button();
            this.btn_form_cadastrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_login_cadastrar
            // 
            this.lbl_login_cadastrar.AutoSize = true;
            this.lbl_login_cadastrar.Location = new System.Drawing.Point(13, 108);
            this.lbl_login_cadastrar.Name = "lbl_login_cadastrar";
            this.lbl_login_cadastrar.Size = new System.Drawing.Size(39, 13);
            this.lbl_login_cadastrar.TabIndex = 0;
            this.lbl_login_cadastrar.Text = "Login: ";
            // 
            // lbl_senha_cadastrar
            // 
            this.lbl_senha_cadastrar.AutoSize = true;
            this.lbl_senha_cadastrar.Location = new System.Drawing.Point(13, 157);
            this.lbl_senha_cadastrar.Name = "lbl_senha_cadastrar";
            this.lbl_senha_cadastrar.Size = new System.Drawing.Size(41, 13);
            this.lbl_senha_cadastrar.TabIndex = 1;
            this.lbl_senha_cadastrar.Text = "Senha:";
            // 
            // lbl_confirmar_senha_cadastrar
            // 
            this.lbl_confirmar_senha_cadastrar.AutoSize = true;
            this.lbl_confirmar_senha_cadastrar.Location = new System.Drawing.Point(13, 209);
            this.lbl_confirmar_senha_cadastrar.Name = "lbl_confirmar_senha_cadastrar";
            this.lbl_confirmar_senha_cadastrar.Size = new System.Drawing.Size(88, 13);
            this.lbl_confirmar_senha_cadastrar.TabIndex = 2;
            this.lbl_confirmar_senha_cadastrar.Text = "Confirmar Senha:";
            // 
            // txt_login_cadastrar
            // 
            this.txt_login_cadastrar.Location = new System.Drawing.Point(58, 105);
            this.txt_login_cadastrar.Name = "txt_login_cadastrar";
            this.txt_login_cadastrar.Size = new System.Drawing.Size(180, 20);
            this.txt_login_cadastrar.TabIndex = 3;
            // 
            // txt_confirmar_senha_cadastrar
            // 
            this.txt_confirmar_senha_cadastrar.Location = new System.Drawing.Point(107, 206);
            this.txt_confirmar_senha_cadastrar.Name = "txt_confirmar_senha_cadastrar";
            this.txt_confirmar_senha_cadastrar.Size = new System.Drawing.Size(131, 20);
            this.txt_confirmar_senha_cadastrar.TabIndex = 4;
            // 
            // txt_senha_cadastrar
            // 
            this.txt_senha_cadastrar.Location = new System.Drawing.Point(58, 154);
            this.txt_senha_cadastrar.Name = "txt_senha_cadastrar";
            this.txt_senha_cadastrar.Size = new System.Drawing.Size(180, 20);
            this.txt_senha_cadastrar.TabIndex = 5;
            // 
            // btn_entrar_cadastrar
            // 
            this.btn_entrar_cadastrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_entrar_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_entrar_cadastrar.Location = new System.Drawing.Point(16, 299);
            this.btn_entrar_cadastrar.Name = "btn_entrar_cadastrar";
            this.btn_entrar_cadastrar.Size = new System.Drawing.Size(222, 23);
            this.btn_entrar_cadastrar.TabIndex = 6;
            this.btn_entrar_cadastrar.Text = "Entrar";
            this.btn_entrar_cadastrar.UseVisualStyleBackColor = false;
            this.btn_entrar_cadastrar.Click += new System.EventHandler(this.btn_entrar_cadastrar_Click);
            // 
            // btn_form_cadastrar
            // 
            this.btn_form_cadastrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_form_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_form_cadastrar.Location = new System.Drawing.Point(16, 254);
            this.btn_form_cadastrar.Name = "btn_form_cadastrar";
            this.btn_form_cadastrar.Size = new System.Drawing.Size(222, 23);
            this.btn_form_cadastrar.TabIndex = 7;
            this.btn_form_cadastrar.Text = "Cadastrar";
            this.btn_form_cadastrar.UseVisualStyleBackColor = false;
            this.btn_form_cadastrar.Click += new System.EventHandler(this.btn_form_cadastrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 33);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cadastre-se";
            // 
            // Cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(249, 351);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_form_cadastrar);
            this.Controls.Add(this.btn_entrar_cadastrar);
            this.Controls.Add(this.txt_senha_cadastrar);
            this.Controls.Add(this.txt_confirmar_senha_cadastrar);
            this.Controls.Add(this.txt_login_cadastrar);
            this.Controls.Add(this.lbl_confirmar_senha_cadastrar);
            this.Controls.Add(this.lbl_senha_cadastrar);
            this.Controls.Add(this.lbl_login_cadastrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Cadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_login_cadastrar;
        private System.Windows.Forms.Label lbl_senha_cadastrar;
        private System.Windows.Forms.Label lbl_confirmar_senha_cadastrar;
        private System.Windows.Forms.TextBox txt_login_cadastrar;
        private System.Windows.Forms.TextBox txt_confirmar_senha_cadastrar;
        private System.Windows.Forms.TextBox txt_senha_cadastrar;
        private System.Windows.Forms.Button btn_entrar_cadastrar;
        private System.Windows.Forms.Button btn_form_cadastrar;
        private System.Windows.Forms.Label label1;
    }
}