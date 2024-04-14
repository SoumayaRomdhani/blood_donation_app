namespace frame
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.reset = new Bunifu.Framework.UI.BunifuThinButton2();
            this.login = new Bunifu.Framework.UI.BunifuThinButton2();
            this.password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.username = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.reset);
            this.panel1.Controls.Add(this.login);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.username);
            this.panel1.Location = new System.Drawing.Point(102, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 259);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Andalus", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(19, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 41);
            this.label2.TabIndex = 6;
            this.label2.Text = "Donate Blood, Be a Hero";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::frame.Properties.Resources.fermer_a_cle;
            this.pictureBox3.Location = new System.Drawing.Point(259, 124);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(39, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::frame.Properties.Resources.utilisateur;
            this.pictureBox2.Location = new System.Drawing.Point(259, 63);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // reset
            // 
            this.reset.ActiveBorderThickness = 1;
            this.reset.ActiveCornerRadius = 20;
            this.reset.ActiveFillColor = System.Drawing.Color.IndianRed;
            this.reset.ActiveForecolor = System.Drawing.Color.White;
            this.reset.ActiveLineColor = System.Drawing.Color.IndianRed;
            this.reset.BackColor = System.Drawing.SystemColors.Control;
            this.reset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reset.BackgroundImage")));
            this.reset.ButtonText = "RESET";
            this.reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.ForeColor = System.Drawing.Color.DarkRed;
            this.reset.IdleBorderThickness = 1;
            this.reset.IdleCornerRadius = 20;
            this.reset.IdleFillColor = System.Drawing.Color.White;
            this.reset.IdleForecolor = System.Drawing.Color.Maroon;
            this.reset.IdleLineColor = System.Drawing.Color.DarkRed;
            this.reset.Location = new System.Drawing.Point(172, 196);
            this.reset.Margin = new System.Windows.Forms.Padding(5);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(80, 41);
            this.reset.TabIndex = 3;
            this.reset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // login
            // 
            this.login.ActiveBorderThickness = 1;
            this.login.ActiveCornerRadius = 20;
            this.login.ActiveFillColor = System.Drawing.Color.IndianRed;
            this.login.ActiveForecolor = System.Drawing.Color.White;
            this.login.ActiveLineColor = System.Drawing.Color.IndianRed;
            this.login.BackColor = System.Drawing.SystemColors.Control;
            this.login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("login.BackgroundImage")));
            this.login.ButtonText = "LOGIN";
            this.login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.ForeColor = System.Drawing.Color.DarkRed;
            this.login.IdleBorderThickness = 1;
            this.login.IdleCornerRadius = 20;
            this.login.IdleFillColor = System.Drawing.Color.White;
            this.login.IdleForecolor = System.Drawing.Color.Maroon;
            this.login.IdleLineColor = System.Drawing.Color.DarkRed;
            this.login.Location = new System.Drawing.Point(61, 196);
            this.login.Margin = new System.Windows.Forms.Padding(5);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(82, 41);
            this.login.TabIndex = 2;
            this.login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // password
            // 
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.password.ForeColor = System.Drawing.Color.Black;
            this.password.HintForeColor = System.Drawing.Color.Empty;
            this.password.HintText = "";
            this.password.isPassword = false;
            this.password.LineFocusedColor = System.Drawing.Color.Black;
            this.password.LineIdleColor = System.Drawing.Color.DarkRed;
            this.password.LineMouseHoverColor = System.Drawing.Color.Black;
            this.password.LineThickness = 3;
            this.password.Location = new System.Drawing.Point(61, 110);
            this.password.Margin = new System.Windows.Forms.Padding(4);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(191, 44);
            this.password.TabIndex = 1;
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // username
            // 
            this.username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.username.ForeColor = System.Drawing.Color.Black;
            this.username.HintForeColor = System.Drawing.Color.Empty;
            this.username.HintText = "";
            this.username.isPassword = false;
            this.username.LineFocusedColor = System.Drawing.Color.Black;
            this.username.LineIdleColor = System.Drawing.Color.DarkRed;
            this.username.LineMouseHoverColor = System.Drawing.Color.Black;
            this.username.LineThickness = 3;
            this.username.Location = new System.Drawing.Point(61, 47);
            this.username.Margin = new System.Windows.Forms.Padding(4);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(191, 44);
            this.username.TabIndex = 0;
            this.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::frame.Properties.Resources._8880485;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox username;
        private Bunifu.Framework.UI.BunifuThinButton2 login;
        private Bunifu.Framework.UI.BunifuMaterialTextbox password;
        private Bunifu.Framework.UI.BunifuThinButton2 reset;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
    }
}

