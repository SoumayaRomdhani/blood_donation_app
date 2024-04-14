namespace frame
{
    partial class updatedelete
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
            this.donneurs = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bd = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bt = new System.Windows.Forms.ComboBox();
            this.adresse = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.prenom = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.nom = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.mh = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.donneurs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // donneurs
            // 
            this.donneurs.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.donneurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.donneurs.Location = new System.Drawing.Point(12, 46);
            this.donneurs.Name = "donneurs";
            this.donneurs.Size = new System.Drawing.Size(405, 332);
            this.donneurs.TabIndex = 3;
            this.donneurs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.donneurs_CellContentClickdonneurs_CellClick);
            this.donneurs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.donneurs_CellContentClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RosyBrown;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(635, 373);
            this.button2.Margin = new System.Windows.Forms.Padding(1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 44);
            this.button2.TabIndex = 28;
            this.button2.Text = "DELETE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RosyBrown;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(496, 373);
            this.button1.Margin = new System.Windows.Forms.Padding(1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 44);
            this.button1.TabIndex = 27;
            this.button1.Text = "UPDATE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(613, 276);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(115, 16);
            this.bunifuCustomLabel6.TabIndex = 26;
            this.bunifuCustomLabel6.Text = "Medical History";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(433, 276);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(102, 16);
            this.bunifuCustomLabel5.TabIndex = 25;
            this.bunifuCustomLabel5.Text = "BLOOD TYPE";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(423, 190);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(80, 16);
            this.bunifuCustomLabel4.TabIndex = 24;
            this.bunifuCustomLabel4.Text = "ADDRESS";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(613, 190);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(129, 16);
            this.bunifuCustomLabel3.TabIndex = 23;
            this.bunifuCustomLabel3.Text = "BIRTHDAY DATE";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(433, 107);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(72, 16);
            this.bunifuCustomLabel2.TabIndex = 22;
            this.bunifuCustomLabel2.Text = "PRENOM";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(423, 26);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(41, 16);
            this.bunifuCustomLabel1.TabIndex = 21;
            this.bunifuCustomLabel1.Text = "NOM";
            // 
            // bd
            // 
            this.bd.BackColor = System.Drawing.Color.Maroon;
            this.bd.BorderRadius = 0;
            this.bd.ForeColor = System.Drawing.Color.White;
            this.bd.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.bd.FormatCustom = null;
            this.bd.Location = new System.Drawing.Point(616, 218);
            this.bd.Name = "bd";
            this.bd.Size = new System.Drawing.Size(180, 36);
            this.bd.TabIndex = 20;
            this.bd.Value = new System.DateTime(2024, 3, 26, 15, 47, 44, 834);
            // 
            // bt
            // 
            this.bt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bt.FormattingEnabled = true;
            this.bt.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "O+",
            "O-",
            "AB+",
            "AB-"});
            this.bt.Location = new System.Drawing.Point(426, 319);
            this.bt.Name = "bt";
            this.bt.Size = new System.Drawing.Size(174, 21);
            this.bt.TabIndex = 19;
            // 
            // adresse
            // 
            this.adresse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.adresse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.adresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.adresse.ForeColor = System.Drawing.Color.Black;
            this.adresse.HintForeColor = System.Drawing.Color.Black;
            this.adresse.HintText = "";
            this.adresse.isPassword = false;
            this.adresse.LineFocusedColor = System.Drawing.Color.Maroon;
            this.adresse.LineIdleColor = System.Drawing.Color.DarkRed;
            this.adresse.LineMouseHoverColor = System.Drawing.Color.Black;
            this.adresse.LineThickness = 3;
            this.adresse.Location = new System.Drawing.Point(426, 210);
            this.adresse.Margin = new System.Windows.Forms.Padding(4);
            this.adresse.Name = "adresse";
            this.adresse.Size = new System.Drawing.Size(174, 44);
            this.adresse.TabIndex = 17;
            this.adresse.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // prenom
            // 
            this.prenom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.prenom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.prenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.prenom.ForeColor = System.Drawing.Color.Black;
            this.prenom.HintForeColor = System.Drawing.Color.Black;
            this.prenom.HintText = "";
            this.prenom.isPassword = false;
            this.prenom.LineFocusedColor = System.Drawing.Color.Maroon;
            this.prenom.LineIdleColor = System.Drawing.Color.DarkRed;
            this.prenom.LineMouseHoverColor = System.Drawing.Color.Black;
            this.prenom.LineThickness = 3;
            this.prenom.Location = new System.Drawing.Point(426, 127);
            this.prenom.Margin = new System.Windows.Forms.Padding(4);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(174, 44);
            this.prenom.TabIndex = 16;
            this.prenom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // nom
            // 
            this.nom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.nom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.nom.ForeColor = System.Drawing.Color.Black;
            this.nom.HintForeColor = System.Drawing.Color.Black;
            this.nom.HintText = "";
            this.nom.isPassword = false;
            this.nom.LineFocusedColor = System.Drawing.Color.Maroon;
            this.nom.LineIdleColor = System.Drawing.Color.DarkRed;
            this.nom.LineMouseHoverColor = System.Drawing.Color.Black;
            this.nom.LineThickness = 3;
            this.nom.Location = new System.Drawing.Point(426, 46);
            this.nom.Margin = new System.Windows.Forms.Padding(4);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(174, 44);
            this.nom.TabIndex = 15;
            this.nom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // mh
            // 
            this.mh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.mh.FormattingEnabled = true;
            this.mh.Items.AddRange(new object[] {
            "sain(e)",
            "le VIH ou l\'hépatite",
            "leucémie ou lymphome.",
            "Utilisation récente de drogues intraveineuses.",
            "maladie cardiaque",
            "accident vasculaire cérébral.",
            "encéphalopathie  ",
            "anémie sévère",
            "maladie infectieuse",
            "maladies auto-immunes."});
            this.mh.Location = new System.Drawing.Point(616, 319);
            this.mh.Name = "mh";
            this.mh.Size = new System.Drawing.Size(174, 21);
            this.mh.TabIndex = 29;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::frame.Properties.Resources.The_Circulatory_System_Education_Presentation_in_0_Hand_Drawn_Lightly_Textured_Style;
            this.pictureBox1.Location = new System.Drawing.Point(0, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(803, 456);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::frame.Properties.Resources.The_Circulatory_System_Education_Presentation_in_0_Hand_Drawn_Lightly_Textured_Style__3_;
            this.pictureBox3.Location = new System.Drawing.Point(745, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(51, 38);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 33;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::frame.Properties.Resources.The_Circulatory_System_Education_Presentation_in_0_Hand_Drawn_Lightly_Textured_Style__2_;
            this.pictureBox2.Location = new System.Drawing.Point(699, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // updatedelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.mh);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.bd);
            this.Controls.Add(this.bt);
            this.Controls.Add(this.adresse);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.donneurs);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "updatedelete";
            this.Text = "updatedelete";
            this.Load += new System.EventHandler(this.updatedelete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.donneurs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView donneurs;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuDatepicker bd;
        private System.Windows.Forms.ComboBox bt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox adresse;
        private Bunifu.Framework.UI.BunifuMaterialTextbox prenom;
        private Bunifu.Framework.UI.BunifuMaterialTextbox nom;
        private System.Windows.Forms.ComboBox mh;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}