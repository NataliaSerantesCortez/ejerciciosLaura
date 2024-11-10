namespace TotalPagar
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
            this.nbCantidad = new System.Windows.Forms.NumericUpDown();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.tfTotal = new System.Windows.Forms.TextBox();
            this.labelDescuento = new System.Windows.Forms.Label();
            this.imagenDescuento = new System.Windows.Forms.PictureBox();
            this.cbDesglose = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nbCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenDescuento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Precio por unidad:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad:";
            // 
            // nbCantidad
            // 
            this.nbCantidad.Location = new System.Drawing.Point(152, 72);
            this.nbCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbCantidad.Name = "nbCantidad";
            this.nbCantidad.Size = new System.Drawing.Size(72, 21);
            this.nbCantidad.TabIndex = 2;
            this.nbCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(40, 104);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(96, 40);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular Total";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // tfTotal
            // 
            this.tfTotal.Location = new System.Drawing.Point(152, 112);
            this.tfTotal.Name = "tfTotal";
            this.tfTotal.ReadOnly = true;
            this.tfTotal.Size = new System.Drawing.Size(72, 21);
            this.tfTotal.TabIndex = 5;
            // 
            // labelDescuento
            // 
            this.labelDescuento.AutoSize = true;
            this.labelDescuento.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescuento.Location = new System.Drawing.Point(88, 176);
            this.labelDescuento.Name = "labelDescuento";
            this.labelDescuento.Size = new System.Drawing.Size(57, 13);
            this.labelDescuento.TabIndex = 6;
            this.labelDescuento.Text = "Desglose: ";
            this.labelDescuento.Visible = false;
            this.labelDescuento.Click += new System.EventHandler(this.labelDescuento_Click);
            // 
            // imagenDescuento
            // 
            this.imagenDescuento.Image = global::TotalPagar.Properties.Resources.receipt_106581;
            this.imagenDescuento.Location = new System.Drawing.Point(8, 176);
            this.imagenDescuento.Name = "imagenDescuento";
            this.imagenDescuento.Size = new System.Drawing.Size(72, 64);
            this.imagenDescuento.TabIndex = 7;
            this.imagenDescuento.TabStop = false;
            this.imagenDescuento.Visible = false;
            // 
            // cbDesglose
            // 
            this.cbDesglose.AutoSize = true;
            this.cbDesglose.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDesglose.Location = new System.Drawing.Point(24, 152);
            this.cbDesglose.Name = "cbDesglose";
            this.cbDesglose.Size = new System.Drawing.Size(90, 20);
            this.cbDesglose.TabIndex = 8;
            this.cbDesglose.Text = "Ver factura";
            this.cbDesglose.UseVisualStyleBackColor = true;
            this.cbDesglose.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Location = new System.Drawing.Point(152, 32);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(72, 21);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 242);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.cbDesglose);
            this.Controls.Add(this.imagenDescuento);
            this.Controls.Add(this.labelDescuento);
            this.Controls.Add(this.tfTotal);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.nbCantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Total a pagar";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nbCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenDescuento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nbCantidad;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox tfTotal;
        private System.Windows.Forms.Label labelDescuento;
        private System.Windows.Forms.PictureBox imagenDescuento;
        private System.Windows.Forms.CheckBox cbDesglose;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

