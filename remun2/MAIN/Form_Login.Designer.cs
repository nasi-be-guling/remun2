namespace remun2.MAIN
{
    partial class Form_Login
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPasswd = new System.Windows.Forms.TextBox();
            this.txtNIP = new System.Windows.Forms.TextBox();
            this.bLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "PASSWORD: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "NIP:";
            // 
            // txtPasswd
            // 
            this.txtPasswd.Location = new System.Drawing.Point(180, 51);
            this.txtPasswd.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.txtPasswd.Name = "txtPasswd";
            this.txtPasswd.PasswordChar = '*';
            this.txtPasswd.Size = new System.Drawing.Size(316, 27);
            this.txtPasswd.TabIndex = 3;
            // 
            // txtNIP
            // 
            this.txtNIP.Location = new System.Drawing.Point(180, 14);
            this.txtNIP.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.txtNIP.Name = "txtNIP";
            this.txtNIP.Size = new System.Drawing.Size(316, 27);
            this.txtNIP.TabIndex = 1;
            this.txtNIP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNIP_KeyPress);
            // 
            // bLogin
            // 
            this.bLogin.Location = new System.Drawing.Point(363, 94);
            this.bLogin.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(133, 54);
            this.bLogin.TabIndex = 4;
            this.bLogin.Text = "LOGIN";
            this.bLogin.UseVisualStyleBackColor = true;
            this.bLogin.Click += new System.EventHandler(this.bLogin_Click);
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 162);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPasswd);
            this.Controls.Add(this.txtNIP);
            this.Controls.Add(this.bLogin);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LOGIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPasswd;
        private System.Windows.Forms.TextBox txtNIP;
        private System.Windows.Forms.Button bLogin;
    }
}