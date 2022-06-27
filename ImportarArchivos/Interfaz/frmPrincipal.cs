using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbVia.Text.Length > 0 && tbVia.Text.Length < 3)
                {
                    DateTime dtFDesde = Convert.ToDateTime(dtpDesde.Text);
                    DateTime dtFHasta = Convert.ToDateTime(dtpHasta.Text);
                    int iVia = Convert.ToInt32(tbVia.Text);
                    string sPlaca = tbPlaca.Text;

                    List<TransitoAgrupado> transitoAgrupadoL = TransitoBs.GetTransitosAgrupados(dtFDesde, dtFHasta, sPlaca, iVia);

                    if (transitoAgrupadoL.Count > 0)
                    {
                        frmTransitos frm = new frmTransitos(transitoAgrupadoL);
                        frm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("No se encuentraron transitos con dicha especificación.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Error en el ingreso de la vía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
