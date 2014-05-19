using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ReporteExistenciaPrecio;
using ReporteExistenciaPrecio.Reporte_Vendedores;

namespace Reportes_A_Medida
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void btnExisPrecio_Click(object sender, EventArgs e)
        {
            this.Hide();
            Splash spExistencia = new Splash();
            spExistencia.ShowDialog();
            this.WindowState = FormWindowState.Maximized;
            this.Show();
        }

        private void btnVentasVendedor_Click(object sender, EventArgs e)
        {
            this.Hide();
            Splash_VentasVendedores splashVendedores = new Splash_VentasVendedores();
            splashVendedores.ShowDialog();
            this.WindowState = FormWindowState.Maximized;
            this.Show();
        }
    }
}
