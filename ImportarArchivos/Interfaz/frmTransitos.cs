using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class frmTransitos : Form
    {
        public List<TransitoAgrupado> TransitoAgrupadoL { get; set; }
        public string CarpetaDestino { get; set; }
        public string CarpetaOrigen { get; set; }

        public frmTransitos()
        {
            InitializeComponent();
        }

        public frmTransitos(List<TransitoAgrupado> TransitoAgrupadoL)
        {
            InitializeComponent();
            this.TransitoAgrupadoL = TransitoAgrupadoL;
            CarpetaDestino = ConfigurationManager.AppSettings["CarpetaDestino"];
            CarpetaOrigen = ConfigurationManager.AppSettings["CarpetaOrigen"];
        }

        private void dgvTransitos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTransitosAgrupados.SelectedRows.Count > 0)
            {
                btnGuardar.Enabled = true;
            }
        }

        private void frmTransitos_Load(object sender, EventArgs e)
        {
            try
            {
                dgvTransitosAgrupados.DataSource = TransitoAgrupadoL;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TransitoBs.GuardarArchivos(CarpetaOrigen, CarpetaDestino, (TransitoAgrupado)dgvTransitosAgrupados.CurrentRow.DataBoundItem))
                {
                    MessageBox.Show($@"Archivos guardados en la carpeta: '{CarpetaDestino}'.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvTransitosAgrupados.CurrentRow.DefaultCellStyle.BackColor = Color.Yellow;
                }
                else
                {
                    MessageBox.Show("No se encontraron archivos en la carpeta de origen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dgvTransitosAgrupados.CurrentRow.DefaultCellStyle.BackColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
