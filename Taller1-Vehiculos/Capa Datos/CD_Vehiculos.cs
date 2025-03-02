using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1_Vehiculos.Capa_Datos
{
    internal class CD_Vehiculos
    {
        CD_Conexion db_conexion = new CD_Conexion();

        public DataTable MtMostrarVehiculos()
        {
            string QryMostrarVehiculos = "usp_VehiculosMostrar";
            SqlDataAdapter adapter = new SqlDataAdapter(QryMostrarVehiculos, db_conexion.MtdAbrirConexion());
            DataTable dtMostrarVehiculos = new DataTable();
            adapter.Fill(dtMostrarVehiculos);
            db_conexion.MtdCerrarConexion();
            return dtMostrarVehiculos;
        }

        public void MtdAgregarVehiculos(string Marca, string Modelo, int Año, decimal Precio, string Estado)
        {
            string usp_crear = "usp_VehiculosCrear";
            SqlCommand cmd_UspCrearVehiculos = new SqlCommand(usp_crear, db_conexion.MtdAbrirConexion());
            cmd_UspCrearVehiculos.CommandType = CommandType.StoredProcedure;
            cmd_UspCrearVehiculos.Parameters.AddWithValue("@Marca",Marca);
            cmd_UspCrearVehiculos.Parameters.AddWithValue("@Modelo", Modelo);
            cmd_UspCrearVehiculos.Parameters.AddWithValue("@Año", Año);
            cmd_UspCrearVehiculos.Parameters.AddWithValue("@Precio", Precio);
            cmd_UspCrearVehiculos.Parameters.AddWithValue("@Estado", Estado);
            cmd_UspCrearVehiculos.ExecuteNonQuery();

            db_conexion.MtdCerrarConexion();
        }

    }
}
