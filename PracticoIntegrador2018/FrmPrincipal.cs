using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticoIntegrador2018
{
    public partial class Form1 : Form
    {

        AccesoDatos acceso = new AccesoDatos(@"");//Falta colocar cadena
        List<Actores> actores = new List<Actores>();
        List<Pelicula> peliculas = new List<Pelicula>();

        public Form1()
        {
            InitializeComponent();
        }
        //----------------------------------------------------------------------------------------
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //----------------------------------------------------------------------------------------
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea salir?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }
        //----------------------------------------------------------------------------------------
        private void btnABM_Click(object sender, EventArgs e)
        {
            Form abm = new FrmABM();
            abm.Show();

        }
        //----------------------------------------------------------------------------------------
        private void btnConsulta1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Select id_actor, Nombre, Nacionalidad from actores where nombre like " +
                            "'[C-H]%' and edad between 30 and 50 UNION Select id_director, Nombre, " +
                            "Nacionalidad from Directores where nombre not like '[J-Q]%' and edad " +
                            "between 50 and 60 Order By 3 desc ..........se puede parametrizar el " +
                            "rango de edad", "Instrucciones", MessageBoxButtons.OK, MessageBoxIcon.Information);

            acceso.leerTabla("actores");
            int c = 0;

            while (acceso.pLector.Read())
            {
                actores.Add(new Actores());

                if (!acceso.pLector.IsDBNull(0))
                {
                    actores.ElementAt(c).Id = acceso.pLector.GetInt32(0);
                }
                if (!acceso.pLector.IsDBNull(1))
                {
                    actores.ElementAt(c).Nombre = acceso.pLector.GetString(1);
                }
                if (!acceso.pLector.IsDBNull(2))
                {
                    actores.ElementAt(c).Pais = acceso.pLector.GetInt32(2);
                }
                if (!acceso.pLector.IsDBNull(3))
                {
                    actores.ElementAt(c).Reseña = acceso.pLector.GetString(3);
                }
                if (!acceso.pLector.IsDBNull(4))
                {
                    actores.ElementAt(c).FechaN = acceso.pLector.GetDateTime(4);
                }
                c++;
            }
            acceso.pLector.Close();
            acceso.desconectar();

        }
    }
}
