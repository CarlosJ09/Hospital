namespace Hospital.Core
{
    partial class AutorizacionMedicaCore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutorizacionMedicaCore));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEstadoAutori = new System.Windows.Forms.TextBox();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtIDdoctor = new System.Windows.Forms.TextBox();
            this.txtIDProced = new System.Windows.Forms.TextBox();
            this.txtIDPaciente = new System.Windows.Forms.TextBox();
            this.txtIDAutorizacion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewAutor = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEliminarAuto = new System.Windows.Forms.Button();
            this.btnModificarAuto = new System.Windows.Forms.Button();
            this.btnRegistrarAuto = new System.Windows.Forms.Button();
            this.btnNuevoAutor = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAutor)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.txtEstadoAutori);
            this.groupBox1.Controls.Add(this.txtdescripcion);
            this.groupBox1.Controls.Add(this.txtFecha);
            this.groupBox1.Controls.Add(this.txtIDdoctor);
            this.groupBox1.Controls.Add(this.txtIDProced);
            this.groupBox1.Controls.Add(this.txtIDPaciente);
            this.groupBox1.Controls.Add(this.txtIDAutorizacion);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(28, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(581, 177);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información General";
            // 
            // txtEstadoAutori
            // 
            this.txtEstadoAutori.Location = new System.Drawing.Point(408, 130);
            this.txtEstadoAutori.Name = "txtEstadoAutori";
            this.txtEstadoAutori.Size = new System.Drawing.Size(149, 22);
            this.txtEstadoAutori.TabIndex = 13;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(408, 91);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(149, 22);
            this.txtdescripcion.TabIndex = 12;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(408, 59);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(149, 22);
            this.txtFecha.TabIndex = 11;
            // 
            // txtIDdoctor
            // 
            this.txtIDdoctor.Location = new System.Drawing.Point(408, 25);
            this.txtIDdoctor.Name = "txtIDdoctor";
            this.txtIDdoctor.Size = new System.Drawing.Size(149, 22);
            this.txtIDdoctor.TabIndex = 10;
            // 
            // txtIDProced
            // 
            this.txtIDProced.Location = new System.Drawing.Point(35, 133);
            this.txtIDProced.Name = "txtIDProced";
            this.txtIDProced.Size = new System.Drawing.Size(124, 22);
            this.txtIDProced.TabIndex = 9;
            // 
            // txtIDPaciente
            // 
            this.txtIDPaciente.Location = new System.Drawing.Point(143, 77);
            this.txtIDPaciente.Name = "txtIDPaciente";
            this.txtIDPaciente.Size = new System.Drawing.Size(100, 22);
            this.txtIDPaciente.TabIndex = 8;
            // 
            // txtIDAutorizacion
            // 
            this.txtIDAutorizacion.Location = new System.Drawing.Point(145, 43);
            this.txtIDAutorizacion.Name = "txtIDAutorizacion";
            this.txtIDAutorizacion.Size = new System.Drawing.Size(100, 22);
            this.txtIDAutorizacion.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(277, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 14);
            this.label8.TabIndex = 6;
            this.label8.Text = "Estado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(277, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 14);
            this.label7.TabIndex = 5;
            this.label7.Text = "Descripción ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(277, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 14);
            this.label6.TabIndex = 4;
            this.label6.Text = "Fecha Autorización";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(277, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 14);
            this.label5.TabIndex = 3;
            this.label5.Text = "ID_Doctor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 14);
            this.label4.TabIndex = 2;
            this.label4.Text = "ID_Procedimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 14);
            this.label3.TabIndex = 1;
            this.label3.Text = "ID_Paciente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID_Autorizacion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Autorización Médica";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.dataGridViewAutor);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(28, 274);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(456, 180);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos";
            // 
            // dataGridViewAutor
            // 
            this.dataGridViewAutor.AllowUserToAddRows = false;
            this.dataGridViewAutor.AllowUserToDeleteRows = false;
            this.dataGridViewAutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAutor.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewAutor.Name = "dataGridViewAutor";
            this.dataGridViewAutor.ReadOnly = true;
            this.dataGridViewAutor.Size = new System.Drawing.Size(438, 150);
            this.dataGridViewAutor.TabIndex = 0;
            this.dataGridViewAutor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAutor_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.btnEliminarAuto);
            this.groupBox3.Controls.Add(this.btnModificarAuto);
            this.groupBox3.Controls.Add(this.btnRegistrarAuto);
            this.groupBox3.Controls.Add(this.btnNuevoAutor);
            this.groupBox3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(508, 274);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 180);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gestionar Autorizaciones";
            // 
            // btnEliminarAuto
            // 
            this.btnEliminarAuto.Location = new System.Drawing.Point(6, 130);
            this.btnEliminarAuto.Name = "btnEliminarAuto";
            this.btnEliminarAuto.Size = new System.Drawing.Size(188, 37);
            this.btnEliminarAuto.TabIndex = 3;
            this.btnEliminarAuto.Text = "Eliminar";
            this.btnEliminarAuto.UseVisualStyleBackColor = true;
            this.btnEliminarAuto.Click += new System.EventHandler(this.btnEliminarAuto_Click);
            // 
            // btnModificarAuto
            // 
            this.btnModificarAuto.Location = new System.Drawing.Point(6, 93);
            this.btnModificarAuto.Name = "btnModificarAuto";
            this.btnModificarAuto.Size = new System.Drawing.Size(188, 37);
            this.btnModificarAuto.TabIndex = 2;
            this.btnModificarAuto.Text = "Modificar ";
            this.btnModificarAuto.UseVisualStyleBackColor = true;
            this.btnModificarAuto.Click += new System.EventHandler(this.btnModificarAuto_Click);
            // 
            // btnRegistrarAuto
            // 
            this.btnRegistrarAuto.Location = new System.Drawing.Point(6, 56);
            this.btnRegistrarAuto.Name = "btnRegistrarAuto";
            this.btnRegistrarAuto.Size = new System.Drawing.Size(188, 37);
            this.btnRegistrarAuto.TabIndex = 1;
            this.btnRegistrarAuto.Text = "Registrar";
            this.btnRegistrarAuto.UseVisualStyleBackColor = true;
            this.btnRegistrarAuto.Click += new System.EventHandler(this.btnRegistrarAuto_Click);
            // 
            // btnNuevoAutor
            // 
            this.btnNuevoAutor.Location = new System.Drawing.Point(6, 19);
            this.btnNuevoAutor.Name = "btnNuevoAutor";
            this.btnNuevoAutor.Size = new System.Drawing.Size(188, 37);
            this.btnNuevoAutor.TabIndex = 0;
            this.btnNuevoAutor.Text = "Nuevo";
            this.btnNuevoAutor.UseVisualStyleBackColor = true;
            this.btnNuevoAutor.Click += new System.EventHandler(this.btnNuevoAutor_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(615, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // AutorizacionMedicaCore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(745, 466);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AutorizacionMedicaCore";
            this.Text = "AutorizacionMedicaCore";
            this.Load += new System.EventHandler(this.AutorizacionMedicaCore_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAutor)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEstadoAutori;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtIDdoctor;
        private System.Windows.Forms.TextBox txtIDProced;
        private System.Windows.Forms.TextBox txtIDPaciente;
        private System.Windows.Forms.TextBox txtIDAutorizacion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewAutor;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnEliminarAuto;
        private System.Windows.Forms.Button btnModificarAuto;
        private System.Windows.Forms.Button btnRegistrarAuto;
        private System.Windows.Forms.Button btnNuevoAutor;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}