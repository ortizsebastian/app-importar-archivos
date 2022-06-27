
namespace Interfaz
{
    partial class frmTransitos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransitos));
            this.dgvTransitosAgrupados = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransitosAgrupados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTransitosAgrupados
            // 
            this.dgvTransitosAgrupados.AllowUserToResizeColumns = false;
            this.dgvTransitosAgrupados.AllowUserToResizeRows = false;
            this.dgvTransitosAgrupados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTransitosAgrupados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransitosAgrupados.Location = new System.Drawing.Point(12, 13);
            this.dgvTransitosAgrupados.MultiSelect = false;
            this.dgvTransitosAgrupados.Name = "dgvTransitosAgrupados";
            this.dgvTransitosAgrupados.ReadOnly = true;
            this.dgvTransitosAgrupados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransitosAgrupados.Size = new System.Drawing.Size(622, 325);
            this.dgvTransitosAgrupados.TabIndex = 0;
            this.dgvTransitosAgrupados.SelectionChanged += new System.EventHandler(this.dgvTransitos_SelectionChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Location = new System.Drawing.Point(266, 347);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(115, 29);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmTransitos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 383);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvTransitosAgrupados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTransitos";
            this.Text = "Tránsitos";
            this.Load += new System.EventHandler(this.frmTransitos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransitosAgrupados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTransitosAgrupados;
        private System.Windows.Forms.Button btnGuardar;
    }
}