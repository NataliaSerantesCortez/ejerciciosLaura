namespace CuentaBancaria
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
            this.cbCuentas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelCuotaMantenimiento = new System.Windows.Forms.Label();
            this.cbCuentaAhorro = new System.Windows.Forms.CheckBox();
            this.tfNumeroCuenta = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tfTitular = new System.Windows.Forms.TextBox();
            this.tfSaldo = new System.Windows.Forms.TextBox();
            this.tfInteres = new System.Windows.Forms.TextBox();
            this.tfCuotaMantenimiento = new System.Windows.Forms.TextBox();
            this.btnNueva = new System.Windows.Forms.Button();
            this.imagenGuardar = new System.Windows.Forms.PictureBox();
            this.labelRegistro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenGuardar)).BeginInit();
            this.SuspendLayout();
            // 
            // cbCuentas
            // 
            this.cbCuentas.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCuentas.FormattingEnabled = true;
            this.cbCuentas.Location = new System.Drawing.Point(176, 32);
            this.cbCuentas.Name = "cbCuentas";
            this.cbCuentas.Size = new System.Drawing.Size(136, 24);
            this.cbCuentas.TabIndex = 0;
            this.cbCuentas.SelectedIndexChanged += new System.EventHandler(this.cbCuentas_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selección de cuenta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Número cuenta:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Titular:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Saldo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Interés (%):";
            // 
            // labelCuotaMantenimiento
            // 
            this.labelCuotaMantenimiento.AutoSize = true;
            this.labelCuotaMantenimiento.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCuotaMantenimiento.Location = new System.Drawing.Point(24, 248);
            this.labelCuotaMantenimiento.Name = "labelCuotaMantenimiento";
            this.labelCuotaMantenimiento.Size = new System.Drawing.Size(134, 16);
            this.labelCuotaMantenimiento.TabIndex = 6;
            this.labelCuotaMantenimiento.Text = "Cuota mantenimiento:";
            this.labelCuotaMantenimiento.Visible = false;
            // 
            // cbCuentaAhorro
            // 
            this.cbCuentaAhorro.AutoSize = true;
            this.cbCuentaAhorro.Enabled = false;
            this.cbCuentaAhorro.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCuentaAhorro.Location = new System.Drawing.Point(24, 280);
            this.cbCuentaAhorro.Name = "cbCuentaAhorro";
            this.cbCuentaAhorro.Size = new System.Drawing.Size(126, 20);
            this.cbCuentaAhorro.TabIndex = 7;
            this.cbCuentaAhorro.Text = "Cuenta de ahorro";
            this.cbCuentaAhorro.UseVisualStyleBackColor = true;
            this.cbCuentaAhorro.CheckedChanged += new System.EventHandler(this.cbCuentaAhorro_CheckedChanged);
            // 
            // tfNumeroCuenta
            // 
            this.tfNumeroCuenta.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tfNumeroCuenta.Location = new System.Drawing.Point(176, 88);
            this.tfNumeroCuenta.Name = "tfNumeroCuenta";
            this.tfNumeroCuenta.ReadOnly = true;
            this.tfNumeroCuenta.Size = new System.Drawing.Size(136, 23);
            this.tfNumeroCuenta.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CuentaBancaria.Properties.Resources.coin_money_icon_icons1;
            this.pictureBox1.Location = new System.Drawing.Point(360, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 64);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // tfTitular
            // 
            this.tfTitular.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tfTitular.Location = new System.Drawing.Point(176, 128);
            this.tfTitular.Name = "tfTitular";
            this.tfTitular.ReadOnly = true;
            this.tfTitular.Size = new System.Drawing.Size(136, 23);
            this.tfTitular.TabIndex = 10;
            // 
            // tfSaldo
            // 
            this.tfSaldo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tfSaldo.Location = new System.Drawing.Point(176, 168);
            this.tfSaldo.Name = "tfSaldo";
            this.tfSaldo.ReadOnly = true;
            this.tfSaldo.Size = new System.Drawing.Size(136, 23);
            this.tfSaldo.TabIndex = 11;
            // 
            // tfInteres
            // 
            this.tfInteres.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tfInteres.Location = new System.Drawing.Point(176, 208);
            this.tfInteres.Name = "tfInteres";
            this.tfInteres.ReadOnly = true;
            this.tfInteres.Size = new System.Drawing.Size(136, 23);
            this.tfInteres.TabIndex = 12;
            // 
            // tfCuotaMantenimiento
            // 
            this.tfCuotaMantenimiento.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tfCuotaMantenimiento.Location = new System.Drawing.Point(176, 248);
            this.tfCuotaMantenimiento.Name = "tfCuotaMantenimiento";
            this.tfCuotaMantenimiento.ReadOnly = true;
            this.tfCuotaMantenimiento.Size = new System.Drawing.Size(136, 23);
            this.tfCuotaMantenimiento.TabIndex = 13;
            this.tfCuotaMantenimiento.Visible = false;
            // 
            // btnNueva
            // 
            this.btnNueva.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNueva.Location = new System.Drawing.Point(360, 264);
            this.btnNueva.Name = "btnNueva";
            this.btnNueva.Size = new System.Drawing.Size(75, 48);
            this.btnNueva.TabIndex = 14;
            this.btnNueva.Text = "Nueva";
            this.btnNueva.UseVisualStyleBackColor = true;
            this.btnNueva.Click += new System.EventHandler(this.btnNueva_Click);
            // 
            // imagenGuardar
            // 
            this.imagenGuardar.Enabled = false;
            this.imagenGuardar.Image = global::CuentaBancaria.Properties.Resources.Save_37110;
            this.imagenGuardar.Location = new System.Drawing.Point(368, 264);
            this.imagenGuardar.Name = "imagenGuardar";
            this.imagenGuardar.Size = new System.Drawing.Size(56, 50);
            this.imagenGuardar.TabIndex = 15;
            this.imagenGuardar.TabStop = false;
            this.imagenGuardar.Visible = false;
            this.imagenGuardar.Click += new System.EventHandler(this.imagenGuardar_Click);
            // 
            // labelRegistro
            // 
            this.labelRegistro.AutoSize = true;
            this.labelRegistro.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistro.Location = new System.Drawing.Point(24, 320);
            this.labelRegistro.Name = "labelRegistro";
            this.labelRegistro.Size = new System.Drawing.Size(199, 16);
            this.labelRegistro.TabIndex = 16;
            this.labelRegistro.Text = "Registro guardado correctamente";
            this.labelRegistro.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 346);
            this.Controls.Add(this.labelRegistro);
            this.Controls.Add(this.imagenGuardar);
            this.Controls.Add(this.btnNueva);
            this.Controls.Add(this.tfCuotaMantenimiento);
            this.Controls.Add(this.tfInteres);
            this.Controls.Add(this.tfSaldo);
            this.Controls.Add(this.tfTitular);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tfNumeroCuenta);
            this.Controls.Add(this.cbCuentaAhorro);
            this.Controls.Add(this.labelCuotaMantenimiento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCuentas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Banco";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenGuardar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCuentas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelCuotaMantenimiento;
        private System.Windows.Forms.CheckBox cbCuentaAhorro;
        private System.Windows.Forms.TextBox tfNumeroCuenta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tfTitular;
        private System.Windows.Forms.TextBox tfSaldo;
        private System.Windows.Forms.TextBox tfInteres;
        private System.Windows.Forms.TextBox tfCuotaMantenimiento;
        private System.Windows.Forms.Button btnNueva;
        private System.Windows.Forms.PictureBox imagenGuardar;
        private System.Windows.Forms.Label labelRegistro;
    }
}

