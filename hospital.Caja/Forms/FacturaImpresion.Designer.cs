namespace hospital.Caja.Forms
{
    partial class FacturaImpresion
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.fACTURABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataset = new hospital.Caja.Dataset();
            this.fACTURATableAdapter = new hospital.Caja.DatasetTableAdapters.FACTURATableAdapter();
            this.fACTURABindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fACTURABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTURABindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetFactura";
            reportDataSource1.Value = this.fACTURABindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "hospital.Caja.Forms.IFactura.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(5, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(791, 426);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // fACTURABindingSource
            // 
            this.fACTURABindingSource.DataMember = "FACTURA";
            this.fACTURABindingSource.DataSource = this.dataset;
            // 
            // dataset
            // 
            this.dataset.DataSetName = "Dataset";
            this.dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fACTURATableAdapter
            // 
            this.fACTURATableAdapter.ClearBeforeFill = true;
            // 
            // fACTURABindingSource1
            // 
            this.fACTURABindingSource1.DataMember = "FACTURA";
            this.fACTURABindingSource1.DataSource = this.dataset;
            // 
            // FacturaImpresion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FacturaImpresion";
            this.Text = "FacturaImpresion";
            this.Load += new System.EventHandler(this.FacturaImpresion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fACTURABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTURABindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Dataset dataset;
        private System.Windows.Forms.BindingSource fACTURABindingSource;
        private DatasetTableAdapters.FACTURATableAdapter fACTURATableAdapter;
        private System.Windows.Forms.BindingSource fACTURABindingSource1;
    }
}