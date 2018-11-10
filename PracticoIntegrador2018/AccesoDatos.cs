using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace PracticoIntegrador2018
{
    class AccesoDatos
    {
        OleDbConnection conexion;
        OleDbCommand comando;
        OleDbDataReader lector;
        OleDbDataAdapter da;
        DataTable tabla;
        string cadena;

        public AccesoDatos(string cadena)
        {
            this.cadena = cadena;
            this.lector = null;
            this.conexion = new OleDbConnection();
            this.comando = new OleDbCommand();
            this.tabla = new DataTable();
            this.da = new OleDbDataAdapter();
        }

        public DataTable pTabla { get => tabla; set => tabla = value; }
        public string pCadena { get => cadena; set => cadena = value; }
        public OleDbDataReader pLector { get => lector; set => lector = value; }

        public void conectar()
        {
            this.conexion.ConnectionString = cadena;
            this.conexion.Open();
            this.comando.Connection = conexion;
            this.comando.CommandType = CommandType.Text;

        }

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

        public DataTable consultarTabla(string nombretabla)
        {
            conectar();
            tabla = new DataTable();
            comando.CommandText = "SELECT * FROM " + nombretabla;
            tabla.Load(comando.ExecuteReader());

            desconectar();

            return tabla;
        }

        public DataTable consultarBD(string consulta)
        {
            conectar();
            tabla = new DataTable();
            comando.CommandText = consulta;
            tabla.Load(comando.ExecuteReader());

            desconectar();

            return tabla;
        }

        public void leerTabla(string nombretabla)
        {
            conectar();

            comando.CommandText = "SELECT * FROM " + nombretabla;
            lector = comando.ExecuteReader();
        }

        public void actualizarBD(string consulta)
        {
            conectar();

            comando.CommandText = consulta;
            comando.ExecuteNonQuery();

            desconectar();
        }

        public void putInGrid(DataGridView grid, string consulta)
        {
            conectar();

            tabla = new DataTable();

            da = new OleDbDataAdapter(consulta, conexion);
            da.Fill(tabla);
            grid.DataSource = da;

            desconectar();
        }

    }
}
