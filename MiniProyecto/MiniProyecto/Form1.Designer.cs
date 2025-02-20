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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelSideBar = new System.Windows.Forms.Panel();
            this.buttonPersonal = new System.Windows.Forms.Button();
            this.buttonPlanos = new System.Windows.Forms.Button();
            this.buttonNormas = new System.Windows.Forms.Button();
            this.buttonInteres = new System.Windows.Forms.Button();
            this.panelDireccion = new System.Windows.Forms.Panel();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelLogo.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panelSideBar.SuspendLayout();
            this.panelDireccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBienvenida
            // 
            this.panelBienvenida.BackColor = System.Drawing.Color.White;
            this.panelBienvenida.Location = new System.Drawing.Point(176, 104);
            this.panelBienvenida.Name = "panelBienvenida";
            this.panelBienvenida.Size = new System.Drawing.Size(624, 312);
            this.panelBienvenida.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MiniProyecto.Properties.Resources.Logo_Def_Fun_JGr_Hor__1_;
            this.pictureBox1.Location = new System.Drawing.Point(16, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Dosis", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.White;
            this.labelTitulo.Location = new System.Drawing.Point(32, 24);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(336, 41);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Colegio Cristo Rey Granada";
            this.labelTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.White;
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(176, 100);
            this.panelLogo.TabIndex = 1;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(140)))));
            this.panelHeader.Controls.Add(this.button1);
            this.panelHeader.Controls.Add(this.labelTitulo);
            this.panelHeader.Location = new System.Drawing.Point(176, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(624, 100);
            this.panelHeader.TabIndex = 2;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(552, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelLogo.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelSideBar.ResumeLayout(false);
            this.panelDireccion.ResumeLayout(false);
            this.panelDireccion.PerformLayout();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelDireccion;
    }
}

