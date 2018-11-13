using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace PracticoIntegrador2018
{
    class AccesoDatos
    {
        SqlConnection conexion;
        SqlCommand comando;
        SqlDataReader lector;
        SqlDataAdapter da;
        DataTable tabla;
        string cadena;

        public AccesoDatos(string cadena)
        {
            this.cadena = cadena;
            this.lector = null;
            this.conexion = new SqlConnection();
            this.comando = new SqlCommand();
            this.tabla = new DataTable();
            this.da = new SqlDataAdapter();
        }
        //----------------------------------------------------------------------------------------
        public DataTable pTabla { get => tabla; set => tabla = value; }
        public string pCadena { get => cadena; set => cadena = value; }
        public SqlDataReader pLector { get => lector; set => lector = value; }
        //----------------------------------------------------------------------------------------
        public void conectar()
        {
            this.conexion.ConnectionString = cadena;
            this.conexion.Open();
            this.comando.Connection = conexion;
            this.comando.CommandType = CommandType.Text;

        }
        //----------------------------------------------------------------------------------------
        public void desconectar()
        {
            if (ConnectionState.Open == conexion.State)
            {
                conexion.Close();
                conexion.Dispose();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("La conexion ya se encuentra desconectada");
            }
        }
        //----------------------------------------------------------------------------------------
        public DataTable consultarTabla(string nombretabla)
        {
            conectar();
            tabla = new DataTable();
            comando.CommandText = "SELECT * FROM " + nombretabla;
            tabla.Load(comando.ExecuteReader());

            desconectar();
            
            return tabla;
        }
        //----------------------------------------------------------------------------------------
        public DataTable consultarBD(string consulta)
        {
            conectar();
            tabla = new DataTable();
            comando.CommandText = consulta;
            tabla.Load(comando.ExecuteReader());

            desconectar();

            return tabla;
        }
        //----------------------------------------------------------------------------------------
        public void leerTabla(string nombretabla)
        {
            conectar();

            comando.CommandText = "SELECT * FROM " + nombretabla;
            lector = comando.ExecuteReader();
        }
        //----------------------------------------------------------------------------------------
        public void actualizarBD(string consulta)
        {
            conectar();

            comando.CommandText = consulta;
            comando.ExecuteNonQuery();

            desconectar();
        }
        //----------------------------------------------------------------------------------------
        public void putInGrid(DataGridView grid, string consulta)
        {
            conectar();

            tabla = new DataTable();
            
            this.comando = new SqlCommand(consulta, conexion);
            da.SelectCommand = comando;
            da.Fill(tabla);
            grid.DataSource = tabla;
            
            desconectar();
        }

    }
}
