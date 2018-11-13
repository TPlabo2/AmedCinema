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
        int idPeli,idActor;
        Pelicula[] peliculas = new Pelicula[tam];
        AccesoDatos datos = new AccesoDatos(@"Data source=DESKTOP-FRANCO\SQLEXPRESS;Initial Catalog=Cine;  user id = sa; password = 110254");
        public FrmABM()
        {

            InitializeComponent();
        }
        //--------------------------------------------------------------------------------
        private void FrmABM_Load(object sender, EventArgs e)
        {
            btnModAct.Visible = false;
            btnAceptarMod.Visible = false;
            dtpEdad.Text = "01/01/1991";
            dtpDura.Text = "00:00:00";
            bloqueoPelis(false);
            bloqueoActores(false);
            cargarCombo(cboGenero, "Generos");
            cargarCombo(cboIdioma, "Idiomas");
            cargarCombo(cboClasificacion, "ClasificacionesPelicula");
            cargarCombo(cboSubtitulos, "subtitulos");
            cargarCombo(cboDirector, "Directores");
            cargarCombo(cboPaisA, "paises");
            cargarCombo(cboPaisP, "paises");
            //----------------------------------------------------------
            datos.putInGrid(dgvPelis, "Select * from Pelicula");
            datos.putInGrid(dgvActores, "Select * from Actores");

        }

     



        //---------METODOS-------------------------------------------------
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

       
        private void bloqueoPelis(bool x)
        {
            txtIdPeli.Enabled = false;
            txtNombrePelicula.Enabled = x;
            dtpDura.Enabled = x;
            cboGenero.Enabled = x;
            cboIdioma.Enabled = x;
            cboClasificacion.Enabled = x;
            cboSubtitulos.Enabled = x;
            cboDirector.Enabled = x;
            cboPaisP.Enabled = x;

        }
        private void bloqueoActores(bool x)
        {
            txtIdActor.Enabled = x;
            txtNombreActor.Enabled = x;
            txtApellidoActor.Enabled = x;
            cboPaisA.Enabled = x;
            dtpEdad.Enabled = x;
            txtReseña.Enabled = x;
            


        }
        private void limpiarTxtPelis()
        {
            txtIdPeli.Text = "";
            txtNombrePelicula.Text = "";
            dtpDura.Text = "00:00:00";
            cboGenero.SelectedIndex = -1;
            cboIdioma.SelectedIndex = -1;
            cboClasificacion.SelectedIndex = -1;
            cboSubtitulos.SelectedIndex = -1;
            cboDirector.SelectedIndex = -1;
            cboPaisP.SelectedIndex = -1;

        }
        private void limpiarTxtActores()
        {
            txtIdActor.Text = "";
            txtNombreActor.Text = "";
            txtApellidoActor.Text = "";
            cboPaisA.SelectedIndex = -1;
            dtpEdad.Text = "01/01/1990";
            txtReseña.Text = "";
        }

//-------------------BOTONES PELICULA--------------------------------------------------
            private void btnNuevoPeli_Click(object sender, EventArgs e)
        {
            bloqueoPelis(true);
            txtIdPeli.Enabled = true;
            limpiarTxtPelis();
        }

        //------------------------------
        private void btnGuardarPeli_Click(object sender, EventArgs e)
        {
            try
            {


                Pelicula peli = new Pelicula();
                peli.Id = Convert.ToInt32(txtIdPeli.Text);
                peli.Nombre = Convert.ToString(txtNombrePelicula.Text);
                peli.Duracion = Convert.ToDateTime(dtpDura.Value);
                peli.Genero = Convert.ToInt32(cboGenero.SelectedValue);
                peli.Idioma = Convert.ToInt32(cboIdioma.SelectedValue);
                peli.Clasificacion = Convert.ToInt32(cboClasificacion.SelectedValue);
                peli.Subtitulos = Convert.ToInt32(cboSubtitulos.SelectedValue);
                peli.Director = Convert.ToInt32(cboDirector.SelectedValue);
                peli.Pais = Convert.ToInt32(cboPaisP.SelectedValue);




                string agregar = "Insert into Pelicula (    " +
                                                                "id_pelicula," +
                                                               "nombre," +
                                                               "duracion," +
                                                               "id_genero," +
                                                               "id_idioma," +
                                                               "id_clasificacion," +
                                                               "id_subtitulos," +
                                                               "id_director," +
                                                               "id_pais)" +
                                                " values ( " +
                                                                  txtIdPeli.Text + "," +
                                                          " ' " + txtNombrePelicula.Text +
                                                          "','" + dtpDura.Text + "',"
                                                            + cboGenero.SelectedValue + ","
                                                            + cboIdioma.SelectedValue + ","
                                                            + cboClasificacion.SelectedValue + ","
                                                            + cboSubtitulos.SelectedValue + ","
                                                            + cboDirector.SelectedValue + ","
                                                            + cboPaisP.SelectedValue + ")";

                datos.actualizarBD(agregar);




                MessageBox.Show("LA PELICULA SE GUARDO CORRECTAMENTE");

            }
            catch (Exception x)
            {

                MessageBox.Show("ERROR al guardar la pelicula!!  \n " + x.Message);
            }

            datos.putInGrid(dgvPelis, "Select * from Pelicula");
            limpiarTxtPelis();
            bloqueoPelis(false);
        }

        //----------DE DATA GRID A TXT BOX--------------------
        private void dgvPelis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow fila = this.dgvPelis.Rows[e.RowIndex];
                txtIdPeli.Text = fila.Cells["id_Pelicula"].Value.ToString();
                //SET INT CON ID DE PELICULA---------------------------------------------------- 
                idPeli = Convert.ToInt32(fila.Cells["id_Pelicula"].Value.ToString());
                //----------------------------------------------------
                txtNombrePelicula.Text = fila.Cells["nombre"].Value.ToString();
                dtpDura.Text = fila.Cells["duracion"].Value.ToString();
                cboGenero.SelectedIndex = Convert.ToInt32(fila.Cells["id_genero"].Value.ToString()) - 1;
                cboIdioma.SelectedIndex = Convert.ToInt32(fila.Cells["id_idioma"].Value.ToString()) - 1;
                cboClasificacion.SelectedIndex = Convert.ToInt32(fila.Cells["id_clasificacion"].Value.ToString()) - 1;
                cboSubtitulos.SelectedIndex = Convert.ToInt32(fila.Cells["id_subtitulos"].Value.ToString()) - 1;
                cboDirector.SelectedIndex = Convert.ToInt32(fila.Cells["id_director"].Value.ToString()) - 1;
                cboPaisP.SelectedIndex = Convert.ToInt32(fila.Cells["id_pais"].Value.ToString()) - 1;
            }
            catch (Exception x)
            {
                MessageBox.Show("ALGO PASO AL CLIKEAR PELICULA" + x.Message);


            }
        }
        //------------BOTON PREVIO A LA MODIFICACION------------------
        private void btnModificarPeli_Click(object sender, EventArgs e)
        {


            if (idPeli > 0)
            {
               
                btnBorrarPeli.Enabled = false;
                btnAceptarMod.Visible = true;
                btnGuardarPeli.Enabled = false;
                btnNuevoPeli.Enabled = false;
                dgvPelis.Enabled = false;
                btnModificarPeli.Enabled = false;
                bloqueoPelis(true);
            }
            else
            {
                MessageBox.Show("NINGUNA PELICULA ASIGNADA AL CAMBIO");
            }

        }
        //------------CANCELAR(CAMPOS RESTABLECIDOS)------------------
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnBorrarPeli.Enabled = true;
            btnNuevoPeli.Enabled = true;
            btnModificarPeli.Enabled = true;
            btnGuardarPeli.Enabled = true;
            limpiarTxtPelis();
            bloqueoPelis(false);
            dgvPelis.Enabled = true;
            btnAceptarMod.Visible = false;
        }
        //------------ELIMINAR PELICULA------------------
        private void btnBorrarPeli_Click(object sender, EventArgs e)
        {
            string eliminarP = "Delete pelicula where id_pelicula =" + idPeli;

            datos.actualizarBD(eliminarP);
            datos.putInGrid(dgvPelis, "Select * from Pelicula");
        }

        //-------------ACEPTAR LA MODIFICACION(BOTON FANTASMA :O)-----------------
        private void btnAceptarMod_Click(object sender, EventArgs e)
        {
            
            try
            {
                String modificar = "UPDATE Pelicula SET " +
                                                        "nombre ='" + txtNombrePelicula.Text + "'," +
                                                        "duracion='" + dtpDura.Text + "'," +
                                                        "id_genero=" + cboGenero.SelectedValue + "," +
                                                        "id_idioma=" + cboIdioma.SelectedValue + "," +
                                                        "id_clasificacion=" + cboClasificacion.SelectedValue + "," +
                                                        "id_subtitulos=" + cboSubtitulos.SelectedValue + "," +
                                                        "id_director=" + cboDirector.SelectedValue + "," +
                                                        "id_pais=" + cboPaisP.SelectedValue + "  " +
                                                        "WHERE id_pelicula =" + idPeli;
                MessageBox.Show(modificar);


                datos.actualizarBD(modificar);

                MessageBox.Show("La pelicula con el id [" + idPeli + "] HA SIDO ACTUALIZADA CORRECTAMENTE");
                btnAceptarMod.Visible = false;
                bloqueoPelis(false);
                btnNuevoPeli.Enabled = true;
                btnModificarPeli.Enabled = true;
                btnGuardarPeli.Enabled = true;
                btnBorrarPeli.Enabled = true;
                dgvPelis.Enabled = true;


            }
            catch (Exception x)
            {
                MessageBox.Show("La PELICULA NO SE PUDO ACTUALIZAR" + x.Message);

            }
            datos.putInGrid(dgvPelis, "Select * from Pelicula");
        }
        //------------------------------
      

      

        //------------------------------BOTONES ACTORES-----------------------------------------------------
     
        private void btnNuevoAct_Click(object sender, EventArgs e)
        {
            limpiarTxtActores();
            bloqueoActores(true);
        }

       

        private void btnGuardarAct_Click(object sender, EventArgs e)
        {
            try
            {
                Actores ac = new Actores();
                ac.Id = Convert.ToInt32(txtIdActor.Text);
                ac.Nombre = Convert.ToString(txtNombreActor);
                ac.Apellido = Convert.ToString(txtApellidoActor);
                ac.Pais = Convert.ToInt32(cboPaisA.SelectedValue);
                ac.FechaN = Convert.ToDateTime(dtpEdad.Value.Date);
                ac.Reseña = Convert.ToString(txtReseña.Text);

                string agregar = "INSERT INTO ACTORES("
                                         
                                 + "id_actor,nombre,nacionalidad,fecha_nacimiento,reseña,apellido)"
                                 + "values( " 
                                              +txtIdActor.Text+","+
                                             "'" + txtNombreActor.Text + "',"
                                             + cboPaisA.SelectedValue + ",'"
                                             + dtpEdad.Text + "','"
                                             + txtReseña.Text + "','"
                                             + txtApellidoActor.Text + "')";
                MessageBox.Show(agregar);

                datos.actualizarBD(agregar);


            }
            catch (Exception x)
            {

                MessageBox.Show("Error al cargar actor" + x.Message);
            }

            datos.putInGrid(dgvActores, "Select * from Actores");
        }

   

        //NOTA CAMBIAR LA BASE DE DATOS NACIONALIDADES DE STRING A INT O NO ANDA EL GRID 
        private void dgvActores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow fila = this.dgvActores.Rows[e.RowIndex];
            txtIdActor.Text = fila.Cells["id_actor"].Value.ToString();
            txtNombreActor.Text= fila.Cells["nombre"].Value.ToString();
            txtApellidoActor.Text= fila.Cells["apellido"].Value.ToString();
            cboPaisA.SelectedIndex = Convert.ToInt32(fila.Cells["nacionalidad"].Value.ToString());
            txtReseña.Text= fila.Cells["reseña"].Value.ToString();
            dtpEdad.Text= fila.Cells["fecha_nacimiento"].Value.ToString();


        }

        private void btnModAct_Click(object sender, EventArgs e)
        {
            String modificarAct = "UPDATE actores SET" +
                                                    "nombre='" + txtNombreActor.Text + "'," +
                                                    "apellido='" + txtApellidoActor.Text + "'," +
                                                    "nacionalidad=" + cboPaisA.SelectedValue + "," +
                                                    "reseña= '" + txtReseña.Text + "'," +
                                                    "fecha_nacimiento='" + dtpEdad.Text + "'" +
                                                    "WHERE id_actor=" + idActor;
        }

        private void btnModificarAct_Click(object sender, EventArgs e)
        {

            if (idPeli > 0)
            {

                btnBorrarAct.Enabled = false;
                btnModAct.Visible = true;
                dgvActores.Enabled = false;
              
                bloqueoActores(true);
            }
            else
            {
                MessageBox.Show("NINGUNA PELICULA ASIGNADA AL CAMBIO");
            }

        }

        //String modificar = "UPDATE Pelicula SET " +
        //                                                "nombre ='" + txtNombrePelicula.Text + "'," +
        //                                                "duracion='" + dtpDura.Text + "'," +
        //                                                "id_genero=" + cboGenero.SelectedValue + "," +
        //                                                "id_idioma=" + cboIdioma.SelectedValue + "," +
        //                                                "id_clasificacion=" + cboClasificacion.SelectedValue + "," +
        //                                                "id_subtitulos=" + cboSubtitulos.SelectedValue + "," +
        //                                                "id_director=" + cboDirector.SelectedValue + "," +
        //                                                "id_pais=" + cboPaisP.SelectedValue + "  " +
        //                                                "WHERE id_pelicula =" + idPeli;




    }
}