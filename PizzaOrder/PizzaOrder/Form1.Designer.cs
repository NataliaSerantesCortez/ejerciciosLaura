namespace PizzaOrder
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
            this.Logotipo = new System.Windows.Forms.PictureBox();
            this.labelEmpresa = new System.Windows.Forms.Label();
            this.labelCliente = new System.Windows.Forms.Label();
            this.nombreCliente = new System.Windows.Forms.TextBox();
            this.opcionesTamanio = new System.Windows.Forms.GroupBox();
            this.pizzaPequenia = new System.Windows.Forms.RadioButton();
            this.pizzaGrande = new System.Windows.Forms.RadioButton();
            this.labelToppings = new System.Windows.Forms.Label();
            this.toppings = new System.Windows.Forms.CheckedListBox();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.botonPedir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Logotipo)).BeginInit();
            this.opcionesTamanio.SuspendLayout();
            this.SuspendLayout();
            // 
            // Logotipo
            // 
            this.Logotipo.AccessibleDescription = "Logo de Domino\'s pizza, ficha del juego dominó";
            this.Logotipo.AccessibleName = "Logotipo de la empresa";
            this.Logotipo.BackColor = System.Drawing.Color.Blue;
            this.Logotipo.Image = global::PizzaOrder.Properties.Resources.logo_orange_domino_pizza_icon_134362;
            this.Logotipo.Location = new System.Drawing.Point(24, 32);
            this.Logotipo.Name = "Logotipo";
            this.Logotipo.Size = new System.Drawing.Size(64, 64);
            this.Logotipo.TabIndex = 0;
            this.Logotipo.TabStop = false;
            // 
            // labelEmpresa
            // 
            this.labelEmpresa.AccessibleDescription = "Domino´s Pizza, nombre de la empresa";
            this.labelEmpresa.AccessibleName = "Nombre de la empresa";
            this.labelEmpresa.AutoSize = true;
            this.labelEmpresa.BackColor = System.Drawing.Color.Blue;
            this.labelEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpresa.ForeColor = System.Drawing.Color.Yellow;
            this.labelEmpresa.Location = new System.Drawing.Point(168, 48);
            this.labelEmpresa.Name = "labelEmpresa";
            this.labelEmpresa.Size = new System.Drawing.Size(176, 29);
            this.labelEmpresa.TabIndex = 1;
            this.labelEmpresa.Text = "Domino\'s Pizza";
            // 
            // labelCliente
            // 
            this.labelCliente.AccessibleDescription = "Etiqueta de nombre de cliente";
            this.labelCliente.AccessibleName = "Etiqueta de nombre de cliente";
            this.labelCliente.AutoSize = true;
            this.labelCliente.Location = new System.Drawing.Point(216, 112);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(56, 16);
            this.labelCliente.TabIndex = 2;
            this.labelCliente.Text = "&Nombre";
            // 
            // nombreCliente
            // 
            this.nombreCliente.AccessibleDescription = "Nombre del cliente";
            this.nombreCliente.AccessibleName = "Nombre del cliente";
            this.nombreCliente.Location = new System.Drawing.Point(288, 104);
            this.nombreCliente.Name = "nombreCliente";
            this.nombreCliente.Size = new System.Drawing.Size(100, 22);
            this.nombreCliente.TabIndex = 3;
            // 
            // opcionesTamanio
            // 
            this.opcionesTamanio.AccessibleDescription = "Opciones de tamaño de pizza";
            this.opcionesTamanio.AccessibleName = "Opciones de tamaño de pizza";
            this.opcionesTamanio.Controls.Add(this.pizzaPequenia);
            this.opcionesTamanio.Controls.Add(this.pizzaGrande);
            this.opcionesTamanio.Location = new System.Drawing.Point(16, 168);
            this.opcionesTamanio.Name = "opcionesTamanio";
            this.opcionesTamanio.Size = new System.Drawing.Size(200, 100);
            this.opcionesTamanio.TabIndex = 4;
            this.opcionesTamanio.TabStop = false;
            this.opcionesTamanio.Text = "Tamaño de la pizza";
            // 
            // pizzaPequenia
            // 
            this.pizzaPequenia.AccessibleDescription = "Pizza pequeña";
            this.pizzaPequenia.AccessibleName = "Pizza pequeña";
            this.pizzaPequenia.AutoSize = true;
            this.pizzaPequenia.Checked = true;
            this.pizzaPequenia.Location = new System.Drawing.Point(24, 32);
            this.pizzaPequenia.Name = "pizzaPequenia";
            this.pizzaPequenia.Size = new System.Drawing.Size(114, 20);
            this.pizzaPequenia.TabIndex = 0;
            this.pizzaPequenia.TabStop = true;
            this.pizzaPequenia.Text = "&Pequeña 6.00€";
            this.pizzaPequenia.UseVisualStyleBackColor = true;
            // 
            // pizzaGrande
            // 
            this.pizzaGrande.AccessibleDescription = "Pizza grande";
            this.pizzaGrande.AccessibleName = "Pizza grande";
            this.pizzaGrande.AutoSize = true;
            this.pizzaGrande.Location = new System.Drawing.Point(24, 64);
            this.pizzaGrande.Name = "pizzaGrande";
            this.pizzaGrande.Size = new System.Drawing.Size(111, 20);
            this.pizzaGrande.TabIndex = 1;
            this.pizzaGrande.Text = "&Grande 10.00€";
            this.pizzaGrande.UseVisualStyleBackColor = true;
            // 
            // labelToppings
            // 
            this.labelToppings.AccessibleDescription = "Etiqueta de ingredientes";
            this.labelToppings.AccessibleName = "Etiqueta de ingredientes";
            this.labelToppings.AutoSize = true;
            this.labelToppings.Location = new System.Drawing.Point(240, 168);
            this.labelToppings.Name = "labelToppings";
            this.labelToppings.Size = new System.Drawing.Size(166, 16);
            this.labelToppings.TabIndex = 5;
            this.labelToppings.Text = "&Toppings (0.75€ cada uno)";
            // 
            // toppings
            // 
            this.toppings.AccessibleDescription = "Ingredientes disponibles";
            this.toppings.AccessibleName = "Ingredientes disponibles";
            this.toppings.FormattingEnabled = true;
            this.toppings.Items.AddRange(new object[] {
            "David",
            "Cristina",
            "Alejandro",
            "Paul",
            "Sergio"});
            this.toppings.Location = new System.Drawing.Point(240, 192);
            this.toppings.Name = "toppings";
            this.toppings.Size = new System.Drawing.Size(120, 89);
            this.toppings.TabIndex = 6;
            // 
            // botonCancelar
            // 
            this.botonCancelar.AccessibleDescription = "Cancelar el pedido";
            this.botonCancelar.AccessibleName = "Cancelar el pedido";
            this.botonCancelar.Location = new System.Drawing.Point(88, 312);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(75, 23);
            this.botonCancelar.TabIndex = 8;
            this.botonCancelar.Text = "&Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            // 
            // botonPedir
            // 
            this.botonPedir.AccessibleDescription = "Total del pedido";
            this.botonPedir.AccessibleName = "Total del pedido";
            this.botonPedir.Location = new System.Drawing.Point(240, 312);
            this.botonPedir.Name = "botonPedir";
            this.botonPedir.Size = new System.Drawing.Size(75, 23);
            this.botonPedir.TabIndex = 7;
            this.botonPedir.Text = "&Pedir";
            this.botonPedir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AccessibleDescription = "Formulario de pedido";
            this.AccessibleName = "Formulario de pedido";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 365);
            this.Controls.Add(this.botonPedir);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.toppings);
            this.Controls.Add(this.labelToppings);
            this.Controls.Add(this.opcionesTamanio);
            this.Controls.Add(this.nombreCliente);
            this.Controls.Add(this.labelCliente);
            this.Controls.Add(this.labelEmpresa);
            this.Controls.Add(this.Logotipo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Formulario de pedidos de pizza - Natalia Serantes";
            ((System.ComponentModel.ISupportInitialize)(this.Logotipo)).EndInit();
            this.opcionesTamanio.ResumeLayout(false);
            this.opcionesTamanio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Logotipo;
        private System.Windows.Forms.Label labelEmpresa;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.TextBox nombreCliente;
        private System.Windows.Forms.GroupBox opcionesTamanio;
        private System.Windows.Forms.RadioButton pizzaPequenia;
        private System.Windows.Forms.RadioButton pizzaGrande;
        private System.Windows.Forms.Label labelToppings;
        private System.Windows.Forms.CheckedListBox toppings;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.Button botonPedir;
    }
}

