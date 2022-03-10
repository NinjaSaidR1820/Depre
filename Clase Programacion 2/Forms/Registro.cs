using Clase_Programacion_2.Forms;
using Domain.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_Programacion_2
{
    public partial class FrmRegistro : Form
    {
        List<ActivoFijo> listaActivos = new List<ActivoFijo>();
        ActivoFijo activo;

        int i = 0;

        private void ActualizarLista()
        { 
            dgvActivos.DataSource = null;
            dgvActivos.DataSource = listaActivos;
            txtBuscar.Text = "";
        }

        private void Clear()
        {
            txtVidaUtil.Clear();
            txtValorDeSalvamento.Clear();
            txtNombreActivo.Clear();
            txtValorActivo.Clear();
            cbTipoActivo.SelectedIndex = -1;

            txtNombreActivo.Focus();
        }


        public void CreateActivo() {

            i++;

            string id = i.ToString();

            activo = new ActivoFijo(id,txtNombreActivo.Text, Convert.ToInt32(txtValorActivo.Text), cbTipoActivo.Text,
                Convert.ToInt32(txtVidaUtil.Text),Convert.ToInt32(txtValorDeSalvamento.Text));

            listaActivos.Add(activo);

            ActualizarLista();
            Clear();


        }

        public void Delete(string id)
        {
            foreach (var usuario in listaActivos)
            {
                if (usuario.Id == id)
                {
                    listaActivos.Remove(usuario);
                    break;
                }
            }
        }

        public void Buscar(string id)
        {
            foreach (var usuario in listaActivos)
            { 
                if (usuario.Id == id)
                { 
                    cbTipoActivo.Text = usuario.TipoActivofijo;
                    txtNombreActivo.Text = usuario.NombreActivo;
                    txtValorActivo.Text = usuario.ValorActivo.ToString();
                    txtVidaUtil.Text = usuario.VidaUtil.ToString();
                    txtValorDeSalvamento.Text = usuario.ValorDeSalvamento.ToString();
                    break;
                }
            }
        }

        public void Modificar(string id)
        {
            foreach (var usuario in listaActivos)
            {
                if (usuario.Id == id)
                {
                    usuario.TipoActivofijo = cbTipoActivo.Text;
                    usuario.NombreActivo = txtNombreActivo.Text;
                    usuario.ValorActivo = Convert.ToInt32(txtValorActivo.Text);
                    usuario.VidaUtil = Convert.ToInt32(txtVidaUtil.Text);
                    usuario.ValorDeSalvamento = Convert.ToInt32(txtValorDeSalvamento.Text);
                    break;
                }
            }
        }
        public void BorrarActivo(string id)
        {
            foreach (var usuario in listaActivos)
            { 
                if (usuario.Id == id)
                {
                    listaActivos.Remove(usuario);
                    break;
                }
            }
        }


        public void ExceptionEmply()
        {
            if (txtValorActivo.Text == "" || txtNombreActivo.Text == "" || 
                txtValorDeSalvamento.Text == "" || txtVidaUtil.Text == "" || 
                cbTipoActivo.SelectedIndex == -1 )
            {
                MessageBox.Show("Porfavor Rellenar los Campos Vacios", "Estado de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
           
        }

        #region linq
        public void getInfoDeBusqueda()
        {
            IEnumerable<ActivoFijo> x = from d in listaActivos select d;
            foreach(ActivoFijo i in listaActivos)
            {
                txtConsulta.AppendText(i.getInfoBasicaActivoBusqueda());
            }


        }

        #endregion


        public FrmRegistro()
        {
            InitializeComponent();
        }


       
        #region buttons
        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            if (txtValorActivo.Text == "" || txtNombreActivo.Text == "" ||
               txtValorDeSalvamento.Text == "" || txtVidaUtil.Text == "" ||
               cbTipoActivo.SelectedIndex == -1)
            {
                MessageBox.Show("Porfavor Rellenar los Campos Vacios", "Estado de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else { CreateActivo(); }

        }
        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void ToolStripButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            txtConsulta.Clear();
            getInfoDeBusqueda();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Buscar(txtBuscar.Text);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Modificar(txtBuscar.Text);
            ActualizarLista();
            button1_Click(sender, e);
            Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            BorrarActivo(txtBuscar.Text);
            ActualizarLista();
            Clear();
        }

        private void btnDepreciaciones_Click(object sender, EventArgs e)
        {
            this.Hide();
            Depreciaciones dp = new Depreciaciones();
            dp.Show();


            dp.lblTitulo.Text = "Welcome To The Depreciations Methods";
        }



        #endregion

        #region Cosas que agregue por Error pero no puedo borrar porque se chinga el form
        private void ToolStripLabel3_Click(object sender, EventArgs e)
        {

        }

        #endregion

    }
}
