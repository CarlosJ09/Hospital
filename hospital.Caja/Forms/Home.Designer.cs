namespace hospital.Caja.Forms
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.btnOpenMontoInicial = new System.Windows.Forms.Button();
            this.btnOpenProcesos = new System.Windows.Forms.Button();
            this.btnOpenFacturar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOpenCuadre = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblReloj = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnOpenReporte = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpenMontoInicial
            // 
            this.btnOpenMontoInicial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnOpenMontoInicial.Font = new System.Drawing.Font("Quicksand Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenMontoInicial.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOpenMontoInicial.Location = new System.Drawing.Point(6, 225);
            this.btnOpenMontoInicial.Name = "btnOpenMontoInicial";
            this.btnOpenMontoInicial.Size = new System.Drawing.Size(94, 142);
            this.btnOpenMontoInicial.TabIndex = 0;
            this.btnOpenMontoInicial.Text = "Monto Inicial";
            this.btnOpenMontoInicial.UseVisualStyleBackColor = false;
            this.btnOpenMontoInicial.Click += new System.EventHandler(this.btnOpenMontoInicial_Click);
            // 
            // btnOpenProcesos
            // 
            this.btnOpenProcesos.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnOpenProcesos.Font = new System.Drawing.Font("Quicksand Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenProcesos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOpenProcesos.Location = new System.Drawing.Point(238, 19);
            this.btnOpenProcesos.Name = "btnOpenProcesos";
            this.btnOpenProcesos.Size = new System.Drawing.Size(218, 193);
            this.btnOpenProcesos.TabIndex = 1;
            this.btnOpenProcesos.Text = "Procesos a Facturar";
            this.btnOpenProcesos.UseVisualStyleBackColor = false;
            this.btnOpenProcesos.Click += new System.EventHandler(this.btnOpenProcesos_Click);
            // 
            // btnOpenFacturar
            // 
            this.btnOpenFacturar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnOpenFacturar.Font = new System.Drawing.Font("Quicksand Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFacturar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOpenFacturar.Location = new System.Drawing.Point(6, 19);
            this.btnOpenFacturar.Name = "btnOpenFacturar";
            this.btnOpenFacturar.Size = new System.Drawing.Size(226, 193);
            this.btnOpenFacturar.TabIndex = 2;
            this.btnOpenFacturar.Text = "Facturacion Offline";
            this.btnOpenFacturar.UseVisualStyleBackColor = false;
            this.btnOpenFacturar.Click += new System.EventHandler(this.btnOpenFacturar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOpenCuadre);
            this.groupBox1.Controls.Add(this.btnOpenFacturar);
            this.groupBox1.Controls.Add(this.btnOpenProcesos);
            this.groupBox1.Controls.Add(this.btnOpenMontoInicial);
            this.groupBox1.Location = new System.Drawing.Point(28, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 373);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btnOpenCuadre
            // 
            this.btnOpenCuadre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnOpenCuadre.Font = new System.Drawing.Font("Quicksand Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenCuadre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOpenCuadre.Location = new System.Drawing.Point(106, 225);
            this.btnOpenCuadre.Name = "btnOpenCuadre";
            this.btnOpenCuadre.Size = new System.Drawing.Size(214, 142);
            this.btnOpenCuadre.TabIndex = 3;
            this.btnOpenCuadre.Text = "Cuadre del Dia";
            this.btnOpenCuadre.UseVisualStyleBackColor = false;
            this.btnOpenCuadre.Click += new System.EventHandler(this.btnOpenCuadre_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(529, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 236);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblReloj
            // 
            this.lblReloj.AutoSize = true;
            this.lblReloj.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblReloj.Font = new System.Drawing.Font("Orbitron", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReloj.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblReloj.Location = new System.Drawing.Point(62, 43);
            this.lblReloj.Name = "lblReloj";
            this.lblReloj.Size = new System.Drawing.Size(103, 35);
            this.lblReloj.TabIndex = 5;
            this.lblReloj.Text = "label1";
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.groupBox2.Controls.Add(this.lblReloj);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(519, 328);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 106);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnOpenReporte
            // 
            this.btnOpenReporte.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnOpenReporte.Font = new System.Drawing.Font("Quicksand Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenReporte.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOpenReporte.Location = new System.Drawing.Point(354, 286);
            this.btnOpenReporte.Name = "btnOpenReporte";
            this.btnOpenReporte.Size = new System.Drawing.Size(130, 142);
            this.btnOpenReporte.TabIndex = 4;
            this.btnOpenReporte.Text = "Reportes";
            this.btnOpenReporte.UseVisualStyleBackColor = false;
            this.btnOpenReporte.Click += new System.EventHandler(this.btnOpenReporte_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Quicksand Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(34, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 40);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpenReporte);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenMontoInicial;
        private System.Windows.Forms.Button btnOpenProcesos;
        private System.Windows.Forms.Button btnOpenFacturar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblReloj;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnOpenCuadre;
        private System.Windows.Forms.Button btnOpenReporte;
        private System.Windows.Forms.Label label1;
    }
}