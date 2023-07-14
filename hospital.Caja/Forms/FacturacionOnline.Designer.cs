namespace hospital.Caja
{
    partial class FacturacionOnline
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacturacionOnline));
            this.lblFacturacion = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblFacturar_a = new System.Windows.Forms.Label();
            this.lblSeguro = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblPoliza = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblShow_Cliente = new System.Windows.Forms.Label();
            this.lbl_ShowSeguro = new System.Windows.Forms.Label();
            this.lblShow_Poliza = new System.Windows.Forms.Label();
            this.lblShow_Tel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblShow_Fecha = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lvwFactura = new System.Windows.Forms.ListView();
            this.chCodigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDescripcion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPrecio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSeguro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chImporte = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label12 = new System.Windows.Forms.Label();
            this.lblShow_Total_Facturado = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblShow_Balance = new System.Windows.Forms.Label();
            this.lblShow_Balance_a_pagar = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblShow_Total_Importe = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblShow_Total_Seguro = new System.Windows.Forms.Label();
            this.lblFacturado_Por = new System.Windows.Forms.Label();
            this.lblShow_Empleado = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtEliminar = new System.Windows.Forms.TextBox();
            this.lblEliminar = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFacturacion
            // 
            this.lblFacturacion.AutoSize = true;
            this.lblFacturacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacturacion.Location = new System.Drawing.Point(437, 37);
            this.lblFacturacion.Name = "lblFacturacion";
            this.lblFacturacion.Size = new System.Drawing.Size(287, 42);
            this.lblFacturacion.TabIndex = 0;
            this.lblFacturacion.Text = "FACTURACION";
            this.lblFacturacion.Click += new System.EventHandler(this.lblFacturacion_Click);
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
            // lblPoliza
            // 
            this.lblPoliza.AutoSize = true;
            this.lblPoliza.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoliza.Location = new System.Drawing.Point(449, 68);
            this.lblPoliza.Name = "lblPoliza";
            this.lblPoliza.Size = new System.Drawing.Size(65, 24);
            this.lblPoliza.TabIndex = 8;
            this.lblPoliza.Text = "Poliza:";
            this.lblPoliza.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(100, 26);
            this.txtCodigo.Multiline = true;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(105, 24);
            this.txtCodigo.TabIndex = 9;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
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
            // lblShow_Cliente
            // 
            this.lblShow_Cliente.AutoSize = true;
            this.lblShow_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShow_Cliente.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblShow_Cliente.Location = new System.Drawing.Point(125, 68);
            this.lblShow_Cliente.Name = "lblShow_Cliente";
            this.lblShow_Cliente.Size = new System.Drawing.Size(262, 24);
            this.lblShow_Cliente.TabIndex = 12;
            this.lblShow_Cliente.Text = "Rafael Alberto Pichardo Colon";
            // 
            // lbl_ShowSeguro
            // 
            this.lbl_ShowSeguro.AutoSize = true;
            this.lbl_ShowSeguro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ShowSeguro.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_ShowSeguro.Location = new System.Drawing.Point(103, 107);
            this.lbl_ShowSeguro.Name = "lbl_ShowSeguro";
            this.lbl_ShowSeguro.Size = new System.Drawing.Size(89, 24);
            this.lbl_ShowSeguro.TabIndex = 13;
            this.lbl_ShowSeguro.Text = "MAPFRE";
            // 
            // lblShow_Poliza
            // 
            this.lblShow_Poliza.AutoSize = true;
            this.lblShow_Poliza.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShow_Poliza.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblShow_Poliza.Location = new System.Drawing.Point(520, 68);
            this.lblShow_Poliza.Name = "lblShow_Poliza";
            this.lblShow_Poliza.Size = new System.Drawing.Size(90, 24);
            this.lblShow_Poliza.TabIndex = 14;
            this.lblShow_Poliza.Text = "01930984";
            // 
            // lblShow_Tel
            // 
            this.lblShow_Tel.AutoSize = true;
            this.lblShow_Tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShow_Tel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblShow_Tel.Location = new System.Drawing.Point(498, 107);
            this.lblShow_Tel.Name = "lblShow_Tel";
            this.lblShow_Tel.Size = new System.Drawing.Size(138, 24);
            this.lblShow_Tel.TabIndex = 15;
            this.lblShow_Tel.Text = "809XXXXXXX";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.lblShow_Fecha);
            this.groupBox1.Controls.Add(this.lblFecha);
            this.groupBox1.Controls.Add(this.lblCodigo);
            this.groupBox1.Controls.Add(this.lblShow_Tel);
            this.groupBox1.Controls.Add(this.lblShow_Poliza);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.lbl_ShowSeguro);
            this.groupBox1.Controls.Add(this.lblDescripcion);
            this.groupBox1.Controls.Add(this.lblShow_Cliente);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.lblPoliza);
            this.groupBox1.Controls.Add(this.lblPrecio);
            this.groupBox1.Controls.Add(this.lblTel);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.lblSeguro);
            this.groupBox1.Controls.Add(this.lblFacturar_a);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(54, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1028, 158);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
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
            this.lblShow_Fecha.Click += new System.EventHandler(this.label22_Click);
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
            this.lvwFactura.Location = new System.Drawing.Point(54, 268);
            this.lvwFactura.Name = "lvwFactura";
            this.lvwFactura.Size = new System.Drawing.Size(691, 183);
            this.lvwFactura.TabIndex = 17;
            this.lvwFactura.UseCompatibleStateImageBehavior = false;
            this.lvwFactura.View = System.Windows.Forms.View.Details;
            this.lvwFactura.SelectedIndexChanged += new System.EventHandler(this.lvwFactura_SelectedIndexChanged);
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
            this.lblShow_Total_Facturado.Click += new System.EventHandler(this.label13_Click);
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
            this.groupBox2.Location = new System.Drawing.Point(678, 457);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(404, 170);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
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
            // lblFacturado_Por
            // 
            this.lblFacturado_Por.AutoSize = true;
            this.lblFacturado_Por.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacturado_Por.Location = new System.Drawing.Point(50, 471);
            this.lblFacturado_Por.Name = "lblFacturado_Por";
            this.lblFacturado_Por.Size = new System.Drawing.Size(133, 24);
            this.lblFacturado_Por.TabIndex = 21;
            this.lblFacturado_Por.Text = "Facturado por:";
            this.lblFacturado_Por.Click += new System.EventHandler(this.lblFacturado_Por_Click);
            // 
            // lblShow_Empleado
            // 
            this.lblShow_Empleado.AutoSize = true;
            this.lblShow_Empleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShow_Empleado.Location = new System.Drawing.Point(189, 471);
            this.lblShow_Empleado.Name = "lblShow_Empleado";
            this.lblShow_Empleado.Size = new System.Drawing.Size(99, 24);
            this.lblShow_Empleado.TabIndex = 22;
            this.lblShow_Empleado.Text = "Mario Lora";
            this.lblShow_Empleado.Click += new System.EventHandler(this.lblShow_Empleado_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(54, 525);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(217, 78);
            this.btnGuardar.TabIndex = 23;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregar.BackgroundImage")));
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregar.Location = new System.Drawing.Point(754, 268);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(116, 84);
            this.btnAgregar.TabIndex = 24;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEliminar.Location = new System.Drawing.Point(901, 268);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(181, 134);
            this.btnEliminar.TabIndex = 25;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtEliminar
            // 
            this.txtEliminar.Location = new System.Drawing.Point(1054, 408);
            this.txtEliminar.Name = "txtEliminar";
            this.txtEliminar.Size = new System.Drawing.Size(28, 20);
            this.txtEliminar.TabIndex = 26;
            this.txtEliminar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEliminar_KeyPress);
            // 
            // lblEliminar
            // 
            this.lblEliminar.AutoSize = true;
            this.lblEliminar.Location = new System.Drawing.Point(904, 411);
            this.lblEliminar.Name = "lblEliminar";
            this.lblEliminar.Size = new System.Drawing.Size(144, 13);
            this.lblEliminar.TabIndex = 27;
            this.lblEliminar.Text = "Codigo de servicio a eliminar:";
            this.lblEliminar.Click += new System.EventHandler(this.lblEliminar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnImprimir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnImprimir.BackgroundImage")));
            this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnImprimir.Location = new System.Drawing.Point(754, 358);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(116, 93);
            this.btnImprimir.TabIndex = 28;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // FacturacionOnline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 637);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.lblEliminar);
            this.Controls.Add(this.txtEliminar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblShow_Empleado);
            this.Controls.Add(this.lblFacturado_Por);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lvwFactura);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblFacturacion);
            this.Name = "FacturacionOnline";
            this.Text = "FacturacionOnline";
            this.Load += new System.EventHandler(this.FacturacionOnline_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFacturacion;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblFacturar_a;
        private System.Windows.Forms.Label lblSeguro;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblPoliza;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblShow_Cliente;
        private System.Windows.Forms.Label lbl_ShowSeguro;
        private System.Windows.Forms.Label lblShow_Poliza;
        private System.Windows.Forms.Label lblShow_Tel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvwFactura;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblShow_Total_Facturado;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblShow_Balance;
        private System.Windows.Forms.Label lblShow_Balance_a_pagar;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblShow_Total_Importe;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblShow_Total_Seguro;
        private System.Windows.Forms.Label lblShow_Fecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblFacturado_Por;
        private System.Windows.Forms.Label lblShow_Empleado;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ColumnHeader chCodigo;
        private System.Windows.Forms.ColumnHeader chDescripcion;
        private System.Windows.Forms.ColumnHeader chPrecio;
        private System.Windows.Forms.ColumnHeader chSeguro;
        private System.Windows.Forms.ColumnHeader chImporte;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtEliminar;
        private System.Windows.Forms.Label lblEliminar;
        private System.Windows.Forms.Button btnImprimir;
    }
}