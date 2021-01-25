using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class Boleta_PrestamoActivos : Form
    {
        public Boleta_PrestamoActivos()
        {
            InitializeComponent();
        }

        public int idMov { get; set; }

        private void Boleta_PrestamoActivos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetBoletas.SP_CNS_BOLETA_PACTIVO' Puede moverla o quitarla según sea necesario.
            this.SP_CNS_BOLETA_PACTIVOTableAdapter.Fill(this.DataSetBoletas.SP_CNS_BOLETA_PACTIVO, idMov);

            this.reportViewer1.RefreshReport();
        }
    }
}
