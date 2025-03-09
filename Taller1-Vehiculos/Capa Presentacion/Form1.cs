using System.Data;
using Taller1_Vehiculos.Capa_Datos;

namespace Taller1_Vehiculos
{
    public partial class frm_Vehiculos : Form
    {
        public frm_Vehiculos()
        {
            InitializeComponent();
        }

        public void MtdMostrarVehiculos()
        {
            CD_Vehiculos cd_vehiculos = new CD_Vehiculos();
            DataTable dtMostrarVehiculos = cd_vehiculos.MtMostrarVehiculos();
            dgvVehiculos.DataSource = dtMostrarVehiculos;
        }

        private void frm_Vehiculos_Load(object sender, EventArgs e)
        {
            MtdMostrarVehiculos();
        }

        private void btn_VehiculosCrear_Click(object sender, EventArgs e)
        {
            CD_Vehiculos cD_Vehiculos = new CD_Vehiculos();
            try
            {
                cD_Vehiculos.MtdAgregarVehiculos(txt_VehiculoMarca.Text, txt_VehiculoModelo.Text, int.Parse(txt_VehiculoAño.Text), decimal.Parse(txt_VehiculoPrecio.Text), cbx_VehiculoEstado.Text);
                MessageBox.Show("El Vehiculo se agrego con Exito", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MtdMostrarVehiculos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgvVehiculos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_VehiculoID.Text = dgvVehiculos.SelectedCells[0].Value.ToString();
            txt_VehiculoMarca.Text = dgvVehiculos.SelectedCells[1].Value.ToString();
            txt_VehiculoModelo.Text = dgvVehiculos.SelectedCells[2].Value.ToString();
            txt_VehiculoAño.Text = dgvVehiculos.SelectedCells[3].Value.ToString();
            txt_VehiculoPrecio.Text = dgvVehiculos.SelectedCells[4].Value.ToString();
            cbx_VehiculoEstado.Text = dgvVehiculos.SelectedCells[5].Value.ToString();
        }

        private void dgvVehiculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_VehiculosActualizar_Click(object sender, EventArgs e)
        {
            CD_Vehiculos cD_Vehiculos = new CD_Vehiculos();
            try
            {
                cD_Vehiculos.MtdActualizarVehiculos(int.Parse(txt_VehiculoID.Text), txt_VehiculoMarca.Text, txt_VehiculoModelo.Text, int.Parse(txt_VehiculoAño.Text), decimal.Parse(txt_VehiculoPrecio.Text), cbx_VehiculoEstado.Text);
                MessageBox.Show("El Vehiculo se actualizo con exito", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MtdMostrarVehiculos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_VehiculosEliminar_Click(object sender, EventArgs e)
        {
            CD_Vehiculos cD_Vehiculos = new CD_Vehiculos();
            try
            {
                cD_Vehiculos.MtdEliminarVehiculos(int.Parse(txt_VehiculoID.Text));
                MessageBox.Show("El Vehiculo se elimino con exito", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MtdMostrarVehiculos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            foreach( Control control in this.Controls )
            {
                if(control is TextBox )
                {
                    control.Text=string.Empty;
                }
                if(control is CheckBox )
                {
                    control.Text = string.Empty;
                }
            }
        }
    }
}
