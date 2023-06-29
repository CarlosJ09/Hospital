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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lblFacturacion = new System.Windows.Forms.Label();
            this.gpbProcesos = new System.Windows.Forms.GroupBox();
            this.gpbConsulta = new System.Windows.Forms.GroupBox();
            this.gpbTitulos = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblConsulta_Medico = new System.Windows.Forms.Label();
            this.lblConsulta_Cliente = new System.Windows.Forms.Label();
            this.lblConsulta_Proceso = new System.Windows.Forms.Label();
            this.btnConsulta_Eliminar = new System.Windows.Forms.Button();
            this.btnConsulta_Facturar = new System.Windows.Forms.Button();
            this.gpbProcesos.SuspendLayout();
            this.gpbConsulta.SuspendLayout();
            this.gpbTitulos.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1024, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
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
            // gpbProcesos
            // 
            this.gpbProcesos.Controls.Add(this.gpbTitulos);
            this.gpbProcesos.Controls.Add(this.gpbConsulta);
            this.gpbProcesos.Location = new System.Drawing.Point(63, 131);
            this.gpbProcesos.Name = "gpbProcesos";
            this.gpbProcesos.Size = new System.Drawing.Size(921, 320);
            this.gpbProcesos.TabIndex = 2;
            this.gpbProcesos.TabStop = false;
            this.gpbProcesos.Text = "groupBox1";
            // 
            // gpbConsulta
            // 
            this.gpbConsulta.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gpbConsulta.Controls.Add(this.btnConsulta_Facturar);
            this.gpbConsulta.Controls.Add(this.btnConsulta_Eliminar);
            this.gpbConsulta.Controls.Add(this.lblConsulta_Medico);
            this.gpbConsulta.Controls.Add(this.lblConsulta_Cliente);
            this.gpbConsulta.Controls.Add(this.lblConsulta_Proceso);
            this.gpbConsulta.Location = new System.Drawing.Point(47, 119);
            this.gpbConsulta.Name = "gpbConsulta";
            this.gpbConsulta.Size = new System.Drawing.Size(744, 73);
            this.gpbConsulta.TabIndex = 0;
            this.gpbConsulta.TabStop = false;
            this.gpbConsulta.Text = "groupBox2";
            // 
            // gpbTitulos
            // 
            this.gpbTitulos.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gpbTitulos.Controls.Add(this.label3);
            this.gpbTitulos.Controls.Add(this.label2);
            this.gpbTitulos.Controls.Add(this.label1);
            this.gpbTitulos.Location = new System.Drawing.Point(47, 28);
            this.gpbTitulos.Name = "gpbTitulos";
            this.gpbTitulos.Size = new System.Drawing.Size(744, 73);
            this.gpbTitulos.TabIndex = 1;
            this.gpbTitulos.TabStop = false;
            this.gpbTitulos.Text = "groupBox3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proceso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(229, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(416, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Medico";
            // 
            // lblConsulta_Medico
            // 
            this.lblConsulta_Medico.AutoSize = true;
            this.lblConsulta_Medico.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsulta_Medico.Location = new System.Drawing.Point(416, 26);
            this.lblConsulta_Medico.Name = "lblConsulta_Medico";
            this.lblConsulta_Medico.Size = new System.Drawing.Size(73, 24);
            this.lblConsulta_Medico.TabIndex = 5;
            this.lblConsulta_Medico.Text = "Medico";
            // 
            // lblConsulta_Cliente
            // 
            this.lblConsulta_Cliente.AutoSize = true;
            this.lblConsulta_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsulta_Cliente.Location = new System.Drawing.Point(229, 26);
            this.lblConsulta_Cliente.Name = "lblConsulta_Cliente";
            this.lblConsulta_Cliente.Size = new System.Drawing.Size(68, 24);
            this.lblConsulta_Cliente.TabIndex = 4;
            this.lblConsulta_Cliente.Text = "Cliente";
            // 
            // lblConsulta_Proceso
            // 
            this.lblConsulta_Proceso.AutoSize = true;
            this.lblConsulta_Proceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsulta_Proceso.Location = new System.Drawing.Point(35, 26);
            this.lblConsulta_Proceso.Name = "lblConsulta_Proceso";
            this.lblConsulta_Proceso.Size = new System.Drawing.Size(80, 24);
            this.lblConsulta_Proceso.TabIndex = 3;
            this.lblConsulta_Proceso.Text = "Proceso";
            // 
            // btnConsulta_Eliminar
            // 
            this.btnConsulta_Eliminar.Location = new System.Drawing.Point(608, 19);
            this.btnConsulta_Eliminar.Name = "btnConsulta_Eliminar";
            this.btnConsulta_Eliminar.Size = new System.Drawing.Size(45, 41);
            this.btnConsulta_Eliminar.TabIndex = 6;
            this.btnConsulta_Eliminar.Text = "Eliminar";
            this.btnConsulta_Eliminar.UseVisualStyleBackColor = true;
            // 
            // btnConsulta_Facturar
            // 
            this.btnConsulta_Facturar.Location = new System.Drawing.Point(670, 19);
            this.btnConsulta_Facturar.Name = "btnConsulta_Facturar";
            this.btnConsulta_Facturar.Size = new System.Drawing.Size(45, 41);
            this.btnConsulta_Facturar.TabIndex = 7;
            this.btnConsulta_Facturar.Text = "Facturar";
            this.btnConsulta_Facturar.UseVisualStyleBackColor = true;
            // 
            // ProcesosAFacturar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 571);
            this.Controls.Add(this.gpbProcesos);
            this.Controls.Add(this.lblFacturacion);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ProcesosAFacturar";
            this.Text = "Procesos A Facturar";
            this.gpbProcesos.ResumeLayout(false);
            this.gpbConsulta.ResumeLayout(false);
            this.gpbConsulta.PerformLayout();
            this.gpbTitulos.ResumeLayout(false);
            this.gpbTitulos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lblFacturacion;
        private System.Windows.Forms.GroupBox gpbProcesos;
        private System.Windows.Forms.GroupBox gpbTitulos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpbConsulta;
        private System.Windows.Forms.Button btnConsulta_Facturar;
        private System.Windows.Forms.Button btnConsulta_Eliminar;
        private System.Windows.Forms.Label lblConsulta_Medico;
        private System.Windows.Forms.Label lblConsulta_Cliente;
        private System.Windows.Forms.Label lblConsulta_Proceso;
    }
}