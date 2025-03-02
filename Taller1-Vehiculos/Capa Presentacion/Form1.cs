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

        }
    }
}
