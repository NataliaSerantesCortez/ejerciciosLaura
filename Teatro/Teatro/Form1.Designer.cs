namespace Teatro
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.quintoDescuento = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cuartoDescuento = new System.Windows.Forms.NumericUpDown();
            this.tercerDescuento = new System.Windows.Forms.NumericUpDown();
            this.primerDescuento = new System.Windows.Forms.NumericUpDown();
            this.segundoDescuento = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.sextoDescuento = new System.Windows.Forms.NumericUpDown();
            this.btnComprar = new System.Windows.Forms.Button();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quintoDescuento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuartoDescuento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tercerDescuento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.primerDescuento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.segundoDescuento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sextoDescuento)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 40);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "SELECCIONA TUS ENTRADAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "5 A 14 años:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "15 a 19 años: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "20 a 45 años:";
            // 
            // quintoDescuento
            // 
            this.quintoDescuento.Location = new System.Drawing.Point(152, 240);
            this.quintoDescuento.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.quintoDescuento.Name = "quintoDescuento";
            this.quintoDescuento.Size = new System.Drawing.Size(72, 20);
            this.quintoDescuento.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "46 a 65 años:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Mayores de 65 años:";
            // 
            // cuartoDescuento
            // 
            this.cuartoDescuento.Location = new System.Drawing.Point(152, 200);
            this.cuartoDescuento.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.cuartoDescuento.Name = "cuartoDescuento";
            this.cuartoDescuento.Size = new System.Drawing.Size(72, 20);
            this.cuartoDescuento.TabIndex = 7;
            // 
            // tercerDescuento
            // 
            this.tercerDescuento.Location = new System.Drawing.Point(152, 160);
            this.tercerDescuento.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.tercerDescuento.Name = "tercerDescuento";
            this.tercerDescuento.Size = new System.Drawing.Size(72, 20);
            this.tercerDescuento.TabIndex = 8;
            // 
            // primerDescuento
            // 
            this.primerDescuento.Location = new System.Drawing.Point(152, 80);
            this.primerDescuento.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.primerDescuento.Name = "primerDescuento";
            this.primerDescuento.Size = new System.Drawing.Size(72, 20);
            this.primerDescuento.TabIndex = 9;
            // 
            // segundoDescuento
            // 
            this.segundoDescuento.Location = new System.Drawing.Point(152, 120);
            this.segundoDescuento.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.segundoDescuento.Name = "segundoDescuento";
            this.segundoDescuento.Size = new System.Drawing.Size(72, 20);
            this.segundoDescuento.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Diversidad funcional:";
            // 
            // sextoDescuento
            // 
            this.sextoDescuento.Location = new System.Drawing.Point(152, 280);
            this.sextoDescuento.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.sextoDescuento.Name = "sextoDescuento";
            this.sextoDescuento.Size = new System.Drawing.Size(72, 20);
            this.sextoDescuento.TabIndex = 12;
            // 
            // btnComprar
            // 
            this.btnComprar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprar.Location = new System.Drawing.Point(40, 344);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(75, 23);
            this.btnComprar.TabIndex = 13;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(152, 344);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(72, 20);
            this.tbTotal.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Valor entrada 8,20 €";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label9.Location = new System.Drawing.Point(24, 320);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(173, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "Máximo 5 entradas por compra.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 378);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.sextoDescuento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.segundoDescuento);
            this.Controls.Add(this.primerDescuento);
            this.Controls.Add(this.tercerDescuento);
            this.Controls.Add(this.cuartoDescuento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.quintoDescuento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Teatro";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quintoDescuento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuartoDescuento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tercerDescuento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.primerDescuento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.segundoDescuento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sextoDescuento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown quintoDescuento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown cuartoDescuento;
        private System.Windows.Forms.NumericUpDown tercerDescuento;
        private System.Windows.Forms.NumericUpDown primerDescuento;
        private System.Windows.Forms.NumericUpDown segundoDescuento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown sextoDescuento;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

