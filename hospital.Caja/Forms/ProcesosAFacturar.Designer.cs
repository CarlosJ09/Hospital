namespace hospital.Caja
{
    partial class ProcesosAFacturar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcesosAFacturar));
            this.lblFacturacion = new System.Windows.Forms.Label();
            this.dgvProcesos = new System.Windows.Forms.DataGridView();
            this.clCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTable2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataset = new hospital.Caja.Dataset();
            this.dataTable2TableAdapter = new hospital.Caja.DatasetTableAdapters.DataTable2TableAdapter();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcesos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFacturacion
            // 
            this.lblFacturacion.AutoSize = true;
            this.lblFacturacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacturacion.Location = new System.Drawing.Point(272, 46);
            this.lblFacturacion.Name = "lblFacturacion";
            this.lblFacturacion.Size = new System.Drawing.Size(479, 42);
            this.lblFacturacion.TabIndex = 1;
            this.lblFacturacion.Text = "PROCESOS A FACTURAR";
            // 
            // dgvProcesos
            // 
            this.dgvProcesos.AllowUserToOrderColumns = true;
            this.dgvProcesos.AutoGenerateColumns = false;
            this.dgvProcesos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcesos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clCliente,
            this.clDescripcion});
            this.dgvProcesos.DataSource = this.dataTable2BindingSource;
            this.dgvProcesos.Location = new System.Drawing.Point(85, 137);
            this.dgvProcesos.Name = "dgvProcesos";
            this.dgvProcesos.Size = new System.Drawing.Size(544, 277);
            this.dgvProcesos.TabIndex = 2;
            this.dgvProcesos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProcesos_CellClick);
            // 
            // clCliente
            // 
            this.clCliente.DataPropertyName = "Nombre_Cliente";
            this.clCliente.FillWeight = 200F;
            this.clCliente.HeaderText = "Nombre de Cliente";
            this.clCliente.Name = "clCliente";
            this.clCliente.Width = 200;
            // 
            // clDescripcion
            // 
            this.clDescripcion.DataPropertyName = "Descripcion";
            this.clDescripcion.HeaderText = "Descripcion de proceso";
            this.clDescripcion.Name = "clDescripcion";
            this.clDescripcion.Width = 300;
            // 
            // dataTable2BindingSource
            // 
            this.dataTable2BindingSource.DataMember = "DataTable2";
            this.dataTable2BindingSource.DataSource = this.dataset;
            // 
            // dataset
            // 
            this.dataset.DataSetName = "Dataset";
            this.dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable2TableAdapter
            // 
            this.dataTable2TableAdapter.ClearBeforeFill = true;
            // 
            // btnFacturar
            // 
            this.btnFacturar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFacturar.BackgroundImage")));
            this.btnFacturar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFacturar.Enabled = false;
            this.btnFacturar.Location = new System.Drawing.Point(720, 137);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(206, 206);
            this.btnFacturar.TabIndex = 3;
            this.btnFacturar.UseVisualStyleBackColor = true;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Quicksand Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(770, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Facturar";
            // 
            // ProcesosAFacturar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 571);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.dgvProcesos);
            this.Controls.Add(this.lblFacturacion);
            this.Name = "ProcesosAFacturar";
            this.Text = "Procesos A Facturar";
            this.Load += new System.EventHandler(this.ProcesosAFacturar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcesos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFacturacion;
        private System.Windows.Forms.DataGridView dgvProcesos;
        private Dataset dataset;
        private System.Windows.Forms.BindingSource dataTable2BindingSource;
        private DatasetTableAdapters.DataTable2TableAdapter dataTable2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDescripcion;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.Label label1;
    }
}