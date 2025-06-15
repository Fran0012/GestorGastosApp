namespace GestorGastosApp
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
            this.grpABMGrupo = new System.Windows.Forms.GroupBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminarGasto = new System.Windows.Forms.Button();
            this.btnModificarGasto = new System.Windows.Forms.Button();
            this.btnAgregarGasto = new System.Windows.Forms.Button();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.grpListadoGastos = new System.Windows.Forms.GroupBox();
            this.lstGastos = new System.Windows.Forms.ListBox();
            this.grpFiltradoAnalisis = new System.Windows.Forms.GroupBox();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblFiltrarDescr = new System.Windows.Forms.Label();
            this.txtDescripcionFiltrado = new System.Windows.Forms.TextBox();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCategoriaFiltrado = new System.Windows.Forms.ComboBox();
            this.lblCategor = new System.Windows.Forms.Label();
            this.grpABMGrupo.SuspendLayout();
            this.grpListadoGastos.SuspendLayout();
            this.grpFiltradoAnalisis.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpABMGrupo
            // 
            this.grpABMGrupo.Controls.Add(this.dtpFecha);
            this.grpABMGrupo.Controls.Add(this.btnLimpiar);
            this.grpABMGrupo.Controls.Add(this.btnEliminarGasto);
            this.grpABMGrupo.Controls.Add(this.btnModificarGasto);
            this.grpABMGrupo.Controls.Add(this.btnAgregarGasto);
            this.grpABMGrupo.Controls.Add(this.cmbCategoria);
            this.grpABMGrupo.Controls.Add(this.txtDescripcion);
            this.grpABMGrupo.Controls.Add(this.txtMonto);
            this.grpABMGrupo.Controls.Add(this.lblFecha);
            this.grpABMGrupo.Controls.Add(this.lblDescripcion);
            this.grpABMGrupo.Controls.Add(this.lblCategoria);
            this.grpABMGrupo.Controls.Add(this.lblMonto);
            this.grpABMGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.grpABMGrupo.Location = new System.Drawing.Point(12, 12);
            this.grpABMGrupo.Name = "grpABMGrupo";
            this.grpABMGrupo.Size = new System.Drawing.Size(548, 201);
            this.grpABMGrupo.TabIndex = 0;
            this.grpABMGrupo.TabStop = false;
            this.grpABMGrupo.Text = "Gastos";
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(316, 29);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(201, 23);
            this.dtpFecha.TabIndex = 12;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(316, 64);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminarGasto
            // 
            this.btnEliminarGasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnEliminarGasto.Location = new System.Drawing.Point(365, 151);
            this.btnEliminarGasto.Name = "btnEliminarGasto";
            this.btnEliminarGasto.Size = new System.Drawing.Size(115, 31);
            this.btnEliminarGasto.TabIndex = 10;
            this.btnEliminarGasto.Text = "Eliminar Gasto";
            this.btnEliminarGasto.UseVisualStyleBackColor = true;
            this.btnEliminarGasto.Click += new System.EventHandler(this.btnEliminarGasto_Click);
            // 
            // btnModificarGasto
            // 
            this.btnModificarGasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnModificarGasto.Location = new System.Drawing.Point(219, 151);
            this.btnModificarGasto.Name = "btnModificarGasto";
            this.btnModificarGasto.Size = new System.Drawing.Size(115, 31);
            this.btnModificarGasto.TabIndex = 9;
            this.btnModificarGasto.Text = "Modificar Gasto";
            this.btnModificarGasto.UseVisualStyleBackColor = true;
            this.btnModificarGasto.Click += new System.EventHandler(this.btnModificarGasto_Click);
            // 
            // btnAgregarGasto
            // 
            this.btnAgregarGasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnAgregarGasto.Location = new System.Drawing.Point(71, 151);
            this.btnAgregarGasto.Name = "btnAgregarGasto";
            this.btnAgregarGasto.Size = new System.Drawing.Size(115, 31);
            this.btnAgregarGasto.TabIndex = 8;
            this.btnAgregarGasto.Text = "Agregar Gasto";
            this.btnAgregarGasto.UseVisualStyleBackColor = true;
            this.btnAgregarGasto.Click += new System.EventHandler(this.btnAgregarGasto_Click);
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(98, 64);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(201, 25);
            this.cmbCategoria.TabIndex = 6;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtDescripcion.Location = new System.Drawing.Point(98, 105);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(419, 23);
            this.txtDescripcion.TabIndex = 5;
            // 
            // txtMonto
            // 
            this.txtMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtMonto.Location = new System.Drawing.Point(98, 29);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(201, 23);
            this.txtMonto.TabIndex = 4;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblFecha.Location = new System.Drawing.Point(313, 11);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(51, 17);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha:";
            this.lblFecha.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblDescripcion.Location = new System.Drawing.Point(6, 108);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(86, 17);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblCategoria.Location = new System.Drawing.Point(6, 68);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(73, 17);
            this.lblCategoria.TabIndex = 1;
            this.lblCategoria.Text = "Categoría:";
            this.lblCategoria.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblMonto.Location = new System.Drawing.Point(6, 29);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(69, 17);
            this.lblMonto.TabIndex = 0;
            this.lblMonto.Text = "Monto($):";
            this.lblMonto.Click += new System.EventHandler(this.lblMonto_Click);
            // 
            // grpListadoGastos
            // 
            this.grpListadoGastos.Controls.Add(this.lstGastos);
            this.grpListadoGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.grpListadoGastos.Location = new System.Drawing.Point(12, 219);
            this.grpListadoGastos.Name = "grpListadoGastos";
            this.grpListadoGastos.Size = new System.Drawing.Size(548, 255);
            this.grpListadoGastos.TabIndex = 1;
            this.grpListadoGastos.TabStop = false;
            this.grpListadoGastos.Text = "Listado de últimos gastos";
            // 
            // lstGastos
            // 
            this.lstGastos.FormattingEnabled = true;
            this.lstGastos.ItemHeight = 17;
            this.lstGastos.Location = new System.Drawing.Point(28, 32);
            this.lstGastos.Name = "lstGastos";
            this.lstGastos.Size = new System.Drawing.Size(489, 208);
            this.lstGastos.TabIndex = 0;
            this.lstGastos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstGastos_MouseClick);
            this.lstGastos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstGastos_MouseDoubleClick);
            // 
            // grpFiltradoAnalisis
            // 
            this.grpFiltradoAnalisis.Controls.Add(this.dtpHasta);
            this.grpFiltradoAnalisis.Controls.Add(this.dtpDesde);
            this.grpFiltradoAnalisis.Controls.Add(this.btnBuscar);
            this.grpFiltradoAnalisis.Controls.Add(this.lblFiltrarDescr);
            this.grpFiltradoAnalisis.Controls.Add(this.txtDescripcionFiltrado);
            this.grpFiltradoAnalisis.Controls.Add(this.lblHasta);
            this.grpFiltradoAnalisis.Controls.Add(this.lblDesde);
            this.grpFiltradoAnalisis.Controls.Add(this.label1);
            this.grpFiltradoAnalisis.Controls.Add(this.cmbCategoriaFiltrado);
            this.grpFiltradoAnalisis.Controls.Add(this.lblCategor);
            this.grpFiltradoAnalisis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.grpFiltradoAnalisis.Location = new System.Drawing.Point(12, 480);
            this.grpFiltradoAnalisis.Name = "grpFiltradoAnalisis";
            this.grpFiltradoAnalisis.Size = new System.Drawing.Size(548, 157);
            this.grpFiltradoAnalisis.TabIndex = 3;
            this.grpFiltradoAnalisis.TabStop = false;
            this.grpFiltradoAnalisis.Text = "Filtrado y Análisis";
            // 
            // dtpHasta
            // 
            this.dtpHasta.CustomFormat = "dd/MM/yyyy";
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHasta.Location = new System.Drawing.Point(424, 54);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(105, 23);
            this.dtpHasta.TabIndex = 17;
            // 
            // dtpDesde
            // 
            this.dtpDesde.CustomFormat = "dd/MM/yyyy";
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDesde.Location = new System.Drawing.Point(312, 54);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(106, 23);
            this.dtpDesde.TabIndex = 16;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnBuscar.Location = new System.Drawing.Point(219, 120);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(115, 31);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblFiltrarDescr
            // 
            this.lblFiltrarDescr.AutoSize = true;
            this.lblFiltrarDescr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblFiltrarDescr.Location = new System.Drawing.Point(8, 86);
            this.lblFiltrarDescr.Name = "lblFiltrarDescr";
            this.lblFiltrarDescr.Size = new System.Drawing.Size(147, 17);
            this.lblFiltrarDescr.TabIndex = 15;
            this.lblFiltrarDescr.Text = "Filtrar por Descripción";
            // 
            // txtDescripcionFiltrado
            // 
            this.txtDescripcionFiltrado.Location = new System.Drawing.Point(170, 83);
            this.txtDescripcionFiltrado.Name = "txtDescripcionFiltrado";
            this.txtDescripcionFiltrado.Size = new System.Drawing.Size(359, 23);
            this.txtDescripcionFiltrado.TabIndex = 11;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblHasta.Location = new System.Drawing.Point(421, 38);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(35, 13);
            this.lblHasta.TabIndex = 14;
            this.lblHasta.Text = "Hasta";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblDesde.Location = new System.Drawing.Point(309, 38);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(38, 13);
            this.lblDesde.TabIndex = 13;
            this.lblDesde.Text = "Desde";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(309, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccionar Fecha";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // cmbCategoriaFiltrado
            // 
            this.cmbCategoriaFiltrado.FormattingEnabled = true;
            this.cmbCategoriaFiltrado.Location = new System.Drawing.Point(170, 52);
            this.cmbCategoriaFiltrado.Name = "cmbCategoriaFiltrado";
            this.cmbCategoriaFiltrado.Size = new System.Drawing.Size(121, 25);
            this.cmbCategoriaFiltrado.TabIndex = 1;
            // 
            // lblCategor
            // 
            this.lblCategor.AutoSize = true;
            this.lblCategor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblCategor.Location = new System.Drawing.Point(8, 52);
            this.lblCategor.Name = "lblCategor";
            this.lblCategor.Size = new System.Drawing.Size(144, 17);
            this.lblCategor.TabIndex = 0;
            this.lblCategor.Text = "Mostrar por categoría";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 649);
            this.Controls.Add(this.grpFiltradoAnalisis);
            this.Controls.Add(this.grpListadoGastos);
            this.Controls.Add(this.grpABMGrupo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDoubleClick);
            this.grpABMGrupo.ResumeLayout(false);
            this.grpABMGrupo.PerformLayout();
            this.grpListadoGastos.ResumeLayout(false);
            this.grpFiltradoAnalisis.ResumeLayout(false);
            this.grpFiltradoAnalisis.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpABMGrupo;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Button btnEliminarGasto;
        private System.Windows.Forms.Button btnModificarGasto;
        private System.Windows.Forms.Button btnAgregarGasto;
        private System.Windows.Forms.GroupBox grpListadoGastos;
        private System.Windows.Forms.ListBox lstGastos;
        private System.Windows.Forms.GroupBox grpFiltradoAnalisis;
        private System.Windows.Forms.Label lblCategor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCategoriaFiltrado;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.TextBox txtDescripcionFiltrado;
        private System.Windows.Forms.Label lblFiltrarDescr;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
    }
}

