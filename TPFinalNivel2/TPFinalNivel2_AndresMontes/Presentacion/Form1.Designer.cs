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
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.pcbCatalogo = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnPapelera = new System.Windows.Forms.Button();
            this.btnEliminar1 = new System.Windows.Forms.Button();
            this.btnBusqAdv = new System.Windows.Forms.Button();
            this.cboColumna = new System.Windows.Forms.ComboBox();
            this.cboCriterio = new System.Windows.Forms.ComboBox();
            this.txtBusqFiltro = new System.Windows.Forms.TextBox();
            this.lblColumna = new System.Windows.Forms.Label();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.btnFiltro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCatalogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBuscarRap
            // 
            this.lblBuscarRap.AutoSize = true;
            this.lblBuscarRap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarRap.Location = new System.Drawing.Point(33, 390);
            this.lblBuscarRap.Name = "lblBuscarRap";
            this.lblBuscarRap.Size = new System.Drawing.Size(59, 18);
            this.lblBuscarRap.TabIndex = 0;
            this.lblBuscarRap.Text = "Buscar:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(101, 387);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(209, 20);
            this.txtFiltro.TabIndex = 1;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(101, 15);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.Size = new System.Drawing.Size(662, 353);
            this.dgvArticulos.TabIndex = 2;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // pcbCatalogo
            // 
            this.pcbCatalogo.Location = new System.Drawing.Point(771, 15);
            this.pcbCatalogo.Name = "pcbCatalogo";
            this.pcbCatalogo.Size = new System.Drawing.Size(300, 353);
            this.pcbCatalogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCatalogo.TabIndex = 3;
            this.pcbCatalogo.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(12, 15);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(79, 27);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(12, 48);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(79, 31);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnPapelera
            // 
            this.btnPapelera.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPapelera.Location = new System.Drawing.Point(13, 341);
            this.btnPapelera.Name = "btnPapelera";
            this.btnPapelera.Size = new System.Drawing.Size(79, 27);
            this.btnPapelera.TabIndex = 7;
            this.btnPapelera.Text = "Papelera";
            this.btnPapelera.UseVisualStyleBackColor = true;
            // 
            // btnEliminar1
            // 
            this.btnEliminar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar1.Location = new System.Drawing.Point(12, 85);
            this.btnEliminar1.Name = "btnEliminar1";
            this.btnEliminar1.Size = new System.Drawing.Size(78, 27);
            this.btnEliminar1.TabIndex = 8;
            this.btnEliminar1.Text = "Eliminar1";
            this.btnEliminar1.UseVisualStyleBackColor = true;
            this.btnEliminar1.Click += new System.EventHandler(this.btnEliminar1_Click);
            // 
            // btnBusqAdv
            // 
            this.btnBusqAdv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusqAdv.Location = new System.Drawing.Point(316, 381);
            this.btnBusqAdv.Name = "btnBusqAdv";
            this.btnBusqAdv.Size = new System.Drawing.Size(88, 27);
            this.btnBusqAdv.TabIndex = 9;
            this.btnBusqAdv.Text = "Avanzada";
            this.btnBusqAdv.UseVisualStyleBackColor = true;
            // 
            // cboColumna
            // 
            this.cboColumna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboColumna.FormattingEnabled = true;
            this.cboColumna.Location = new System.Drawing.Point(97, 466);
            this.cboColumna.Name = "cboColumna";
            this.cboColumna.Size = new System.Drawing.Size(121, 21);
            this.cboColumna.TabIndex = 10;
            this.cboColumna.SelectedIndexChanged += new System.EventHandler(this.cboColumna_SelectedIndexChanged);
            // 
            // cboCriterio
            // 
            this.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterio.FormattingEnabled = true;
            this.cboCriterio.Location = new System.Drawing.Point(98, 500);
            this.cboCriterio.Name = "cboCriterio";
            this.cboCriterio.Size = new System.Drawing.Size(121, 21);
            this.cboCriterio.TabIndex = 11;
            // 
            // txtBusqFiltro
            // 
            this.txtBusqFiltro.Location = new System.Drawing.Point(98, 533);
            this.txtBusqFiltro.Name = "txtBusqFiltro";
            this.txtBusqFiltro.Size = new System.Drawing.Size(209, 20);
            this.txtBusqFiltro.TabIndex = 12;
            // 
            // lblColumna
            // 
            this.lblColumna.AutoSize = true;
            this.lblColumna.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColumna.Location = new System.Drawing.Point(20, 469);
            this.lblColumna.Name = "lblColumna";
            this.lblColumna.Size = new System.Drawing.Size(72, 18);
            this.lblColumna.TabIndex = 13;
            this.lblColumna.Text = "Columna:";
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriterio.Location = new System.Drawing.Point(32, 503);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(60, 18);
            this.lblCriterio.TabIndex = 14;
            this.lblCriterio.Text = "Criterio:";
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusqueda.Location = new System.Drawing.Point(14, 535);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(78, 18);
            this.lblBusqueda.TabIndex = 15;
            this.lblBusqueda.Text = "Busqueda:";
            // 
            // btnFiltro
            // 
            this.btnFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltro.Location = new System.Drawing.Point(313, 533);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(88, 24);
            this.btnFiltro.TabIndex = 16;
            this.btnFiltro.Text = "Buscar";
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 604);
            this.Controls.Add(this.btnFiltro);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.lblCriterio);
            this.Controls.Add(this.lblColumna);
            this.Controls.Add(this.txtBusqFiltro);
            this.Controls.Add(this.cboCriterio);
            this.Controls.Add(this.cboColumna);
            this.Controls.Add(this.btnBusqAdv);
            this.Controls.Add(this.btnEliminar1);
            this.Controls.Add(this.btnPapelera);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pcbCatalogo);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.lblBuscarRap);
            this.Name = "Form1";
            this.Text = "Catalogo Comercio";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCatalogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBuscarRap;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.PictureBox pcbCatalogo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnPapelera;
        private System.Windows.Forms.Button btnEliminar1;
        private System.Windows.Forms.Button btnBusqAdv;
        private System.Windows.Forms.ComboBox cboColumna;
        private System.Windows.Forms.ComboBox cboCriterio;
        private System.Windows.Forms.TextBox txtBusqFiltro;
        private System.Windows.Forms.Label lblColumna;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.Button btnFiltro;
    }
}

