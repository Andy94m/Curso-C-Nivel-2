namespace Practica4
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
            this.txbPrincipal = new System.Windows.Forms.TextBox();
            this.lblPrueba = new System.Windows.Forms.Label();
            this.btnPUM = new System.Windows.Forms.Button();
            this.txbSecundario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txbPrincipal
            // 
            this.txbPrincipal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbPrincipal.Location = new System.Drawing.Point(256, 98);
            this.txbPrincipal.MaxLength = 100;
            this.txbPrincipal.Name = "txbPrincipal";
            this.txbPrincipal.Size = new System.Drawing.Size(210, 20);
            this.txbPrincipal.TabIndex = 0;
            this.txbPrincipal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPrincipal_KeyPress);
            // 
            // lblPrueba
            // 
            this.lblPrueba.AutoSize = true;
            this.lblPrueba.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrueba.Location = new System.Drawing.Point(132, 98);
            this.lblPrueba.Name = "lblPrueba";
            this.lblPrueba.Size = new System.Drawing.Size(118, 20);
            this.lblPrueba.TabIndex = 1;
            this.lblPrueba.Text = "Escriba algo: ";
            // 
            // btnPUM
            // 
            this.btnPUM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPUM.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPUM.Image = global::Practica4.Properties.Resources.iorio;
            this.btnPUM.Location = new System.Drawing.Point(256, 136);
            this.btnPUM.Name = "btnPUM";
            this.btnPUM.Size = new System.Drawing.Size(200, 76);
            this.btnPUM.TabIndex = 2;
            this.btnPUM.Text = "Esa mirada, esa maldita mirada";
            this.btnPUM.UseVisualStyleBackColor = true;
            this.btnPUM.Click += new System.EventHandler(this.btnPUM_Click);
            // 
            // txbSecundario
            // 
            this.txbSecundario.Location = new System.Drawing.Point(492, 149);
            this.txbSecundario.Multiline = true;
            this.txbSecundario.Name = "txbSecundario";
            this.txbSecundario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbSecundario.Size = new System.Drawing.Size(207, 46);
            this.txbSecundario.TabIndex = 3;
            this.txbSecundario.Leave += new System.EventHandler(this.txbSecundario_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbSecundario);
            this.Controls.Add(this.btnPUM);
            this.Controls.Add(this.lblPrueba);
            this.Controls.Add(this.txbPrincipal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbPrincipal;
        private System.Windows.Forms.Label lblPrueba;
        private System.Windows.Forms.Button btnPUM;
        private System.Windows.Forms.TextBox txbSecundario;
    }
}

