namespace MiniProyecto
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelBienvenida = new System.Windows.Forms.Panel();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.panelSideBar = new System.Windows.Forms.Panel();
            this.buttonInteres = new System.Windows.Forms.Button();
            this.buttonNormas = new System.Windows.Forms.Button();
            this.buttonPlanos = new System.Windows.Forms.Button();
            this.buttonPersonal = new System.Windows.Forms.Button();
            this.panelDireccion = new System.Windows.Forms.Panel();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonConfig = new System.Windows.Forms.Button();
            this.buttonInicio = new System.Windows.Forms.Button();
            this.buttonAyuda = new System.Windows.Forms.Button();
            this.linkLabelWeb = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelBienvenida.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panelSideBar.SuspendLayout();
            this.panelDireccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBienvenida
            // 
            this.panelBienvenida.BackColor = System.Drawing.Color.White;
            this.panelBienvenida.Controls.Add(this.panelLogin);
            this.panelBienvenida.Controls.Add(this.pictureBox2);
            this.panelBienvenida.Controls.Add(this.label2);
            this.panelBienvenida.Controls.Add(this.linkLabelWeb);
            this.panelBienvenida.Location = new System.Drawing.Point(176, 104);
            this.panelBienvenida.Name = "panelBienvenida";
            this.panelBienvenida.Size = new System.Drawing.Size(624, 312);
            this.panelBienvenida.TabIndex = 0;
            this.panelBienvenida.Click += new System.EventHandler(this.panelBienvenida_Click);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Dosis", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.White;
            this.labelTitulo.Location = new System.Drawing.Point(32, 32);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(360, 41);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Colegio Cristo Rey Granada";
            this.labelTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.White;
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Controls.Add(this.buttonInicio);
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(176, 100);
            this.panelLogo.TabIndex = 1;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(140)))));
            this.panelHeader.Controls.Add(this.buttonAyuda);
            this.panelHeader.Controls.Add(this.buttonConfig);
            this.panelHeader.Controls.Add(this.buttonLogin);
            this.panelHeader.Controls.Add(this.labelTitulo);
            this.panelHeader.Location = new System.Drawing.Point(176, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(624, 100);
            this.panelHeader.TabIndex = 2;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.buttonLogin.Image = global::MiniProyecto.Properties.Resources.person_avatar_account_user_icon_191606;
            this.buttonLogin.Location = new System.Drawing.Point(560, 32);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(48, 48);
            this.buttonLogin.TabIndex = 1;
            this.buttonLogin.UseVisualStyleBackColor = false;
            // 
            // panelSideBar
            // 
            this.panelSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(140)))));
            this.panelSideBar.Controls.Add(this.buttonInteres);
            this.panelSideBar.Controls.Add(this.buttonNormas);
            this.panelSideBar.Controls.Add(this.buttonPlanos);
            this.panelSideBar.Controls.Add(this.buttonPersonal);
            this.panelSideBar.Location = new System.Drawing.Point(0, 104);
            this.panelSideBar.Name = "panelSideBar";
            this.panelSideBar.Size = new System.Drawing.Size(176, 352);
            this.panelSideBar.TabIndex = 3;
            // 
            // buttonInteres
            // 
            this.buttonInteres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.buttonInteres.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInteres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(140)))));
            this.buttonInteres.Location = new System.Drawing.Point(8, 256);
            this.buttonInteres.Name = "buttonInteres";
            this.buttonInteres.Size = new System.Drawing.Size(160, 48);
            this.buttonInteres.TabIndex = 3;
            this.buttonInteres.Text = "Zonas de Interés";
            this.buttonInteres.UseVisualStyleBackColor = false;
            // 
            // buttonNormas
            // 
            this.buttonNormas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.buttonNormas.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNormas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(140)))));
            this.buttonNormas.Location = new System.Drawing.Point(8, 184);
            this.buttonNormas.Name = "buttonNormas";
            this.buttonNormas.Size = new System.Drawing.Size(160, 48);
            this.buttonNormas.TabIndex = 2;
            this.buttonNormas.Text = "Normas de Convivencia";
            this.buttonNormas.UseVisualStyleBackColor = false;
            // 
            // buttonPlanos
            // 
            this.buttonPlanos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.buttonPlanos.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlanos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(140)))));
            this.buttonPlanos.Location = new System.Drawing.Point(8, 112);
            this.buttonPlanos.Name = "buttonPlanos";
            this.buttonPlanos.Size = new System.Drawing.Size(160, 48);
            this.buttonPlanos.TabIndex = 1;
            this.buttonPlanos.Text = "Planos";
            this.buttonPlanos.UseVisualStyleBackColor = false;
            // 
            // buttonPersonal
            // 
            this.buttonPersonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.buttonPersonal.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPersonal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(140)))));
            this.buttonPersonal.Location = new System.Drawing.Point(8, 40);
            this.buttonPersonal.Name = "buttonPersonal";
            this.buttonPersonal.Size = new System.Drawing.Size(160, 48);
            this.buttonPersonal.TabIndex = 0;
            this.buttonPersonal.Text = "Personal";
            this.buttonPersonal.UseVisualStyleBackColor = false;
            // 
            // panelDireccion
            // 
            this.panelDireccion.BackColor = System.Drawing.Color.White;
            this.panelDireccion.Controls.Add(this.labelDireccion);
            this.panelDireccion.Location = new System.Drawing.Point(176, 416);
            this.panelDireccion.Name = "panelDireccion";
            this.panelDireccion.Size = new System.Drawing.Size(624, 40);
            this.panelDireccion.TabIndex = 4;
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDireccion.Location = new System.Drawing.Point(376, 8);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(235, 20);
            this.labelDireccion.TabIndex = 0;
            this.labelDireccion.Text = "San Gregorio Alto, 5 - 18010 Granada";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MiniProyecto.Properties.Resources.Logo_Def_Fun_JGr_Hor__1_;
            this.pictureBox1.Location = new System.Drawing.Point(24, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // buttonConfig
            // 
            this.buttonConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.buttonConfig.Image = global::MiniProyecto.Properties.Resources.gear_settings_options_icon_191642;
            this.buttonConfig.Location = new System.Drawing.Point(504, 32);
            this.buttonConfig.Name = "buttonConfig";
            this.buttonConfig.Size = new System.Drawing.Size(48, 48);
            this.buttonConfig.TabIndex = 2;
            this.buttonConfig.UseVisualStyleBackColor = false;
            // 
            // buttonInicio
            // 
            this.buttonInicio.Location = new System.Drawing.Point(16, 16);
            this.buttonInicio.Name = "buttonInicio";
            this.buttonInicio.Size = new System.Drawing.Size(152, 72);
            this.buttonInicio.TabIndex = 0;
            this.buttonInicio.UseVisualStyleBackColor = true;
            // 
            // buttonAyuda
            // 
            this.buttonAyuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.buttonAyuda.Image = global::MiniProyecto.Properties.Resources.question_help_icon_191660;
            this.buttonAyuda.Location = new System.Drawing.Point(448, 32);
            this.buttonAyuda.Name = "buttonAyuda";
            this.buttonAyuda.Size = new System.Drawing.Size(48, 48);
            this.buttonAyuda.TabIndex = 0;
            this.buttonAyuda.UseVisualStyleBackColor = false;
            // 
            // linkLabelWeb
            // 
            this.linkLabelWeb.AutoSize = true;
            this.linkLabelWeb.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelWeb.Location = new System.Drawing.Point(248, 240);
            this.linkLabelWeb.Name = "linkLabelWeb";
            this.linkLabelWeb.Size = new System.Drawing.Size(117, 20);
            this.linkLabelWeb.TabIndex = 0;
            this.linkLabelWeb.TabStop = true;
            this.linkLabelWeb.Text = "Página Web Oficial";
            this.linkLabelWeb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelWeb_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dosis", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(441, 41);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bienvenido al Punto de Información";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MiniProyecto.Properties.Resources.logoCorona;
            this.pictureBox2.Location = new System.Drawing.Point(240, 104);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(128, 120);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.button2);
            this.panelLogin.Controls.Add(this.button1);
            this.panelLogin.Controls.Add(this.textBox2);
            this.panelLogin.Controls.Add(this.textBox1);
            this.panelLogin.Controls.Add(this.checkBox1);
            this.panelLogin.Controls.Add(this.label4);
            this.panelLogin.Controls.Add(this.label3);
            this.panelLogin.Controls.Add(this.label1);
            this.panelLogin.Location = new System.Drawing.Point(0, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(624, 312);
            this.panelLogin.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dosis", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inicio de Sesión";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(192, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Usuario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(192, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Contraseña:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(304, 176);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(304, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 28);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(304, 136);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 28);
            this.textBox2.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(328, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(192, 224);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelDireccion);
            this.Controls.Add(this.panelSideBar);
            this.Controls.Add(this.panelLogo);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelBienvenida);
            this.Name = "Form1";
            this.Text = "Punto de Información";
            this.panelBienvenida.ResumeLayout(false);
            this.panelBienvenida.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelSideBar.ResumeLayout(false);
            this.panelDireccion.ResumeLayout(false);
            this.panelDireccion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBienvenida;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelSideBar;
        private System.Windows.Forms.Button buttonPersonal;
        private System.Windows.Forms.Button buttonPlanos;
        private System.Windows.Forms.Button buttonInteres;
        private System.Windows.Forms.Button buttonNormas;
        private System.Windows.Forms.Panel panelDireccion;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.Button buttonConfig;
        private System.Windows.Forms.Button buttonInicio;
        private System.Windows.Forms.Button buttonAyuda;
        private System.Windows.Forms.LinkLabel linkLabelWeb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

