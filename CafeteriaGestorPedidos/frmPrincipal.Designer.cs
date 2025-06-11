namespace CafeteriaGestorPedidos
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
            this.btnAgregarPedido = new System.Windows.Forms.Button();
            this.btnExportarTxt = new System.Windows.Forms.Button();
            this.btnProcesarSiguiente = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.dgvCola = new System.Windows.Forms.DataGridView();
            this.lblPendientes = new System.Windows.Forms.Label();
            this.lblAtendidos = new System.Windows.Forms.Label();
            this.dgvAtendidos = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.chkFiltrarHora = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscarAtendidos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtendidos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregarPedido
            // 
            this.btnAgregarPedido.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPedido.Location = new System.Drawing.Point(70, 180);
            this.btnAgregarPedido.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarPedido.Name = "btnAgregarPedido";
            this.btnAgregarPedido.Size = new System.Drawing.Size(113, 36);
            this.btnAgregarPedido.TabIndex = 0;
            this.btnAgregarPedido.Text = "Agregar";
            this.btnAgregarPedido.UseVisualStyleBackColor = false;
            this.btnAgregarPedido.Click += new System.EventHandler(this.btnAgregarPedido_Click);
            // 
            // btnExportarTxt
            // 
            this.btnExportarTxt.Location = new System.Drawing.Point(664, 310);
            this.btnExportarTxt.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportarTxt.Name = "btnExportarTxt";
            this.btnExportarTxt.Size = new System.Drawing.Size(100, 28);
            this.btnExportarTxt.TabIndex = 1;
            this.btnExportarTxt.Text = "Exportar";
            this.btnExportarTxt.UseVisualStyleBackColor = true;
            this.btnExportarTxt.Click += new System.EventHandler(this.btnExportarTxt_Click);
            // 
            // btnProcesarSiguiente
            // 
            this.btnProcesarSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcesarSiguiente.Location = new System.Drawing.Point(644, 28);
            this.btnProcesarSiguiente.Margin = new System.Windows.Forms.Padding(4);
            this.btnProcesarSiguiente.Name = "btnProcesarSiguiente";
            this.btnProcesarSiguiente.Size = new System.Drawing.Size(142, 39);
            this.btnProcesarSiguiente.TabIndex = 2;
            this.btnProcesarSiguiente.Text = "Entregar";
            this.btnProcesarSiguiente.UseVisualStyleBackColor = true;
            this.btnProcesarSiguiente.Click += new System.EventHandler(this.btnProcesarSiguiente_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(159, 268);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(100, 28);
            this.btnFiltrar.TabIndex = 4;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // txtCliente
            // 
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(28, 59);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(223, 22);
            this.txtCliente.TabIndex = 5;
            // 
            // txtDetalle
            // 
            this.txtDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetalle.Location = new System.Drawing.Point(28, 128);
            this.txtDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(217, 22);
            this.txtDetalle.TabIndex = 6;
            // 
            // dgvCola
            // 
            this.dgvCola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCola.Location = new System.Drawing.Point(345, 75);
            this.dgvCola.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCola.Name = "dgvCola";
            this.dgvCola.Size = new System.Drawing.Size(467, 179);
            this.dgvCola.TabIndex = 7;
            // 
            // lblPendientes
            // 
            this.lblPendientes.AutoSize = true;
            this.lblPendientes.Location = new System.Drawing.Point(14, 47);
            this.lblPendientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPendientes.Name = "lblPendientes";
            this.lblPendientes.Size = new System.Drawing.Size(0, 16);
            this.lblPendientes.TabIndex = 8;
            // 
            // lblAtendidos
            // 
            this.lblAtendidos.AutoSize = true;
            this.lblAtendidos.Location = new System.Drawing.Point(141, 47);
            this.lblAtendidos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAtendidos.Name = "lblAtendidos";
            this.lblAtendidos.Size = new System.Drawing.Size(0, 16);
            this.lblAtendidos.TabIndex = 9;
            // 
            // dgvAtendidos
            // 
            this.dgvAtendidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAtendidos.Location = new System.Drawing.Point(319, 36);
            this.dgvAtendidos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAtendidos.Name = "dgvAtendidos";
            this.dgvAtendidos.Size = new System.Drawing.Size(467, 260);
            this.dgvAtendidos.TabIndex = 10;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(129, 113);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(165, 24);
            this.txtBuscar.TabIndex = 11;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // dtpDesde
            // 
            this.dtpDesde.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpDesde.Location = new System.Drawing.Point(12, 221);
            this.dtpDesde.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(111, 26);
            this.dtpDesde.TabIndex = 12;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHasta.Location = new System.Drawing.Point(143, 221);
            this.dtpHasta.Margin = new System.Windows.Forms.Padding(4);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(116, 26);
            this.dtpHasta.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCliente);
            this.groupBox1.Controls.Add(this.txtDetalle);
            this.groupBox1.Controls.Add(this.btnAgregarPedido);
            this.groupBox1.Location = new System.Drawing.Point(22, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(281, 238);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nuevo pedido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Detalle pedido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre del cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(340, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 27);
            this.label3.TabIndex = 15;
            this.label3.Text = "En preparación";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Silver;
            this.groupBox2.Controls.Add(this.lblCantidad);
            this.groupBox2.Controls.Add(this.chkFiltrarHora);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dgvAtendidos);
            this.groupBox2.Controls.Add(this.txtBuscar);
            this.groupBox2.Controls.Add(this.lblAtendidos);
            this.groupBox2.Controls.Add(this.lblPendientes);
            this.groupBox2.Controls.Add(this.dtpHasta);
            this.groupBox2.Controls.Add(this.btnExportarTxt);
            this.groupBox2.Controls.Add(this.dtpDesde);
            this.groupBox2.Controls.Add(this.btnFiltrar);
            this.groupBox2.Location = new System.Drawing.Point(22, 282);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(793, 350);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Control ";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(334, 300);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(0, 16);
            this.lblCantidad.TabIndex = 23;
            // 
            // chkFiltrarHora
            // 
            this.chkFiltrarHora.AutoSize = true;
            this.chkFiltrarHora.Location = new System.Drawing.Point(12, 174);
            this.chkFiltrarHora.Name = "chkFiltrarHora";
            this.chkFiltrarHora.Size = new System.Drawing.Size(112, 20);
            this.chkFiltrarHora.TabIndex = 21;
            this.chkFiltrarHora.Text = "Filtrar por hora";
            this.chkFiltrarHora.UseVisualStyleBackColor = true;
            this.chkFiltrarHora.CheckedChanged += new System.EventHandler(this.chkFiltrarHora_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Buscar cliente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(143, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Hasta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Desde";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(498, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 18);
            this.label4.TabIndex = 17;
            this.label4.Text = "Entregados";
            // 
            // btnBuscarAtendidos
            // 
            this.btnBuscarAtendidos.Location = new System.Drawing.Point(960, 525);
            this.btnBuscarAtendidos.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarAtendidos.Name = "btnBuscarAtendidos";
            this.btnBuscarAtendidos.Size = new System.Drawing.Size(100, 28);
            this.btnBuscarAtendidos.TabIndex = 3;
            this.btnBuscarAtendidos.Text = "Buscar";
            this.btnBuscarAtendidos.UseVisualStyleBackColor = true;
            this.btnBuscarAtendidos.Click += new System.EventHandler(this.btnBuscarAtendidos_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(825, 657);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvCola);
            this.Controls.Add(this.btnProcesarSiguiente);
            this.Controls.Add(this.btnBuscarAtendidos);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPrincipal";
            this.Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtendidos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarPedido;
        private System.Windows.Forms.Button btnExportarTxt;
        private System.Windows.Forms.Button btnProcesarSiguiente;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.DataGridView dgvCola;
        private System.Windows.Forms.Label lblPendientes;
        private System.Windows.Forms.Label lblAtendidos;
        private System.Windows.Forms.DataGridView dgvAtendidos;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkFiltrarHora;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btnBuscarAtendidos;
    }
}

