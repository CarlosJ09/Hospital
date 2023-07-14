namespace Hospital.Core
{
    partial class AnalisisCore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnalisisCore));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtObservacionAnal = new System.Windows.Forms.TextBox();
            this.txtIDDoctorAnalsis = new System.Windows.Forms.TextBox();
            this.txtResultadoAnal = new System.Windows.Forms.TextBox();
            this.txtFechaAnal = new System.Windows.Forms.TextBox();
            this.txtTipoAnalsis = new System.Windows.Forms.TextBox();
            this.txtIDPacienteAnalisis = new System.Windows.Forms.TextBox();
            this.txtIDAnalisis = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBuscarAnalisis = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEliminarAnal = new System.Windows.Forms.Button();
            this.btnModificarAnal = new System.Windows.Forms.Button();
            this.btnRegistrarAnal = new System.Windows.Forms.Button();
            this.btnNuevoAnalisis = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridViewAnalisis = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnalisis)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(259, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anáslisis Medico";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.txtObservacionAnal);
            this.groupBox1.Controls.Add(this.txtIDDoctorAnalsis);
            this.groupBox1.Controls.Add(this.txtResultadoAnal);
            this.groupBox1.Controls.Add(this.txtFechaAnal);
            this.groupBox1.Controls.Add(this.txtTipoAnalsis);
            this.groupBox1.Controls.Add(this.txtIDPacienteAnalisis);
            this.groupBox1.Controls.Add(this.txtIDAnalisis);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(590, 213);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informaciones Generales";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtObservacionAnal
            // 
            this.txtObservacionAnal.Location = new System.Drawing.Point(364, 172);
            this.txtObservacionAnal.Name = "txtObservacionAnal";
            this.txtObservacionAnal.Size = new System.Drawing.Size(207, 22);
            this.txtObservacionAnal.TabIndex = 13;
            // 
            // txtIDDoctorAnalsis
            // 
            this.txtIDDoctorAnalsis.Location = new System.Drawing.Point(364, 114);
            this.txtIDDoctorAnalsis.Name = "txtIDDoctorAnalsis";
            this.txtIDDoctorAnalsis.Size = new System.Drawing.Size(207, 22);
            this.txtIDDoctorAnalsis.TabIndex = 12;
            // 
            // txtResultadoAnal
            // 
            this.txtResultadoAnal.Location = new System.Drawing.Point(364, 38);
            this.txtResultadoAnal.Multiline = true;
            this.txtResultadoAnal.Name = "txtResultadoAnal";
            this.txtResultadoAnal.Size = new System.Drawing.Size(207, 42);
            this.txtResultadoAnal.TabIndex = 11;
            // 
            // txtFechaAnal
            // 
            this.txtFechaAnal.Location = new System.Drawing.Point(110, 172);
            this.txtFechaAnal.Name = "txtFechaAnal";
            this.txtFechaAnal.Size = new System.Drawing.Size(180, 22);
            this.txtFechaAnal.TabIndex = 10;
            // 
            // txtTipoAnalsis
            // 
            this.txtTipoAnalsis.Location = new System.Drawing.Point(110, 102);
            this.txtTipoAnalsis.Name = "txtTipoAnalsis";
            this.txtTipoAnalsis.Size = new System.Drawing.Size(180, 22);
            this.txtTipoAnalsis.TabIndex = 9;
            // 
            // txtIDPacienteAnalisis
            // 
            this.txtIDPacienteAnalisis.Location = new System.Drawing.Point(110, 71);
            this.txtIDPacienteAnalisis.Name = "txtIDPacienteAnalisis";
            this.txtIDPacienteAnalisis.Size = new System.Drawing.Size(180, 22);
            this.txtIDPacienteAnalisis.TabIndex = 8;
            // 
            // txtIDAnalisis
            // 
            this.txtIDAnalisis.Location = new System.Drawing.Point(110, 38);
            this.txtIDAnalisis.Name = "txtIDAnalisis";
            this.txtIDAnalisis.Size = new System.Drawing.Size(180, 22);
            this.txtIDAnalisis.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(404, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 14);
            this.label8.TabIndex = 6;
            this.label8.Text = "Observaciones";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(423, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 14);
            this.label7.TabIndex = 5;
            this.label7.Text = "ID Doctor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(401, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 14);
            this.label6.TabIndex = 4;
            this.label6.Text = "Resultado Final";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(140, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 14);
            this.label5.TabIndex = 3;
            this.label5.Text = "Fecha del análisis";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 14);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tipo Análisis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 14);
            this.label3.TabIndex = 1;
            this.label3.Text = "ID Paciente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID Análisis";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(617, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 201);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.txtBuscarAnalisis);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(21, 307);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 76);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar Análsis  ";
            // 
            // txtBuscarAnalisis
            // 
            this.txtBuscarAnalisis.Location = new System.Drawing.Point(84, 30);
            this.txtBuscarAnalisis.Name = "txtBuscarAnalisis";
            this.txtBuscarAnalisis.Size = new System.Drawing.Size(100, 22);
            this.txtBuscarAnalisis.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 14);
            this.label9.TabIndex = 0;
            this.label9.Text = "ID Analisis";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.btnEliminarAnal);
            this.groupBox3.Controls.Add(this.btnModificarAnal);
            this.groupBox3.Controls.Add(this.btnRegistrarAnal);
            this.groupBox3.Controls.Add(this.btnNuevoAnalisis);
            this.groupBox3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(245, 307);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(513, 76);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gestionar Análisis";
            // 
            // btnEliminarAnal
            // 
            this.btnEliminarAnal.Location = new System.Drawing.Point(372, 23);
            this.btnEliminarAnal.Name = "btnEliminarAnal";
            this.btnEliminarAnal.Size = new System.Drawing.Size(102, 37);
            this.btnEliminarAnal.TabIndex = 3;
            this.btnEliminarAnal.Text = "Eliminar";
            this.btnEliminarAnal.UseVisualStyleBackColor = true;
            this.btnEliminarAnal.Click += new System.EventHandler(this.btnEliminarAnal_Click);
            // 
            // btnModificarAnal
            // 
            this.btnModificarAnal.Location = new System.Drawing.Point(254, 23);
            this.btnModificarAnal.Name = "btnModificarAnal";
            this.btnModificarAnal.Size = new System.Drawing.Size(102, 37);
            this.btnModificarAnal.TabIndex = 2;
            this.btnModificarAnal.Text = "Modificar";
            this.btnModificarAnal.UseVisualStyleBackColor = true;
            this.btnModificarAnal.Click += new System.EventHandler(this.btnModificarAnal_Click);
            // 
            // btnRegistrarAnal
            // 
            this.btnRegistrarAnal.Location = new System.Drawing.Point(128, 23);
            this.btnRegistrarAnal.Name = "btnRegistrarAnal";
            this.btnRegistrarAnal.Size = new System.Drawing.Size(102, 37);
            this.btnRegistrarAnal.TabIndex = 1;
            this.btnRegistrarAnal.Text = "Registrar";
            this.btnRegistrarAnal.UseVisualStyleBackColor = true;
            this.btnRegistrarAnal.Click += new System.EventHandler(this.btnRegistrarAnal_Click);
            // 
            // btnNuevoAnalisis
            // 
            this.btnNuevoAnalisis.Location = new System.Drawing.Point(6, 23);
            this.btnNuevoAnalisis.Name = "btnNuevoAnalisis";
            this.btnNuevoAnalisis.Size = new System.Drawing.Size(102, 37);
            this.btnNuevoAnalisis.TabIndex = 0;
            this.btnNuevoAnalisis.Text = "Nuevo";
            this.btnNuevoAnalisis.UseVisualStyleBackColor = true;
            this.btnNuevoAnalisis.Click += new System.EventHandler(this.btnNuevoAnalisis_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox4.Controls.Add(this.dataGridViewAnalisis);
            this.groupBox4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(70, 402);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(555, 141);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Datos";
            // 
            // dataGridViewAnalisis
            // 
            this.dataGridViewAnalisis.AllowUserToAddRows = false;
            this.dataGridViewAnalisis.AllowUserToDeleteRows = false;
            this.dataGridViewAnalisis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAnalisis.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewAnalisis.Name = "dataGridViewAnalisis";
            this.dataGridViewAnalisis.ReadOnly = true;
            this.dataGridViewAnalisis.Size = new System.Drawing.Size(543, 112);
            this.dataGridViewAnalisis.TabIndex = 0;
            this.dataGridViewAnalisis.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAnalisis_CellContentClick);
            // 
            // AnalisisCore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(772, 555);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AnalisisCore";
            this.Text = "AnalisisCore";
            this.Load += new System.EventHandler(this.AnalisisCore_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnalisis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFechaAnal;
        private System.Windows.Forms.TextBox txtTipoAnalsis;
        private System.Windows.Forms.TextBox txtIDPacienteAnalisis;
        private System.Windows.Forms.TextBox txtIDAnalisis;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtObservacionAnal;
        private System.Windows.Forms.TextBox txtIDDoctorAnalsis;
        private System.Windows.Forms.TextBox txtResultadoAnal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBuscarAnalisis;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnEliminarAnal;
        private System.Windows.Forms.Button btnModificarAnal;
        private System.Windows.Forms.Button btnRegistrarAnal;
        private System.Windows.Forms.Button btnNuevoAnalisis;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridViewAnalisis;
    }
}