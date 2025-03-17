namespace Practica_2
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
            this.btnPruebaRun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPruebaRun
            // 
            this.btnPruebaRun.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnPruebaRun.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPruebaRun.Image = global::Practica_2.Properties.Resources.iorio;
            this.btnPruebaRun.Location = new System.Drawing.Point(317, 150);
            this.btnPruebaRun.Name = "btnPruebaRun";
            this.btnPruebaRun.Size = new System.Drawing.Size(146, 77);
            this.btnPruebaRun.TabIndex = 0;
            this.btnPruebaRun.Text = "RUN";
            this.btnPruebaRun.UseVisualStyleBackColor = false;
            this.btnPruebaRun.Click += new System.EventHandler(this.btnPruebaRun_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPruebaRun);
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.Form1_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPruebaRun;
    }
}

