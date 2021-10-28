namespace SistematicoActivo.Forms
{
    partial class FrmActivo
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lablDescripcion = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblFechaAdquisicion = new System.Windows.Forms.Label();
            this.lblTipoActivoFijo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.nudValorActivo = new System.Windows.Forms.NumericUpDown();
            this.dtpFechaAdquisicion = new System.Windows.Forms.DateTimePicker();
            this.cmbTipoActivo = new System.Windows.Forms.ComboBox();
            this.lblMetodo = new System.Windows.Forms.Label();
            this.cmbTipoMetodo = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudValorActivo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(62, 51);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(62, 110);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lablDescripcion
            // 
            this.lablDescripcion.AutoSize = true;
            this.lablDescripcion.Location = new System.Drawing.Point(62, 161);
            this.lablDescripcion.Name = "lablDescripcion";
            this.lablDescripcion.Size = new System.Drawing.Size(69, 13);
            this.lablDescripcion.TabIndex = 2;
            this.lablDescripcion.Text = "Descripcion: ";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(62, 213);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(37, 13);
            this.lblValor.TabIndex = 3;
            this.lblValor.Text = "Valor: ";
            // 
            // lblFechaAdquisicion
            // 
            this.lblFechaAdquisicion.AutoSize = true;
            this.lblFechaAdquisicion.Location = new System.Drawing.Point(31, 258);
            this.lblFechaAdquisicion.Name = "lblFechaAdquisicion";
            this.lblFechaAdquisicion.Size = new System.Drawing.Size(100, 13);
            this.lblFechaAdquisicion.TabIndex = 4;
            this.lblFechaAdquisicion.Text = "Fecha Adquisicion: ";
            // 
            // lblTipoActivoFijo
            // 
            this.lblTipoActivoFijo.AutoSize = true;
            this.lblTipoActivoFijo.Location = new System.Drawing.Point(38, 311);
            this.lblTipoActivoFijo.Name = "lblTipoActivoFijo";
            this.lblTipoActivoFijo.Size = new System.Drawing.Size(67, 13);
            this.lblTipoActivoFijo.TabIndex = 5;
            this.lblTipoActivoFijo.Text = "Tipo Activo: ";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(153, 48);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(236, 20);
            this.txtCodigo.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(153, 102);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(236, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(153, 158);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(236, 39);
            this.txtDescripcion.TabIndex = 8;
            // 
            // nudValorActivo
            // 
            this.nudValorActivo.DecimalPlaces = 2;
            this.nudValorActivo.Location = new System.Drawing.Point(153, 211);
            this.nudValorActivo.Name = "nudValorActivo";
            this.nudValorActivo.Size = new System.Drawing.Size(236, 20);
            this.nudValorActivo.TabIndex = 9;
            // 
            // dtpFechaAdquisicion
            // 
            this.dtpFechaAdquisicion.Location = new System.Drawing.Point(153, 252);
            this.dtpFechaAdquisicion.Name = "dtpFechaAdquisicion";
            this.dtpFechaAdquisicion.Size = new System.Drawing.Size(236, 20);
            this.dtpFechaAdquisicion.TabIndex = 10;
            // 
            // cmbTipoActivo
            // 
            this.cmbTipoActivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoActivo.FormattingEnabled = true;
            this.cmbTipoActivo.Location = new System.Drawing.Point(153, 308);
            this.cmbTipoActivo.Name = "cmbTipoActivo";
            this.cmbTipoActivo.Size = new System.Drawing.Size(236, 21);
            this.cmbTipoActivo.TabIndex = 11;
            // 
            // lblMetodo
            // 
            this.lblMetodo.AutoSize = true;
            this.lblMetodo.Location = new System.Drawing.Point(41, 356);
            this.lblMetodo.Name = "lblMetodo";
            this.lblMetodo.Size = new System.Drawing.Size(73, 13);
            this.lblMetodo.TabIndex = 12;
            this.lblMetodo.Text = "Tipo Metodo: ";
            // 
            // cmbTipoMetodo
            // 
            this.cmbTipoMetodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoMetodo.FormattingEnabled = true;
            this.cmbTipoMetodo.Location = new System.Drawing.Point(153, 356);
            this.cmbTipoMetodo.Name = "cmbTipoMetodo";
            this.cmbTipoMetodo.Size = new System.Drawing.Size(236, 21);
            this.cmbTipoMetodo.TabIndex = 13;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(276, 412);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(88, 40);
            this.btnAceptar.TabIndex = 14;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(405, 412);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(92, 40);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // FrmActivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 489);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cmbTipoMetodo);
            this.Controls.Add(this.lblMetodo);
            this.Controls.Add(this.cmbTipoActivo);
            this.Controls.Add(this.dtpFechaAdquisicion);
            this.Controls.Add(this.nudValorActivo);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblTipoActivoFijo);
            this.Controls.Add(this.lblFechaAdquisicion);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lablDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.Name = "FrmActivo";
            this.Text = "FrmActivo";
            this.Load += new System.EventHandler(this.FrmActivo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudValorActivo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lablDescripcion;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblFechaAdquisicion;
        private System.Windows.Forms.Label lblTipoActivoFijo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.NumericUpDown nudValorActivo;
        private System.Windows.Forms.DateTimePicker dtpFechaAdquisicion;
        private System.Windows.Forms.ComboBox cmbTipoActivo;
        private System.Windows.Forms.Label lblMetodo;
        private System.Windows.Forms.ComboBox cmbTipoMetodo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}