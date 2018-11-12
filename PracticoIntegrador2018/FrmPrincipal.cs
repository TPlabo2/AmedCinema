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
        AccesoDatos acceso = new AccesoDatos(@"Data source=DESKTOP-FRANCO\SQLEXPRESS;Initial Catalog=Cine;  user id = sa; password = 110254");//Falta colocar cadena
        string consulta;

        int variablePruebaSanti; 

        //Enumeracion para verificar que consulta se debe ejecutar
        public enum Consultero {
            C1,C2,C3,C4,C5,C6,C7,C8,C9,C10,none
        }
        //se instancia la enumeracion
        Consultero consultero = Consultero.none;
        //----------------------------------------------------------------------------------------
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
        private void btnConsulta1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Select id_actor, Nombre, Nacionalidad from actores where nombre like " +
                           "'[C-H]%' and edad between 30 and 50 UNION Select id_director, Nombre, " +
                           "Nacionalidad from Directores where nombre not like '[J-Q]%' and edad " +
                           "between 50 and 60 Order By 3 desc ..........se puede parametrizar el " +
                           "rango de edad", "Instrucciones", MessageBoxButtons.OK, MessageBoxIcon.Information);

            consulta = "Select id_actor, Nombre, Nacionalidad from actores where nombre like " +
                            "'[C-H]%' and fecha_nacimiento between '2000/1/1' and '2018/1/1' UNION Select id_director, Nombre, " +
                            "Nacionalidad from Directores where nombre not like '[J-Q]%' and fecha_nacimiento " +
                            "between '2000/1/1' and '2018/1/1' Order By 3 desc";
            consultero = Consultero.C1;
        }
        //----------------------------------------------------------------------------------------
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            switch (consultero)
            {
                case Consultero.C1:
                                acceso.putInGrid(dgrvConsultas, consulta);
                    break;
                case Consultero.C2:
                    acceso.putInGrid(dgrvConsultas, consulta);
                    break;
                case Consultero.C3:
                    acceso.putInGrid(dgrvConsultas, consulta);
                    break;
                case Consultero.C4:
                    acceso.putInGrid(dgrvConsultas, consulta);
                    break;
                case Consultero.C5:
                    acceso.putInGrid(dgrvConsultas, consulta);
                    break;
                case Consultero.C6:
                    acceso.putInGrid(dgrvConsultas, consulta);
                    break;
                case Consultero.C7:
                    acceso.putInGrid(dgrvConsultas, consulta);
                    break;
                case Consultero.C8:
                    acceso.putInGrid(dgrvConsultas, consulta);
                    break;
                case Consultero.C9:
                    acceso.putInGrid(dgrvConsultas, consulta);
                    break;
                case Consultero.C10:
                    acceso.putInGrid(dgrvConsultas, consulta);
                    break;
                case Consultero.none:
                    MessageBox.Show("No selecciono ninguna consulta", "error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    break;
                default:
                    MessageBox.Show("No selecciono ninguna consulta", "error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    break;
            }
        }
    }
}
