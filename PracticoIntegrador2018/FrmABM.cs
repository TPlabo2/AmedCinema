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
    public partial class FrmABM : Form
    {
        const int tam = 25;
        int pos;
        Pelicula[] peliculas = new Pelicula[tam];
        AccesoDatos datos = new AccesoDatos(@"Data Source=DESKTOP-D2E18LA;Initial Catalog=Cine;Integrated Security=True");
        public FrmABM()
        {

            InitializeComponent();
        }
        //--------------------------------------------------------------------------------
        private void FrmABM_Load(object sender, EventArgs e)
        {
            dtpEdad.Text = "01/01/1991";
            txtDuracion.Text = "00:00:00";
            bloqueoPelis(false);
            bloqueoActores(false);


            cargarCombo(cboGenero, "Generos");
            cargarCombo(cboIdioma, "Idiomas");
            cargarCombo(cboClasificacion, "ClasificacionesPelicula");
            cargarCombo(cboSubtitulos, "subtitulos");
            //cargarCombo(cboDirector, "Directores");
            cargarCombo(cboPais, "Paises");
            //----------------------------------------------------------
            //datos.putInGrid(dgvPeliculas, "Select * from Pelicula");
            //datos.putInGrid(dgvActores, "Select * from Actores");

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNuevoPelicula_Click(object sender, EventArgs e)
        {



        }



        //--------------------------------------------------------------------------------
        private void cargarCombo(ComboBox combo, string nombreTabla)
        {
            DataTable tabla = new DataTable();
            tabla = datos.consultarTabla(nombreTabla);
            combo.DataSource = tabla;
            combo.ValueMember = tabla.Columns[0].ColumnName;
            combo.DisplayMember = tabla.Columns[1].ColumnName;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
            combo.SelectedIndex = -1;
        }

        private void btnGuardarPelicula_Click(object sender, EventArgs e)
        {
            try
            {

                Pelicula peli = new Pelicula();
                // peli.Id = Convert.ToInt32(txtIdPeli.Text);
                peli.Nombre = Convert.ToString(txtNombrePelicula.Text);
                peli.Duracion = Convert.ToDateTime(txtDuracion.Text);
                peli.Genero = Convert.ToInt32(cboGenero.SelectedValue);
                peli.Idioma = Convert.ToInt32(cboIdioma.SelectedValue);
                peli.Clasificacion = Convert.ToInt32(cboClasificacion.SelectedValue);
                peli.Subtitulos = Convert.ToInt32(cboSubtitulos.SelectedValue);
                //peli.Director = Convert.ToInt32(cboDirector.SelectedValue);




                //string agregar = "Insert into Pelicula (    " +
                //                                               // "id_pelicula," +
                //                                               "nombre," +
                //                                               "duracion," +
                //                                               "id_genero," +
                //                                               "id_idioma," +
                //                                               "id_clasificacion," +
                //                                               "id_subtitulos," +
                //                                               "id_director)" +
                //                                " values ( " +
                                                          //+ txtIdPeli.Text +","+ 
                                                          //" ' " + txtNombrePelicula.Text +
                                                          //"','" + txtDuracion.Text + "',"
                                                            //+ cboGenero.SelectedValue + ","
                                                            //+ cboIdioma.SelectedValue + ","
                                                            //+ cboClasificacion.SelectedValue + ","
                                                            //+ cboSubtitulos.SelectedValue + ","
                                                            //+ cboDirector.SelectedValue + ")";

                //datos.actualizarBD(agregar);
                limpiarTxtPelis();
                bloqueoPelis(true);


            }
            catch (Exception x)
            {

                MessageBox.Show("ERROR al guardar la pelicula!!  \n " + x.Message);
            }

            //datos.putInGrid(dgvPeliculas, "Select * from Pelicula");

        }
        private void btnGuardarActor_Click(object sender, EventArgs e)
        {
            try
            {
                Actores ac = new Actores();
                ac.Id = Convert.ToInt32(txtIdActor.Text);
                ac.Nombre = Convert.ToString(txtNombreActor);
                ac.Apellido = Convert.ToString(txtApellidoActor);
                ac.Pais = Convert.ToInt32(cboPais.SelectedValue);
                ac.FechaN = Convert.ToDateTime(dtpEdad.Text);
                //ac.Reseña = Convert.ToString(txtReseña.Text);

                string agregar = "INSERT INTO ACTORES("
                                 //"           id_actor,"
                                 + "nombre,nacionalidad,edad,reseña,apellido)"
                                 + "values( " +
                                             // +txtIdActor.Text+",'"
                                             "'" + txtNombreActor.Text + "',"
                                             + cboPais.SelectedValue + ",'"
                                             + dtpEdad.Text + "','"
                                             // + txtReseña.Text + "','"
                                             + txtApellidoActor.Text + "')";
                MessageBox.Show(agregar);

                datos.actualizarBD(agregar);


            }
            catch (Exception x)
            {

                MessageBox.Show("Error al cargar actor" + x.Message);
            }

            //datos.putInGrid(dgvActores, "Select * from Actores");

        }
        private void bloqueoPelis(bool x)
        {
            txtIdPelicula.Enabled = x;
            txtNombrePelicula.Enabled = x;
            txtDuracion.Enabled = x;
            cboGenero.Enabled = x;
            cboIdioma.Enabled = x;
            cboClasificacion.Enabled = x;
            cboSubtitulos.Enabled = x;
            //cboDirector.Enabled = x;

        }
        private void bloqueoActores(bool x)
        {
            txtIdActor.Enabled = x;
            txtNombreActor.Enabled = x;
            txtApellidoActor.Enabled = x;
            cboPais.Enabled = x;
            dtpEdad.Enabled = x;
            //txtReseña.Enabled = x;


        }
        private void limpiarTxtPelis()
        {
            txtIdPelicula.Text = "";
            txtNombrePelicula.Text = "";
            txtDuracion.Text = "00:00:00";
            cboGenero.SelectedIndex = -1;
            cboIdioma.SelectedIndex = -1;
            cboClasificacion.SelectedIndex = -1;
            cboSubtitulos.SelectedIndex = -1;
            //cboDirector.SelectedIndex = -1;

        }
        private void limpiarTxtActores()
        {
            txtIdActor.Text = "";
            txtNombreActor.Text = "";
            txtApellidoActor.Text = "";
            cboPais.SelectedIndex = -1;
            dtpEdad.Text = "01/01/1990";
            //txtReseña.Text = "";
        }


        private void btnNuevoPelicula_Click_1(object sender, EventArgs e)
        {
            bloqueoPelis(true);
        }

        private void btnNuevoActor_Click(object sender, EventArgs e)
        {
            bloqueoActores(true);
        }

        private void dgvPeliculas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //pos = dgvPeliculas.CurrentRow.Index;
            //DataGridViewRow fila = this.dgvPeliculas.Rows[e.RowIndex];
            MessageBox.Show(pos.ToString());
            //txtIdPelicula.Text = fila.Cells["id_Pelicula"].Value.ToString();
            //txtNombreActor.Text = fila.Cells["nombre"].Value.ToString();
            //txtDuracion.Text = fila.Cells["duracion"].Value.ToString();
            //cboGenero.SelectedIndex = Convert.ToInt32(fila.Cells["id_genero"].Value.ToString());
            //cboIdioma.SelectedIndex = Convert.ToInt32(fila.Cells["id_idioma"].Value.ToString());
            //cboClasificacion.SelectedIndex = Convert.ToInt32(fila.Cells["id_clasificacion"].Value.ToString());
            //cboSubtitulos.SelectedIndex = Convert.ToInt32(fila.Cells["id_subtitulos"].Value.ToString());
            //cboDirector.SelectedIndex = Convert.ToInt32(fila.Cells["id_director"].Value.ToString());

        }

        private void pnlActores_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlPelicula_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvPeliculas_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}