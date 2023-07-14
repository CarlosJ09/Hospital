namespace hospital.Caja.Forms
{
    partial class FacturacionOffline
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacturacionOffline));
            this.btnImprimir = new System.Windows.Forms.Button();
            this.lblEliminar = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblShow_Empleado = new System.Windows.Forms.Label();
            this.lblFacturado_Por = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblShow_Balance = new System.Windows.Forms.Label();
            this.lblShow_Balance_a_pagar = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblShow_Total_Importe = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblShow_Total_Seguro = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblShow_Total_Facturado = new System.Windows.Forms.Label();
            this.lvwFactura = new System.Windows.Forms.ListView();
            this.chCodigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDescripcion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPrecio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSeguro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chImporte = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbSeguro = new System.Windows.Forms.ComboBox();
            this.sEGUROBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataset = new hospital.Caja.Dataset();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtPoliza = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblShow_Fecha = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblPoliza = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblSeguro = new System.Windows.Forms.Label();
            this.lblFacturar_a = new System.Windows.Forms.Label();
            this.lblFacturacion = new System.Windows.Forms.Label();
            this.txtEliminar = new System.Windows.Forms.TextBox();
            this.sEGUROTableAdapter = new hospital.Caja.DatasetTableAdapters.SEGUROTableAdapter();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sEGUROBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnImprimir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnImprimir.BackgroundImage")));
            this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImprimir.Location = new System.Drawing.Point(718, 364);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(116, 81);
            this.btnImprimir.TabIndex = 39;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // lblEliminar
            // 
            this.lblEliminar.AutoSize = true;
            this.lblEliminar.Location = new System.Drawing.Point(862, 405);
            this.lblEliminar.Name = "lblEliminar";
            this.lblEliminar.Size = new System.Drawing.Size(144, 13);
            this.lblEliminar.TabIndex = 38;
            this.lblEliminar.Text = "Codigo de servicio a eliminar:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEliminar.Location = new System.Drawing.Point(859, 262);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(181, 134);
            this.btnEliminar.TabIndex = 37;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregar.BackgroundImage")));
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregar.Location = new System.Drawing.Point(718, 262);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(116, 96);
            this.btnAgregar.TabIndex = 36;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(12, 519);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(217, 78);
            this.btnGuardar.TabIndex = 35;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblShow_Empleado
            // 
            this.lblShow_Empleado.AutoSize = true;
            this.lblShow_Empleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShow_Empleado.Location = new System.Drawing.Point(147, 465);
            this.lblShow_Empleado.Name = "lblShow_Empleado";
            this.lblShow_Empleado.Size = new System.Drawing.Size(99, 24);
            this.lblShow_Empleado.TabIndex = 34;
            this.lblShow_Empleado.Text = "Mario Lora";
            // 
            // lblFacturado_Por
            // 
            this.lblFacturado_Por.AutoSize = true;
            this.lblFacturado_Por.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacturado_Por.Location = new System.Drawing.Point(8, 465);
            this.lblFacturado_Por.Name = "lblFacturado_Por";
            this.lblFacturado_Por.Size = new System.Drawing.Size(133, 24);
            this.lblFacturado_Por.TabIndex = 33;
            this.lblFacturado_Por.Text = "Facturado por:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblShow_Balance);
            this.groupBox2.Controls.Add(this.lblShow_Balance_a_pagar);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.lblShow_Total_Importe);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.lblShow_Total_Seguro);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.lblShow_Total_Facturado);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Location = new System.Drawing.Point(636, 451);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(404, 170);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            // 
            // lblShow_Balance
            // 
            this.lblShow_Balance.AutoSize = true;
            this.lblShow_Balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShow_Balance.Location = new System.Drawing.Point(6, 131);
            this.lblShow_Balance.Name = "lblShow_Balance";
            this.lblShow_Balance.Size = new System.Drawing.Size(151, 24);
            this.lblShow_Balance.TabIndex = 24;
            this.lblShow_Balance.Text = "Balance a pagar:";
            // 
            // lblShow_Balance_a_pagar
            // 
            this.lblShow_Balance_a_pagar.AutoSize = true;
            this.lblShow_Balance_a_pagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShow_Balance_a_pagar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblShow_Balance_a_pagar.Location = new System.Drawing.Point(158, 131);
            this.lblShow_Balance_a_pagar.Name = "lblShow_Balance_a_pagar";
            this.lblShow_Balance_a_pagar.Size = new System.Drawing.Size(80, 24);
            this.lblShow_Balance_a_pagar.TabIndex = 25;
            this.lblShow_Balance_a_pagar.Text = "$$$$$$$";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(6, 93);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(124, 24);
            this.label16.TabIndex = 22;
            this.label16.Text = "Total Importe:";
            // 
            // lblShow_Total_Importe
            // 
            this.lblShow_Total_Importe.AutoSize = true;
            this.lblShow_Total_Importe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShow_Total_Importe.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblShow_Total_Importe.Location = new System.Drawing.Point(158, 93);
            this.lblShow_Total_Importe.Name = "lblShow_Total_Importe";
            this.lblShow_Total_Importe.Size = new System.Drawing.Size(80, 24);
            this.lblShow_Total_Importe.TabIndex = 23;
            this.lblShow_Total_Importe.Text = "$$$$$$$";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 58);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(123, 24);
            this.label14.TabIndex = 20;
            this.label14.Text = "Total Seguro:";
            // 
            // lblShow_Total_Seguro
            // 
            this.lblShow_Total_Seguro.AutoSize = true;
            this.lblShow_Total_Seguro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShow_Total_Seguro.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblShow_Total_Seguro.Location = new System.Drawing.Point(158, 58);
            this.lblShow_Total_Seguro.Name = "lblShow_Total_Seguro";
            this.lblShow_Total_Seguro.Size = new System.Drawing.Size(80, 24);
            this.lblShow_Total_Seguro.TabIndex = 21;
            this.lblShow_Total_Seguro.Text = "$$$$$$$";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(146, 24);
            this.label12.TabIndex = 18;
            this.label12.Text = "Total Facturado:";
            // 
            // lblShow_Total_Facturado
            // 
            this.lblShow_Total_Facturado.AutoSize = true;
            this.lblShow_Total_Facturado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShow_Total_Facturado.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblShow_Total_Facturado.Location = new System.Drawing.Point(158, 25);
            this.lblShow_Total_Facturado.Name = "lblShow_Total_Facturado";
            this.lblShow_Total_Facturado.Size = new System.Drawing.Size(80, 24);
            this.lblShow_Total_Facturado.TabIndex = 19;
            this.lblShow_Total_Facturado.Text = "$$$$$$$";
            // 
            // lvwFactura
            // 
            this.lvwFactura.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chCodigo,
            this.chDescripcion,
            this.chPrecio,
            this.chSeguro,
            this.chImporte});
            this.lvwFactura.HideSelection = false;
            this.lvwFactura.HoverSelection = true;
            this.lvwFactura.Location = new System.Drawing.Point(12, 262);
            this.lvwFactura.Name = "lvwFactura";
            this.lvwFactura.Size = new System.Drawing.Size(691, 183);
            this.lvwFactura.TabIndex = 31;
            this.lvwFactura.UseCompatibleStateImageBehavior = false;
            this.lvwFactura.View = System.Windows.Forms.View.Details;
            // 
            // chCodigo
            // 
            this.chCodigo.Text = "CODIGO";
            this.chCodigo.Width = 98;
            // 
            // chDescripcion
            // 
            this.chDescripcion.Text = "DESCRIPCION";
            this.chDescripcion.Width = 242;
            // 
            // chPrecio
            // 
            this.chPrecio.Text = "PRECIO";
            this.chPrecio.Width = 106;
            // 
            // chSeguro
            // 
            this.chSeguro.Text = "SEGURO";
            this.chSeguro.Width = 112;
            // 
            // chImporte
            // 
            this.chImporte.Text = "IMPORTE";
            this.chImporte.Width = 128;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.btnAgregarCliente);
            this.groupBox1.Controls.Add(this.cbSeguro);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.txtNombreCliente);
            this.groupBox1.Controls.Add(this.txtCedula);
            this.groupBox1.Controls.Add(this.txtPoliza);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.lblShow_Fecha);
            this.groupBox1.Controls.Add(this.lblFecha);
            this.groupBox1.Controls.Add(this.lblCodigo);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.lblDescripcion);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.lblPoliza);
            this.groupBox1.Controls.Add(this.lblPrecio);
            this.groupBox1.Controls.Add(this.lblTel);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.lblSeguro);
            this.groupBox1.Controls.Add(this.lblFacturar_a);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1074, 183);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // cbSeguro
            // 
            this.cbSeguro.DataSource = this.sEGUROBindingSource;
            this.cbSeguro.DisplayMember = "Nombre_Seguro";
            this.cbSeguro.FormattingEnabled = true;
            this.cbSeguro.Location = new System.Drawing.Point(113, 107);
            this.cbSeguro.Name = "cbSeguro";
            this.cbSeguro.Size = new System.Drawing.Size(121, 21);
            this.cbSeguro.TabIndex = 24;
            // 
            // sEGUROBindingSource
            // 
            this.sEGUROBindingSource.DataMember = "SEGURO";
            this.sEGUROBindingSource.DataSource = this.dataset;
            // 
            // dataset
            // 
            this.dataset.DataSetName = "Dataset";
            this.dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(498, 107);
            this.txtTelefono.Multiline = true;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(184, 24);
            this.txtTelefono.TabIndex = 23;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente.Location = new System.Drawing.Point(125, 68);
            this.txtNombreCliente.Multiline = true;
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(291, 24);
            this.txtNombreCliente.TabIndex = 22;
            // 
            // txtCedula
            // 
            this.txtCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.Location = new System.Drawing.Point(826, 68);
            this.txtCedula.Multiline = true;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(178, 24);
            this.txtCedula.TabIndex = 21;
            this.txtCedula.TextChanged += new System.EventHandler(this.txtCedula_TextChanged);
            this.txtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedula_KeyPress);
            // 
            // txtPoliza
            // 
            this.txtPoliza.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPoliza.Location = new System.Drawing.Point(520, 68);
            this.txtPoliza.Multiline = true;
            this.txtPoliza.Name = "txtPoliza";
            this.txtPoliza.Size = new System.Drawing.Size(171, 24);
            this.txtPoliza.TabIndex = 20;
            this.txtPoliza.TextChanged += new System.EventHandler(this.txtPoliza_TextChanged);
            this.txtPoliza.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPoliza_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(747, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "Cedula:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscar.Location = new System.Drawing.Point(211, 26);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(30, 24);
            this.btnBuscar.TabIndex = 18;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblShow_Fecha
            // 
            this.lblShow_Fecha.AutoSize = true;
            this.lblShow_Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShow_Fecha.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblShow_Fecha.Location = new System.Drawing.Point(822, 107);
            this.lblShow_Fecha.Name = "lblShow_Fecha";
            this.lblShow_Fecha.Size = new System.Drawing.Size(100, 24);
            this.lblShow_Fecha.TabIndex = 17;
            this.lblShow_Fecha.Text = "06/28/2023";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(747, 107);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(69, 24);
            this.lblFecha.TabIndex = 16;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(19, 26);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(71, 24);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "Codigo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(100, 26);
            this.txtCodigo.Multiline = true;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(105, 24);
            this.txtCodigo.TabIndex = 9;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(286, 26);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(110, 24);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(411, 26);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(239, 24);
            this.txtDescripcion.TabIndex = 10;
            // 
            // lblPoliza
            // 
            this.lblPoliza.AutoSize = true;
            this.lblPoliza.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoliza.Location = new System.Drawing.Point(449, 68);
            this.lblPoliza.Name = "lblPoliza";
            this.lblPoliza.Size = new System.Drawing.Size(65, 24);
            this.lblPoliza.TabIndex = 8;
            this.lblPoliza.Text = "Poliza:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(737, 26);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(64, 24);
            this.lblPrecio.TabIndex = 4;
            this.lblPrecio.Text = "Precio";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.Location = new System.Drawing.Point(450, 107);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(42, 24);
            this.lblTel.TabIndex = 7;
            this.lblTel.Text = "Tel:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(807, 26);
            this.txtPrecio.Multiline = true;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.Size = new System.Drawing.Size(115, 24);
            this.txtPrecio.TabIndex = 11;
            // 
            // lblSeguro
            // 
            this.lblSeguro.AutoSize = true;
            this.lblSeguro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeguro.Location = new System.Drawing.Point(20, 107);
            this.lblSeguro.Name = "lblSeguro";
            this.lblSeguro.Size = new System.Drawing.Size(77, 24);
            this.lblSeguro.TabIndex = 6;
            this.lblSeguro.Text = "Seguro:";
            // 
            // lblFacturar_a
            // 
            this.lblFacturar_a.AutoSize = true;
            this.lblFacturar_a.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacturar_a.Location = new System.Drawing.Point(20, 68);
            this.lblFacturar_a.Name = "lblFacturar_a";
            this.lblFacturar_a.Size = new System.Drawing.Size(99, 24);
            this.lblFacturar_a.TabIndex = 5;
            this.lblFacturar_a.Text = "Facturar a:";
            // 
            // lblFacturacion
            // 
            this.lblFacturacion.AutoSize = true;
            this.lblFacturacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacturacion.Location = new System.Drawing.Point(407, 9);
            this.lblFacturacion.Name = "lblFacturacion";
            this.lblFacturacion.Size = new System.Drawing.Size(287, 42);
            this.lblFacturacion.TabIndex = 29;
            this.lblFacturacion.Text = "FACTURACION";
            // 
            // txtEliminar
            // 
            this.txtEliminar.Location = new System.Drawing.Point(1008, 402);
            this.txtEliminar.Name = "txtEliminar";
            this.txtEliminar.Size = new System.Drawing.Size(32, 20);
            this.txtEliminar.TabIndex = 40;
            this.txtEliminar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEliminar_KeyPress);
            // 
            // sEGUROTableAdapter
            // 
            this.sEGUROTableAdapter.ClearBeforeFill = true;
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Location = new System.Drawing.Point(22, 143);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(195, 34);
            this.btnAgregarCliente.TabIndex = 41;
            this.btnAgregarCliente.Text = "Agregar Cliente";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // FacturacionOffline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 620);
            this.Controls.Add(this.txtEliminar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.lblEliminar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblShow_Empleado);
            this.Controls.Add(this.lblFacturado_Por);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lvwFactura);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblFacturacion);
            this.Name = "FacturacionOffline";
            this.Text = "FacturacionOffline";
            this.Load += new System.EventHandler(this.FacturacionOffline_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sEGUROBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label lblEliminar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblShow_Empleado;
        private System.Windows.Forms.Label lblFacturado_Por;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblShow_Balance;
        private System.Windows.Forms.Label lblShow_Balance_a_pagar;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblShow_Total_Importe;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblShow_Total_Seguro;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblShow_Total_Facturado;
        private System.Windows.Forms.ListView lvwFactura;
        private System.Windows.Forms.ColumnHeader chCodigo;
        private System.Windows.Forms.ColumnHeader chDescripcion;
        private System.Windows.Forms.ColumnHeader chPrecio;
        private System.Windows.Forms.ColumnHeader chSeguro;
        private System.Windows.Forms.ColumnHeader chImporte;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblShow_Fecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblPoliza;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblSeguro;
        private System.Windows.Forms.Label lblFacturar_a;
        private System.Windows.Forms.Label lblFacturacion;
        private System.Windows.Forms.ComboBox cbSeguro;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtPoliza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEliminar;
        private Dataset dataset;
        private System.Windows.Forms.BindingSource sEGUROBindingSource;
        private DatasetTableAdapters.SEGUROTableAdapter sEGUROTableAdapter;
        private System.Windows.Forms.Button btnAgregarCliente;
    }
}