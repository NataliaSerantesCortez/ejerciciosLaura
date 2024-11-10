namespace TemperaturaMedia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalcularMedia = new System.Windows.Forms.Button();
            this.tfMedia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nbLunes = new System.Windows.Forms.NumericUpDown();
            this.nbMartes = new System.Windows.Forms.NumericUpDown();
            this.nbMiercoles = new System.Windows.Forms.NumericUpDown();
            this.nbJueves = new System.Windows.Forms.NumericUpDown();
            this.nbViernes = new System.Windows.Forms.NumericUpDown();
            this.nbSabado = new System.Windows.Forms.NumericUpDown();
            this.nbDomingo = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.imagenSol = new System.Windows.Forms.PictureBox();
            this.imagenNieve = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nbLunes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbMartes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbMiercoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbJueves)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbViernes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbSabado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbDomingo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenSol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenNieve)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduce las temperaturas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lunes:";
            // 
            // btnCalcularMedia
            // 
            this.btnCalcularMedia.Location = new System.Drawing.Point(24, 288);
            this.btnCalcularMedia.Name = "btnCalcularMedia";
            this.btnCalcularMedia.Size = new System.Drawing.Size(96, 23);
            this.btnCalcularMedia.TabIndex = 9;
            this.btnCalcularMedia.Text = "Calcular Media";
            this.btnCalcularMedia.UseVisualStyleBackColor = true;
            this.btnCalcularMedia.Click += new System.EventHandler(this.button1_Click);
            // 
            // tfMedia
            // 
            this.tfMedia.Location = new System.Drawing.Point(144, 288);
            this.tfMedia.Name = "tfMedia";
            this.tfMedia.ReadOnly = true;
            this.tfMedia.Size = new System.Drawing.Size(56, 20);
            this.tfMedia.TabIndex = 10;
            this.tfMedia.TextChanged += new System.EventHandler(this.tfMedia_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Martes:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Miercoles:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Jueves:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Viernes:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Sabado:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Domingo:";
            // 
            // nbLunes
            // 
            this.nbLunes.Location = new System.Drawing.Point(88, 56);
            this.nbLunes.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nbLunes.Minimum = new decimal(new int[] {
            40,
            0,
            0,
            -2147483648});
            this.nbLunes.Name = "nbLunes";
            this.nbLunes.Size = new System.Drawing.Size(64, 20);
            this.nbLunes.TabIndex = 17;
            // 
            // nbMartes
            // 
            this.nbMartes.Location = new System.Drawing.Point(88, 88);
            this.nbMartes.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nbMartes.Minimum = new decimal(new int[] {
            40,
            0,
            0,
            -2147483648});
            this.nbMartes.Name = "nbMartes";
            this.nbMartes.Size = new System.Drawing.Size(64, 20);
            this.nbMartes.TabIndex = 18;
            // 
            // nbMiercoles
            // 
            this.nbMiercoles.Location = new System.Drawing.Point(88, 120);
            this.nbMiercoles.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nbMiercoles.Minimum = new decimal(new int[] {
            40,
            0,
            0,
            -2147483648});
            this.nbMiercoles.Name = "nbMiercoles";
            this.nbMiercoles.Size = new System.Drawing.Size(64, 20);
            this.nbMiercoles.TabIndex = 19;
            // 
            // nbJueves
            // 
            this.nbJueves.Location = new System.Drawing.Point(88, 152);
            this.nbJueves.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nbJueves.Minimum = new decimal(new int[] {
            40,
            0,
            0,
            -2147483648});
            this.nbJueves.Name = "nbJueves";
            this.nbJueves.Size = new System.Drawing.Size(64, 20);
            this.nbJueves.TabIndex = 20;
            // 
            // nbViernes
            // 
            this.nbViernes.Location = new System.Drawing.Point(88, 184);
            this.nbViernes.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nbViernes.Minimum = new decimal(new int[] {
            40,
            0,
            0,
            -2147483648});
            this.nbViernes.Name = "nbViernes";
            this.nbViernes.Size = new System.Drawing.Size(64, 20);
            this.nbViernes.TabIndex = 21;
            // 
            // nbSabado
            // 
            this.nbSabado.Location = new System.Drawing.Point(88, 216);
            this.nbSabado.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nbSabado.Minimum = new decimal(new int[] {
            40,
            0,
            0,
            -2147483648});
            this.nbSabado.Name = "nbSabado";
            this.nbSabado.Size = new System.Drawing.Size(64, 20);
            this.nbSabado.TabIndex = 22;
            // 
            // nbDomingo
            // 
            this.nbDomingo.Location = new System.Drawing.Point(88, 248);
            this.nbDomingo.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nbDomingo.Minimum = new decimal(new int[] {
            40,
            0,
            0,
            -2147483648});
            this.nbDomingo.Name = "nbDomingo";
            this.nbDomingo.Size = new System.Drawing.Size(64, 20);
            this.nbDomingo.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(72, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 16);
            this.label9.TabIndex = 24;
            this.label9.Text = "de la semana (en °C)";
            // 
            // imagenSol
            // 
            this.imagenSol.Image = global::TemperaturaMedia.Properties.Resources.iconfinder_weather_weather_forecast_hot_sun_day_3859136_121222;
            this.imagenSol.Location = new System.Drawing.Point(192, 144);
            this.imagenSol.Name = "imagenSol";
            this.imagenSol.Size = new System.Drawing.Size(64, 64);
            this.imagenSol.TabIndex = 25;
            this.imagenSol.TabStop = false;
            this.imagenSol.Visible = false;
            // 
            // imagenNieve
            // 
            this.imagenNieve.Image = global::TemperaturaMedia.Properties.Resources.weather_snow_snowflake_winter_freeze_icon_189094;
            this.imagenNieve.Location = new System.Drawing.Point(192, 144);
            this.imagenNieve.Name = "imagenNieve";
            this.imagenNieve.Size = new System.Drawing.Size(64, 64);
            this.imagenNieve.TabIndex = 26;
            this.imagenNieve.TabStop = false;
            this.imagenNieve.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 320);
            this.Controls.Add(this.imagenNieve);
            this.Controls.Add(this.imagenSol);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nbDomingo);
            this.Controls.Add(this.nbSabado);
            this.Controls.Add(this.nbViernes);
            this.Controls.Add(this.nbJueves);
            this.Controls.Add(this.nbMiercoles);
            this.Controls.Add(this.nbMartes);
            this.Controls.Add(this.nbLunes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tfMedia);
            this.Controls.Add(this.btnCalcularMedia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Temperatura Media";
            ((System.ComponentModel.ISupportInitialize)(this.nbLunes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbMartes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbMiercoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbJueves)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbViernes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbSabado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbDomingo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenSol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenNieve)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalcularMedia;
        private System.Windows.Forms.TextBox tfMedia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nbLunes;
        private System.Windows.Forms.NumericUpDown nbMartes;
        private System.Windows.Forms.NumericUpDown nbMiercoles;
        private System.Windows.Forms.NumericUpDown nbJueves;
        private System.Windows.Forms.NumericUpDown nbViernes;
        private System.Windows.Forms.NumericUpDown nbSabado;
        private System.Windows.Forms.NumericUpDown nbDomingo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox imagenSol;
        private System.Windows.Forms.PictureBox imagenNieve;
    }
}

