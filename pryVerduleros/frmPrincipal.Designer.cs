﻿namespace pryVerduleros
{
    partial class frmPrincipal
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
            this.mrcVenta = new System.Windows.Forms.GroupBox();
            this.numKilos = new System.Windows.Forms.NumericUpDown();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.lblKilos = new System.Windows.Forms.Label();
            this.cmbVendedor = new System.Windows.Forms.ComboBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mrcVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKilos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mrcVenta
            // 
            this.mrcVenta.Controls.Add(this.numKilos);
            this.mrcVenta.Controls.Add(this.btnGuardar);
            this.mrcVenta.Controls.Add(this.lblVendedor);
            this.mrcVenta.Controls.Add(this.lblKilos);
            this.mrcVenta.Controls.Add(this.cmbVendedor);
            this.mrcVenta.Controls.Add(this.lblFecha);
            this.mrcVenta.Controls.Add(this.cmbProducto);
            this.mrcVenta.Controls.Add(this.lblProducto);
            this.mrcVenta.Controls.Add(this.dtpFecha);
            this.mrcVenta.Location = new System.Drawing.Point(26, 58);
            this.mrcVenta.Name = "mrcVenta";
            this.mrcVenta.Size = new System.Drawing.Size(388, 202);
            this.mrcVenta.TabIndex = 11;
            this.mrcVenta.TabStop = false;
            this.mrcVenta.Text = "Ventas de verduleria";
            // 
            // numKilos
            // 
            this.numKilos.Location = new System.Drawing.Point(248, 50);
            this.numKilos.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numKilos.Name = "numKilos";
            this.numKilos.Size = new System.Drawing.Size(62, 20);
            this.numKilos.TabIndex = 10;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(216, 103);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(144, 57);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Location = new System.Drawing.Point(6, 21);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(53, 13);
            this.lblVendedor.TabIndex = 5;
            this.lblVendedor.Text = "Vendedor";
            // 
            // lblKilos
            // 
            this.lblKilos.AutoSize = true;
            this.lblKilos.Location = new System.Drawing.Point(213, 53);
            this.lblKilos.Name = "lblKilos";
            this.lblKilos.Size = new System.Drawing.Size(29, 13);
            this.lblKilos.TabIndex = 8;
            this.lblKilos.Text = "Kilos";
            // 
            // cmbVendedor
            // 
            this.cmbVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVendedor.FormattingEnabled = true;
            this.cmbVendedor.Location = new System.Drawing.Point(65, 18);
            this.cmbVendedor.Name = "cmbVendedor";
            this.cmbVendedor.Size = new System.Drawing.Size(121, 21);
            this.cmbVendedor.TabIndex = 1;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(22, 53);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 7;
            this.lblFecha.Text = "Fecha";
            // 
            // cmbProducto
            // 
            this.cmbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(248, 18);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(121, 21);
            this.cmbProducto.TabIndex = 2;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(192, 21);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(50, 13);
            this.lblProducto.TabIndex = 6;
            this.lblProducto.Text = "Producto";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(65, 50);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(86, 20);
            this.dtpFecha.TabIndex = 3;
            // 
            // dgvVentas
            // 
            this.dgvVentas.AllowUserToAddRows = false;
            this.dgvVentas.AllowUserToDeleteRows = false;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Location = new System.Drawing.Point(26, 256);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.ReadOnly = true;
            this.dgvVentas.Size = new System.Drawing.Size(388, 220);
            this.dgvVentas.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pryVerduleros.Properties.Resources.verduleria;
            this.pictureBox1.Location = new System.Drawing.Point(420, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(736, 418);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Cargar Datos";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1191, 524);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mrcVenta);
            this.Controls.Add(this.dgvVentas);
            this.Name = "frmPrincipal";
            this.Text = "VERDULERIA";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.mrcVenta.ResumeLayout(false);
            this.mrcVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKilos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcVenta;
        private System.Windows.Forms.NumericUpDown numKilos;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.Label lblKilos;
        private System.Windows.Forms.ComboBox cmbVendedor;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

