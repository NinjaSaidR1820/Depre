using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_Programacion_2.Forms
{
    public partial class Depreciaciones : Form
    {
        public Depreciaciones()
        {
            InitializeComponent();
        }

        private void btnCloseWindow_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmRegistro rg = new FrmRegistro();
            rg.Show();
            
        }
    }
}
