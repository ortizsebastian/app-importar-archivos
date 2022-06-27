
namespace Interfaz
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.gbBuscarTransitos = new System.Windows.Forms.GroupBox();
            this.gbFecha = new System.Windows.Forms.GroupBox();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.lbDesde = new System.Windows.Forms.Label();
            this.lbHasta = new System.Windows.Forms.Label();
            this.lbVia = new System.Windows.Forms.Label();
            this.tbPlaca = new System.Windows.Forms.TextBox();
            this.lbPlaca = new System.Windows.Forms.Label();
            this.tbVia = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gbBuscarTransitos.SuspendLayout();
            this.gbFecha.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbBuscarTransitos
            // 
            this.gbBuscarTransitos.Controls.Add(this.gbFecha);
            this.gbBuscarTransitos.Controls.Add(this.lbVia);
            this.gbBuscarTransitos.Controls.Add(this.tbPlaca);
            this.gbBuscarTransitos.Controls.Add(this.lbPlaca);
            this.gbBuscarTransitos.Controls.Add(this.tbVia);
            this.gbBuscarTransitos.Controls.Add(this.btnBuscar);
            this.gbBuscarTransitos.Location = new System.Drawing.Point(12, 12);
            this.gbBuscarTransitos.Name = "gbBuscarTransitos";
            this.gbBuscarTransitos.Size = new System.Drawing.Size(334, 249);
            this.gbBuscarTransitos.TabIndex = 6;
            this.gbBuscarTransitos.TabStop = false;
            this.gbBuscarTransitos.Text = "Parámetros";
            // 
            // gbFecha
            // 
            this.gbFecha.Controls.Add(this.dtpDesde);
            this.gbFecha.Controls.Add(this.dtpHasta);
            this.gbFecha.Controls.Add(this.lbDesde);
            this.gbFecha.Controls.Add(this.lbHasta);
            this.gbFecha.Location = new System.Drawing.Point(20, 31);
            this.gbFecha.Name = "gbFecha";
            this.gbFecha.Size = new System.Drawing.Size(292, 96);
            this.gbFecha.TabIndex = 9;
            this.gbFecha.TabStop = false;
            this.gbFecha.Text = "Fecha";
            // 
            // dtpDesde
            // 
            this.dtpDesde.CustomFormat = "dd/MM/yyyy HH\':\'mm";
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDesde.Location = new System.Drawing.Point(66, 30);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(200, 20);
            this.dtpDesde.TabIndex = 5;
            // 
            // dtpHasta
            // 
            this.dtpHasta.CustomFormat = "dd/MM/yyyy HH\':\'mm";
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHasta.Location = new System.Drawing.Point(66, 58);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(200, 20);
            this.dtpHasta.TabIndex = 10;
            // 
            // lbDesde
            // 
            this.lbDesde.AutoSize = true;
            this.lbDesde.Location = new System.Drawing.Point(8, 33);
            this.lbDesde.Name = "lbDesde";
            this.lbDesde.Size = new System.Drawing.Size(41, 13);
            this.lbDesde.TabIndex = 3;
            this.lbDesde.Text = "Desde:";
            // 
            // lbHasta
            // 
            this.lbHasta.AutoSize = true;
            this.lbHasta.Location = new System.Drawing.Point(8, 60);
            this.lbHasta.Name = "lbHasta";
            this.lbHasta.Size = new System.Drawing.Size(38, 13);
            this.lbHasta.TabIndex = 4;
            this.lbHasta.Text = "Hasta:";
            // 
            // lbVia
            // 
            this.lbVia.AutoSize = true;
            this.lbVia.Location = new System.Drawing.Point(48, 166);
            this.lbVia.Name = "lbVia";
            this.lbVia.Size = new System.Drawing.Size(27, 13);
            this.lbVia.TabIndex = 8;
            this.lbVia.Text = "Vía:";
            // 
            // tbPlaca
            // 
            this.tbPlaca.Location = new System.Drawing.Point(106, 136);
            this.tbPlaca.MaxLength = 10;
            this.tbPlaca.Name = "tbPlaca";
            this.tbPlaca.Size = new System.Drawing.Size(161, 20);
            this.tbPlaca.TabIndex = 5;
            // 
            // lbPlaca
            // 
            this.lbPlaca.AutoSize = true;
            this.lbPlaca.Location = new System.Drawing.Point(48, 139);
            this.lbPlaca.Name = "lbPlaca";
            this.lbPlaca.Size = new System.Drawing.Size(47, 13);
            this.lbPlaca.TabIndex = 7;
            this.lbPlaca.Text = "Patente:";
            // 
            // tbVia
            // 
            this.tbVia.Location = new System.Drawing.Point(106, 166);
            this.tbVia.MaxLength = 5;
            this.tbVia.Name = "tbVia";
            this.tbVia.Size = new System.Drawing.Size(161, 20);
            this.tbVia.TabIndex = 6;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(124, 209);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(86, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Listar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 274);
            this.Controls.Add(this.gbBuscarTransitos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.Text = "Importar Archivos";
            this.gbBuscarTransitos.ResumeLayout(false);
            this.gbBuscarTransitos.PerformLayout();
            this.gbFecha.ResumeLayout(false);
            this.gbFecha.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBuscarTransitos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lbHasta;
        private System.Windows.Forms.Label lbDesde;
        private System.Windows.Forms.GroupBox gbFecha;
        private System.Windows.Forms.Label lbVia;
        private System.Windows.Forms.TextBox tbPlaca;
        private System.Windows.Forms.Label lbPlaca;
        private System.Windows.Forms.TextBox tbVia;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
    }
}

