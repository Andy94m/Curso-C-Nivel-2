namespace Presentacion
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
            this.lblBuscarRap = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pcbCatalogo = new System.Windows.Forms.PictureBox();
            this.lblBuscarAvn = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar2 = new System.Windows.Forms.Button();
            this.btnEliminar1 = new System.Windows.Forms.Button();
            this.btnBusqAdv = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCatalogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBuscarRap
            // 
            this.lblBuscarRap.AutoSize = true;
            this.lblBuscarRap.Location = new System.Drawing.Point(47, 339);
            this.lblBuscarRap.Name = "lblBuscarRap";
            this.lblBuscarRap.Size = new System.Drawing.Size(43, 13);
            this.lblBuscarRap.TabIndex = 0;
            this.lblBuscarRap.Text = "Buscar:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 336);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(96, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(567, 298);
            this.dataGridView1.TabIndex = 2;
            // 
            // pcbCatalogo
            // 
            this.pcbCatalogo.Location = new System.Drawing.Point(689, 32);
            this.pcbCatalogo.Name = "pcbCatalogo";
            this.pcbCatalogo.Size = new System.Drawing.Size(300, 298);
            this.pcbCatalogo.TabIndex = 3;
            this.pcbCatalogo.TabStop = false;
            // 
            // lblBuscarAvn
            // 
            this.lblBuscarAvn.AutoSize = true;
            this.lblBuscarAvn.Location = new System.Drawing.Point(47, 372);
            this.lblBuscarAvn.Name = "lblBuscarAvn";
            this.lblBuscarAvn.Size = new System.Drawing.Size(105, 13);
            this.lblBuscarAvn.TabIndex = 4;
            this.lblBuscarAvn.Text = "Busqueda avanzada";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 32);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(12, 61);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar2
            // 
            this.btnEliminar2.Location = new System.Drawing.Point(12, 119);
            this.btnEliminar2.Name = "btnEliminar2";
            this.btnEliminar2.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar2.TabIndex = 7;
            this.btnEliminar2.Text = "Eliminar2";
            this.btnEliminar2.UseVisualStyleBackColor = true;
            // 
            // btnEliminar1
            // 
            this.btnEliminar1.Location = new System.Drawing.Point(12, 90);
            this.btnEliminar1.Name = "btnEliminar1";
            this.btnEliminar1.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar1.TabIndex = 8;
            this.btnEliminar1.Text = "Eliminar1";
            this.btnEliminar1.UseVisualStyleBackColor = true;
            // 
            // btnBusqAdv
            // 
            this.btnBusqAdv.Location = new System.Drawing.Point(311, 334);
            this.btnBusqAdv.Name = "btnBusqAdv";
            this.btnBusqAdv.Size = new System.Drawing.Size(88, 23);
            this.btnBusqAdv.TabIndex = 9;
            this.btnBusqAdv.Text = "Avanzada";
            this.btnBusqAdv.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 506);
            this.Controls.Add(this.btnBusqAdv);
            this.Controls.Add(this.btnEliminar1);
            this.Controls.Add(this.btnEliminar2);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblBuscarAvn);
            this.Controls.Add(this.pcbCatalogo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblBuscarRap);
            this.Name = "Form1";
            this.Text = "Catalogo Comercio";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCatalogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBuscarRap;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pcbCatalogo;
        private System.Windows.Forms.Label lblBuscarAvn;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar2;
        private System.Windows.Forms.Button btnEliminar1;
        private System.Windows.Forms.Button btnBusqAdv;
    }
}

