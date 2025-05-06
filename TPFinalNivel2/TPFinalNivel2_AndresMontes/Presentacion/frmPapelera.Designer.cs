namespace Presentacion
{
    partial class frmPapelera
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
            this.dgvPapelera = new System.Windows.Forms.DataGridView();
            this.btnPapElim = new System.Windows.Forms.Button();
            this.btnPapRest = new System.Windows.Forms.Button();
            this.btnPapVaciar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPapelera)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPapelera
            // 
            this.dgvPapelera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPapelera.Location = new System.Drawing.Point(12, 12);
            this.dgvPapelera.Name = "dgvPapelera";
            this.dgvPapelera.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPapelera.Size = new System.Drawing.Size(911, 330);
            this.dgvPapelera.TabIndex = 0;
            this.dgvPapelera.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPapelera_CellContentClick);
            // 
            // btnPapElim
            // 
            this.btnPapElim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPapElim.Location = new System.Drawing.Point(12, 352);
            this.btnPapElim.Name = "btnPapElim";
            this.btnPapElim.Size = new System.Drawing.Size(85, 33);
            this.btnPapElim.TabIndex = 1;
            this.btnPapElim.Text = "Eliminar";
            this.btnPapElim.UseVisualStyleBackColor = true;
            this.btnPapElim.Click += new System.EventHandler(this.btnPapElim_Click);
            // 
            // btnPapRest
            // 
            this.btnPapRest.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPapRest.Location = new System.Drawing.Point(103, 352);
            this.btnPapRest.Name = "btnPapRest";
            this.btnPapRest.Size = new System.Drawing.Size(85, 33);
            this.btnPapRest.TabIndex = 2;
            this.btnPapRest.Text = "Restaurar";
            this.btnPapRest.UseVisualStyleBackColor = true;
            // 
            // btnPapVaciar
            // 
            this.btnPapVaciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPapVaciar.Location = new System.Drawing.Point(781, 352);
            this.btnPapVaciar.Name = "btnPapVaciar";
            this.btnPapVaciar.Size = new System.Drawing.Size(142, 33);
            this.btnPapVaciar.TabIndex = 3;
            this.btnPapVaciar.Text = "Vaciar papelera";
            this.btnPapVaciar.UseVisualStyleBackColor = true;
            // 
            // frmPapelera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 450);
            this.Controls.Add(this.btnPapVaciar);
            this.Controls.Add(this.btnPapRest);
            this.Controls.Add(this.btnPapElim);
            this.Controls.Add(this.dgvPapelera);
            this.Name = "frmPapelera";
            this.Text = "Papelera de reciclaje";
            this.Load += new System.EventHandler(this.frmPapelera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPapelera)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPapelera;
        private System.Windows.Forms.Button btnPapElim;
        private System.Windows.Forms.Button btnPapRest;
        private System.Windows.Forms.Button btnPapVaciar;
    }
}