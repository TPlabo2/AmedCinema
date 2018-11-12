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
        string consultaParametrizada;
 

        //Enumeracion para verificar que consulta se debe ejecutar
        public enum Consultero {
            C1,C2,C3,C4,C5,C6,C7,C8,C9,C10,none
        }
        //se instancia la enumeracion en none
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
        private void btnConsulta1_Click_1(object sender, EventArgs e)//SE PARAMETRIZAN LOS NOMBRES DEL PRIMER SELECT
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

            //deshabilitarBtn();//Metodo que inhabilita los botones de las consultas

            if (rbtnConsulta1.Checked == true)
            {
                consultaParametrizada =  "Select id_actor, Nombre, Nacionalidad from actores where nombre like " +
                            "'["+txtConsulta1.Text+"-"+txtConsulta1C2.Text+"]%' and fecha_nacimiento between '2000/1/1' and '2018/1/1' UNION Select id_director, Nombre, " +
                            "Nacionalidad from Directores where nombre not like '[J-Q]%' and fecha_nacimiento " +
                            "between '2000/1/1' and '2018/1/1' Order By 3 desc";
                //deshabilitarRadioBtn();//Metodo que deshabilita los radiobtn una vez ingresados los paramtros

            }

        }
        //----------------------------------------------------------------------------------------
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (radioBtnVacios())//Metodo que comprueba que ningun btn este seleccionado
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
            else
            {
                switch (consultero)
                {
                    case Consultero.C1:
                        acceso.putInGrid(dgrvConsultas, consultaParametrizada);
                        break;
                    case Consultero.C2:
                        acceso.putInGrid(dgrvConsultas, consultaParametrizada);
                        break;
                    case Consultero.C3:
                        acceso.putInGrid(dgrvConsultas, consultaParametrizada);
                        break;
                    case Consultero.C4:
                        acceso.putInGrid(dgrvConsultas, consultaParametrizada);
                        break;
                    case Consultero.C5:
                        acceso.putInGrid(dgrvConsultas, consultaParametrizada);
                        break;
                    case Consultero.C6:
                        acceso.putInGrid(dgrvConsultas, consultaParametrizada);
                        break;                          
                    case Consultero.C7:                 
                        acceso.putInGrid(dgrvConsultas, consultaParametrizada);
                        break;                         
                    case Consultero.C8:                 
                        acceso.putInGrid(dgrvConsultas, consultaParametrizada);
                        break;                          
                    case Consultero.C9:                
                        acceso.putInGrid(dgrvConsultas, consultaParametrizada);
                        break;                         
                    case Consultero.C10:                
                        acceso.putInGrid(dgrvConsultas, consultaParametrizada);
                        break;
                    case Consultero.none:
                        MessageBox.Show("No selecciono ninguna consulta", "error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        break;
                    default:
                        MessageBox.Show("No selecciono ninguna consulta", "error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        break;
                }
            }

            consultero = Consultero.none;
        }
        //----------------------------------------------------------------------------------------
        private bool radioBtnVacios()
        {
            if (rbtnConsulta1.Checked == false && rbtnConsulta2.Checked == false && rbtnConsulta3.Checked == false && rbtnConsulta4.Checked == false && rbtnConsulta5.Checked == false
                && rbtnConsulta6.Checked == false && rbtnConsulta7.Checked == false && rbtnConsulta8.Checked == false && rbtnConsulta9.Checked == false && rbtnConsulta10.Checked == false)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //----------------------------------------------------------------------------------------
        private void btnConsulta2_Click(object sender, EventArgs e)//SE PARAMETRIZA LA FEHCA DE NACIMIENTO DE LA PRIMER CONSULTA
        {
            MessageBox.Show("Select id_actor, nombre, id_pais From actores a join paises p on p.id_pais = a.id_pais Where p.nombre in (‘Argentina’) and a.nombre not like ‘[A - F]%’ and fecha_nacimiento > '1990/1/1' " +
                            "UNION Select id_pelicula, nombre, idioma From peliculas p join idiomas i on p.id_idioma = i.id_idioma join clasificacionesPelicula C on c.id_clasificacion = p.id_clasificacion " +
                            "join genero g  on g.id_genero = p.id_genero Where idioma in (‘Ingles’) and clasificacion like ‘+16’  and genero like ‘Terror’ or ‘Accion’ Order by 2",
                            "Instrucciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
            consulta = "Select id_actor, nombre, id_pais From actores a join paises p on p.id_pais = a.id_pais Where p.nombre in (‘Argentina’) and a.nombre not like ‘[A - F]%’ and fecha_nacimiento > '1990/1/1' " +
                        "UNION Select id_pelicula, nombre, idioma From peliculas p join idiomas i on p.id_idioma = i.id_idioma join clasificacionesPelicula C on c.id_clasificacion = p.id_clasificacion " +
                        "join genero g  on g.id_genero = p.id_genero Where idioma in (‘Ingles’) and clasificacion like ‘+16’  and genero like ‘Terror’ or ‘Accion’ Order by 2";

            consultero = Consultero.C2;

            //deshabilitarBtn();//Metodo que inhabilita los botones de las consultas

            if (rbtnConsulta2.Checked == true)
            {
               consultaParametrizada = "Select id_actor, nombre, id_pais From actores a join paises p on p.id_pais = a.id_pais Where p.nombre in (‘Argentina’) and a.nombre not like ‘[A - F]%’ and fecha_nacimiento > '"+dtpckConsulta2+"' " +
                                       "UNION Select id_pelicula, nombre, idioma From peliculas p join idiomas i on p.id_idioma = i.id_idioma join clasificacionesPelicula C on c.id_clasificacion = p.id_clasificacion " +
                                       "join genero g  on g.id_genero = p.id_genero Where idioma in (‘Ingles’) and clasificacion like ‘+16’  and genero like ‘Terror’ or ‘Accion’ Order by 2"

                //deshabilitarRadioBtn();//Metodo que deshabilita los radiobtn una vez ingresados los paramtros
            }
        }
    }
}
