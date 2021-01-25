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
    public partial class Boleta_PrestamoActivo : Form
    {
        public Boleta_PrestamoActivo()
        {
            InitializeComponent();
        }

        private void Boleta_PrestamoActivo_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
